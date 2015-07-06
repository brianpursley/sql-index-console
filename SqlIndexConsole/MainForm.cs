using ClosedXML.Excel;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.Data.ConnectionUI;
using SqlIndexConsole.Data;
using SqlIndexConsole.Data.Actions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SqlIndexConsole
{
    public partial class MainForm : Form
    {
        private enum State
        {
            Idle,
            Checking
        }

        private State state = State.Idle;
        private IndexDataProvider indexDataProvider;
        private IList<IndexViewModel> viewModels;
        private IList<IndexViewModel> boundViewModels;

        public MainForm()
        {
            InitializeComponent();            
        }

        #region MainForm Event Handlers

        private void MainForm_Load(object sender, EventArgs e)
        {
            EnableDisable();
            UpdateCaption();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                UpdateCaption();
                IndexDataGridView.AutoGenerateColumns = false;
                SelectFilter(allIndexesToolStripMenuItem);

                state = State.Idle;
                EnableDisable();
                UpdateCaption();
            }
            finally
            {
                Cursor = Cursors.Default;
            }

            SelectDatabase();
            EnableDisable();
        }

        #endregion

        #region Database Selection

        private void SelectDatabase()
        {
            var sqlDataSource = new DataSource("MicrosoftSqlServer", "Microsoft SQL Server");
            sqlDataSource.Providers.Add(DataProvider.SqlDataProvider);
            using (var dlg = new DataConnectionDialog())
            {
                dlg.DataSources.Add(sqlDataSource);
                dlg.SelectedDataProvider = DataProvider.SqlDataProvider;
                dlg.SelectedDataSource = sqlDataSource;
                
                try
                {
                    if (!string.IsNullOrWhiteSpace(Program.Settings.LastConnectionString))
                    {
                        dlg.ConnectionString = Program.Settings.LastConnectionString;
                    }
                }
                catch
                {
                }

                dlg.FormClosing += DataConnectionDialog_FormClosing;

                if (DataConnectionDialog.Show(dlg, this) == System.Windows.Forms.DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;
                    try
                    {
                        SaveLastConnectionString(dlg.ConnectionString);
                        UpdateCaption();
                        SelectFilter(allIndexesToolStripMenuItem);
                        CheckIndexes();
                    }
                    finally
                    {
                        Cursor = Cursors.Default;
                    }
                }
            }
        }

        private void DataConnectionDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dlg = sender as DataConnectionDialog;
            if (dlg.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    indexDataProvider = new IndexDataProvider(dlg.ConnectionString);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Connect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
        }

        private void Disconnect()
        {
            indexDataProvider = null;
            viewModels = null;
            boundViewModels = null;
            IndexDataGridView.DataSource = null;
            UpdateCaption();
        }

        private void SaveLastConnectionString(string connectionString)
        {
            Program.Settings.LastConnectionString = connectionString;
            Program.Settings.Save();
        }

        #endregion

        #region Data Source Initialization Functions

        private void CheckIndexes()
        {
            if (indexDataProvider == null)
            {
                return;
            }

            if (state != State.Idle)
            {
                return;
            }

            try
            {
                state = State.Checking;

                SetStatus("Loading Indexes");
                viewModels = indexDataProvider.GetIndexes().Select(x => new IndexViewModel(x)).ToList();
                ApplyFilter();
                AutoResizeColumns();
                SetStatus("Checking Fragmentation");

                UpdateCaption();
                EnableDisable();
                QueryFragmentationBackgroupWorker.RunWorkerAsync();
            }
            catch
            {
                state = State.Idle;
                throw;
            }
        }

        private void SetMaxAutoWidth(DataGridViewColumn column, int maxAutoWidth)
        {
            if (column.Width > maxAutoWidth)
            {
                column.Width = maxAutoWidth;
            }
        }

        private void ApplyFilter()
        {
            IList<IndexViewModel> filteredViewModels;
            if (indexesSelectedToReorganizeToolStripMenuItem.Checked)
            {
                filteredViewModels = viewModels.Where(x => x.Reorganize).ToList();
            }
            else if (indexesSelectedToRebuildToolStripMenuItem.Checked)
            {
                filteredViewModels = viewModels.Where(x => x.Rebuild).ToList();
            }
            else if (indexesSelectedToReorganizeRebuildToolStripMenuItem.Checked)
            {
                filteredViewModels = viewModels.Where(x => x.Rebuild || x.Reorganize).ToList();
            }
            else if (indexesWithRecommendationsToolStripMenuItem.Checked)
            {
                filteredViewModels = viewModels.Where(x => x.HasRecommendation).ToList();                
            }
            else if (indexesWithAnyFragmentationToolStripMenuItem.Checked)
            {
                filteredViewModels = viewModels.Where(x => x.AvgFragmentationPercent.GetValueOrDefault() > 0).ToList();
            }
            else if (nonclusteredIndexesToolStripMenuItem.Checked)
            {
                filteredViewModels = viewModels.Where(x => x.IndexTypeDescription == "Nonclustered").ToList();
            }
            else if (clusteredIndexesToolStripMenuItem.Checked)
            {
                filteredViewModels = viewModels.Where(x => x.IndexTypeDescription == "Clustered").ToList();
            }
            else if (heapsToolStripMenuItem.Checked)
            {
                filteredViewModels = viewModels.Where(x => x.IndexTypeDescription == "Heap").ToList();                
            }
            else
            {
                filteredViewModels = viewModels;
            }
            SetIndexDataGridViewDataSource(filteredViewModels);
        }

        private void SetIndexDataGridViewDataSource(IList<IndexViewModel> dataSource)
        {
            boundViewModels = dataSource;
            IndexDataGridView.DataSource = (boundViewModels == null) ? null : new SortableBindingList<IndexViewModel>(boundViewModels);
            UpdateObjectCount();
            UpdateIndexCount();
            UpdateRebuildCount();
            UpdateReorganizeCount();
        }

        private void AutoResizeColumns()
        {
            IndexDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);
            ReorganizeColumn.Width = 70;
            RebuildColumn.Width = 50;
            using (var g = IndexDataGridView.CreateGraphics())
            {
                AutoSizeColumn(g, SchemaNameColumn, viewModels.Select(x => x.SchemaName), 50, 170);
                AutoSizeColumn(g, ObjectNameColumn, viewModels.Select(x => x.ObjectName), 50, 170);
                AutoSizeColumn(g, IndexNameColumn, viewModels.Select(x => x.IndexName), 50, 170);
                AutoSizeColumn(g, IndexTypeDescriptionColumn, viewModels.Select(x => x.IndexTypeDescription), 50, 100);
                AutoSizeColumn(g, IndexSizeColumn, viewModels.Select(x => x.SizeDescription), 60, 200);
                AutoSizeColumn(g, IndexPagesColumn, viewModels.Select(x => x.PageCount.ToString()), 50, 100);
                AutoSizeColumn(g, AvgFragmentationPercentColumn, viewModels.Select(x => x.AvgFragmentationPercent.ToString()), 50, 100);
                AutoSizeColumn(g, RecommendationDescriptionColumn, viewModels.Select(x => x.RecommendationDescription), 100, 200);
                AutoSizeColumn(g, ReasonColumn, viewModels.Select(x => x.RecommendationReason), 250, 250);
                AutoSizeColumn(g, ColumnsDescriptionColumn, viewModels.Select(x => x.ColumnsDescription), 50, 200);
                AutoSizeColumn(g, IncludeColumnsDescriptionColumn, viewModels.Select(x => x.IncludeColumnsDescription), 50, 200);
                AutoSizeColumn(g, FilterDefinitionColumn, viewModels.Select(x => x.FilterDefinition), 50, 200);
                AutoSizeColumn(g, FillFactorColumn, viewModels.Select(x => x.FillFactor.ToString()), 50, 200);
                AutoSizeColumn(g, DataSpaceNameColumn, viewModels.Select(x => x.DataSpaceName), 50, 200);
            }
        }

        private void AutoSizeColumn(Graphics g, DataGridViewColumn c, IEnumerable<string> values, int minWidth, int maxWidth)
        {
            var headerFont = c.HeaderCell.Style.Font ?? IndexDataGridView.Font;
            var measuredHeaderWidth = g.MeasureString(c.HeaderText, headerFont).Width + 25;
            var cellFont = c.DefaultCellStyle.Font ?? IndexDataGridView.Font;
            var measuredValueWidth = values.Any() && values.Where(x => x != null).Any() ? 
                values.Where(x => x != null).Select(x => g.MeasureString(x, cellFont)).Select(x => x.Width).Max() : 0;
            var measuredWidth = Math.Max(measuredHeaderWidth, measuredValueWidth);
            c.Width = Math.Max(Math.Min((int)measuredWidth, maxWidth), minWidth);
        }

        #endregion

        #region Status Bar

        private void UpdateIndexCount()
        {
            if (viewModels == null)
            {
                IndexCountToolStripStatusLabel.Text = string.Empty;
                return;
            }
            var c = boundViewModels.Count;
            IndexCountToolStripStatusLabel.Text = string.Concat(
                c, 
                c == 1 ? " index" : " indexes", 
                boundViewModels == viewModels ? string.Empty : string.Format(" (FILTERED OUT OF {0})", viewModels.Count));
        }

        private void UpdateObjectCount()
        {
            if (viewModels == null)
            {
                ObjectCountToolStripStatusLabel.Text = string.Empty;
                return;
            }
            var c = boundViewModels.Select(x => x.Index.ObjectId).Distinct().Count();
            ObjectCountToolStripStatusLabel.Text = string.Concat(
                c, 
                c == 1 ? " object" : " objects",
                boundViewModels == viewModels ? string.Empty : string.Format(" (FILTERED OUT OF {0})", viewModels.Select(x => x.Index.ObjectId).Distinct().Count()));
        }

        private void UpdateReorganizeCount()
        {
            if (boundViewModels == null)
            {
                return;
            }
            var c = boundViewModels.Count(x => x.Reorganize);
            ReorganizeCountLabel.Text = c == 1 ? "1 index selected to reorganize" : string.Concat(c, " indexes selected to reorganize");
            ReorganizeCountLabel.ForeColor = c == 0 ? Color.DarkGray : Color.Green;
        }

        private void UpdateRebuildCount()
        {
            if (boundViewModels == null)
            {
                return;
            }
            var c = boundViewModels.Count(x => x.Rebuild);
            RebuildCountLabel.Text = c == 1 ? "1 index selected to rebuild" : string.Concat(c, " indexes selected to rebuild");
            RebuildCountLabel.ForeColor = c == 0 ? Color.DarkGray : Color.Green;
        }

        private void SetStatus(string text)
        {
            StatusToolStripStatusLabel.Text = text;
        }

        private void ResetStatus()
        {
            StatusToolStripStatusLabel.Text = string.Empty;
        }

        #endregion

        #region Background Worker

        private void QueryFragmentationBackgroupWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                for (int i = 0; i < viewModels.Count; i++)
                {
                    try
                    {
                        var ivm = viewModels[i];
                        try
                        {
                            indexDataProvider.LoadIndexPhysicalStats(ivm.Index);
                            ivm.Index.SetRecommendation(
                                Program.Settings.ReorganizeIndexFragmentationThreshold,
                                Program.Settings.ReorganizeIndexMinimumSize,
                                Program.Settings.RebuildIndexFragmentationThreshold,
                                Program.Settings.RebuildIndexMinimumSize);
                            ivm.UseRecommendation();
                        }
                        catch (Exception ex)
                        {
                            if (ex.Message.StartsWith("The user does not have permission to perform this action."))
                            {
                                ivm.Index.SetError("You do not have permission to load physical stats for this index");
                            }
                            else
                            {
                                ivm.Index.SetError("Physical stats could not be loaded for this index");
                            }
                            Trace.TraceError(ex.Message);
                        }
                        finally
                        {
                            var percentComplete = (i + 1) * 100 / viewModels.Count;
                            QueryFragmentationBackgroupWorker.ReportProgress(percentComplete, i);
                        }
                    }
                    catch (Exception ex)
                    {
                        Trace.TraceError(ex.Message);
                    }
                }
            }
            finally
            {
                state = State.Idle;
            }
        }

        private void QueryFragmentationBackgroupWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {            
            var i = (int)e.UserState;
            var index = viewModels[i];
            DataGridViewRow row = FindDataGridViewRowForIndex(index);
            if (row != null)
            {
                IndexDataGridView.InvalidateRow(row.Index);
            }
        }

        private void QueryFragmentationBackgroupWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ApplyFilter();
            SelectAllRecommendations();
            ResetStatus();
            UpdateCaption();
            EnableDisable();
        }

        #endregion

        #region IndexDataGridView Event Handlers

        private void IndexDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == ReorganizeColumn.Index)
            {
                var ivm = IndexDataGridView.Rows[e.RowIndex].DataBoundItem as IndexViewModel;
                if (ivm.CanReorganize())
                {
                    ivm.Reorganize = !ivm.Reorganize;
                    IndexDataGridView.InvalidateRow(e.RowIndex);
                    UpdateReorganizeCount();
                }
            }
            else if (e.ColumnIndex == RebuildColumn.Index)
            {
                var ivm = IndexDataGridView.Rows[e.RowIndex].DataBoundItem as IndexViewModel;
                if (ivm.CanRebuild())
                {
                    ivm.Rebuild = !ivm.Rebuild;
                    IndexDataGridView.InvalidateRow(e.RowIndex);
                    UpdateRebuildCount();
                }
            }
            
            EnableDisable();
        }

        private void IndexDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Trace.TraceError(e.Exception.Message);
            e.Cancel = true;
        }

        private void IndexDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == IndexSizeColumn.Index)
            {
                var ivm = IndexDataGridView.Rows[e.RowIndex].DataBoundItem as IndexViewModel;
                e.Value = ivm.SizeDescription;
                e.FormattingApplied = true;
            }
        }

        private void IndexDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == ReorganizeColumn.Index)
            {
                var ivm = IndexDataGridView.Rows[e.RowIndex].DataBoundItem as IndexViewModel;
                if (ivm.RecommendationReady)
                {
                    if (!ivm.CanReorganize())
                    {
                        e.PaintBackground(e.ClipBounds, true);
                        e.Handled = true;
                    }
                }
                else
                {
                    e.PaintBackground(e.ClipBounds, true);
                    var s = e.Graphics.MeasureString("...", IndexDataGridView.Font);
                    e.Graphics.DrawString(
                        "...", 
                        IndexDataGridView.Font, 
                        Brushes.Gray, 
                        e.CellBounds.X + (e.CellBounds.Width / 2) - (s.Width / 2), 
                        e.CellBounds.Y);
                    e.Handled = true;
                }
            }
            else if (e.ColumnIndex == RebuildColumn.Index)
            {
                var ivm = IndexDataGridView.Rows[e.RowIndex].DataBoundItem as IndexViewModel;
                if (ivm.RecommendationReady)
                {
                    if (!ivm.CanRebuild())
                    {
                        e.PaintBackground(e.ClipBounds, true);
                        e.Handled = true;
                    }
                }
                else
                {
                    e.PaintBackground(e.ClipBounds, true);
                    var s = e.Graphics.MeasureString("...", IndexDataGridView.Font);
                    e.Graphics.DrawString(
                        "...", 
                        IndexDataGridView.Font, 
                        Brushes.Gray,
                        e.CellBounds.X + (e.CellBounds.Width / 2) - (s.Width / 2),
                        e.CellBounds.Y);
                    e.Handled = true;
                }
            }
            else if (e.ColumnIndex == RecommendationDescriptionColumn.Index)
            {
                var ivm = IndexDataGridView.Rows[e.RowIndex].DataBoundItem as IndexViewModel;
                if (!ivm.RecommendationReady)
                {
                    e.PaintBackground(e.ClipBounds, true);
                    e.Graphics.DrawString("Checking...", IndexDataGridView.Font, Brushes.Gray, e.CellBounds);
                    e.Handled = true;
                }
            }
            else if (e.ColumnIndex == AvgFragmentationPercentColumn.Index)
            {
                var row = IndexDataGridView.Rows[e.RowIndex];
                var ivm = row.DataBoundItem as IndexViewModel;
                if (ivm.AvgFragmentationPercent.GetValueOrDefault() == 0)
                {
                    return;
                }
                Color c1;
                Color c2;
                switch (ivm.Index.Recommendation)
                {
                    case RecommendationEnum.Reorganize:
                        c1 = row.Selected ? Color.FromArgb(180, 180, 150) : Color.FromArgb(255, 255, 180);
                        c2 = row.Selected ? Color.FromArgb(180, 180, 50) : Color.FromArgb(255, 255, 0);
                        break;
                    case RecommendationEnum.Rebuild:
                        c1 = row.Selected ? Color.FromArgb(180, 120, 120) : Color.FromArgb(255, 230, 230);
                        c2 = row.Selected ? Color.FromArgb(180, 30, 30) : Color.FromArgb(255, 50, 50);
                        break;
                    default:
                        c1 = row.Selected ? Color.FromArgb(150, 150, 150) : Color.FromArgb(255, 255, 255);
                        c2 = row.Selected ? Color.FromArgb(50, 50, 50) : Color.FromArgb(200, 200, 200);
                        break;
                }
                e.PaintBackground(e.ClipBounds, true);
                using (var b = new LinearGradientBrush(e.CellBounds, c2, c1, 0f))
                {
                    int w = (int)((e.CellBounds.Width - 1) * ivm.AvgFragmentationPercent.Value / 100);
                    Rectangle r = new Rectangle(e.CellBounds.Right - w, e.CellBounds.Top + 1, w - 1, e.CellBounds.Height - 3);
                    e.Graphics.FillRectangle(b, r);
                    using (var p = new Pen(c2))
                    {
                        e.Graphics.DrawRectangle(p, r);
                    }
                }
                e.PaintContent(e.ClipBounds);
                e.Handled = true;
            }
        }

        #endregion

        #region Toolbar Event Handlers

        private void FilterToolStripDropDownButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            SelectFilter((ToolStripMenuItem)e.ClickedItem);
            ApplyFilter();
            EnableDisable();
        }

        private void SelectDataSourceToolStripButton_Click(object sender, EventArgs e)
        {
            SelectDatabase();
            EnableDisable();
        }

        private void ExportToExcelToolbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportGridToExcel();
        }

        private void ExportToCsvToolbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportGridToCsv();
        }

        private void exportToTxtToolbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportGridToTxt();
        }

        #endregion

        #region Menu Event Handlers

        private void fixIndexesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FixIndexes();
            EnableDisable();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void selectDataSourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectDatabase();
            EnableDisable();
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Disconnect();
            EnableDisable();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckIndexes();
            EnableDisable();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dlg = new AboutBox())
            {
                dlg.ShowDialog(this);
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOptionsDialog();
            EnableDisable();
        }

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportGridToExcel();
        }

        private void exportToCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportGridToCsv();
        }

        private void exportToTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportGridToTxt();
        }

        private void unselectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnselectAll();
            ApplyFilter();
            EnableDisable();
        }

        private void resetToRecommendationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAllRecommendations();
            ApplyFilter();
            EnableDisable();
        }

        #endregion

        #region Context Menu Event Handlers

        private void selectReorganizeContextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRowIndexes = GetSelectedRowIndexes().ToList();
            SelectReorganize(GetSelectedRowIndexViewModels());
            ApplyFilter();
            EnableDisable();
            SelectRows(selectedRowIndexes);
        }

        private void selectRebuildContextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRowIndexes = GetSelectedRowIndexes().ToList();
            SelectRebuild(GetSelectedRowIndexViewModels());
            ApplyFilter();
            EnableDisable();
            SelectRows(selectedRowIndexes);
        }

        private void unselectContextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRowIndexes = GetSelectedRowIndexes().ToList();
            Unselect(GetSelectedRowIndexViewModels());
            ApplyFilter();
            EnableDisable();
            SelectRows(selectedRowIndexes);
        }

        #endregion

        #region Export

        private void ExportGridToExcel()
        {
            ExcelSaveFileDialog.FileName = string.Format(
                "{0}.{1}-{2:yyyyMMdd}-{2:HHmmss}.xlsx",
                indexDataProvider.GetServerName(),
                indexDataProvider.GetDatabaseName(),
                DateTime.Now);

            if (ExcelSaveFileDialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            Cursor = Cursors.WaitCursor;
            try
            {
                if (File.Exists(ExcelSaveFileDialog.FileName))
                {
                    File.Delete(ExcelSaveFileDialog.FileName);
                }

                using (var wb = new XLWorkbook())
                using (var ws = wb.Worksheets.Add("SqlIndexConsole"))
                {
                    ws.Cells("A1").Value = "Reorganize";
                    ws.Cells("B1").Value = "Rebuild";
                    ws.Cells("C1").Value = "Schema";
                    ws.Cells("D1").Value = "Object";
                    ws.Cells("E1").Value = "Index";
                    ws.Cells("F1").Value = "Type";
                    ws.Cells("G1").Value = "Size";
                    ws.Cells("H1").Value = "Pages";
                    ws.Cells("I1").Value = "Frag %";
                    ws.Cells("J1").Value = "Recommendation";
                    ws.Cells("K1").Value = "Reason";
                    ws.Cells("L1").Value = "Columns";
                    ws.Cells("M1").Value = "Include";
                    ws.Cells("N1").Value = "Filter";
                    ws.Cells("O1").Value = "Fill Factor";
                    ws.Cells("P1").Value = "Unique";
                    ws.Cells("Q1").Value = "PK";
                    ws.Cells("R1").Value = "Unique Constraint";
                    ws.Cells("S1").Value = "Data Space";

                    int i = 2;
                    foreach (DataGridViewRow row in IndexDataGridView.Rows)
                    {
                        var ivm = row.DataBoundItem as IndexViewModel;
                        ws.Cell(string.Concat("A", i)).Value = ivm.Reorganize ? "Y" : string.Empty;
                        ws.Cell(string.Concat("B", i)).Value = ivm.Rebuild ? "Y" : string.Empty;
                        ws.Cell(string.Concat("C", i)).Value = ivm.SchemaName;
                        ws.Cell(string.Concat("D", i)).Value = ivm.ObjectName;
                        ws.Cell(string.Concat("E", i)).Value = ivm.IndexName;
                        ws.Cell(string.Concat("F", i)).Value = ivm.IndexTypeDescription;
                        ws.Cell(string.Concat("G", i)).Value = ivm.SizeDescription;
                        ws.Cell(string.Concat("H", i)).Value = ivm.PageCount;
                        ws.Cell(string.Concat("I", i)).Value = ivm.AvgFragmentationPercent;
                        ws.Cell(string.Concat("J", i)).Value = ivm.RecommendationDescription;
                        ws.Cell(string.Concat("K", i)).Value = ivm.RecommendationReason;
                        ws.Cell(string.Concat("L", i)).Value = ivm.ColumnsDescription;
                        ws.Cell(string.Concat("M", i)).Value = ivm.IncludeColumnsDescription;
                        ws.Cell(string.Concat("N", i)).Value = ivm.FilterDefinition;
                        ws.Cell(string.Concat("O", i)).Value = ivm.FillFactor;
                        ws.Cell(string.Concat("P", i)).Value = ivm.Index.IsUnique ? "Y" : string.Empty;
                        ws.Cell(string.Concat("Q", i)).Value = ivm.Index.IsPrimaryKey ? "Y" : string.Empty;
                        ws.Cell(string.Concat("R", i)).Value = ivm.Index.IsUniqueConstraint ? "Y" : string.Empty;
                        ws.Cell(string.Concat("S", i)).Value = ivm.DataSpaceName;
                        i++;
                    }

                    wb.SaveAs(ExcelSaveFileDialog.FileName);
                }
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void ExportGridToCsv()
        {
            CsvSaveFileDialog.FileName = string.Format(
                "{0}.{1}-{2:yyyyMMdd}-{2:HHmmss}.csv",
                indexDataProvider.GetServerName(),
                indexDataProvider.GetDatabaseName(),
                DateTime.Now);

            if (CsvSaveFileDialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            WriteCsv(CsvSaveFileDialog.FileName);
        }

        private void ExportGridToTxt()
        {
            TxtSaveFileDialog.FileName = string.Format(
                "{0}.{1}-{2:yyyyMMdd}-{2:HHmmss}.txt",
                indexDataProvider.GetServerName(),
                indexDataProvider.GetDatabaseName(),
                DateTime.Now);

            if (TxtSaveFileDialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            WriteCsv(TxtSaveFileDialog.FileName);
        }

        private void WriteCsv(string filename)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (File.Exists(filename))
                {
                    File.Delete(filename);
                }

                var config = new CsvConfiguration()
                {
                    Encoding = Encoding.UTF8,
                    HasHeaderRecord = true
                };

                if (Path.GetExtension(filename) == ".txt")
                {
                    config.Delimiter = "\t";
                }

                using (var csv = new CsvWriter(File.CreateText(filename), config))
                {
                    csv.WriteField("Reorganize");
                    csv.WriteField("Rebuild");
                    csv.WriteField("Schema"); 
                    csv.WriteField("Object");
                    csv.WriteField("Index");
                    csv.WriteField("Type");
                    csv.WriteField("Size");
                    csv.WriteField("Pages");
                    csv.WriteField("Frag %");
                    csv.WriteField("Recommendation");
                    csv.WriteField("Reason");
                    csv.WriteField("Columns");
                    csv.WriteField("Include");
                    csv.WriteField("Filter");
                    csv.WriteField("Fill Factor");
                    csv.WriteField("Unique");
                    csv.WriteField("PK");
                    csv.WriteField("Unique Constraint");
                    csv.WriteField("Data Space");
                    csv.NextRecord();

                    foreach (DataGridViewRow row in IndexDataGridView.Rows)
                    {
                        var ivm = row.DataBoundItem as IndexViewModel;
                        csv.WriteField(ivm.Reorganize ? "Y" : string.Empty);
                        csv.WriteField(ivm.Rebuild ? "Y" : string.Empty);
                        csv.WriteField(ivm.SchemaName);
                        csv.WriteField(ivm.ObjectName);
                        csv.WriteField(ivm.IndexName);
                        csv.WriteField(ivm.IndexTypeDescription);
                        csv.WriteField(ivm.SizeDescription);
                        csv.WriteField(ivm.PageCount.HasValue ? ivm.PageCount.Value.ToString() : string.Empty);
                        csv.WriteField(ivm.AvgFragmentationPercent.HasValue ? ivm.AvgFragmentationPercent.Value.ToString() : string.Empty);
                        csv.WriteField(ivm.RecommendationDescription);
                        csv.WriteField(ivm.RecommendationReason);
                        csv.WriteField(ivm.ColumnsDescription);
                        csv.WriteField(ivm.IncludeColumnsDescription);
                        csv.WriteField(ivm.FilterDefinition);
                        csv.WriteField(ivm.FillFactor);
                        csv.WriteField(ivm.Index.IsUnique ? "Y" : string.Empty);
                        csv.WriteField(ivm.Index.IsPrimaryKey ? "Y" : string.Empty);
                        csv.WriteField(ivm.Index.IsUniqueConstraint ? "Y" : string.Empty);
                        csv.WriteField(ivm.DataSpaceName);
                        csv.NextRecord();
                    }
                }
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        #endregion

        #region Rebuild/Reorganize Selection

        private void SelectReorganize(IEnumerable<IndexViewModel> ivms)
        {
            foreach (var ivm in ivms)
            {
                if (ivm.CanReorganize())
                {
                    ivm.Reorganize = true;
                }
            }
        }

        private void SelectRebuild(IEnumerable<IndexViewModel> ivms)
        {
            foreach (var ivm in ivms)
            {
                if (ivm.CanRebuild())
                {
                    ivm.Rebuild = true;
                }
            }
        }

        private void Unselect(IEnumerable<IndexViewModel> ivms)
        {
            foreach (var ivm in ivms)
            {
                ivm.Reorganize = false;
                ivm.Rebuild = false;
            }
        }

        private void SelectAllRecommendations()
        {
            foreach (var ivm in viewModels)
            {
                ivm.UseRecommendation();
            }
        }

        private void UnselectAll()
        {
            Unselect(viewModels);
        }
        
        #endregion

        #region Fix Indexes

        private void FixIndexesButton_Click(object sender, EventArgs e)
        {
            FixIndexes();
            EnableDisable();
        }

        private void FixIndexes()
        {
            using (var dlg = new FixIndexesDialog())
            {
                dlg.Actions = GetActions();
                if (dlg.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }
            }
            using (var dlg = new FixProgressDialog())
            {
                dlg.Actions = GetActions();
                dlg.IndexDataProvider = indexDataProvider;
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    CheckIndexes();
                    SelectFilter(allIndexesToolStripMenuItem);
                }
            }
        }

        private IEnumerable<SqlAction> GetActions()
        {
            var isEnterpriseEdition = indexDataProvider.IsEnterpriseEdition();

            var indexesToReorganize = viewModels.Where(x => x.Reorganize).Select(x => x.Index);
            var indexesToRebuild = viewModels.Where(x => x.Rebuild).Select(x => x.Index);

            // Heaps To Rebuild
            var heapsToRebuild = indexesToRebuild.Where(x => x.IsHeap);
            var rebuiltHeapTables = heapsToRebuild.Select(x => x.SchemaObjectName);
            foreach (var index in heapsToRebuild)
            {
                yield return new RebuildHeapSqlAction() 
                { 
                    DatabaseName = index.DatabaseName,
                    SchemaName = index.SchemaName, 
                    TableName = index.ObjectName,
                    CommandTimeout = Program.Settings.RebuildIndexCommandTimeout,
                    SortInTempDb = Program.Settings.RebuildIndexSortInTempDb,
                    Online = isEnterpriseEdition ? (bool?)Program.Settings.RebuildIndexOnline : null,
                    MaxDop = isEnterpriseEdition ? (int?)Program.Settings.RebuildIndexMaxDop : null
                };
            }

            // Non-Heap Indexes To Rebuild
            var toRebuild = indexesToRebuild
                .Where(x => !x.IsHeap)
                .OrderBy(x => x.IsClustered ? 0 : 1);
            foreach (var index in toRebuild)
            {
                if (rebuiltHeapTables.Contains(index.SchemaObjectName))
                {
                    yield return new SkipRebuildIndexSqlAction()
                    {
                        DatabaseName = index.DatabaseName,
                        SchemaName = index.SchemaName,
                        ObjectName = index.ObjectName,
                        IndexName = index.IndexName
                    };
                }
                else
                {
                    yield return new RebuildIndexSqlAction()
                    {
                        DatabaseName = index.DatabaseName,
                        SchemaName = index.SchemaName,
                        ObjectName = index.ObjectName,
                        IndexName = index.IndexName,
                        CommandTimeout = Program.Settings.RebuildIndexCommandTimeout,
                        SortInTempDb = Program.Settings.RebuildIndexSortInTempDb,
                        Online = isEnterpriseEdition ? (bool?)Program.Settings.RebuildIndexOnline : null,
                        MaxDop = isEnterpriseEdition ? (int?)Program.Settings.RebuildIndexMaxDop : null
                    };
                }
            }

            // Non-Heap Indexes To Reorganize
            var toReorganize = indexesToReorganize
                .OrderBy(x => x.IsClustered ? 0 : 1);
            foreach (var index in toReorganize)
            {
                if (rebuiltHeapTables.Contains(index.SchemaObjectName))
                {
                    yield return new SkipReorganizeIndexSqlAction()
                    {
                        DatabaseName = index.DatabaseName,
                        SchemaName = index.SchemaName,
                        ObjectName = index.ObjectName,
                        IndexName = index.IndexName
                    };
                }
                else
                {
                    yield return new ReorganizeIndexSqlAction()
                    {
                        DatabaseName = index.DatabaseName,
                        SchemaName = index.SchemaName,
                        ObjectName = index.ObjectName,
                        IndexName = index.IndexName,
                        CommandTimeout = Program.Settings.ReorganizeIndexCommandTimeout,
                        LobCompaction = Program.Settings.ReorganizeIndexLobCompaction
                    };
                }
            }
        }

        #endregion

        #region Grid Helper Functions

        private IEnumerable<IndexViewModel> GetSelectedRowIndexViewModels()
        {
            foreach (DataGridViewRow r in IndexDataGridView.SelectedRows)
            {
                yield return r.DataBoundItem as IndexViewModel;
            }
        }

        private DataGridViewRow FindDataGridViewRowForIndex(IndexViewModel ivm)
        {
            foreach (DataGridViewRow row in IndexDataGridView.Rows)
            {
                if ((row.DataBoundItem as IndexViewModel) == ivm)
                {
                    return row;
                }
            }
            return null;
        }

        private IEnumerable<int> GetSelectedRowIndexes()
        {
            foreach (DataGridViewRow row in IndexDataGridView.SelectedRows)
            {
                yield return row.Index;
            }
        }

        private void SelectRows(IEnumerable<int> rowIndexes)
        {
            foreach (var index in rowIndexes)
            {
                IndexDataGridView.Rows[index].Selected = true;
            }
        }

        #endregion

        #region Options

        private void ShowOptionsDialog()
        {
            using (var dlg = new OptionsDialog())
            {
                dlg.ShowDialog(this);
                if (dlg.ReloadRequired)
                {
                    CheckIndexes();
                }
            }
        }

        #endregion

        #region Caption

        private void UpdateCaption()
        {
            if (indexDataProvider == null)
            {
                Text = "SQL Index Console";
            }
            else
            {
                Text = string.Format(
                    "{0}.{1} - SQL Index Console (Connected)", 
                    indexDataProvider.GetServerName(), 
                    indexDataProvider.GetDatabaseName());
            }
        }

        #endregion

        #region EnableDisable

        private void EnableDisable()
        {
            var isDataLoaded = boundViewModels != null;
            var indexCount = viewModels == null ? 0 : viewModels.Count;
            var isAnythingSelected = viewModels != null && viewModels.Any(x => x.Rebuild || x.Reorganize);
            var recommendationCount = viewModels == null ? 0 : viewModels.Where(x => x.HasRecommendation).Count();
            var isAnythingRecommended = recommendationCount > 0;
            var isAnythingDisplayed = boundViewModels != null && boundViewModels.Count > 0;
            var isIdle = state == State.Idle;
            var isChecking = state == State.Checking;

            IndexDataGridView.Visible = isDataLoaded;
            toolStripSeparator1.Visible = isDataLoaded;
            toolStripSeparator2.Visible = isDataLoaded;
            toolStripMenuItem1.Visible = isDataLoaded;
            ExportToolStripDropDownButton.Visible = isDataLoaded;
            ReorganizeCountLabel.Visible = isDataLoaded;
            RebuildCountLabel.Visible = isDataLoaded;
            FixIndexesButton.Visible = isDataLoaded;
            fixIndexesToolStripMenuItem.Visible = isDataLoaded;
            exportToolStripMenuItem.Visible = isDataLoaded;
            editToolStripMenuItem.Visible = isDataLoaded;
            viewToolStripMenuItem.Visible = isDataLoaded;
            FilterToolStripDropDownButton.Visible = isDataLoaded;

            MainStatusStrip.Enabled = isDataLoaded;
            ExportToolStripDropDownButton.Enabled = isAnythingDisplayed && isIdle;
            exportToolStripMenuItem.Enabled = isAnythingDisplayed && isIdle;
            FilterToolStripDropDownButton.Enabled = isDataLoaded && isIdle && indexCount > 0;
            resetToRecommendationsToolStripMenuItem.Enabled = isDataLoaded && isIdle && indexCount > 0;
            unselectAllToolStripMenuItem.Enabled = isDataLoaded && isIdle && indexCount > 0;
            FixIndexesButton.Enabled = isAnythingSelected && isIdle;
            fixIndexesToolStripMenuItem.Enabled = isAnythingSelected && isIdle;

            ShowRecommendationsLink.Visible = isDataLoaded && isIdle && isAnythingRecommended && !indexesWithRecommendationsToolStripMenuItem.Checked;

            WarningPictureBox.Visible = !isChecking && isDataLoaded && isAnythingRecommended;
            FragmentationDetectedLabel.Visible = !isChecking && isDataLoaded && isAnythingRecommended;
            CheckmarkPictureBox.Visible = !isChecking && isDataLoaded && !isAnythingRecommended;
            NoFragmentationDetectedLabel.Visible = !isChecking && isDataLoaded && !isAnythingRecommended;
            CheckingPictureBox.Visible = isChecking;
            CheckingLabel.Visible = isChecking;

            FragmentationDetectedLabel.Text = recommendationCount == 1 ?
                string.Format("Fragmentation detected.{0}There is 1 recommendation.", Environment.NewLine) :
                string.Format("Fragmentation detected.{0}There are {1} recommendations.", Environment.NewLine, recommendationCount);
        }

        #endregion
        
        #region Filter

        private void SelectFilter(ToolStripMenuItem selected)
        {
            foreach (ToolStripMenuItem mi in FilterToolStripDropDownButton.DropDownItems)
            {
                mi.Checked = false;
            }
            selected.Checked = true;
            FilterToolStripDropDownButton.Text = "Filter: " + selected.Text;
        }

        private void ShowRecommendationsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectFilter(indexesWithRecommendationsToolStripMenuItem);
            ApplyFilter();
            EnableDisable();
        }

        #endregion
    }
}

namespace SqlIndexConsole
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.SelectDataSourceToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExportToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.ExportToExcelToolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportToCsvToolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToTxtToolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.FilterToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.allIndexesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexesSelectedToReorganizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexesSelectedToRebuildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexesSelectedToReorganizeRebuildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexesWithRecommendationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexesWithAnyFragmentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nonclusteredIndexesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clusteredIndexesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.ObjectCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.IndexCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.IndexDataGridView = new System.Windows.Forms.DataGridView();
            this.ReorganizeColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RebuildColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SchemaNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObjectNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndexNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndexTypeDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndexSizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndexPagesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgFragmentationPercentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecommendationDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReasonColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnsDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncludeColumnsDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilterDefinitionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FillFactorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsUniqueColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.IsPrimaryKeyColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.IsUniqueConstraintColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.DataSpaceNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndexContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectReorganizeContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectRebuildContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unselectContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QueryFragmentationBackgroupWorker = new System.ComponentModel.BackgroundWorker();
            this.MainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectDataSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.fixIndexesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToCsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToTxtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToRecommendationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unselectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowRecommendationsLink = new System.Windows.Forms.LinkLabel();
            this.RebuildCountLabel = new System.Windows.Forms.Label();
            this.ReorganizeCountLabel = new System.Windows.Forms.Label();
            this.FixIndexesButton = new System.Windows.Forms.Button();
            this.WarningPictureBox = new System.Windows.Forms.PictureBox();
            this.CheckmarkPictureBox = new System.Windows.Forms.PictureBox();
            this.FragmentationDetectedLabel = new System.Windows.Forms.Label();
            this.NoFragmentationDetectedLabel = new System.Windows.Forms.Label();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CheckingLabel = new System.Windows.Forms.Label();
            this.CheckingPictureBox = new System.Windows.Forms.PictureBox();
            this.ExcelSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.CsvSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.TxtSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MainToolStrip.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IndexDataGridView)).BeginInit();
            this.IndexContextMenuStrip.SuspendLayout();
            this.MainFormMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarningPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckmarkPictureBox)).BeginInit();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckingPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectDataSourceToolStripButton,
            this.toolStripSeparator1,
            this.ExportToolStripDropDownButton,
            this.toolStripSeparator2,
            this.FilterToolStripDropDownButton});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(884, 25);
            this.MainToolStrip.TabIndex = 1;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // SelectDataSourceToolStripButton
            // 
            this.SelectDataSourceToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SelectDataSourceToolStripButton.Image")));
            this.SelectDataSourceToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SelectDataSourceToolStripButton.Name = "SelectDataSourceToolStripButton";
            this.SelectDataSourceToolStripButton.Size = new System.Drawing.Size(81, 22);
            this.SelectDataSourceToolStripButton.Text = "Connect...";
            this.SelectDataSourceToolStripButton.ToolTipText = "Connect to a SQL Server Database";
            this.SelectDataSourceToolStripButton.Click += new System.EventHandler(this.SelectDataSourceToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ExportToolStripDropDownButton
            // 
            this.ExportToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportToExcelToolbarToolStripMenuItem,
            this.ExportToCsvToolbarToolStripMenuItem,
            this.exportToTxtToolbarToolStripMenuItem});
            this.ExportToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("ExportToolStripDropDownButton.Image")));
            this.ExportToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportToolStripDropDownButton.Name = "ExportToolStripDropDownButton";
            this.ExportToolStripDropDownButton.Size = new System.Drawing.Size(69, 22);
            this.ExportToolStripDropDownButton.Text = "Export";
            // 
            // ExportToExcelToolbarToolStripMenuItem
            // 
            this.ExportToExcelToolbarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportToExcelToolbarToolStripMenuItem.Name = "ExportToExcelToolbarToolStripMenuItem";
            this.ExportToExcelToolbarToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.ExportToExcelToolbarToolStripMenuItem.Text = "Export to &Excel...";
            this.ExportToExcelToolbarToolStripMenuItem.Click += new System.EventHandler(this.ExportToExcelToolbarToolStripMenuItem_Click);
            // 
            // ExportToCsvToolbarToolStripMenuItem
            // 
            this.ExportToCsvToolbarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportToCsvToolbarToolStripMenuItem.Name = "ExportToCsvToolbarToolStripMenuItem";
            this.ExportToCsvToolbarToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.ExportToCsvToolbarToolStripMenuItem.Text = "Export to &Csv...";
            this.ExportToCsvToolbarToolStripMenuItem.Click += new System.EventHandler(this.ExportToCsvToolbarToolStripMenuItem_Click);
            // 
            // exportToTxtToolbarToolStripMenuItem
            // 
            this.exportToTxtToolbarToolStripMenuItem.Name = "exportToTxtToolbarToolStripMenuItem";
            this.exportToTxtToolbarToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.exportToTxtToolbarToolStripMenuItem.Text = "Export to Txt...";
            this.exportToTxtToolbarToolStripMenuItem.Click += new System.EventHandler(this.exportToTxtToolbarToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // FilterToolStripDropDownButton
            // 
            this.FilterToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allIndexesToolStripMenuItem,
            this.indexesSelectedToReorganizeToolStripMenuItem,
            this.indexesSelectedToRebuildToolStripMenuItem,
            this.indexesSelectedToReorganizeRebuildToolStripMenuItem,
            this.indexesWithRecommendationsToolStripMenuItem,
            this.indexesWithAnyFragmentationToolStripMenuItem,
            this.nonclusteredIndexesToolStripMenuItem,
            this.clusteredIndexesToolStripMenuItem,
            this.heapsToolStripMenuItem});
            this.FilterToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("FilterToolStripDropDownButton.Image")));
            this.FilterToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FilterToolStripDropDownButton.Name = "FilterToolStripDropDownButton";
            this.FilterToolStripDropDownButton.Size = new System.Drawing.Size(62, 22);
            this.FilterToolStripDropDownButton.Text = "Filter";
            this.FilterToolStripDropDownButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.FilterToolStripDropDownButton_DropDownItemClicked);
            // 
            // allIndexesToolStripMenuItem
            // 
            this.allIndexesToolStripMenuItem.Name = "allIndexesToolStripMenuItem";
            this.allIndexesToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.allIndexesToolStripMenuItem.Text = "All Indexes";
            // 
            // indexesSelectedToReorganizeToolStripMenuItem
            // 
            this.indexesSelectedToReorganizeToolStripMenuItem.Name = "indexesSelectedToReorganizeToolStripMenuItem";
            this.indexesSelectedToReorganizeToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.indexesSelectedToReorganizeToolStripMenuItem.Text = "Indexes Selected To Reorganize";
            // 
            // indexesSelectedToRebuildToolStripMenuItem
            // 
            this.indexesSelectedToRebuildToolStripMenuItem.Name = "indexesSelectedToRebuildToolStripMenuItem";
            this.indexesSelectedToRebuildToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.indexesSelectedToRebuildToolStripMenuItem.Text = "Indexes Selected To Rebuild";
            // 
            // indexesSelectedToReorganizeRebuildToolStripMenuItem
            // 
            this.indexesSelectedToReorganizeRebuildToolStripMenuItem.Name = "indexesSelectedToReorganizeRebuildToolStripMenuItem";
            this.indexesSelectedToReorganizeRebuildToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.indexesSelectedToReorganizeRebuildToolStripMenuItem.Text = "Indexes Selected To Reorganize/Rebuild";
            // 
            // indexesWithRecommendationsToolStripMenuItem
            // 
            this.indexesWithRecommendationsToolStripMenuItem.Name = "indexesWithRecommendationsToolStripMenuItem";
            this.indexesWithRecommendationsToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.indexesWithRecommendationsToolStripMenuItem.Text = "Indexes With Recommendations";
            // 
            // indexesWithAnyFragmentationToolStripMenuItem
            // 
            this.indexesWithAnyFragmentationToolStripMenuItem.Name = "indexesWithAnyFragmentationToolStripMenuItem";
            this.indexesWithAnyFragmentationToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.indexesWithAnyFragmentationToolStripMenuItem.Text = "Indexes With Any Fragmentation";
            // 
            // nonclusteredIndexesToolStripMenuItem
            // 
            this.nonclusteredIndexesToolStripMenuItem.Name = "nonclusteredIndexesToolStripMenuItem";
            this.nonclusteredIndexesToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.nonclusteredIndexesToolStripMenuItem.Text = "Nonclustered Indexes";
            // 
            // clusteredIndexesToolStripMenuItem
            // 
            this.clusteredIndexesToolStripMenuItem.Name = "clusteredIndexesToolStripMenuItem";
            this.clusteredIndexesToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.clusteredIndexesToolStripMenuItem.Text = "Clustered Indexes";
            // 
            // heapsToolStripMenuItem
            // 
            this.heapsToolStripMenuItem.Name = "heapsToolStripMenuItem";
            this.heapsToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.heapsToolStripMenuItem.Text = "Heaps";
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ObjectCountToolStripStatusLabel,
            this.IndexCountToolStripStatusLabel,
            this.StatusToolStripStatusLabel});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 538);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(884, 24);
            this.MainStatusStrip.TabIndex = 4;
            this.MainStatusStrip.Text = "statusStrip1";
            // 
            // ObjectCountToolStripStatusLabel
            // 
            this.ObjectCountToolStripStatusLabel.Name = "ObjectCountToolStripStatusLabel";
            this.ObjectCountToolStripStatusLabel.Size = new System.Drawing.Size(56, 19);
            this.ObjectCountToolStripStatusLabel.Text = "0 Objects";
            // 
            // IndexCountToolStripStatusLabel
            // 
            this.IndexCountToolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.IndexCountToolStripStatusLabel.Name = "IndexCountToolStripStatusLabel";
            this.IndexCountToolStripStatusLabel.Size = new System.Drawing.Size(59, 19);
            this.IndexCountToolStripStatusLabel.Text = "0 Indexes";
            // 
            // StatusToolStripStatusLabel
            // 
            this.StatusToolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.StatusToolStripStatusLabel.Name = "StatusToolStripStatusLabel";
            this.StatusToolStripStatusLabel.Size = new System.Drawing.Size(4, 19);
            // 
            // IndexDataGridView
            // 
            this.IndexDataGridView.AllowUserToAddRows = false;
            this.IndexDataGridView.AllowUserToDeleteRows = false;
            this.IndexDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IndexDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.IndexDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.IndexDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IndexDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.IndexDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.IndexDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IndexDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReorganizeColumn,
            this.RebuildColumn,
            this.SchemaNameColumn,
            this.ObjectNameColumn,
            this.IndexNameColumn,
            this.IndexTypeDescriptionColumn,
            this.IndexSizeColumn,
            this.IndexPagesColumn,
            this.AvgFragmentationPercentColumn,
            this.RecommendationDescriptionColumn,
            this.ReasonColumn,
            this.ColumnsDescriptionColumn,
            this.IncludeColumnsDescriptionColumn,
            this.FilterDefinitionColumn,
            this.FillFactorColumn,
            this.IsUniqueColumn,
            this.IsPrimaryKeyColumn,
            this.IsUniqueConstraintColumn,
            this.DataSpaceNameColumn});
            this.IndexDataGridView.ContextMenuStrip = this.IndexContextMenuStrip;
            this.IndexDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IndexDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.IndexDataGridView.Location = new System.Drawing.Point(0, 97);
            this.IndexDataGridView.Name = "IndexDataGridView";
            this.IndexDataGridView.RowHeadersVisible = false;
            this.IndexDataGridView.RowTemplate.Height = 18;
            this.IndexDataGridView.RowTemplate.ReadOnly = true;
            this.IndexDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.IndexDataGridView.ShowCellErrors = false;
            this.IndexDataGridView.ShowCellToolTips = false;
            this.IndexDataGridView.ShowEditingIcon = false;
            this.IndexDataGridView.ShowRowErrors = false;
            this.IndexDataGridView.Size = new System.Drawing.Size(884, 441);
            this.IndexDataGridView.TabIndex = 3;
            this.IndexDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IndexDataGridView_CellClick);
            this.IndexDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.IndexDataGridView_CellFormatting);
            this.IndexDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.IndexDataGridView_CellPainting);
            this.IndexDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.IndexDataGridView_DataError);
            // 
            // ReorganizeColumn
            // 
            this.ReorganizeColumn.DataPropertyName = "Reorganize";
            this.ReorganizeColumn.Frozen = true;
            this.ReorganizeColumn.HeaderText = "Reorganize";
            this.ReorganizeColumn.Name = "ReorganizeColumn";
            // 
            // RebuildColumn
            // 
            this.RebuildColumn.DataPropertyName = "Rebuild";
            this.RebuildColumn.Frozen = true;
            this.RebuildColumn.HeaderText = "Rebuild";
            this.RebuildColumn.Name = "RebuildColumn";
            // 
            // SchemaNameColumn
            // 
            this.SchemaNameColumn.DataPropertyName = "SchemaName";
            this.SchemaNameColumn.Frozen = true;
            this.SchemaNameColumn.HeaderText = "Schema";
            this.SchemaNameColumn.Name = "SchemaNameColumn";
            this.SchemaNameColumn.ReadOnly = true;
            // 
            // ObjectNameColumn
            // 
            this.ObjectNameColumn.DataPropertyName = "ObjectName";
            this.ObjectNameColumn.Frozen = true;
            this.ObjectNameColumn.HeaderText = "Object";
            this.ObjectNameColumn.Name = "ObjectNameColumn";
            this.ObjectNameColumn.ReadOnly = true;
            // 
            // IndexNameColumn
            // 
            this.IndexNameColumn.DataPropertyName = "IndexName";
            this.IndexNameColumn.Frozen = true;
            this.IndexNameColumn.HeaderText = "Index";
            this.IndexNameColumn.Name = "IndexNameColumn";
            this.IndexNameColumn.ReadOnly = true;
            // 
            // IndexTypeDescriptionColumn
            // 
            this.IndexTypeDescriptionColumn.DataPropertyName = "IndexTypeDescription";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.IndexTypeDescriptionColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.IndexTypeDescriptionColumn.HeaderText = "Type";
            this.IndexTypeDescriptionColumn.Name = "IndexTypeDescriptionColumn";
            this.IndexTypeDescriptionColumn.ReadOnly = true;
            // 
            // IndexSizeColumn
            // 
            this.IndexSizeColumn.DataPropertyName = "Size";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.IndexSizeColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.IndexSizeColumn.HeaderText = "Size";
            this.IndexSizeColumn.Name = "IndexSizeColumn";
            this.IndexSizeColumn.ReadOnly = true;
            // 
            // IndexPagesColumn
            // 
            this.IndexPagesColumn.DataPropertyName = "PageCount";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "n0";
            this.IndexPagesColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.IndexPagesColumn.HeaderText = "Pages";
            this.IndexPagesColumn.Name = "IndexPagesColumn";
            this.IndexPagesColumn.ReadOnly = true;
            // 
            // AvgFragmentationPercentColumn
            // 
            this.AvgFragmentationPercentColumn.DataPropertyName = "AvgFragmentationPercent";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.AvgFragmentationPercentColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.AvgFragmentationPercentColumn.HeaderText = "Frag %";
            this.AvgFragmentationPercentColumn.Name = "AvgFragmentationPercentColumn";
            this.AvgFragmentationPercentColumn.ReadOnly = true;
            // 
            // RecommendationDescriptionColumn
            // 
            this.RecommendationDescriptionColumn.DataPropertyName = "RecommendationDescription";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.RecommendationDescriptionColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.RecommendationDescriptionColumn.HeaderText = "Recommendation";
            this.RecommendationDescriptionColumn.Name = "RecommendationDescriptionColumn";
            this.RecommendationDescriptionColumn.ReadOnly = true;
            // 
            // ReasonColumn
            // 
            this.ReasonColumn.DataPropertyName = "RecommendationReason";
            this.ReasonColumn.HeaderText = "Reason";
            this.ReasonColumn.Name = "ReasonColumn";
            this.ReasonColumn.ReadOnly = true;
            // 
            // ColumnsDescriptionColumn
            // 
            this.ColumnsDescriptionColumn.DataPropertyName = "ColumnsDescription";
            this.ColumnsDescriptionColumn.HeaderText = "Columns";
            this.ColumnsDescriptionColumn.Name = "ColumnsDescriptionColumn";
            this.ColumnsDescriptionColumn.ReadOnly = true;
            // 
            // IncludeColumnsDescriptionColumn
            // 
            this.IncludeColumnsDescriptionColumn.DataPropertyName = "IncludeColumnsDescription";
            this.IncludeColumnsDescriptionColumn.HeaderText = "Include";
            this.IncludeColumnsDescriptionColumn.Name = "IncludeColumnsDescriptionColumn";
            this.IncludeColumnsDescriptionColumn.ReadOnly = true;
            // 
            // FilterDefinitionColumn
            // 
            this.FilterDefinitionColumn.DataPropertyName = "FilterDefinition";
            this.FilterDefinitionColumn.HeaderText = "Filter";
            this.FilterDefinitionColumn.Name = "FilterDefinitionColumn";
            this.FilterDefinitionColumn.ReadOnly = true;
            // 
            // FillFactorColumn
            // 
            this.FillFactorColumn.DataPropertyName = "FillFactor";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.FillFactorColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.FillFactorColumn.HeaderText = "Fill Factor";
            this.FillFactorColumn.Name = "FillFactorColumn";
            this.FillFactorColumn.ReadOnly = true;
            // 
            // IsUniqueColumn
            // 
            this.IsUniqueColumn.DataPropertyName = "IsUniqueIcon";
            this.IsUniqueColumn.HeaderText = "Unique";
            this.IsUniqueColumn.Name = "IsUniqueColumn";
            this.IsUniqueColumn.ReadOnly = true;
            this.IsUniqueColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // IsPrimaryKeyColumn
            // 
            this.IsPrimaryKeyColumn.DataPropertyName = "IsPrimaryKeyIcon";
            this.IsPrimaryKeyColumn.HeaderText = "PK";
            this.IsPrimaryKeyColumn.Name = "IsPrimaryKeyColumn";
            this.IsPrimaryKeyColumn.ReadOnly = true;
            this.IsPrimaryKeyColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // IsUniqueConstraintColumn
            // 
            this.IsUniqueConstraintColumn.DataPropertyName = "IsUniqueConstraintIcon";
            this.IsUniqueConstraintColumn.HeaderText = "Unique Constraint";
            this.IsUniqueConstraintColumn.Name = "IsUniqueConstraintColumn";
            this.IsUniqueConstraintColumn.ReadOnly = true;
            this.IsUniqueConstraintColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DataSpaceNameColumn
            // 
            this.DataSpaceNameColumn.DataPropertyName = "DataSpaceName";
            this.DataSpaceNameColumn.HeaderText = "Data Space";
            this.DataSpaceNameColumn.Name = "DataSpaceNameColumn";
            this.DataSpaceNameColumn.ReadOnly = true;
            // 
            // IndexContextMenuStrip
            // 
            this.IndexContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectReorganizeContextToolStripMenuItem,
            this.selectRebuildContextToolStripMenuItem,
            this.unselectContextToolStripMenuItem});
            this.IndexContextMenuStrip.Name = "IndexContextMenuStrip";
            this.IndexContextMenuStrip.Size = new System.Drawing.Size(167, 70);
            // 
            // selectReorganizeContextToolStripMenuItem
            // 
            this.selectReorganizeContextToolStripMenuItem.Name = "selectReorganizeContextToolStripMenuItem";
            this.selectReorganizeContextToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.selectReorganizeContextToolStripMenuItem.Text = "Select Reorganize";
            this.selectReorganizeContextToolStripMenuItem.Click += new System.EventHandler(this.selectReorganizeContextToolStripMenuItem_Click);
            // 
            // selectRebuildContextToolStripMenuItem
            // 
            this.selectRebuildContextToolStripMenuItem.Name = "selectRebuildContextToolStripMenuItem";
            this.selectRebuildContextToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.selectRebuildContextToolStripMenuItem.Text = "Select Rebuild";
            this.selectRebuildContextToolStripMenuItem.Click += new System.EventHandler(this.selectRebuildContextToolStripMenuItem_Click);
            // 
            // unselectContextToolStripMenuItem
            // 
            this.unselectContextToolStripMenuItem.Name = "unselectContextToolStripMenuItem";
            this.unselectContextToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.unselectContextToolStripMenuItem.Text = "Unselect";
            this.unselectContextToolStripMenuItem.Click += new System.EventHandler(this.unselectContextToolStripMenuItem_Click);
            // 
            // QueryFragmentationBackgroupWorker
            // 
            this.QueryFragmentationBackgroupWorker.WorkerReportsProgress = true;
            this.QueryFragmentationBackgroupWorker.WorkerSupportsCancellation = true;
            this.QueryFragmentationBackgroupWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.QueryFragmentationBackgroupWorker_DoWork);
            this.QueryFragmentationBackgroupWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.QueryFragmentationBackgroupWorker_ProgressChanged);
            this.QueryFragmentationBackgroupWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.QueryFragmentationBackgroupWorker_RunWorkerCompleted);
            // 
            // MainFormMenuStrip
            // 
            this.MainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainFormMenuStrip.Name = "MainFormMenuStrip";
            this.MainFormMenuStrip.Size = new System.Drawing.Size(884, 24);
            this.MainFormMenuStrip.TabIndex = 0;
            this.MainFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectDataSourceToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.toolStripMenuItem8,
            this.fixIndexesToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // selectDataSourceToolStripMenuItem
            // 
            this.selectDataSourceToolStripMenuItem.Name = "selectDataSourceToolStripMenuItem";
            this.selectDataSourceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.selectDataSourceToolStripMenuItem.Text = "&Connect...";
            this.selectDataSourceToolStripMenuItem.Click += new System.EventHandler(this.selectDataSourceToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.disconnectToolStripMenuItem.Text = "&Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(149, 6);
            // 
            // fixIndexesToolStripMenuItem
            // 
            this.fixIndexesToolStripMenuItem.Name = "fixIndexesToolStripMenuItem";
            this.fixIndexesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fixIndexesToolStripMenuItem.Text = "&Fix Indexes...";
            this.fixIndexesToolStripMenuItem.Click += new System.EventHandler(this.fixIndexesToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToExcelToolStripMenuItem,
            this.exportToCsvToolStripMenuItem,
            this.exportToTxtToolStripMenuItem1});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToolStripMenuItem.Text = "&Export";
            // 
            // exportToExcelToolStripMenuItem
            // 
            this.exportToExcelToolStripMenuItem.Name = "exportToExcelToolStripMenuItem";
            this.exportToExcelToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exportToExcelToolStripMenuItem.Text = "Export To &Excel...";
            this.exportToExcelToolStripMenuItem.Click += new System.EventHandler(this.exportToExcelToolStripMenuItem_Click);
            // 
            // exportToCsvToolStripMenuItem
            // 
            this.exportToCsvToolStripMenuItem.Name = "exportToCsvToolStripMenuItem";
            this.exportToCsvToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exportToCsvToolStripMenuItem.Text = "Export To &Csv...";
            this.exportToCsvToolStripMenuItem.Click += new System.EventHandler(this.exportToCsvToolStripMenuItem_Click);
            // 
            // exportToTxtToolStripMenuItem1
            // 
            this.exportToTxtToolStripMenuItem1.Name = "exportToTxtToolStripMenuItem1";
            this.exportToTxtToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.exportToTxtToolStripMenuItem1.Text = "Export To &Txt...";
            this.exportToTxtToolStripMenuItem1.Click += new System.EventHandler(this.exportToTxtToolbarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToRecommendationsToolStripMenuItem,
            this.unselectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // resetToRecommendationsToolStripMenuItem
            // 
            this.resetToRecommendationsToolStripMenuItem.Name = "resetToRecommendationsToolStripMenuItem";
            this.resetToRecommendationsToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.resetToRecommendationsToolStripMenuItem.Text = "&Reset To Recommendations";
            this.resetToRecommendationsToolStripMenuItem.Click += new System.EventHandler(this.resetToRecommendationsToolStripMenuItem_Click);
            // 
            // unselectAllToolStripMenuItem
            // 
            this.unselectAllToolStripMenuItem.Name = "unselectAllToolStripMenuItem";
            this.unselectAllToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.unselectAllToolStripMenuItem.Text = "Unselect All";
            this.unselectAllToolStripMenuItem.Click += new System.EventHandler(this.unselectAllToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.refreshToolStripMenuItem.Text = "&Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "&Options...";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ShowRecommendationsLink
            // 
            this.ShowRecommendationsLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ShowRecommendationsLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowRecommendationsLink.Location = new System.Drawing.Point(264, 8);
            this.ShowRecommendationsLink.Name = "ShowRecommendationsLink";
            this.ShowRecommendationsLink.Size = new System.Drawing.Size(168, 32);
            this.ShowRecommendationsLink.TabIndex = 2;
            this.ShowRecommendationsLink.TabStop = true;
            this.ShowRecommendationsLink.Text = "Show Recommendations";
            this.ShowRecommendationsLink.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ShowRecommendationsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowRecommendationsLink_LinkClicked);
            // 
            // RebuildCountLabel
            // 
            this.RebuildCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RebuildCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RebuildCountLabel.ForeColor = System.Drawing.Color.Green;
            this.RebuildCountLabel.Location = new System.Drawing.Point(584, 24);
            this.RebuildCountLabel.Name = "RebuildCountLabel";
            this.RebuildCountLabel.Size = new System.Drawing.Size(184, 16);
            this.RebuildCountLabel.TabIndex = 4;
            this.RebuildCountLabel.Text = "X indexes selected to rebuild";
            this.RebuildCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReorganizeCountLabel
            // 
            this.ReorganizeCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReorganizeCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReorganizeCountLabel.ForeColor = System.Drawing.Color.Green;
            this.ReorganizeCountLabel.Location = new System.Drawing.Point(584, 8);
            this.ReorganizeCountLabel.Name = "ReorganizeCountLabel";
            this.ReorganizeCountLabel.Size = new System.Drawing.Size(184, 16);
            this.ReorganizeCountLabel.TabIndex = 3;
            this.ReorganizeCountLabel.Text = "X indexes selected to reorganize";
            this.ReorganizeCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FixIndexesButton
            // 
            this.FixIndexesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FixIndexesButton.Location = new System.Drawing.Point(776, 8);
            this.FixIndexesButton.Name = "FixIndexesButton";
            this.FixIndexesButton.Size = new System.Drawing.Size(99, 32);
            this.FixIndexesButton.TabIndex = 5;
            this.FixIndexesButton.Text = "Fix Indexes...";
            this.FixIndexesButton.UseVisualStyleBackColor = true;
            this.FixIndexesButton.Click += new System.EventHandler(this.FixIndexesButton_Click);
            // 
            // WarningPictureBox
            // 
            this.WarningPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WarningPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("WarningPictureBox.Image")));
            this.WarningPictureBox.Location = new System.Drawing.Point(8, 10);
            this.WarningPictureBox.Name = "WarningPictureBox";
            this.WarningPictureBox.Size = new System.Drawing.Size(32, 32);
            this.WarningPictureBox.TabIndex = 1;
            this.WarningPictureBox.TabStop = false;
            // 
            // CheckmarkPictureBox
            // 
            this.CheckmarkPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CheckmarkPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CheckmarkPictureBox.Image")));
            this.CheckmarkPictureBox.Location = new System.Drawing.Point(8, 8);
            this.CheckmarkPictureBox.Name = "CheckmarkPictureBox";
            this.CheckmarkPictureBox.Size = new System.Drawing.Size(32, 32);
            this.CheckmarkPictureBox.TabIndex = 0;
            this.CheckmarkPictureBox.TabStop = false;
            // 
            // FragmentationDetectedLabel
            // 
            this.FragmentationDetectedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FragmentationDetectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FragmentationDetectedLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.FragmentationDetectedLabel.Location = new System.Drawing.Point(48, 0);
            this.FragmentationDetectedLabel.Name = "FragmentationDetectedLabel";
            this.FragmentationDetectedLabel.Size = new System.Drawing.Size(224, 48);
            this.FragmentationDetectedLabel.TabIndex = 1;
            this.FragmentationDetectedLabel.Text = "Fragmentation detected.\r\nThere are X recommendations.";
            this.FragmentationDetectedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NoFragmentationDetectedLabel
            // 
            this.NoFragmentationDetectedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NoFragmentationDetectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoFragmentationDetectedLabel.ForeColor = System.Drawing.Color.Green;
            this.NoFragmentationDetectedLabel.Location = new System.Drawing.Point(48, -1);
            this.NoFragmentationDetectedLabel.Name = "NoFragmentationDetectedLabel";
            this.NoFragmentationDetectedLabel.Size = new System.Drawing.Size(360, 48);
            this.NoFragmentationDetectedLabel.TabIndex = 0;
            this.NoFragmentationDetectedLabel.Text = "Fragmentation levels are below the defined thresholds.\r\nNo action is recommended " +
    "at this time.";
            this.NoFragmentationDetectedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Reorganize";
            this.dataGridViewCheckBoxColumn1.Frozen = true;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Select";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Rebuild";
            this.dataGridViewCheckBoxColumn2.Frozen = true;
            this.dataGridViewCheckBoxColumn2.HeaderText = "Rebuild";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.ShowRecommendationsLink);
            this.TopPanel.Controls.Add(this.RebuildCountLabel);
            this.TopPanel.Controls.Add(this.ReorganizeCountLabel);
            this.TopPanel.Controls.Add(this.FixIndexesButton);
            this.TopPanel.Controls.Add(this.CheckingLabel);
            this.TopPanel.Controls.Add(this.CheckingPictureBox);
            this.TopPanel.Controls.Add(this.WarningPictureBox);
            this.TopPanel.Controls.Add(this.CheckmarkPictureBox);
            this.TopPanel.Controls.Add(this.FragmentationDetectedLabel);
            this.TopPanel.Controls.Add(this.NoFragmentationDetectedLabel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 49);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(884, 48);
            this.TopPanel.TabIndex = 2;
            // 
            // CheckingLabel
            // 
            this.CheckingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckingLabel.ForeColor = System.Drawing.Color.Black;
            this.CheckingLabel.Location = new System.Drawing.Point(48, 0);
            this.CheckingLabel.Name = "CheckingLabel";
            this.CheckingLabel.Size = new System.Drawing.Size(216, 48);
            this.CheckingLabel.TabIndex = 7;
            this.CheckingLabel.Text = "Checking...";
            this.CheckingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CheckingPictureBox
            // 
            this.CheckingPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CheckingPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CheckingPictureBox.Image")));
            this.CheckingPictureBox.Location = new System.Drawing.Point(8, 8);
            this.CheckingPictureBox.Name = "CheckingPictureBox";
            this.CheckingPictureBox.Size = new System.Drawing.Size(32, 32);
            this.CheckingPictureBox.TabIndex = 6;
            this.CheckingPictureBox.TabStop = false;
            // 
            // ExcelSaveFileDialog
            // 
            this.ExcelSaveFileDialog.DefaultExt = "xlsx";
            this.ExcelSaveFileDialog.Filter = "Excel Workbook|*.xlsx";
            this.ExcelSaveFileDialog.Title = "Export to Excel";
            // 
            // CsvSaveFileDialog
            // 
            this.CsvSaveFileDialog.Filter = "CSV (Comma delimited)|*.csv";
            this.CsvSaveFileDialog.Title = "Export to CSV";
            // 
            // TxtSaveFileDialog
            // 
            this.TxtSaveFileDialog.Filter = "Text (Tab delimited)|*.txt";
            this.TxtSaveFileDialog.Title = "Export to Txt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.IndexDataGridView);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.MainFormMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainFormMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Index Console";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IndexDataGridView)).EndInit();
            this.IndexContextMenuStrip.ResumeLayout(false);
            this.MainFormMenuStrip.ResumeLayout(false);
            this.MainFormMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarningPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckmarkPictureBox)).EndInit();
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CheckingPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.DataGridView IndexDataGridView;
        private System.ComponentModel.BackgroundWorker QueryFragmentationBackgroupWorker;
        private System.Windows.Forms.ToolStripButton SelectDataSourceToolStripButton;
        private System.Windows.Forms.MenuStrip MainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectDataSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton ExportToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem ExportToExcelToolbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportToCsvToolbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToCsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel IndexCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ObjectCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel StatusToolStripStatusLabel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.ToolStripMenuItem unselectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem fixIndexesToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton FilterToolStripDropDownButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem allIndexesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexesSelectedToReorganizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexesSelectedToRebuildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexesSelectedToReorganizeRebuildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexesWithRecommendationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexesWithAnyFragmentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nonclusteredIndexesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clusteredIndexesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heapsToolStripMenuItem;
        private System.Windows.Forms.Label RebuildCountLabel;
        private System.Windows.Forms.Label ReorganizeCountLabel;
        private System.Windows.Forms.Label FragmentationDetectedLabel;
        private System.Windows.Forms.Button FixIndexesButton;
        private System.Windows.Forms.PictureBox WarningPictureBox;
        private System.Windows.Forms.PictureBox CheckmarkPictureBox;
        private System.Windows.Forms.Label NoFragmentationDetectedLabel;
        private System.Windows.Forms.LinkLabel ShowRecommendationsLink;
        private System.Windows.Forms.ToolStripMenuItem resetToRecommendationsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip IndexContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem selectReorganizeContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectRebuildContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unselectContextToolStripMenuItem;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.SaveFileDialog ExcelSaveFileDialog;
        private System.Windows.Forms.SaveFileDialog CsvSaveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem exportToTxtToolbarToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog TxtSaveFileDialog;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ReorganizeColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RebuildColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchemaNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjectNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexTypeDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexSizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexPagesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgFragmentationPercentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecommendationDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReasonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnsDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncludeColumnsDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilterDefinitionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FillFactorColumn;
        private System.Windows.Forms.DataGridViewImageColumn IsUniqueColumn;
        private System.Windows.Forms.DataGridViewImageColumn IsPrimaryKeyColumn;
        private System.Windows.Forms.DataGridViewImageColumn IsUniqueConstraintColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSpaceNameColumn;
        private System.Windows.Forms.ToolStripMenuItem exportToTxtToolStripMenuItem1;
        private System.Windows.Forms.PictureBox CheckingPictureBox;
        private System.Windows.Forms.Label CheckingLabel;
    }
}
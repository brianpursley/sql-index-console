using SqlIndexConsole.Data;
using SqlIndexConsole.Data.Actions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace SqlIndexConsole
{
    public partial class FixProgressDialog : Form
    {
        public IndexDataProvider IndexDataProvider { get; set; }

        public IEnumerable<SqlAction> Actions { get; set; }
        
        public bool Cancelled { get; private set; }
        
        public bool ErrorsOccurred { get; private set; }
        
        private CancellationTokenSource cancellationTokenSource;
        
        private DateTime startedOn;

        public FixProgressDialog()
        {
            InitializeComponent();
            Cancelled = false;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (cancellationTokenSource != null)
                {
                    cancellationTokenSource.Dispose();
                }
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void FixProgressDialog_Load(object sender, EventArgs e)
        {
            cancellationTokenSource = new CancellationTokenSource();
        }

        private void FixProgressDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            cancellationTokenSource.Dispose();
            cancellationTokenSource = null;
        }

        private void FixProgressDialog_Shown(object sender, EventArgs e)
        {
            FixBackgroundWorker.RunWorkerAsync();
            startedOn = DateTime.Now;
            clockTimer.Start();
        }

        private void FixBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                int i = 0;
                int total = Actions.Count();
                foreach (var action in Actions)
                {
                    if (FixBackgroundWorker.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                    if (action.HasSql())
                    {
                        i++;
                    }
                    else
                    {
                        total--;
                    }
                    var progressPercent = i * 100 / total;
                    FixBackgroundWorker.ReportProgress(progressPercent, action.GetStatus());
                    try
                    {
                        IndexDataProvider.ExecuteAction(action, cancellationTokenSource);
                    }
                    catch (AggregateException ex)
                    {
                        foreach (var ex2 in ex.InnerExceptions)
                        {
                            ReportException(progressPercent, ex2);
                        }
                    }
                    catch (Exception ex)
                    {
                        ReportException(progressPercent, ex);
                    }
                    FixBackgroundWorker.ReportProgress(progressPercent);
                }
            }
            catch (Exception ex)
            {
                FixBackgroundWorker.ReportProgress(0, "ERROR: " + ex.Message);
                ErrorsOccurred = true;
            }
        }

        private void ReportException(int progressPercent, Exception ex)
        {
            if (cancellationTokenSource.IsCancellationRequested)
            {
                return;
            }
            FixBackgroundWorker.ReportProgress(progressPercent, "ERROR: " + ex.Message);
            ErrorsOccurred = true;
        }

        private void FixBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            FixProgressBar.Value = e.ProgressPercentage;
            if (e.UserState != null)
            {
                AddStatusText(e.UserState.ToString());
            }
            toolStripSeparator1.Visible = ErrorsOccurred;
            ErrorsOccurredToolStripLabel.Visible = ErrorsOccurred;
        }

        private void AddStatusText(string text)
        {
            FixProgressTextBox.Text += string.Concat(DateTime.Now, ": ", text, Environment.NewLine);
            FixProgressTextBox.SelectionStart = FixProgressTextBox.Text.Length;
            FixProgressTextBox.SelectionLength = 0;
            FixProgressTextBox.ScrollToCaret();
        }

        private void FixBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            clockTimer.Stop();
            if (ErrorsOccurred)
            {
                AddStatusText("ERROR: One or more errors occurred (see output for details)");
            }
            else if (e.Cancelled)
            {
                AddStatusText("CANCELLED");
                FixProgressBar.Value = 0;
            }
            else
            {
                AddStatusText("DONE");
            }
            Cancelled = e.Cancelled;
            CopyToClipboardButton.Enabled = true;
            CancelFormButton.Visible = false;
            CloseButton.Visible = true;
            AcceptButton = CloseButton;
            CancelButton = CloseButton;
            toolStripSeparator1.Visible = true;
            DoneToolStripLabel.Visible = !ErrorsOccurred;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelFormButton_Click(object sender, EventArgs e)
        {
            AddStatusText("Attempting to cancel...");
            CancelFormButton.Enabled = false;
            FixBackgroundWorker.CancelAsync();
            cancellationTokenSource.Cancel();
        }

        private void CopyToClipboardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(FixProgressTextBox.Text);
        }

        private void FixProgressTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                FixProgressTextBox.SelectAll();
            }
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            var duration = DateTime.Now.Subtract(startedOn);
            ClockToolStripLabel.Text = duration.ToString().Split('.').First();
        }
    }
}

namespace SqlIndexConsole
{
    partial class FixProgressDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixProgressDialog));
            this.FixProgressTextBox = new System.Windows.Forms.TextBox();
            this.FixProgressBar = new System.Windows.Forms.ProgressBar();
            this.CancelFormButton = new System.Windows.Forms.Button();
            this.FixBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SummaryToolStrip = new System.Windows.Forms.ToolStrip();
            this.CopyToClipboardButton = new System.Windows.Forms.ToolStripButton();
            this.ClockToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DoneToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.ErrorsOccurredToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.SummaryToolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FixProgressTextBox
            // 
            this.FixProgressTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FixProgressTextBox.Location = new System.Drawing.Point(0, 25);
            this.FixProgressTextBox.Multiline = true;
            this.FixProgressTextBox.Name = "FixProgressTextBox";
            this.FixProgressTextBox.ReadOnly = true;
            this.FixProgressTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.FixProgressTextBox.Size = new System.Drawing.Size(684, 367);
            this.FixProgressTextBox.TabIndex = 1;
            this.FixProgressTextBox.WordWrap = false;
            this.FixProgressTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FixProgressTextBox_KeyDown);
            // 
            // FixProgressBar
            // 
            this.FixProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FixProgressBar.Location = new System.Drawing.Point(8, 10);
            this.FixProgressBar.Name = "FixProgressBar";
            this.FixProgressBar.Size = new System.Drawing.Size(668, 23);
            this.FixProgressBar.TabIndex = 0;
            // 
            // CancelFormButton
            // 
            this.CancelFormButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CancelFormButton.Location = new System.Drawing.Point(302, 40);
            this.CancelFormButton.Name = "CancelFormButton";
            this.CancelFormButton.Size = new System.Drawing.Size(80, 23);
            this.CancelFormButton.TabIndex = 1;
            this.CancelFormButton.Text = "Cancel";
            this.CancelFormButton.UseVisualStyleBackColor = true;
            this.CancelFormButton.Click += new System.EventHandler(this.CancelFormButton_Click);
            // 
            // FixBackgroundWorker
            // 
            this.FixBackgroundWorker.WorkerReportsProgress = true;
            this.FixBackgroundWorker.WorkerSupportsCancellation = true;
            this.FixBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.FixBackgroundWorker_DoWork);
            this.FixBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.FixBackgroundWorker_ProgressChanged);
            this.FixBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.FixBackgroundWorker_RunWorkerCompleted);
            // 
            // SummaryToolStrip
            // 
            this.SummaryToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyToClipboardButton,
            this.ClockToolStripLabel,
            this.toolStripSeparator1,
            this.DoneToolStripLabel,
            this.ErrorsOccurredToolStripLabel});
            this.SummaryToolStrip.Location = new System.Drawing.Point(0, 0);
            this.SummaryToolStrip.Name = "SummaryToolStrip";
            this.SummaryToolStrip.Size = new System.Drawing.Size(684, 25);
            this.SummaryToolStrip.TabIndex = 0;
            this.SummaryToolStrip.Text = "toolStrip1";
            // 
            // CopyToClipboardButton
            // 
            this.CopyToClipboardButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CopyToClipboardButton.Enabled = false;
            this.CopyToClipboardButton.Image = ((System.Drawing.Image)(resources.GetObject("CopyToClipboardButton.Image")));
            this.CopyToClipboardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyToClipboardButton.Name = "CopyToClipboardButton";
            this.CopyToClipboardButton.Size = new System.Drawing.Size(127, 22);
            this.CopyToClipboardButton.Text = "&Copy To Clipboard";
            this.CopyToClipboardButton.Click += new System.EventHandler(this.CopyToClipboardButton_Click);
            // 
            // ClockToolStripLabel
            // 
            this.ClockToolStripLabel.Name = "ClockToolStripLabel";
            this.ClockToolStripLabel.Size = new System.Drawing.Size(43, 22);
            this.ClockToolStripLabel.Text = "0:00:00";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator1.Visible = false;
            // 
            // DoneToolStripLabel
            // 
            this.DoneToolStripLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneToolStripLabel.Name = "DoneToolStripLabel";
            this.DoneToolStripLabel.Size = new System.Drawing.Size(37, 22);
            this.DoneToolStripLabel.Text = "Done";
            this.DoneToolStripLabel.Visible = false;
            // 
            // ErrorsOccurredToolStripLabel
            // 
            this.ErrorsOccurredToolStripLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ErrorsOccurredToolStripLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorsOccurredToolStripLabel.Name = "ErrorsOccurredToolStripLabel";
            this.ErrorsOccurredToolStripLabel.Size = new System.Drawing.Size(208, 22);
            this.ErrorsOccurredToolStripLabel.Text = "Errors Occurred (See Output Below)";
            this.ErrorsOccurredToolStripLabel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CancelFormButton);
            this.panel1.Controls.Add(this.FixProgressBar);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 392);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 70);
            this.panel1.TabIndex = 2;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CloseButton.Location = new System.Drawing.Point(302, 40);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(80, 23);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Visible = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // clockTimer
            // 
            this.clockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // FixProgressDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.ControlBox = false;
            this.Controls.Add(this.FixProgressTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SummaryToolStrip);
            this.Name = "FixProgressDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fix Indexes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FixProgressDialog_FormClosed);
            this.Load += new System.EventHandler(this.FixProgressDialog_Load);
            this.Shown += new System.EventHandler(this.FixProgressDialog_Shown);
            this.SummaryToolStrip.ResumeLayout(false);
            this.SummaryToolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FixProgressTextBox;
        private System.Windows.Forms.ProgressBar FixProgressBar;
        private System.Windows.Forms.Button CancelFormButton;
        private System.ComponentModel.BackgroundWorker FixBackgroundWorker;
        private System.Windows.Forms.ToolStrip SummaryToolStrip;
        private System.Windows.Forms.ToolStripButton CopyToClipboardButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.ToolStripLabel ClockToolStripLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel ErrorsOccurredToolStripLabel;
        private System.Windows.Forms.ToolStripLabel DoneToolStripLabel;
    }
}
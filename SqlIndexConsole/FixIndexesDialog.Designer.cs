namespace SqlIndexConsole
{
    partial class FixIndexesDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixIndexesDialog));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.SummaryTabPage = new System.Windows.Forms.TabPage();
            this.SummaryTextBox = new System.Windows.Forms.TextBox();
            this.SummaryToolStrip = new System.Windows.Forms.ToolStrip();
            this.CopySummaryToClipboardButton = new System.Windows.Forms.ToolStripButton();
            this.SqlScriptTabPage = new System.Windows.Forms.TabPage();
            this.SqlScriptTextBox = new System.Windows.Forms.TextBox();
            this.SqlScriptToolStrip = new System.Windows.Forms.ToolStrip();
            this.CopySqlScriptToClipboardButton = new System.Windows.Forms.ToolStripButton();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.CancelFormButton = new System.Windows.Forms.Button();
            this.FixNowButton = new System.Windows.Forms.Button();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.MainTabControl.SuspendLayout();
            this.SummaryTabPage.SuspendLayout();
            this.SummaryToolStrip.SuspendLayout();
            this.SqlScriptTabPage.SuspendLayout();
            this.SqlScriptToolStrip.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.SummaryTabPage);
            this.MainTabControl.Controls.Add(this.SqlScriptTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(634, 424);
            this.MainTabControl.TabIndex = 0;
            // 
            // SummaryTabPage
            // 
            this.SummaryTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.SummaryTabPage.Controls.Add(this.SummaryTextBox);
            this.SummaryTabPage.Controls.Add(this.SummaryToolStrip);
            this.SummaryTabPage.Location = new System.Drawing.Point(4, 22);
            this.SummaryTabPage.Name = "SummaryTabPage";
            this.SummaryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SummaryTabPage.Size = new System.Drawing.Size(626, 398);
            this.SummaryTabPage.TabIndex = 0;
            this.SummaryTabPage.Text = "Summary";
            // 
            // SummaryTextBox
            // 
            this.SummaryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SummaryTextBox.Location = new System.Drawing.Point(3, 28);
            this.SummaryTextBox.Multiline = true;
            this.SummaryTextBox.Name = "SummaryTextBox";
            this.SummaryTextBox.ReadOnly = true;
            this.SummaryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SummaryTextBox.Size = new System.Drawing.Size(620, 367);
            this.SummaryTextBox.TabIndex = 1;
            this.SummaryTextBox.WordWrap = false;
            this.SummaryTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SummaryTextBox_KeyDown);
            // 
            // SummaryToolStrip
            // 
            this.SummaryToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopySummaryToClipboardButton});
            this.SummaryToolStrip.Location = new System.Drawing.Point(3, 3);
            this.SummaryToolStrip.Name = "SummaryToolStrip";
            this.SummaryToolStrip.Size = new System.Drawing.Size(620, 25);
            this.SummaryToolStrip.TabIndex = 0;
            this.SummaryToolStrip.Text = "toolStrip1";
            // 
            // CopySummaryToClipboardButton
            // 
            this.CopySummaryToClipboardButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CopySummaryToClipboardButton.Image = ((System.Drawing.Image)(resources.GetObject("CopySummaryToClipboardButton.Image")));
            this.CopySummaryToClipboardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopySummaryToClipboardButton.Name = "CopySummaryToClipboardButton";
            this.CopySummaryToClipboardButton.Size = new System.Drawing.Size(127, 22);
            this.CopySummaryToClipboardButton.Text = "&Copy To Clipboard";
            this.CopySummaryToClipboardButton.Click += new System.EventHandler(this.CopySummaryToClipboardButton_Click);
            // 
            // SqlScriptTabPage
            // 
            this.SqlScriptTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.SqlScriptTabPage.Controls.Add(this.SqlScriptTextBox);
            this.SqlScriptTabPage.Controls.Add(this.SqlScriptToolStrip);
            this.SqlScriptTabPage.Location = new System.Drawing.Point(4, 22);
            this.SqlScriptTabPage.Name = "SqlScriptTabPage";
            this.SqlScriptTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SqlScriptTabPage.Size = new System.Drawing.Size(626, 398);
            this.SqlScriptTabPage.TabIndex = 1;
            this.SqlScriptTabPage.Text = "SQL Script";
            // 
            // SqlScriptTextBox
            // 
            this.SqlScriptTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SqlScriptTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SqlScriptTextBox.Location = new System.Drawing.Point(3, 28);
            this.SqlScriptTextBox.Multiline = true;
            this.SqlScriptTextBox.Name = "SqlScriptTextBox";
            this.SqlScriptTextBox.ReadOnly = true;
            this.SqlScriptTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SqlScriptTextBox.Size = new System.Drawing.Size(620, 367);
            this.SqlScriptTextBox.TabIndex = 1;
            this.SqlScriptTextBox.WordWrap = false;
            this.SqlScriptTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SqlScriptTextBox_KeyDown);
            // 
            // SqlScriptToolStrip
            // 
            this.SqlScriptToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopySqlScriptToClipboardButton});
            this.SqlScriptToolStrip.Location = new System.Drawing.Point(3, 3);
            this.SqlScriptToolStrip.Name = "SqlScriptToolStrip";
            this.SqlScriptToolStrip.Size = new System.Drawing.Size(620, 25);
            this.SqlScriptToolStrip.TabIndex = 0;
            this.SqlScriptToolStrip.Text = "toolStrip2";
            // 
            // CopySqlScriptToClipboardButton
            // 
            this.CopySqlScriptToClipboardButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CopySqlScriptToClipboardButton.Image = ((System.Drawing.Image)(resources.GetObject("CopySqlScriptToClipboardButton.Image")));
            this.CopySqlScriptToClipboardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopySqlScriptToClipboardButton.Name = "CopySqlScriptToClipboardButton";
            this.CopySqlScriptToClipboardButton.Size = new System.Drawing.Size(127, 22);
            this.CopySqlScriptToClipboardButton.Text = "&Copy To Clipboard";
            this.CopySqlScriptToClipboardButton.Click += new System.EventHandler(this.CopySqlScriptToClipboardButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.CancelFormButton);
            this.MainPanel.Controls.Add(this.FixNowButton);
            this.MainPanel.Controls.Add(this.WarningLabel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainPanel.Location = new System.Drawing.Point(0, 424);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(634, 38);
            this.MainPanel.TabIndex = 1;
            // 
            // CancelFormButton
            // 
            this.CancelFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelFormButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelFormButton.Location = new System.Drawing.Point(549, 8);
            this.CancelFormButton.Name = "CancelFormButton";
            this.CancelFormButton.Size = new System.Drawing.Size(75, 23);
            this.CancelFormButton.TabIndex = 2;
            this.CancelFormButton.Text = "Cancel";
            this.CancelFormButton.UseVisualStyleBackColor = true;
            this.CancelFormButton.Click += new System.EventHandler(this.CancelFormButton_Click);
            // 
            // FixNowButton
            // 
            this.FixNowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FixNowButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.FixNowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FixNowButton.ImageKey = "(none)";
            this.FixNowButton.Location = new System.Drawing.Point(473, 8);
            this.FixNowButton.Name = "FixNowButton";
            this.FixNowButton.Size = new System.Drawing.Size(70, 23);
            this.FixNowButton.TabIndex = 1;
            this.FixNowButton.Text = "Fix Now";
            this.FixNowButton.UseVisualStyleBackColor = true;
            this.FixNowButton.Click += new System.EventHandler(this.FixNowButton_Click);
            // 
            // WarningLabel
            // 
            this.WarningLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningLabel.ForeColor = System.Drawing.Color.Black;
            this.WarningLabel.Location = new System.Drawing.Point(8, 0);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(465, 38);
            this.WarningLabel.TabIndex = 0;
            this.WarningLabel.Text = "IMPORTANT MESSAGE:\r\nSever performance may decline while fixes are being applied!";
            this.WarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FixIndexesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelFormButton;
            this.ClientSize = new System.Drawing.Size(634, 462);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.MainPanel);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(575, 200);
            this.Name = "FixIndexesDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fix Indexes";
            this.Load += new System.EventHandler(this.FixIndexesDialog_Load);
            this.MainTabControl.ResumeLayout(false);
            this.SummaryTabPage.ResumeLayout(false);
            this.SummaryTabPage.PerformLayout();
            this.SummaryToolStrip.ResumeLayout(false);
            this.SummaryToolStrip.PerformLayout();
            this.SqlScriptTabPage.ResumeLayout(false);
            this.SqlScriptTabPage.PerformLayout();
            this.SqlScriptToolStrip.ResumeLayout(false);
            this.SqlScriptToolStrip.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage SummaryTabPage;
        private System.Windows.Forms.TextBox SummaryTextBox;
        private System.Windows.Forms.TabPage SqlScriptTabPage;
        private System.Windows.Forms.TextBox SqlScriptTextBox;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button CancelFormButton;
        private System.Windows.Forms.Button FixNowButton;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.ToolStrip SummaryToolStrip;
        private System.Windows.Forms.ToolStripButton CopySummaryToClipboardButton;
        private System.Windows.Forms.ToolStrip SqlScriptToolStrip;
        private System.Windows.Forms.ToolStripButton CopySqlScriptToClipboardButton;
    }
}
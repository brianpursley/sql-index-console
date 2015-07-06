namespace SqlIndexConsole
{
    partial class OptionsDialog
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.RestoreDefaultsButton = new System.Windows.Forms.Button();
            this.CancelFormButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.RebuildIndexOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.RebuildMinimumIndexSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.RebuildThresholdUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RebuildMaxDopUpDown = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.RebuildOnlineCheckBox = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.RebuildSortInTempDbCheckBox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ReorganizeIndexOptions = new System.Windows.Forms.GroupBox();
            this.ReorganizeMinimumIndexSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.ReorganizeThresholdUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReorganizeLobCompactionCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RebuildCommandTimeoutUpDown = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ReorganizeCommandTimeoutUpDown = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.RebuildIndexOptionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RebuildMinimumIndexSizeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RebuildThresholdUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RebuildMaxDopUpDown)).BeginInit();
            this.ReorganizeIndexOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReorganizeMinimumIndexSizeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReorganizeThresholdUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RebuildCommandTimeoutUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReorganizeCommandTimeoutUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.RestoreDefaultsButton);
            this.MainPanel.Controls.Add(this.CancelFormButton);
            this.MainPanel.Controls.Add(this.OkButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainPanel.Location = new System.Drawing.Point(0, 261);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(770, 38);
            this.MainPanel.TabIndex = 6;
            // 
            // RestoreDefaultsButton
            // 
            this.RestoreDefaultsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RestoreDefaultsButton.Location = new System.Drawing.Point(8, 8);
            this.RestoreDefaultsButton.Name = "RestoreDefaultsButton";
            this.RestoreDefaultsButton.Size = new System.Drawing.Size(104, 23);
            this.RestoreDefaultsButton.TabIndex = 0;
            this.RestoreDefaultsButton.Text = "Restore Defaults";
            this.RestoreDefaultsButton.UseVisualStyleBackColor = true;
            this.RestoreDefaultsButton.Click += new System.EventHandler(this.RestoreDefaultsButton_Click);
            // 
            // CancelFormButton
            // 
            this.CancelFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelFormButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelFormButton.Location = new System.Drawing.Point(685, 8);
            this.CancelFormButton.Name = "CancelFormButton";
            this.CancelFormButton.Size = new System.Drawing.Size(75, 23);
            this.CancelFormButton.TabIndex = 2;
            this.CancelFormButton.Text = "Cancel";
            this.CancelFormButton.UseVisualStyleBackColor = true;
            this.CancelFormButton.Click += new System.EventHandler(this.CancelFormButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OkButton.Location = new System.Drawing.Point(604, 8);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // RebuildIndexOptionsGroupBox
            // 
            this.RebuildIndexOptionsGroupBox.Controls.Add(this.RebuildMinimumIndexSizeUpDown);
            this.RebuildIndexOptionsGroupBox.Controls.Add(this.RebuildThresholdUpDown);
            this.RebuildIndexOptionsGroupBox.Controls.Add(this.label6);
            this.RebuildIndexOptionsGroupBox.Controls.Add(this.label7);
            this.RebuildIndexOptionsGroupBox.Controls.Add(this.label8);
            this.RebuildIndexOptionsGroupBox.Controls.Add(this.label9);
            this.RebuildIndexOptionsGroupBox.Location = new System.Drawing.Point(344, 40);
            this.RebuildIndexOptionsGroupBox.Name = "RebuildIndexOptionsGroupBox";
            this.RebuildIndexOptionsGroupBox.Size = new System.Drawing.Size(416, 80);
            this.RebuildIndexOptionsGroupBox.TabIndex = 4;
            this.RebuildIndexOptionsGroupBox.TabStop = false;
            this.RebuildIndexOptionsGroupBox.Text = "Rebuild Recommendation Thresholds";
            // 
            // RebuildMinimumIndexSizeUpDown
            // 
            this.RebuildMinimumIndexSizeUpDown.Location = new System.Drawing.Point(152, 44);
            this.RebuildMinimumIndexSizeUpDown.Maximum = new decimal(new int[] {
            -1,
            2147483647,
            0,
            0});
            this.RebuildMinimumIndexSizeUpDown.Name = "RebuildMinimumIndexSizeUpDown";
            this.RebuildMinimumIndexSizeUpDown.Size = new System.Drawing.Size(72, 20);
            this.RebuildMinimumIndexSizeUpDown.TabIndex = 4;
            // 
            // RebuildThresholdUpDown
            // 
            this.RebuildThresholdUpDown.Location = new System.Drawing.Point(152, 20);
            this.RebuildThresholdUpDown.Name = "RebuildThresholdUpDown";
            this.RebuildThresholdUpDown.Size = new System.Drawing.Size(72, 20);
            this.RebuildThresholdUpDown.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(232, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pages";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(232, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "% Fragmentation";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(16, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "Minimum Index Size";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(16, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Minimum Fragmentation";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RebuildMaxDopUpDown
            // 
            this.RebuildMaxDopUpDown.Location = new System.Drawing.Point(152, 92);
            this.RebuildMaxDopUpDown.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.RebuildMaxDopUpDown.Name = "RebuildMaxDopUpDown";
            this.RebuildMaxDopUpDown.Size = new System.Drawing.Size(72, 20);
            this.RebuildMaxDopUpDown.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(232, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(180, 24);
            this.label14.TabIndex = 7;
            this.label14.Text = "(SQL Server Enterprise Edition Only)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(232, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(180, 24);
            this.label13.TabIndex = 10;
            this.label13.Text = "(SQL Server Enterprise Edition Only)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(16, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 24);
            this.label12.TabIndex = 8;
            this.label12.Text = "Max Degree of Parallelism";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RebuildOnlineCheckBox
            // 
            this.RebuildOnlineCheckBox.AutoSize = true;
            this.RebuildOnlineCheckBox.Location = new System.Drawing.Point(152, 70);
            this.RebuildOnlineCheckBox.Name = "RebuildOnlineCheckBox";
            this.RebuildOnlineCheckBox.Size = new System.Drawing.Size(15, 14);
            this.RebuildOnlineCheckBox.TabIndex = 6;
            this.RebuildOnlineCheckBox.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(16, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 24);
            this.label11.TabIndex = 5;
            this.label11.Text = "Online";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RebuildSortInTempDbCheckBox
            // 
            this.RebuildSortInTempDbCheckBox.AutoSize = true;
            this.RebuildSortInTempDbCheckBox.Location = new System.Drawing.Point(152, 46);
            this.RebuildSortInTempDbCheckBox.Name = "RebuildSortInTempDbCheckBox";
            this.RebuildSortInTempDbCheckBox.Size = new System.Drawing.Size(15, 14);
            this.RebuildSortInTempDbCheckBox.TabIndex = 4;
            this.RebuildSortInTempDbCheckBox.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(16, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 24);
            this.label10.TabIndex = 3;
            this.label10.Text = "Sort In TempDB";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReorganizeIndexOptions
            // 
            this.ReorganizeIndexOptions.Controls.Add(this.ReorganizeMinimumIndexSizeUpDown);
            this.ReorganizeIndexOptions.Controls.Add(this.ReorganizeThresholdUpDown);
            this.ReorganizeIndexOptions.Controls.Add(this.label5);
            this.ReorganizeIndexOptions.Controls.Add(this.label4);
            this.ReorganizeIndexOptions.Controls.Add(this.label2);
            this.ReorganizeIndexOptions.Controls.Add(this.label1);
            this.ReorganizeIndexOptions.Location = new System.Drawing.Point(8, 40);
            this.ReorganizeIndexOptions.Name = "ReorganizeIndexOptions";
            this.ReorganizeIndexOptions.Size = new System.Drawing.Size(328, 80);
            this.ReorganizeIndexOptions.TabIndex = 1;
            this.ReorganizeIndexOptions.TabStop = false;
            this.ReorganizeIndexOptions.Text = "Reorganize Recommendation Thresholds";
            // 
            // ReorganizeMinimumIndexSizeUpDown
            // 
            this.ReorganizeMinimumIndexSizeUpDown.Location = new System.Drawing.Point(152, 44);
            this.ReorganizeMinimumIndexSizeUpDown.Maximum = new decimal(new int[] {
            -1,
            2147483647,
            0,
            0});
            this.ReorganizeMinimumIndexSizeUpDown.Name = "ReorganizeMinimumIndexSizeUpDown";
            this.ReorganizeMinimumIndexSizeUpDown.Size = new System.Drawing.Size(72, 20);
            this.ReorganizeMinimumIndexSizeUpDown.TabIndex = 4;
            // 
            // ReorganizeThresholdUpDown
            // 
            this.ReorganizeThresholdUpDown.Location = new System.Drawing.Point(152, 20);
            this.ReorganizeThresholdUpDown.Name = "ReorganizeThresholdUpDown";
            this.ReorganizeThresholdUpDown.Size = new System.Drawing.Size(72, 20);
            this.ReorganizeThresholdUpDown.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(232, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pages";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(232, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "% Fragmentation";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minimum Index Size";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimum Fragmentation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReorganizeLobCompactionCheckBox
            // 
            this.ReorganizeLobCompactionCheckBox.AutoSize = true;
            this.ReorganizeLobCompactionCheckBox.Location = new System.Drawing.Point(152, 46);
            this.ReorganizeLobCompactionCheckBox.Name = "ReorganizeLobCompactionCheckBox";
            this.ReorganizeLobCompactionCheckBox.Size = new System.Drawing.Size(15, 14);
            this.ReorganizeLobCompactionCheckBox.TabIndex = 4;
            this.ReorganizeLobCompactionCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "LOB Compaction";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RebuildCommandTimeoutUpDown
            // 
            this.RebuildCommandTimeoutUpDown.Location = new System.Drawing.Point(152, 20);
            this.RebuildCommandTimeoutUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.RebuildCommandTimeoutUpDown.Name = "RebuildCommandTimeoutUpDown";
            this.RebuildCommandTimeoutUpDown.Size = new System.Drawing.Size(72, 20);
            this.RebuildCommandTimeoutUpDown.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(232, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(176, 24);
            this.label18.TabIndex = 2;
            this.label18.Text = "Seconds";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(16, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(136, 24);
            this.label20.TabIndex = 0;
            this.label20.Text = "Command Timeout";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ReorganizeCommandTimeoutUpDown);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.ReorganizeLobCompactionCheckBox);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(8, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 128);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reorganize Index Options";
            // 
            // ReorganizeCommandTimeoutUpDown
            // 
            this.ReorganizeCommandTimeoutUpDown.Location = new System.Drawing.Point(152, 20);
            this.ReorganizeCommandTimeoutUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.ReorganizeCommandTimeoutUpDown.Name = "ReorganizeCommandTimeoutUpDown";
            this.ReorganizeCommandTimeoutUpDown.Size = new System.Drawing.Size(72, 20);
            this.ReorganizeCommandTimeoutUpDown.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(232, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 24);
            this.label15.TabIndex = 2;
            this.label15.Text = "Seconds";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(8, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(144, 24);
            this.label16.TabIndex = 0;
            this.label16.Text = "Command Timeout";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RebuildCommandTimeoutUpDown);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.RebuildMaxDopUpDown);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.RebuildSortInTempDbCheckBox);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.RebuildOnlineCheckBox);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(344, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 128);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rebuild Index Options";
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label21.Location = new System.Drawing.Point(8, 8);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(328, 24);
            this.label21.TabIndex = 0;
            this.label21.Text = "Reorganize";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label22.Location = new System.Drawing.Point(344, 8);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(416, 24);
            this.label22.TabIndex = 3;
            this.label22.Text = "Rebuild";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OptionsDialog
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelFormButton;
            this.ClientSize = new System.Drawing.Size(770, 299);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ReorganizeIndexOptions);
            this.Controls.Add(this.RebuildIndexOptionsGroupBox);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsDialog_Load);
            this.MainPanel.ResumeLayout(false);
            this.RebuildIndexOptionsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RebuildMinimumIndexSizeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RebuildThresholdUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RebuildMaxDopUpDown)).EndInit();
            this.ReorganizeIndexOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReorganizeMinimumIndexSizeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReorganizeThresholdUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RebuildCommandTimeoutUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReorganizeCommandTimeoutUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button CancelFormButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.GroupBox RebuildIndexOptionsGroupBox;
        private System.Windows.Forms.GroupBox ReorganizeIndexOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ReorganizeLobCompactionCheckBox;
        private System.Windows.Forms.CheckBox RebuildSortInTempDbCheckBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox RebuildOnlineCheckBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown RebuildMaxDopUpDown;
        private System.Windows.Forms.NumericUpDown RebuildMinimumIndexSizeUpDown;
        private System.Windows.Forms.NumericUpDown RebuildThresholdUpDown;
        private System.Windows.Forms.NumericUpDown ReorganizeMinimumIndexSizeUpDown;
        private System.Windows.Forms.NumericUpDown ReorganizeThresholdUpDown;
        private System.Windows.Forms.Button RestoreDefaultsButton;
        private System.Windows.Forms.NumericUpDown RebuildCommandTimeoutUpDown;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown ReorganizeCommandTimeoutUpDown;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
    }
}
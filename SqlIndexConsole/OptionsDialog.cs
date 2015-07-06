using System;
using System.Windows.Forms;

namespace SqlIndexConsole
{
    public partial class OptionsDialog : Form
    {
        private readonly int originalReorganizeIndexFragmentationThreshold = Program.Settings.ReorganizeIndexFragmentationThreshold;
        private readonly long originalReorganizeIndexMinimumSize = Program.Settings.ReorganizeIndexMinimumSize;
        private readonly int originalRebuildIndexFragmentationThreshold = Program.Settings.RebuildIndexFragmentationThreshold;
        private readonly long originalRebuildIndexMinimumSize = Program.Settings.RebuildIndexMinimumSize;

        public bool ReloadRequired
        {
            get
            {
                return originalReorganizeIndexFragmentationThreshold != Program.Settings.ReorganizeIndexFragmentationThreshold
                    || originalReorganizeIndexMinimumSize != Program.Settings.ReorganizeIndexMinimumSize
                    || originalRebuildIndexFragmentationThreshold != Program.Settings.RebuildIndexFragmentationThreshold
                    || originalRebuildIndexMinimumSize != Program.Settings.RebuildIndexMinimumSize;
            }
        }

        public OptionsDialog()
        {
            InitializeComponent();
        }

        private void CancelFormButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            // Reorganize Options
            Program.Settings.ReorganizeIndexFragmentationThreshold = (int)ReorganizeThresholdUpDown.Value;
            Program.Settings.ReorganizeIndexMinimumSize = (long)ReorganizeMinimumIndexSizeUpDown.Value;
            Program.Settings.ReorganizeIndexLobCompaction = ReorganizeLobCompactionCheckBox.Checked;
            Program.Settings.ReorganizeIndexCommandTimeout = (int)ReorganizeCommandTimeoutUpDown.Value;

            // Rebuild Options
            Program.Settings.RebuildIndexFragmentationThreshold = (int)RebuildThresholdUpDown.Value;
            Program.Settings.RebuildIndexMinimumSize = (long)RebuildMinimumIndexSizeUpDown.Value;
            Program.Settings.RebuildIndexSortInTempDb = RebuildSortInTempDbCheckBox.Checked;
            Program.Settings.RebuildIndexOnline = RebuildOnlineCheckBox.Checked;
            Program.Settings.RebuildIndexMaxDop = (int)RebuildMaxDopUpDown.Value;
            Program.Settings.RebuildIndexCommandTimeout = (int)RebuildCommandTimeoutUpDown.Value;

            // Save
            Program.Settings.Save();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void OptionsDialog_Load(object sender, EventArgs e)
        {
            DisplayCurrentOptions();
        }

        private void DisplayCurrentOptions()
        {
            // Reorganize Options
            ReorganizeThresholdUpDown.Value = Program.Settings.ReorganizeIndexFragmentationThreshold;
            ReorganizeMinimumIndexSizeUpDown.Value = Program.Settings.ReorganizeIndexMinimumSize;
            ReorganizeLobCompactionCheckBox.Checked = Program.Settings.ReorganizeIndexLobCompaction;
            ReorganizeCommandTimeoutUpDown.Value = Program.Settings.ReorganizeIndexCommandTimeout;

            // Rebuild Options
            RebuildThresholdUpDown.Value = Program.Settings.RebuildIndexFragmentationThreshold;
            RebuildMinimumIndexSizeUpDown.Value = Program.Settings.RebuildIndexMinimumSize;
            RebuildSortInTempDbCheckBox.Checked = Program.Settings.RebuildIndexSortInTempDb;
            RebuildOnlineCheckBox.Checked = Program.Settings.RebuildIndexSortInTempDb;
            RebuildMaxDopUpDown.Value = Program.Settings.RebuildIndexMaxDop;
            RebuildCommandTimeoutUpDown.Value = Program.Settings.RebuildIndexCommandTimeout;
        }

        private void RestoreDefaultsButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure you want to restore the default options?", "Confirm Restore Default Options", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var temp = Program.Settings.LastConnectionString;
                Program.Settings.Reset();
                Program.Settings.LastConnectionString = temp;
                Program.Settings.Save();
                DisplayCurrentOptions();
                MessageBox.Show(this, "Default options have been restored", "Restore Default Options", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();                
            }
        }
    }
}

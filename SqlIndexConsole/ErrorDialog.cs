using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SqlIndexConsole
{
    public partial class ErrorDialog : Form
    {
        public ErrorDialog()
        {
            InitializeComponent();
        }

        public static void ShowDialog(IWin32Window owner, Exception ex)
        {
            Trace.TraceError(ex.Message);
            using (var dlg = new ErrorDialog())
            {
                dlg.ErrorLabel.Text = ex.Message;
                dlg.ShowDialog(owner);
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }
    }
}

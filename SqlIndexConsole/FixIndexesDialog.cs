using SqlIndexConsole.Data.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SqlIndexConsole
{
    public partial class FixIndexesDialog : Form
    {
        public IEnumerable<SqlAction> Actions { get; set; }

        public FixIndexesDialog()
        {
            InitializeComponent();
        }

        private void FixNowButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelFormButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FixIndexesDialog_Load(object sender, EventArgs e)
        {
            DisplaySummary();
            DisplaySqlScript();
        }

        private void DisplaySummary()
        {
            SummaryTextBox.Text = string.Join(Environment.NewLine, Actions.Select(x => x.GetDescription()));
        }

        private void DisplaySqlScript()
        {
            var sb = new StringBuilder();
            string previousDatabaseName = string.Empty;

            foreach (var action in Actions)
            {
                var sql = action.GetSql();
                if (!string.IsNullOrWhiteSpace(sql))
                {
                    if (!action.DatabaseName.Equals(previousDatabaseName, StringComparison.OrdinalIgnoreCase))
                    {
                        sb.AppendLine(string.Format("USE [{0}]", action.DatabaseName));
                        sb.AppendLine("GO");
                        sb.AppendLine();
                        previousDatabaseName = action.DatabaseName;
                    }
                    sb.AppendLine(string.Format("PRINT '{0}';", action.GetStatus().Replace("'", "''")));
                    sb.AppendLine(sql);
                    sb.AppendLine("GO");
                    sb.AppendLine();
                }
            }
            SqlScriptTextBox.Text = sb.ToString();
        }

        private void CopySqlScriptToClipboardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SqlScriptTextBox.Text);
        }

        private void CopySummaryToClipboardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SummaryTextBox.Text);
        }

        private void SummaryTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                SummaryTextBox.SelectAll();
            }
        }

        private void SqlScriptTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                SqlScriptTextBox.SelectAll();
            }
        }
    }
}

using System.Windows.Forms;

namespace SqlIndexConsole
{
    public class DataGridViewCheckBoxFilterCell : DataGridViewCheckBoxCell
    {
        public DataGridViewCheckBoxFilterCell()
            : base()
        {
            TrueValue = true;
            FalseValue = false;
        }
    }
}

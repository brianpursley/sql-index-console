using System.Data.SqlClient;
using System.Threading;

namespace SqlIndexConsole.Data.Actions
{
    public abstract class SqlAction
    {
        public string DatabaseName { get; set; }

        public int CommandTimeout { get; set; }

        public abstract string GetDescription();

        public abstract string GetStatus();

        public abstract string GetSql();

        public bool HasSql()
        {
            return !string.IsNullOrWhiteSpace(GetSql());
        }
    }
}

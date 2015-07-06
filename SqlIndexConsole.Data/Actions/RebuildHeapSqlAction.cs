using System.Text;

namespace SqlIndexConsole.Data.Actions
{
    public class RebuildHeapSqlAction : HeapSqlAction
    {
        public bool SortInTempDb { get; set; }

        public bool? Online { get; set; }

        public int? MaxDop { get; set; }

        public override string GetDescription()
        {
            return string.Format("Rebuild heap (table) {0}.{1}", SchemaName, TableName);
        }

        public override string GetStatus()
        {
            return string.Format("Rebuilding heap (table) {0}.{1}", SchemaName, TableName);
        }

        public override string GetSql()
        {
            var sql = new StringBuilder();
            sql.AppendFormat("ALTER TABLE [{0}].[{1}] REBUILD", SchemaName, TableName);
            sql.AppendFormat(" WITH (SORT_IN_TEMPDB = {0}", SortInTempDb ? "ON" : "OFF");
            if (Online.HasValue)
            {
                sql.AppendFormat(", ONLINE = {0}", Online.Value ? "ON" : "OFF");
            }
            if (MaxDop.HasValue)
            {
                sql.AppendFormat(", MAXDOP = {0}", MaxDop.Value);
            }
            sql.Append(");"); 
            return sql.ToString();
        }
    }
}

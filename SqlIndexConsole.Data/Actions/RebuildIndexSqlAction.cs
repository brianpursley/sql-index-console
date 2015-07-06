using System.Text;

namespace SqlIndexConsole.Data.Actions
{
    public class RebuildIndexSqlAction : IndexSqlAction
    {
        public bool SortInTempDb { get; set; }

        public bool? Online { get; set; }

        public int? MaxDop { get; set; }

        public override string GetDescription()
        {
            return string.Format("Rebuild {0} on {1}.{2}", IndexName, SchemaName, ObjectName);
        }

        public override string GetStatus()
        {
            return string.Format("Rebuilding index {0} on {1}.{2}", IndexName, SchemaName, ObjectName);
        }

        public override string GetSql()
        {
            var sql = new StringBuilder();
            sql.AppendFormat("ALTER INDEX [{0}] ON [{1}].[{2}] REBUILD", IndexName, SchemaName, ObjectName);
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

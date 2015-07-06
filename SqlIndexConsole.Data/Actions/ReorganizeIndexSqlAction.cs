using System.Text;

namespace SqlIndexConsole.Data.Actions
{
    public class ReorganizeIndexSqlAction : IndexSqlAction
    {
        public bool LobCompaction { get; set; }

        public override string GetDescription()
        {
            return string.Format("Reorganize {0} on {1}.{2}", IndexName, SchemaName, ObjectName);
        }

        public override string GetStatus()
        {
            return string.Format("Reorganizing index {0} on {1}.{2}", IndexName, SchemaName, ObjectName);
        }

        public override string GetSql()
        {
            var sql = new StringBuilder();
            sql.AppendFormat("ALTER INDEX [{0}] ON [{1}].[{2}] REORGANIZE", IndexName, SchemaName, ObjectName);
            sql.AppendFormat(" WITH (LOB_COMPACTION = {0})", LobCompaction ? "ON" : "OFF");
            sql.Append(";");
            return sql.ToString();
        }
    }
}

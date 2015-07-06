namespace SqlIndexConsole.Data.Actions
{
    public class SkipReorganizeIndexSqlAction : IndexSqlAction
    {
        public override string GetDescription()
        {
            return string.Format("Skip reorganize {0} on {1}.{2} because it will be rebuilt by a previous heap rebuild", IndexName, SchemaName, ObjectName);
        }

        public override string GetStatus()
        {
            return string.Format("Skipped reorganize index {0} ON {1}.{2} because it was rebuilt by a previous heap rebuild", IndexName, SchemaName, ObjectName);
        }

        public override string GetSql()
        {
            return null;
        }
    }
}

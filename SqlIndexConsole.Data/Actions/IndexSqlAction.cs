namespace SqlIndexConsole.Data.Actions
{
    public abstract class IndexSqlAction : SqlAction
    {
        public string SchemaName { get; set; }

        public string ObjectName { get; set; }

        public string IndexName { get; set; }
    }
}

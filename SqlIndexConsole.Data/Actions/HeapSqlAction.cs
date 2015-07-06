namespace SqlIndexConsole.Data.Actions
{
    public abstract class HeapSqlAction : SqlAction
    {
        public string SchemaName { get; set; }

        public string TableName { get; set; }
    }
}

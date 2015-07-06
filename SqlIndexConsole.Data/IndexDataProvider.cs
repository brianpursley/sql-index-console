using Dapper;
using SqlIndexConsole.Data.Actions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;

namespace SqlIndexConsole.Data
{
    public class IndexDataProvider
    {
        public string ConnectionString { get; private set; }

        #region Constructor

        public IndexDataProvider(string connectionString)
        {
            ConnectionString = connectionString;
            AssertDatabaseIsSpecified();
            AssertSqlServerIsAtLeast2008Version();
        }

        #endregion

        #region SQL

        private const string SelectIndexesSQL =
            @"
                select 
                    @@SERVERNAME as ServerName,
					DB_ID() as DatabaseId,
                    DB_NAME() as DatabaseName,
	                o.[schema_id] as SchemaId,
	                sch.name as SchemaName,
	                i.[object_id] as ObjectId, 
	                o.name as ObjectName,
	                o.[type] as ObjectType,
	                i.index_id as IndexId, 
	                i.name as IndexName, 
	                i.[type] as IndexType, 
	                i.data_space_id as DataSpaceId,
	                ds.name as DataSpaceName,
	                i.is_unique as IsUnique,
	                i.[ignore_dup_key] as IgnoreDupKey,
	                i.is_primary_key as IsPrimaryKey, 
	                i.is_unique_constraint as IsUniqueConstraint, 
					i.is_disabled as IsDisabled,
					fg.is_read_only as IsReadOnlyFileGroup,
                    i.allow_page_locks as AllowPageLocks,
	                i.fill_factor as [FillFactor],
	                i.filter_definition as FilterDefinition
                from sys.indexes i
                inner join sys.objects o
	                on i.[object_id] = o.[object_id]
                inner join sys.schemas sch
	                on o.[schema_id] = sch.[schema_id]
                inner join sys.data_spaces ds
	                on i.data_space_id = ds.data_space_id
				left outer join sys.filegroups fg
					on i.data_space_id = fg.data_space_id
                where o.is_ms_shipped = 0
                    and (o.[type] = 'U' or i.name is not null)
                    and PERMISSIONS(i.[object_id]) & 2 = 2
                order by 
	                SchemaName, 
	                ObjectName, 
	                IndexID
            ";
        
        private const string SelectIndexColumnsSQL =
            @"
                select
	                ic.[object_id] as ObjectId,
	                ic.index_id as IndexId,
	                ic.column_id as ColumnId,
	                c.name as ColumnName,
	                ic.key_ordinal as KeyOrdinal,
	                ic.partition_ordinal as PartitionOrdinal,
	                ic.is_descending_key as IsDescendingKey,
	                ic.is_included_column as IsIncludedColumn
                from sys.index_columns ic
                inner join sys.columns c
	                on ic.[object_id] = c.[object_id]
		                and ic.column_id = c.column_id
                order by ObjectId, key_ordinal
	        ";

        private const string SelectIndexPhysicalStatsSql =
            @"
                select 
                    partition_number as PartitionNumber,
	                alloc_unit_type_desc as AllocUnitTypeDescription,
	                index_depth as IndexDepth,
	                index_level as IndexLevel,
	                round(ips.avg_fragmentation_in_percent, 1) as AvgFragmentationPercent,
	                fragment_count as FragmentCount,
	                round(ips.avg_fragment_size_in_pages, 1) as AvgFragmentSizeInPages,
	                page_count as PageCount,
	                avg_page_space_used_in_percent as AvgPageSpaceUsedInPercent
                from sys.dm_db_index_physical_stats(db_id(), @objectId, @IndexId, null, null) ips
                where alloc_unit_type_desc = 'IN_ROW_DATA'
            ";

        #endregion

        public bool IsEnterpriseEdition()
        {
            var engineEdition = GetScalarValue<int>(string.Format("SELECT SERVERPROPERTY('EngineEdition') AS Value"));
            return engineEdition == 1;
        }

        public string GetServerName()
        {
            return GetScalarValue<string>("select @@ServerName AS Value");
        }

        public string GetDatabaseName()
        {
            return GetScalarValue<string>("select DB_NAME() AS Value");
        }

        public IEnumerable<Index> GetIndexes()
        {
            using (var cn = CreateConnection())
            {                
                var indexes = cn.Query<Index>(SelectIndexesSQL);
                var indexColumns = cn.Query<IndexColumn>(SelectIndexColumnsSQL);
                foreach (var i in indexes)
                {
                    i.Columns = indexColumns
                        .Where(x => x.ObjectId == i.ObjectId && x.IndexId == i.IndexId)
                        .ToArray();
                }
                return indexes;
            }
        }

        public void LoadIndexPhysicalStats(Index index)
        {
            using (var cn = CreateConnection())
            {
                var pss = cn.Query(SelectIndexPhysicalStatsSql, index);
                if (pss.Count() > 0)
                {
                    var ps = pss.First();
                    index.PartitionNumber = ps.PartitionNumber;
                    index.AllocUnitTypeDescription = ps.AllocUnitTypeDescription;
                    index.IndexDepth = ps.IndexDepth;
                    index.IndexLevel = ps.IndexLevel;
                    index.AvgFragmentationPercent = ps.AvgFragmentationPercent;
                    index.FragmentCount = ps.FragmentCount;
                    index.AvgFragmentSizeInPages = ps.AvgFragmentSizeInPages;
                    index.PageCount = ps.PageCount;
                    index.AvgPageSpaceUsedInPercent = ps.AvgPageSpaceUsedInPercent;
                }
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
        public void ExecuteAction(SqlAction action, CancellationTokenSource cts)
        {
            var sql = action.GetSql();
            if (string.IsNullOrWhiteSpace(sql))
            {
                return;
            }
            using (var cn = CreateAsyncConnection())
            using (var cmd = cn.CreateCommand())
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = string.Format("USE {0}; {1}", action.DatabaseName, sql);
                cmd.CommandTimeout = action.CommandTimeout;
                var asyncResult = cmd.BeginExecuteNonQuery();
                while (!asyncResult.AsyncWaitHandle.WaitOne(500))
                {
                    if (cts.IsCancellationRequested)
                    {
                        cmd.Cancel();
                        return;
                    }
                }
                cmd.EndExecuteNonQuery(asyncResult);
            }
        }

        private T GetScalarValue<T>(string sql)
        {
            using (var cn = CreateConnection())
            {
                var result = cn.Query(sql);
                return result.First().Value;
            }
        }

        private SqlConnection CreateConnection()
        {
            var cn = new SqlConnection(ConnectionString);
            cn.Open();
            return cn;
        }

        private SqlConnection CreateAsyncConnection()
        {
            var cn = new SqlConnection(ConnectionString + ";Asynchronous Processing=true;");
            cn.Open();
            return cn;
        }

        private void AssertDatabaseIsSpecified()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(ConnectionString);
            if (string.IsNullOrWhiteSpace(builder.InitialCatalog) && string.IsNullOrWhiteSpace(builder.AttachDBFilename))
            {
                throw new ApplicationException("A database must be specified");
            }
        }

        private void AssertSqlServerIsAtLeast2008Version()
        {
            if (!IsProductVersionAtLeast(10))
            {
                throw new ApplicationException("SQL Server 2008 or later is required");
            }
        }

        private bool IsProductVersionAtLeast(int version)
        {
            var productVersion = GetScalarValue<string>(string.Format("SELECT SERVERPROPERTY('ProductVersion') AS Value"));
            int result = Convert.ToInt32(productVersion.Split('.').First());
            return result >= version;
        }
    }
}

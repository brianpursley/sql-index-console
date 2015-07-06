using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlIndexConsole.Data
{
    public class IndexColumn
    {
        public int ObjectId { get; set; }

        public int IndexId { get; set; }
        
        public int ColumnId { get; set; }
        
        public string ColumnName { get; set; }
        
        public int KeyOrdinal { get; set; }
        
        public int PartitionOrdinal { get; set; }
        
        public bool IsDescendingKey { get; set; }
        
        public bool IsIncludedColumn { get; set; }

        public override string ToString()
        {
            return IsDescendingKey ? string.Concat(ColumnName, " DESC") : ColumnName;
        }
    }
}

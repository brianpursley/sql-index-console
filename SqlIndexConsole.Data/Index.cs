using System.Collections.Generic;
using System.Linq;

namespace SqlIndexConsole.Data
{
    public class Index
    {
        public Index()
        {
            Recommendation = RecommendationEnum.None;
        }

        private static readonly Dictionary<string, string> ObjectTypeDescriptionLookup = new Dictionary<string, string>()
        {
            { "IT", "Internal table" },
            { "S ", "System table" },
            { "U ", "Table" },
            { "V ", "View" }
        };

        private static readonly Dictionary<int, string> IndexTypeDescriptionLookup = new Dictionary<int, string>()
        {
            { 0, "Heap" },
            { 1, "Clustered" },
            { 2, "Nonclustered" },
            { 3, "XML" },
            { 4, "Spatial" },
            { 5, "Clustered columnstore" },
            { 6, "Nonclustered columnstore" },
            { 7, "Nonclustered hash" },
        };

        private readonly IList<string> recommendationReasons = new List<string>();

        public int DatabaseId { get; set; }

        public int SchemaId { get; set; }
        
        public int ObjectId { get; set; }
        
        public int IndexId { get; set; }
        
        public string ServerName { get; set; }
        
        public string DatabaseName { get; set; }
        
        public string SchemaName { get; set; }
        
        public string ObjectName { get; set; }
        
        public string ObjectType { get; set; }
        
        public string IndexName { get; set; }
        
        public int IndexType { get; set; }
        
        public int DataSpaceId { get; set; }
        
        public string DataSpaceName { get; set; }
        
        public bool IsUnique { get; set; }
        
        public bool IgnoreDupKey { get; set; }
        
        public bool IsPrimaryKey { get; set; }
        
        public bool IsUniqueConstraint { get; set; }
        
        public bool IsDisabled { get; set; }
        
        public bool IsReadOnlyFileGroup { get; set; }
        
        public bool AllowPageLocks { get; set; }
        
        public int FillFactor { get; set; }
        
        public string FilterDefinition { get; set; }

        public IList<IndexColumn> Columns { get; internal set; }

        public RecommendationEnum Recommendation { get; private set; }
        
        public string RecommendationReason
        {
            get { return string.Join("; ", recommendationReasons); }
        }

        public int? PartitionNumber { get; set; }
        
        public string AllocUnitTypeDescription { get; set; }
        
        public int? IndexDepth { get; set; }
        
        public int? IndexLevel { get; set; }
        
        public double? AvgFragmentationPercent { get; set; }
        
        public long? FragmentCount { get; set; }
        
        public double? AvgFragmentSizeInPages { get; set; }
        
        public long? PageCount { get; set; }
        
        public double? AvgPageSpaceUsedInPercent { get; set; }

        public string SchemaObjectName
        {
            get { return string.Concat(SchemaName, ".", ObjectName); }
        }

        public string ColumnsDescription
        {
            get { return string.Join(", ", Columns.Where(x => !x.IsIncludedColumn).OrderBy(x => x.KeyOrdinal)); }
        }

        public string IncludedColumnsDescription
        {
            get { return string.Join(", ", Columns.Where(x => x.IsIncludedColumn).OrderBy(x => x.KeyOrdinal)); }
        }

        public string ObjectTypeDescription
        {
            get
            {
                return ObjectTypeDescriptionLookup.ContainsKey(ObjectType) ?
                    ObjectTypeDescriptionLookup[ObjectType] :
                    ObjectType;
            }
        }

        public string IndexTypeDescription
        {
            get
            {
                return IndexTypeDescriptionLookup.ContainsKey(IndexType) ?
                    IndexTypeDescriptionLookup[IndexType] :
                    "Other";
            }
        }

        public bool IsHeap
        {
            get
            {
                return IndexType == 0;
            }
        }

        public bool IsClustered
        {
            get
            {
                return IndexType == 1 || IndexType == 5;
            }
        }

        public void SetError(string reason)
        {
            Recommendation = RecommendationEnum.Error;
            recommendationReasons.Clear();
            recommendationReasons.Add(reason);
        }

        public void SetRecommendation(double reorganizeThreshold, long reorganizeMinPageCountThreshold, double rebuildThreshold, long rebuildMinPageCountThreshold)
        {
            recommendationReasons.Clear();
            if (AvgFragmentationPercent.HasValue)
            {
                if (AvgFragmentationPercent.Value >= rebuildThreshold)
                {
                    if (PageCount.HasValue && PageCount >= rebuildMinPageCountThreshold)
                    {
                        Recommendation = RecommendationEnum.Rebuild;
                        recommendationReasons.Add(string.Format("Fragmentation >= {0}%", rebuildThreshold));
                        return;
                    }
                    if (string.IsNullOrEmpty(RecommendationReason))
                    {
                        recommendationReasons.Add(string.Format(
                            "Index too small to rebuild (pages < {0})", rebuildMinPageCountThreshold));
                    }
                }
                if (AvgFragmentationPercent.Value >= reorganizeThreshold)
                {
                    if (IsHeap)
                    {
                        if (string.IsNullOrEmpty(RecommendationReason))
                        {
                            recommendationReasons.Add("Heaps cannot be reorganized");
                        }
                    }
                    else
                    {
                        if (PageCount.HasValue && PageCount >= reorganizeMinPageCountThreshold)
                        {
                            Recommendation = RecommendationEnum.Reorganize;
                            recommendationReasons.Add(string.Format("Fragmentation >= {0}%", reorganizeThreshold));
                            return;
                        }
                        if (string.IsNullOrEmpty(RecommendationReason))
                        {
                            recommendationReasons.Add(string.Format(
                                "Index too small to reorganize (pages < {0})", reorganizeMinPageCountThreshold));
                        }
                    }
                }
            }
            if (AvgFragmentationPercent.HasValue && AvgFragmentationPercent.Value < rebuildThreshold && AvgFragmentationPercent.Value < reorganizeThreshold)
            {
                if (AvgFragmentationPercent.Value == 0)
                {
                    recommendationReasons.Add("Index is not fragmented");
                }
                else
                {
                    recommendationReasons.Add(
                        string.Format(
                            "Index not fragmented enough to rebuild (frag < {0}%) or reorganize (frag < {1}%)", 
                            rebuildThreshold, 
                            reorganizeThreshold));
                }
            }
            Recommendation = RecommendationEnum.None;
        }
    }
}

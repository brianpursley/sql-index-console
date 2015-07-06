using SqlIndexConsole.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlIndexConsole
{
    internal class IndexViewModel
    {
        private const long SqlServerPageSize = 8192;
        private const double KB = 1024;
        private const double MB = KB * 1024;
        private const double GB = MB * 1024;
        private const double TB = GB * 1024;

        private bool reorganize;
        private bool rebuild;

        public IndexViewModel(Index index)
        {
            Index = index;
        }

        public Index Index { get; private set; }

        public bool RecommendationReady { get; private set; }

        public bool Reorganize
        {
            get 
            { 
                return reorganize; 
            }
            set
            {
                reorganize = value;
                if (reorganize)
                {
                    rebuild = false;
                }
            }
        }

        public bool Rebuild
        {
            get 
            {
                return rebuild; 
            }
            set
            {
                rebuild = value;
                if (rebuild)
                {
                    reorganize = false;
                }
            }
        }

        public string RecommendationDescription
        {
            get
            {
                switch (Index.Recommendation)
                {
                    case RecommendationEnum.Rebuild:
                        return "Rebuild";
                    case RecommendationEnum.Reorganize:
                        return "Reorganize";
                    default:
                        return string.Empty;
                }
            }
        }

        public bool HasRecommendation
        {
            get 
            {
                return Index.Recommendation == RecommendationEnum.Reorganize 
                    || Index.Recommendation == RecommendationEnum.Rebuild;
            }
        }

        public string SchemaName { get { return Index.SchemaName; } }        
        
        public string ObjectName { get { return Index.ObjectName; } }
        
        public string IndexName { get { return Index.IndexName; } }
        
        public string IndexTypeDescription { get { return Index.IndexTypeDescription; } }
        
        public long? PageCount { get { return Index.PageCount; } }
        
        public long? Size { get { return Index.PageCount * SqlServerPageSize;  } }
        
        public double? AvgFragmentationPercent { get { return Index.AvgFragmentationPercent; } }
        
        public string RecommendationReason { get { return Index.RecommendationReason; } }
        
        public string ColumnsDescription { get { return Index.ColumnsDescription; } }
        
        public string IncludeColumnsDescription { get { return Index.IncludedColumnsDescription; } }
        
        public string FilterDefinition { get { return Index.FilterDefinition; } }
        
        public int FillFactor { get { return Index.FillFactor; } }

        public string DataSpaceName { get { return Index.DataSpaceName; } }

        public string SizeDescription
        {
            get
            {
                if (!Size.HasValue)
                {
                    return string.Empty;
                }
                else if (Size.Value == 0)
                {
                    return string.Empty;
                }
                else if (Size.Value < KB)
                {
                    return string.Format("{0:#,##0} B", Size.Value);
                }
                else if (Size.Value < MB)
                {
                    return string.Format("{0:#,##0.#} KB", Size.Value / KB);
                }
                else if (Size.Value < GB)
                {
                    return string.Format("{0:#,##0.#} MB", Size.Value / MB);
                }
                else if (Size.Value < TB)
                {
                    return string.Format("{0:#,##0.#} GB", Size.Value / GB);
                }
                else
                {
                    return string.Format("{0:#,##0.#} TB", Size.Value / TB);
                }
            }
        }

        public Bitmap IsUniqueIcon 
        {
            get 
            {
                return Index.IsUnique ?                    
                    SqlIndexConsole.Properties.Resources.CheckMark_6909_24 :
                    SqlIndexConsole.Properties.Resources.Blank;
            }
        }

        public Bitmap IsPrimaryKeyIcon
        {
            get
            {
                return Index.IsPrimaryKey ?
                    SqlIndexConsole.Properties.Resources.CheckMark_6909_24 :
                    SqlIndexConsole.Properties.Resources.Blank;
            }
        }

        public Bitmap IsUniqueConstraintIcon
        {
            get
            {
                return Index.IsUniqueConstraint ?
                    SqlIndexConsole.Properties.Resources.CheckMark_6909_24 :
                    SqlIndexConsole.Properties.Resources.Blank;
            }
        }

        public void UseRecommendation()
        {
            reorganize = Index.Recommendation == RecommendationEnum.Reorganize;
            rebuild = Index.Recommendation == RecommendationEnum.Rebuild;
            RecommendationReady = true;
        }

        public bool CanReorganize()
        {
            if (Index.Recommendation == RecommendationEnum.Error)
            {
                return false;
            }
            if (Index.IsReadOnlyFileGroup)
            {
                return false;
            }
            if (!Index.AllowPageLocks)
            {
                return false;
            }
            if (Index.IsDisabled)
            {
                return false;
            }
            if (Index.IsHeap)
            {
                return false;
            }
            return true;
        }

        public bool CanRebuild()
        {
            if (Index.Recommendation == RecommendationEnum.Error)
            {
                return false;
            }
            if (Index.IsReadOnlyFileGroup)
            {
                return false;
            }
            return true;
        }
    }
}

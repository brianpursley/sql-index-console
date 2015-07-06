using SqlIndexConsole.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlIndexConsole
{
    internal class SortableBindingList<T> : BindingList<T>
    {
        private bool isSorted;
        private PropertyDescriptor sortProperty;
        private ListSortDirection sortDirection;

        public SortableBindingList(IList<T> list)
            : base(list)
        {            
        }

        protected override bool SupportsSortingCore
        {
            get
            {
                return true;
            }
        }

        protected override bool IsSortedCore
        {
            get
            {
                return isSorted;
            }
        }

        protected override ListSortDirection SortDirectionCore
        {
            get
            {
                return sortDirection;
            }
        }

        protected override PropertyDescriptor SortPropertyCore
        {
            get
            {
                return sortProperty;
            }
        }

        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            if (!IsComparable(prop.PropertyType))
            {
                return;
            }

            var sortedItems = direction == ListSortDirection.Ascending ?
                Items.OrderBy(x => prop.GetValue(x)).ToList() :
                Items.OrderByDescending(x => prop.GetValue(x)).ToList();

            CopyItems(sortedItems, Items);

            sortProperty = prop;
            sortDirection = direction;
            isSorted = true;

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        private static bool IsComparable(Type type)
        {
            if (type == null)
            {
                return false;
            }

            if (type.GetInterface("IComparable") != null)
            {
                return true;
            }

            var underlyingType = Nullable.GetUnderlyingType(type);
            if (underlyingType != null)
            {
                return IsComparable(underlyingType);
            }

            return false;
        }

        private static void CopyItems(IList<T> source, IList<T> dest)
        {
            dest.Clear();
            foreach (var item in source)
            {
                dest.Add(item);
            }
        }
    }
}

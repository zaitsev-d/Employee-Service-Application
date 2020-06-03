using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace Service_Application
{
    class ListViewItemComparer : IComparer
    {
        private int _columnIndex;

        public int ColumnIndex
        {
            get
            {
                return _columnIndex;
            }
            set
            {
                _columnIndex = value;
            }
        }

        private SortOrder _sortDirection;

        public SortOrder SortDirection
        {
            get
            {
                return _sortDirection;
            }
            set
            {
                _sortDirection = value;
            }
        }

        public ListViewItemComparer()
        {
            _sortDirection = SortOrder.None;
        }

        public int Compare(object x, object y)
        {
            ListViewItem listViewItemX = x as ListViewItem;
            ListViewItem listViewItemY = y as ListViewItem;

            int result;

            result = string.Compare(listViewItemX.SubItems[_columnIndex].Text, listViewItemY.SubItems[_columnIndex].Text, false);

            if (_sortDirection == SortOrder.Descending) return -result;
            else return result;
        }
    }
}

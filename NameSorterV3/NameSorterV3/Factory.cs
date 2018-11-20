using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorterV3 {
    public static class Factory {

        public static IListItem CreateListItem(string inputValue) {
            return new ListItem(inputValue);
        }

        public static ISortList CreateSortList() {
            return new SortList();
        }

        /*
        public static ListReader CreateListReader() {
            return new ListReader();
        }
        */

    }

    internal class SortList<T> : SortList {
        public SortList() {
        }
    }
}

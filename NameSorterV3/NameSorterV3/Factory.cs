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
        
        public static IListReader CreateListReader(string fileLocation) {
            return new ListReader(fileLocation);
        }

        public static ITextFileRead CreateTextFileRead(string fileLocation) {
            return new TextFileRead(fileLocation);
        }
        
        public static ITextFileWrite CreateTextFileWrite(string txtMessage, string fileLoc) {
            return new TextFileWrite(txtMessage, fileLoc);
        }

        public static IOutToConsole SendOutToConsole(string txtMessage) {
            return new OutToConsole(txtMessage);
        }

    }

    internal class SortList<T> : SortList {
        public SortList() {
        }
    }
}

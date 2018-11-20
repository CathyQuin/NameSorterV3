using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorterV3 {
    /* -----------------------------------------------------------
     * Author:  Cathryn Gaye Ferguson (Cathy)
     * Date:    12 November 2018
     * Email:   quin.tuplet.72@gmail.com
     * Client:  Globalx - Application for Software Engineer Role
     * -----------------------------------------------------------
     * "Person List" class:  Template for creating a list of Person 
     * objects which are sorted in alphabetical order by Sort Name.
     * 
     * Object: My List (List<T>, where <T> is Person objects).
     * 
     * Depends on: Person class
     * ------------------------------------------------------------
     */
    
    class SortList : ISortList {

        private List<IListItem> MyList;

        public SortList() {
            MyList = new List<IListItem>();
        }

        public int ListCount() {
            return MyList.Count;
        }

        public string GetItemDisplayValue(int inputIndex) {
            return MyList[inputIndex].GetDisplayValue();
        }
        
        public void AddItem(string inputValue) {
            MyList.Add(Factory.CreateListItem(inputValue));
        }

        public void DoSorting() {
            MyList.Sort(delegate (IListItem a, IListItem b) {
                return a.GetSortValue().CompareTo(b.GetSortValue());
            });
        }

        public string OutputList() {
            string OutList = "";
            int ItemCount = ListCount();

            for (int i = 0; i < ItemCount; i++) {
                OutList += GetItemDisplayValue(i) + "\n";
            }

            return OutList;
        }
    }
}

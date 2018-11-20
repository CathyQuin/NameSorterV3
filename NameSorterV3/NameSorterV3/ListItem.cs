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
     * "Person" class:  Template for creating objects which 
     * represent a single person (or name) in the provided data.
     * 
     * Fields:  
     * Print Name (string, name as per provided data and output)
     * Sort Name (string, rearranged to facilitate sorting)
     * 
     * Depends on: None
     * ------------------------------------------------------------
     */
    class ListItem : IListItem {

        private string DisplayValue;
        private string SortValue;

        public ListItem(string inputValue) {
            DisplayValue = inputValue;
            CreateSortValue();
        }

        public string GetDisplayValue() {
            return DisplayValue;
        }

        public string GetSortValue() {
            return SortValue;
        }

        private void CreateSortValue() {

            int DivPos = DisplayValue.LastIndexOf(" "); // find last space character
            string GivenNames = DisplayValue.Substring(0, DivPos); // given names are before it
            string SurName = DisplayValue.Substring(DivPos + 1); // surname is after it
            SortValue = SurName + " " + GivenNames; // swap names and store

        }
    }
}

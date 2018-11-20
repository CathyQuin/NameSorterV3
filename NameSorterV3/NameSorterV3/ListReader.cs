using System;
using System.Collections.Generic;
using System.IO; //remove later
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorterV3 {
    class ListReader : IListReader {

        /* -----------------------------------------------------------
         * Author:  Cathryn Gaye Ferguson (Cathy)
         * Date:    12 November 2018
         * Email:   quin.tuplet.72@gmail.com
         * Client:  Globalx - Application for Software Engineer Role
         * -----------------------------------------------------------
         * "List Reader" class:  Responsible for converting the
         * provided data into a sorted string with line breaks. This is 
         * achieved by reading the text file, converting the data into
         * a sorted list, and returning the data as a formatted string.
         * 
         * Fields/Objects: 
         * My Reader (StreamReader, to access text file)
         * My List (PersonList, to hold retrieved data)
         * New Person (string, parameter to create each new list item)
         * Print List Data (string, returned to caller for output)
         * 
         * Depends on: PersonList class
         * ------------------------------------------------------------
         */

        /* private objects/fields */
        //private StreamReader MyReader; // accesses text file
        private ITextFileRead MyReader;
        private ISortList MyList; // stores imported data
        private string NewPerson; // parameter for new list item
        private string PrintListData; // output data


        /* accesses text file and loads it into MyList */
        public ListReader(string FileLocation) {
            MyReader = Factory.CreateTextFileRead(FileLocation);
            InputList();
        }

        /* returns output data from MyList, as string */
        public string OutputList() {
            PrintListData = MyList.OutputList();
            return PrintListData;
        }

        /* private method to read text data, line-by-line, 
         * adding it to MyList, then calling MyList's 
         * sorting method to process data ready for output */
        private void InputList() {
            MyList = Factory.CreateSortList();

            while ((NewPerson = MyReader.GetLine()) != null) {
                MyList.AddItem(NewPerson);
            }

            MyList.DoSorting();
        }

    }
}

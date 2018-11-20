using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorterV3 {
    class Program {
        static void Main(string[] args) {


            /* file names/locations for input and output text files */
            string InputFileLocation = "./unsorted-names-list.txt";
            string OutputFileLocation = "./sorted-names-list.txt";

            try {

                /* Instantiate reader and retrieve output data */
                IListReader myListReader = Factory.CreateListReader(InputFileLocation);
                string outData = myListReader.OutputList();

                Factory.CreateTextFileWrite(outData, OutputFileLocation);
                Factory.SendOutToConsole(outData);

            }
            catch (FileNotFoundException e) {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }


}

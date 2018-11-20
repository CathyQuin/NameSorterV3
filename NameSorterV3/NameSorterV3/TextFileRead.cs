using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorterV3 {
    public class TextFileRead : ITextFileRead {

        private StreamReader MyReader; // accesses text file

        public TextFileRead(string fileLocation) {
            MyReader = new StreamReader(fileLocation);
        }

        public string GetLine() {
            return MyReader.ReadLine();
        }

        public void Close() {
            MyReader = null;
        }


    }
}

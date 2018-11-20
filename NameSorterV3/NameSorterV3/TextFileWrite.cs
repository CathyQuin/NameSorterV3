using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorterV3 {
    public class TextFileWrite : ITextFileWrite {

        public TextFileWrite(string txtMessage, string fileLocation) {
            StreamWriter sw = new StreamWriter(fileLocation);
            sw.Write(txtMessage);
            sw.Close();
        }
           
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorterV3 {
    public class OutToConsole : IOutToConsole {

        public OutToConsole(string outMessage) {

            /* Write output to console (and wait to exit) */
            Console.Write(outMessage);
            Console.Write("\nPress any key to exit");
            Console.ReadKey();
        }


    }
}

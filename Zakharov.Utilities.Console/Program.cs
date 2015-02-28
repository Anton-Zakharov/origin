using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zakharov.Utilities.Console {
    class Program {
        static void Main(string[] args) {
            CDateTime c_dtToday = new CDateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            System.Console.WriteLine(c_dtToday.Day);

            System.Console.WriteLine("Press Enter to continue...");
            System.Console.ReadLine();
        }
    }
}

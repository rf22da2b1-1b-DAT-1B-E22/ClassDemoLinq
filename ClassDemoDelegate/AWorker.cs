using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoDelegate
{
    public class AWorker
    {
        delegate void PrintNameType(String name);

        public void Start()
        {
            Console.WriteLine("==== En metode ====");
            PrintNameType pNameMethod = null;

            pNameMethod = (s) => { Console.WriteLine("Hej med dig " + s); };

            pNameMethod("Peter");

            Console.WriteLine("==== To metode ====");
            pNameMethod += NamedMethod;
            pNameMethod("Jakob");

            Console.WriteLine("==== En igen metode ====");
            pNameMethod -= NamedMethod;
            pNameMethod("Jamshid");

        }

        protected void NamedMethod(String str)
        {
            Console.WriteLine("Davs " + str);
        }
    }
}

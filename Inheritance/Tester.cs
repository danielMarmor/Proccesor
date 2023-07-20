using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processor.Inheritance
{
    public class Tester
    {

        public static void Process(Processor p, string s)
        {
            Console.WriteLine("Using Processor " + p.Name);
            var result = p.Process(s);
            Console.WriteLine("Result = " + result);
        }
    }
}

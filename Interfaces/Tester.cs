using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Processor.Interfaces;

namespace Processor.Interfaces
{
    public class Tester2
    {
        public static void Process(IProcessor p, string s)
        {
            Console.WriteLine("Using Processor " + p.Name);
            var result = p.Process(s);
            Console.WriteLine("Result = " + result);
        }
    }
}

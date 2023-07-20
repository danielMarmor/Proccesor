using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processor.Inheritance
{
    public class StringSwapper
    {
        public string Swap(string str)
        {
            var arr = str.ToCharArray();
            var iter = arr.Length - 1;
            var result = new List<char>();

            while (true)
            {
                if (iter < 0) break;
                result.Add(arr[iter]);
                iter--;
            }

            var swapStr = string.Join("", result);
            return swapStr;
        }
    }
}

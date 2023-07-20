using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processor.Inheritance
{
    public abstract class Processor
    {
        public string Name => this.GetType().Name;

        public abstract string Process(string str);
    }

    public class UpCase : Processor
    {
        public override string Process(string str)
        {
            return str.ToUpper();
        }
    }
    public class DownCase : Processor
    {
        public override string Process(string str)
        {
            return str.ToLower();
        }
    }
    public class SplitterMark : Processor
    {
        public override string Process(string str)
        {
            return string.Join("!", str.Split(" "));
        }
    }

    public class SwapText : Processor
    {
        public override string Process(string str)
        {
            StringSwapper sw = new StringSwapper();
            return sw.Swap(str);
        }
    }

}

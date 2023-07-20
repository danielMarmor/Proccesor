using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processor.Interfaces
{
    public abstract class StringProcessors : IProcessor
    {
        public string Name => this.GetType().Name;

        public abstract string Process(string str);
    }

    public class StringUpCase : StringProcessors
    {
        public override string Process(string str)
        {
            return str.ToUpper();
        }
    }
    public class StringDownCase : StringProcessors
    {
        public override string Process(string str)
        {
            return str.ToLower();
        }
    }
    public class StringSplitterMark : StringProcessors
    {
        public override string Process(string str)
        {
            return string.Join("!", str.Split(" "));
        }
    }
}

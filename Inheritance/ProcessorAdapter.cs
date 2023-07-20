using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processor.Inheritance
{
    public class ProcessorAdapter : Processor
    {
        StringSwapper _swap;
        public ProcessorAdapter(StringSwapper swap) : base()
        {
            _swap = swap;
        }
        public override string Process(string str)
        {
            var swapText = _swap.Swap(str);
            return swapText;
        }
    }
}

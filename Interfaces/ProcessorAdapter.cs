using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processor.Interfaces
{
    public class ProcessorAdapter : IProcessor
    {
        IStringSwapper _swap;
        public ProcessorAdapter(IStringSwapper swap)
        {
            _swap = swap;
        }
        public string Name => this.GetType().Name;

        public string Process(string str)
        {
            var swapText = _swap.Swap(str);
            return swapText;
        }
    }
}

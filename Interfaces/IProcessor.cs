using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processor.Interfaces
{
    public interface IProcessor
    {
        string Name { get; }
        string Process(string str);
    }

    public class UpCaseContract : IProcessor
    {
        public string Name => this.GetType().Name;

        public string Process(string str)
        {
            return str.ToUpper();
        }
    }
    public class DownCaseByContract : IProcessor
    {
        public string Name => this.GetType().Name;
        public string Process(string str)
        {
            return str.ToLower();
        }
    }
    public class SplitterMarkByContract : IProcessor
    {
        public string Name => this.GetType().Name;
        public string Process(string str)
        {
            return string.Join("!", str.Split(" "));
        }
    }

}

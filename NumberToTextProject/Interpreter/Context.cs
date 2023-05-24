using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToTextProject
{
    public class Context
    {
        long input { get; set; }
        string output { get; set; } = "";

        public Context(long input)
        {
            this.input = input;
        }

        public long Input
        {
            get { return input; }
            set { input = value; }
        }
        public string Output
        {
            get { return output; }
            set { output = value; }
        }
    }
}

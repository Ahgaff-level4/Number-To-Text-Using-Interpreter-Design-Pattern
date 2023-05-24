using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToTextProject.Interpreter
{
    internal class ThousandsExpression : AbstractExpression
    {
        private readonly string largeNumName;
        private readonly long largeNumValue;

        public ThousandsExpression(string largeNumName= "thousand",long largeNumValue=1000) { 
            this.largeNumName= largeNumName;
            this.largeNumValue= largeNumValue;
        }
        public override void Interpret(Context context)
        {
            if (context.Input >= this.largeNumValue)
            {

                AbstractExpression hundrands = new HundredExpression();
                AbstractExpression tens = new TensExpression();
                AbstractExpression ones = new OnesExpression();
                //We divide large number to group of three such as "123456" then "123", and "456" are two different groups.
                //To get the correct group for this class we will use `largeNumValue` such as 1000 then in previous example our group is "123"
                int inputSize = context.Input.ToString().Length;
                int largeNumZeros = this.largeNumValue.ToString().Length - 1;
                string subInputStr = context.Input.ToString().Substring(0, inputSize - largeNumZeros);
                int subInput = int.Parse(subInputStr);
                Context con = new Context(subInput);
                hundrands.Interpret(con);
                tens.Interpret(con);
                ones.Interpret(con);
                context.Output += con.Output.Trim() + " " + this.largeNumName + " ";
                context.Input = RemoveFirst(context.Input, context.Input.ToString().Length - largeNumZeros);
            }
        }
    }
}

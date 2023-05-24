using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToTextProject.Interpreter
{
    internal class HundredExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            if (context.Input >= 100)
            {
                context.Output +=  GetWord(FirstDigit(context.Input)) + " hundred ";
                context.Input = RemoveFirst(context.Input, 1);
            }
        }
    }
}

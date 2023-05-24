using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToTextProject.Interpreter
{
    internal class OnesExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {

            if (context.Output.Trim().Length == 0)
            {
                context.Output += GetWord(context.Input);
                context.Input = RemoveFirst(context.Input, 1);
            }
            else if (context.Input < 10 && context.Input > 0)
            {
                context.Output += GetWord(context.Input) + " ";
                context.Input = RemoveFirst(context.Input, 1);
            }

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToTextProject.Interpreter
{
    internal class MillionsExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            if (context.Input >= 1000000)
            {

                AbstractExpression thousands = new ThousandsExpression();
                AbstractExpression hundrands = new HundredExpression();
                AbstractExpression tens = new TensExpression();
                AbstractExpression ones = new OnesExpression();
                //Get the thousands group. Ex:'123456' thousand group is '123'
                Context con = new Context(long.Parse(context.Input.ToString().Substring(0, context.Input.ToString().Length - 3)));
                thousands.Interpret(con);
                hundrands.Interpret(con);
                tens.Interpret(con);
                ones.Interpret(con);
                context.Output += con.Output.Trim() + " thousand ";
                context.Input = RemoveFirst(context.Input, context.Input.ToString().Length - 3);
            }
        }
    }
}

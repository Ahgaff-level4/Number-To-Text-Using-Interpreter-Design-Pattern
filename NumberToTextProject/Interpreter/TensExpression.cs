using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToTextProject.Interpreter
{
    internal class TensExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            if (context.Input >= 10)
            {
                if (context.Input.ToString().StartsWith("1"))
                {
                    context.Output += GetCompoundWord(context.Input % 10) + " ";
                    context.Input = RemoveFirst(context.Input, 2);
                }
                else
                {
                    context.Output += GetWord(FirstDigit(context.Input)) + " ";
                    context.Input = RemoveFirst(context.Input, 1);
                }
            }
        }

        protected override string GetWord(long number)
        {
            string[] words = {"twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety",
                          "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen",
                          "eighteen", "nineteen"};
            return words[number - 2];
        }

        private string GetCompoundWord(long number)
        {
            string[] numbers = new string[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            return numbers[number % 10];
        }
    }
}

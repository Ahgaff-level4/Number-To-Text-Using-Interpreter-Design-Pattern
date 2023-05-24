using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToTextProject.Interpreter
{
    abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
        protected virtual string GetWord(long number)
        {
            string[] words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            return words[number];
        }
        protected long FirstDigit(long number)
        {
            return long.Parse(number.ToString()[0].ToString());
        }

        /// <returns>Returns substring of `from` number start with `places`. Ex: RemoveFirst(1234,2)=>34</returns>
        protected long RemoveFirst(long from, int places)
        {
            if (from.ToString().Length <= places)
                return 0;
            return long.Parse(from.ToString().Substring(places));
        }
    }
}

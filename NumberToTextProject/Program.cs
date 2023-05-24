using NumberToTextProject.Interpreter;

namespace NumberToTextProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //todo publish this project in Ahgaff-level4 github
            Console.WriteLine("Please, enter a number:");
            while (true)
            {

                string prompt = Console.ReadLine();
                try
                {
                    int number = int.Parse(prompt);
                    List<AbstractExpression> expressions = new List<AbstractExpression>();
                    expressions.Add(new ThousandsExpression("billion", 1000000000));
                    expressions.Add(new ThousandsExpression("million", 1000000));
                    expressions.Add(new ThousandsExpression());
                    expressions.Add(new HundredExpression());
                    expressions.Add(new TensExpression());
                    expressions.Add(new OnesExpression());

                    Context context = new Context(number);
                    foreach (AbstractExpression exp in expressions)
                    {
                        exp.Interpret(context);
                    }
                    Console.WriteLine(context.Output);
                    Console.WriteLine("Please, enter another number:");
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Error: Please enter a valid integer number!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error: Please enter a smaller number!");
                }

            }

        }
    }
}
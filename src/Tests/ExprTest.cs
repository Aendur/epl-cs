using System;
namespace epl_cs
{
    public partial class ExprTest<T> where T : IExpression
    {
        private T Instantiate(int arg)
        {
            return (T)Activator.CreateInstance(typeof(T), args: arg);
        }

        private T Instantiate (params object[] argv)
        {
            return (T) Activator.CreateInstance(typeof(T), args: argv);
        }

        private void WhenPrint(T expr)
        {
            Console.Write("Calling " + expr.GetType() + ".Print "); 
        }

        private void With (int arg)
        {
            Console.Write("with args (" + arg + ") "); 
        }
        private void With (Literal[] args)
        {
            string argstr = "";
            foreach (var i in args)
            {
                argstr += "Literal(" + i.Print + "),";
            }
            Console.Write("with args (" + argstr + ") "); 
        }

        private void Should (string expected)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("should return \"" + expected + "\".");
            Console.ResetColor();
        }

        private bool RunPrint(T expr, string expected)
        {
            if (expr.Print != expected)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Failed, return value was: \"" + expr.Print + '\"');
                Console.ResetColor();
                return false;
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(" Passed, return value was: \"" + expr.Print + '\"');
                Console.ResetColor();
                return true;
            }
        }

        public bool TestPrint(int val1, string expected)
        {
            T expr = Instantiate(val1);
            WhenPrint(expr);
            With(val1);
            Should(expected);
            return RunPrint(expr, expected);
        }

        public bool TestPrint(Literal lit1, Literal lit2, string expected)
        {
            T expr = (T) Activator.CreateInstance(typeof(T), args: (new [] {lit1, lit2}));
            WhenPrint(expr);
            With(new [] { lit1, lit2 });
            Should(expected);
            return RunPrint(expr, expected);


        }
    }
}

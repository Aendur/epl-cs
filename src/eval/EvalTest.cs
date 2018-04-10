#if FEATURE_EVAL

using System;

namespace epl_cs
{
    public partial class ExprTest<T> where T : IExpression
    {
        private void WhenEval(T expr)
        {
            Console.Write("Calling " + expr.GetType() + ".Eval "); 
        }

        private void Should(int expected)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("should return " + expected + ".");
            Console.ResetColor();
        }

        private bool RunEval(T expr, int expected)
        {
            if (expr.Eval != expected)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Failed, return value was: " + expr.Eval);
                Console.ResetColor();
                return false;
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(" Passed, return value was: " + expr.Eval);
                Console.ResetColor();
                return true;
            }
        }

        public bool TestEval(int val1, int expected)
        {
            T expr = Instantiate(val1);
            WhenEval(expr);
            With(val1);
            Should(expected);
            return RunEval(expr, expected);
        }

        public bool TestEval(Literal lit1, Literal lit2, int expected)
        {
            T expr = (T) Activator.CreateInstance(typeof(T), args: (new [] {lit1, lit2}));
            WhenEval(expr);
            With(new [] { lit1, lit2 });
            Should(expected);
            return RunEval(expr, expected);
        }
    }
}

#endif

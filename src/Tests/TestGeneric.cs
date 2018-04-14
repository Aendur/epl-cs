using System;
namespace epl_cs
{
    //class TestGeneric<T> where T : IExpression
    class TestGeneric<V> //where V : struct, class
    {
        private string what;
        private string args;
        private string that;
        V observed;
        V expected;

        public TestGeneric(string what, string args, string that, V observed, V expected) {
            this.what     = what;
            this.args     = args;
            this.that     = that;
            this.observed = observed;
            this.expected = expected;
        }

        private void When()
        {
            Console.Write("WHEN we call " + this.what); 
        }

        private void With()
        {
            Console.Write("WITH args " + this.args); 
        }

        private void Then ()
        {
            Console.Write(", THEN it should ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(this.that);
            Console.ResetColor();
        }

        public bool Run()
        {
            When();
            With();
            Then();
            //if (observed != expected)
            if (!observed.Equals(expected))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed, " + observed + " is not equal to " + expected);
                Console.ResetColor();
                return false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Passed, return value was: " + observed);
                Console.ResetColor();
                return true;
            }
        }
    }
}

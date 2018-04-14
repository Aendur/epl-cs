// using System;
// namespace epl_cs
// {
//     class TestPrint<T> : TestGeneric<T>
//     {
//         TestPrint(int i) {
//             T testObject = CreateInstance(new object[] { i });
//             Run<sting>

//         }

//         public bool TestPrint(int val1, string expected)
//         {
//             T expr = Instantiate(val1);
//             WhenPrint(expr);
//             With(val1);
//             Should(expected);
//             return RunPrint(expr, expected);
//         }

//         public bool TestPrint(Literal lit1, Literal lit2, string expected)
//         {
//             T expr = (T) Activator.CreateInstance(typeof(T), args: (new [] {lit1, lit2}));
//             WhenPrint(expr);
//             With(new [] { lit1, lit2 });
//             Should(expected);
//             return RunPrint(expr, expected);
//         }

//         private void When(string whatExpr)
//         {
//             Console.Write("WHEN we call " + whatExpr); 
//         }

//         private void With (string args)
//         {
//             Console.Write("WITH args " + args); 
//         }

//         private void Then (string that)
//         {
//             Console.Write(", THEN it should ");
//             Console.ForegroundColor = ConsoleColor.Yellow;
//             Console.WriteLine(that);
//             Console.ResetColor();
//         }

//         protected void Run<V>(string what, string args, string that, V obseved, V expected)
//         {
//             When(what);
//             With(args);
//             Then(that);
//             if (observed != expected)
//             {
//                 Console.ForegroundColor = ConsoleColor.Red;
//                 Console.WriteLine("Failed, " + observed " is not equal to " + expected);
//                 Console.ResetColor();
//                 return false;
//             }
//             else
//             {
//                 Console.ForegroundColor = ConsoleColor.Blue;
//                 Console.WriteLine("Passed, return value was: " + observed);
//                 Console.ResetColor();
//                 return true;
//             }
//         }
//     }
// }
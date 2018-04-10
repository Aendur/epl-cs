using System;

namespace epl_cs
{
    class Tests
    {
        static void Main(string[] args)
        {
            int val1 = 20;
            int val2 = 30;
            Literal lit1 = new Literal(val1);
            Literal lit2 = new Literal(val2);

            new ExprTest<Literal>().TestPrint(val1, "20"); //val1.ToString());
            new ExprTest<Literal>().TestPrint(val2, "30"); //val2.ToString());
#if FEATURE_ADD
            new ExprTest    <Add>().TestPrint(lit1, lit2, "( 20 + 30 )");
#endif
#if FEATURE_SUB
            new ExprTest    <Sub>().TestPrint(lit1, lit2, "( 20 - 30 )");
#endif
#if FEATURE_MUL
            new ExprTest    <Mul>().TestPrint(lit1, lit2, "( 20 * 30 )");
#endif

#if FEATURE_EVAL
            new ExprTest<Literal>().TestEval(val1, 20);
            new ExprTest<Literal>().TestEval(val2, 30);
#if FEATURE_ADD
            new ExprTest    <Add>().TestEval(lit1, lit2, 20 + 30);
#endif
#if FEATURE_SUB
            new ExprTest    <Sub>().TestEval(lit1, lit2, 20 - 30);
#endif
#if FEATURE_MUL
            new ExprTest    <Mul>().TestEval(lit1, lit2, 20 * 30);
#endif
#endif

            //Console.ReadLine();
            //return;
        }
    }
}

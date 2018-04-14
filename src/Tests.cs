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

            new TestGeneric<string>("Literal.Print", "20", "return string(20)", lit1.Print, "20").Run();
            new TestGeneric<string>("Literal.Print", "30", "return string(20)", lit2.Print, "30").Run();
#if FEATURE_ADD
            Add add1 = new Add(lit1, lit2);
            new TestGeneric<string>("Add.Print", "Literal(20),Literal(30)", "return \"(20 + 30)\"", add1.Print, "(20 + 30)").Run();
#endif
#if FEATURE_SUB
            Sub sub1 = new Sub(lit1, lit2);
            new TestGeneric<string>("Sub.Print", "Literal(20),Literal(30)", "return \"(20 - 30)\"", sub1.Print, "(20 - 30)").Run();
#endif
#if FEATURE_MUL
            Mul mul1 = new Mul(lit1, lit2);
            new TestGeneric<string>("Mul.Print", "Literal(20),Literal(30)", "return \"(20 * 30)\"", mul1.Print, "(20 * 30)").Run();
#endif

#if FEATURE_EVAL
            new TestGeneric<int>("Literal.Eval", "20", "return 20", lit1.Eval, 20).Run();
            new TestGeneric<int>("Literal.Eval", "30", "return 30", lit2.Eval, 30).Run();
#if FEATURE_ADD
            new TestGeneric<int>("Add.Eval", "Literal(20),Literal(30)", "return 50", add1.Eval, 50).Run();
#endif
#if FEATURE_SUB
            new TestGeneric<int>("Sub.Eval", "Literal(20),Literal(30)", "return -10", sub1.Eval, -10).Run();
#endif
#if FEATURE_MUL
            new TestGeneric<int>("Mul.Eval", "Literal(20),Literal(30)", "return 600", mul1.Eval, 600).Run();
#endif
#endif

#if FEATURE_HEIGHT
            new TestGeneric<int>("Literal.Height", "20", "return 1", lit1.Height, 1).Run();
            new TestGeneric<int>("Literal.Height", "30", "return 1", lit2.Height, 1).Run();
#if FEATURE_ADD
            new TestGeneric<int>("Add.Height", "Literal(20),Literal(30)", "return 3", add1.Height, 2).Run();
            Add add2 = new Add(add1, lit2);
            Add add3 = new Add(lit1, add1);
            new TestGeneric<int>("Add.Height", "Add(Literal(20),Literal(30)),Literal(30)", "return 3", add2.Height, 3).Run();
            new TestGeneric<int>("Add.Height", "Literal(20),Add(Literal(20),Literal(30))", "return 3", add3.Height, 3).Run();
#endif
#if FEATURE_SUB
            new TestGeneric<int>("Sub.Height", "Literal(20),Literal(30)", "return -10", sub1.Height, 2).Run();
            Sub sub2 = new Sub(sub1, lit2);
            Sub sub3 = new Sub(lit1, sub1);
            new TestGeneric<int>("Sub.Height", "Sub(Literal(20),Literal(30)),Literal(30)", "return 3", sub2.Height, 3).Run();
            new TestGeneric<int>("Sub.Height", "Literal(20),Sub(Literal(20),Literal(30))", "return 3", sub3.Height, 3).Run();
#endif
#if FEATURE_MUL
            new TestGeneric<int>("Mul.Height", "Literal(20),Literal(30)", "return 600", mul1.Height, 2).Run();
            Mul mul2 = new Mul(mul1, lit2);
            Mul mul3 = new Mul(lit1, mul1);
            new TestGeneric<int>("Mul.Height", "Mul(Literal(20),Literal(30)),Literal(30)", "return 3", mul2.Height, 3).Run();
            new TestGeneric<int>("Mul.Height", "Literal(20),Mul(Literal(20),Literal(30))", "return 3", mul3.Height, 3).Run();
#endif
#endif

            //Console.ReadLine();
            //return;
        }
    }
}

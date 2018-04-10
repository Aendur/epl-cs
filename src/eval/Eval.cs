namespace epl_cs
{
#if FEATURE_EVAL
    public partial interface IExpression
    {
        int Eval { get; }
    }

    public partial class Literal : IExpression
    {
        public int Eval { get { return this.value; } }
    }

#if FEATURE_ADD
    public partial class Add : IExpression
    {
        public int Eval { get { return this.lhs.Eval + this.rhs.Eval; } }
    }
#endif
#if FEATURE_SUB
    public partial class Sub : IExpression
    {
        public int Eval { get { return this.lhs.Eval - this.rhs.Eval; } }
    }
#endif
#if FEATURE_MUL
    public partial class Mul : IExpression
    {
        public int Eval { get { return this.lhs.Eval * this.rhs.Eval; } }
    }
#endif
#endif
}

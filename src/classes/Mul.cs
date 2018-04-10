#if FEATURE_MUL
namespace epl_cs
{
    public partial class Mul : IExpression
    {
        private IExpression lhs;
        private IExpression rhs;

        public Mul(IExpression lhs, IExpression rhs)
        {
            this.lhs = lhs;
            this.rhs = rhs;
        }

        public string Print
        {
            get
            {
                return "( " + lhs.Print + " * " + rhs.Print + " )";
            }
        }
    }
}
#endif
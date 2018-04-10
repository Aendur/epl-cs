#if FEATURE_SUB
namespace epl_cs
{
    public partial class Sub : IExpression
    {
        private IExpression lhs;
        private IExpression rhs;

        public Sub(IExpression lhs, IExpression rhs)
        {
            this.lhs = lhs;
            this.rhs = rhs;
        }

        public string Print
        {
            get
            {
                return "( " + lhs.Print + " - " + rhs.Print + " )";
            }
        }
    }
}
#endif
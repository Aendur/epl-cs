#if FEATURE_ADD
namespace epl_cs
{
    public partial class Add : IExpression
    {
        private IExpression lhs;
        private IExpression rhs;

        public Add(IExpression lhs, IExpression rhs)
        {
            this.lhs = lhs;
            this.rhs = rhs;
        }

        public string Print
        {
            get
            {
                return "(" + lhs.Print + " + " + rhs.Print + ")";
            }
        }
    }
}
#endif
namespace epl_cs
{
#if FEATURE_HEIGHT
    public partial interface IExpression
    {
        int Height { get; }
    }

    public partial class Literal : IExpression
    {
        public int Height { get { return 1; } }
    }

#if FEATURE_ADD
    public partial class Add : IExpression
    {
        public int Height {
            get
            {
                int lh = 1 + this.lhs.Height;
                int rh = 1 + this.rhs.Height;
                if (lh > rh)
                    return lh;
                else
                    return rh;
            }
        }
    }
#endif
#if FEATURE_SUB
    public partial class Sub : IExpression
    {
        public int Height {
            get
            {
                int lh = 1 + this.lhs.Height;
                int rh = 1 + this.rhs.Height;
                if (lh > rh)
                    return lh;
                else
                    return rh;
            }
        }
    }
#endif
#if FEATURE_MUL
    public partial class Mul : IExpression
    {
        public int Height {
            get
            {
                int lh = 1 + this.lhs.Height;
                int rh = 1 + this.rhs.Height;
                if (lh > rh)
                    return lh;
                else
                    return rh;
            }
        }
    }
#endif
#endif
}

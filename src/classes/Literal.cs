namespace epl_cs
{
    public partial class Literal : IExpression
    {
        private int value;

        public Literal(int val)
        {
            this.value = val;
        }

        public string Print
        {
            get
            {
                return this.value.ToString();
            }
        }
    }
}

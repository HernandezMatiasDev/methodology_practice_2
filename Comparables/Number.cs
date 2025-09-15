namespace methodology
{
    public class Number : INumberComparable
    {
        //valor
        private int value;

        //constructor(v)
        public Number(int value)
        {
            this.value = value;
        }

        // getValor
        public int Value => value;

        public string getValue()
        {
            return value.ToString();
        }

        public bool isEqual(IComparable c)
        {
            return this.Value == ((Number)c).Value;
        }

        public bool isSmaller(IComparable c)
        {
            return this.Value < ((Number)c).Value;
        }
        public bool isBigger(IComparable c)
        {
            return this.Value > ((Number)c).Value;
        }
        public override string ToString()
        {
            return $"Numero: {value}";
        }
    }   
}
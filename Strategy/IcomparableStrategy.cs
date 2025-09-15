namespace methodology
{
    public interface IcomparableStrategy
    {
        //sosIgual
        public bool isEqual(IComparable a, IComparable  b);

        //sosMenor
        public bool isSmaller(IComparable a, IComparable b);

        //sosMayor
        public bool isBigger(IComparable a, IComparable b);

        public string getValue(IComparable a);
    }
}
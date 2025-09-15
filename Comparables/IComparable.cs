namespace methodology
{
    public interface IComparable
    {
        //sosIgual
        public bool isEqual(IComparable c);

        //sosMenor
        public bool isSmaller(IComparable c);

        //sosMayor
        public bool isBigger(IComparable c);
    }
}
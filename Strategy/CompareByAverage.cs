namespace methodology
{
    public class CompareByAverage : IcomparableStrategy
    {
        //sosIgual
        public bool isEqual(IComparable a, IComparable b) => ((Student)a).getAverage() == ((Student)b).getAverage();

        //sosMenor
        public bool isSmaller(IComparable a, IComparable b) => ((Student)a).getAverage() < ((Student)b).getAverage();

        //sosMayor
        public bool isBigger(IComparable a, IComparable b) => ((Student)a).getAverage() > ((Student)b).getAverage();

        public string getValue(IComparable a) => ((Student)a).getAverage().ToString();
    }
}
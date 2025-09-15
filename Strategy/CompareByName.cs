namespace methodology
{
    public class CompareByName : IcomparableStrategy
    {
        //sosIgual
        public bool isEqual(IComparable a, IComparable b) => ((Person)a).getName() == ((Person)b).getName();

        //sosMenor
        public bool isSmaller(IComparable a, IComparable b) => ((Person)a).getName().CompareTo(((Person)b).getName()) < 0;

        //sosMayor
        public bool isBigger(IComparable a, IComparable b) => ((Person)a).getName().CompareTo(((Person)b).getName()) > 0;
        
        public string getValue(IComparable a) => ((Person)a).getName().ToString();
    }
}

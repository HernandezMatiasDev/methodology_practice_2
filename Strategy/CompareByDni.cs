namespace methodology
{
    public class CompareByDni : IcomparableStrategy
    {
        //sosIgual
        public bool isEqual(IComparable a, IComparable b) => ((Person)a).getDni() == ((Person)b).getDni();

        //sosMenor
        public bool isSmaller(IComparable a, IComparable b) => ((Person)a).getDni() < ((Person)b).getDni();

        //sosMayor
        public bool isBigger(IComparable a, IComparable b) => ((Person)a).getDni() > ((Person)b).getDni();

        public string getValue(IComparable a) => ((Person)a).getDni().ToString();
    }
}
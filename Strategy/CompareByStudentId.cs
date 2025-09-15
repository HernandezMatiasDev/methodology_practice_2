namespace methodology
{
    public class CompareByStudentId: IcomparableStrategy
    {
        //sosIgual
        public bool isEqual(IComparable a, IComparable b) => ((Student)a).getStudentID() == ((Student)b).getStudentID();

        //sosMenor
        public bool isSmaller(IComparable a, IComparable b) => ((Student)a).getStudentID() < ((Student)b).getStudentID();

        //sosMayor
        public bool isBigger(IComparable a, IComparable b) => ((Student)a).getStudentID() > ((Student)b).getStudentID();

        public string getValue(IComparable a) => ((Student)a).getStudentID().ToString();
    }
}
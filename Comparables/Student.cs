namespace methodology
{
    public class Student : Person, IUseCompareStrategy
    {
        //legajo
        private int studentID;

        //promedio
        private double average;

        private IcomparableStrategy comparableStrategy;

        public Student(string name, int dni, int id, double average) : base(name, dni)
        {
            this.studentID = id;
            this.average = average;
            comparableStrategy = new CompareByStudentId();
        }

        public int getStudentID() => studentID;
        public double getAverage() => average;

        public void setStrategy(IcomparableStrategy comparableStrategy)
        {
            this.comparableStrategy = comparableStrategy;
        }
        public override string getValue()
        {
            return comparableStrategy.getValue(this);
        }

        public override bool isEqual(IComparable c)
        {
            return comparableStrategy.isEqual(this, (Student)c);
        }

        public override bool isSmaller(IComparable c)
        {
            return comparableStrategy.isSmaller(this, (Student)c);
        }
        public override bool isBigger(IComparable c)
        {
            return comparableStrategy.isBigger(this, (Student)c);
        }

        // Use este metodo porque lo necesite en print_student_list de Funcions
        public override string ToString()
        {
            return $"Nombre: {name}, DNI: {dni}, Legajo: {studentID}, Promedio: {average}";
        }
    }
}
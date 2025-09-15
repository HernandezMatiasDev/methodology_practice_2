namespace methodology
{
    public abstract class Person: INumberComparable
    {
        //nombre
        protected string name;

        //dni
        protected int dni;

        //constructor(n, d)
        public Person(string name, int dni)
        {
            this.name = name;
            this.dni = dni;
        }


        //getNombre
        public string getName() => name;

       //getDNI
        public int getDni() => dni;

        public virtual string getValue()
        {
            return dni.ToString();
        }


        public virtual bool isEqual(IComparable c)
        {
            return this.dni == ((Person)c).dni;
        }

        public virtual bool isSmaller(IComparable c)
        {
            return this.dni < ((Person)c).dni;
        }
        public virtual bool isBigger(IComparable c)
        {
            return this.dni > ((Person)c).dni;
        }
    }
}
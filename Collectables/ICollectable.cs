namespace methodology
{
    public interface ICollectable
    {
        //cuantos
        public int amount();

        //minimo
        public IComparable minimum();

        //maximo
        public IComparable maximum();

        //agregar(Comparable)
        public void add(IComparable c);

        //contiene(Comparable) 
        public bool contains(IComparable c);

        // esta funcion la aguregue para poder comprar por un valor y no con otro IComparable
        public bool containsValue(string value);
    }
}
namespace methodology
{
    //Conjunto
    public class UniqueCollection : Collectable
    {
        public override void add(IComparable c)
        {
            if (!this.contains(c))
            {
                elements.Add(c);
            }
            else
            {
                // no quiero tener que controlar la expecion
                // throw new InvalidOperationException("El elemento ya existe en la coleccion");
                Console.WriteLine("El elemento ya existe en la coleccion");
            }
            
        }

    }
}
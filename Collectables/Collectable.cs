using System.Collections.Generic;

namespace methodology
{
    public abstract class Collectable : ICollectable, Iterated
    {
        protected List<IComparable> elements = new List<IComparable>();

        // Necesite el get para la funcion print_collectable y print_student_list de Funcions.cs
        public List<IComparable> GetElements()
        {
            return elements;
        }

        public int amount() => elements.Count;
        public IComparable minimum()
        {
            if (this.amount() == 0)
            {
                throw new InvalidOperationException("La lista esta vacia");
            }
            IComparable min = elements[0];
            for (int i = 1; i < amount(); i++)
            {
                if (elements[i].isSmaller(min))
                {
                    min = elements[i];
                }
            }
            return min;
        }
        public IComparable maximum()
        {
            if (this.amount() == 0)
            {
                throw new InvalidOperationException("La lista esta vacia");
            }
            IComparable max = elements[0];
            for (int i = 1; i < amount(); i++)
            {
                if (elements[i].isBigger(max))
                {
                    max = elements[i];
                }
            }
            return max;
        }
        public virtual void add(IComparable c)
        {
            elements.Add(c);
        }

        public bool contains(IComparable c)
        {
            foreach (IComparable element in elements)
            {
                if (element.isEqual(c))
                {
                    return true;
                }
            }
            return false;
        }

        // compara si lo ingresado ingresado por parametro es igual al value de algun elemento
        // esta funcion fue necesaria para poder buscar por value sin tener que crear un objeto
        /// <summary>
        /// Solo usar esta funcion si los objetos son INumberComparable
        /// </summary>
        public bool containsValue(string value)
        {
            foreach (INumberComparable element in elements)
            {
                if (element.getValue() == value)
                {
                    return true;
                }
            }
            return false;
        }

        public Iiterator createIterator()
        {
            return new ListIterator(this.elements);
        }
    }
}
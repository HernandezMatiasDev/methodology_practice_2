namespace methodology
{
    public class MultipleCollection : ICollectable
    {
        private ICollectable stack;
        private ICollectable queue;

        /// <summary>
        /// Ingresar como primer parametro la pila y como segundo la cola
        /// </summary>
        /// <param name="s">Pila</param>
        /// <param name="q">Cola</param>
        public MultipleCollection(ICollectable s, ICollectable q)
        {
            this.stack = s;
            this.queue = q;

        }

        public int amount()
        {
            return queue.amount() + stack.amount();
        }

        public IComparable minimum()
        {
            Number queueMinNum = (Number)queue.minimum();
            Number stackMinNum = (Number)stack.minimum();

            if (queueMinNum.isSmaller(stackMinNum))
            {
                return queueMinNum;
            }
            else
            {
                return stackMinNum;
            }

        }


        public IComparable maximum()
        {
            Number queueMaxNum = (Number)queue.maximum();
            Number stackMaxNum = (Number)stack.maximum();

            if (queueMaxNum.isBigger(stackMaxNum))
            {
                return queueMaxNum;
            }
            else
            {
                return stackMaxNum;
            }

        }

        public void add(IComparable c)
        {
            //empty function
        }

        public bool contains(IComparable c)
        {
            return queue.contains(c) || stack.contains(c);
        }
        public bool containsValue(string value)
        {
            return queue.containsValue(value) || stack.containsValue(value);
        }
    }
}
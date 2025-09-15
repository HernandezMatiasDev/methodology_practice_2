namespace methodology
{
    public class Stack : Collectable
    {
        public void pop()
        {
            elements.RemoveAt(amount() - 1);
        }
    }
}
namespace methodology
{
    public class Queue : Collectable
    {
        public void deQueue()
        {
            elements.RemoveAt(0);
        }
    }
}
namespace methodology
{
    public interface Iiterator
    {
        // primero
        void First();        

        // siguiente 
        void Next();     

        // fin     
        bool End();        

        // actual
        IComparable Current(); 

    }
}
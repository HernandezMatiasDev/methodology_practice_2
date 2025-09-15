using System;

namespace methodology
{
    class Program
    {
        static void Main(string[] args)
        {
            Collectable stack = new Stack();
            Collectable queue = new Queue();
            Collectable unique = new UniqueCollection();

            // MultipleCollection multiple = new MultipleCollection(stack, queue);

            // Funcions.random_load_num(stack);
            // Funcions.random_load_num(queue);


            // Funcions.inform(stack);
            // Funcions.inform(queue);
            // Funcions.inform(multiple);

            Funcions.randomLoadStudents(stack, new CompareByStudentId());
            Funcions.randomLoadStudents(queue, new CompareByStudentId());
            Funcions.randomLoadStudents(unique, new CompareByStudentId());


            // Funcions.printCollectable(stack);
            // Funcions.printCollectable(queue);
            Funcions.printCollectable(unique);

            Funcions.inform(stack);
            Funcions.changeStrategy(stack, new CompareByAverage());
            Funcions.inform(stack);
            Funcions.changeStrategy(stack, new CompareByDni());
            Funcions.inform(stack);
            Funcions.changeStrategy(stack, new CompareByName());
            Funcions.inform(stack);

        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;

namespace methodology
{
    public static class Funcions
    {
        private static Random random = new Random();

        // Lista con los nombres de los estudiantes
        private static List<string> studentsNames;

        // Ruta del archivo con los nombres
        private static string filepath = "./names.txt";

        //llenar(Coleccionable)
        public static void random_load_num(ICollectable collectable, int load = 20)
        {
            for (int i = 0; i < load; i++)
            {
                int random_value = random.Next(1, 101);
                IComparable comparable = new Number(random_value);
                collectable.add(comparable);
            }

        }

        //informar(Coleccionable)
        public static void inform(ICollectable collectable)
        {
            Console.WriteLine($"Información de {collectable.GetType().Name}:");
            Console.WriteLine($"La {collectable.GetType().Name} tiene {collectable.amount()} elementos");
            Console.WriteLine($"El valor minimo de la {collectable.GetType().Name} es {((INumberComparable)collectable.minimum()).getValue()}");
            Console.WriteLine($"El valor maximo de la {collectable.GetType().Name} es {((INumberComparable)collectable.maximum()).getValue()}");

            if (collectable.containsValue(value_by_keyboard()))
            {
                Console.WriteLine("El valor introducido esta en la coleccion");
            }
            else
            {
                Console.WriteLine("El valor introducido no se encuentra en la coleccion");
            }


        }
        public static string value_by_keyboard()
        {
            Console.Write("Ingrese un valor: ");
            string input = Console.ReadLine();
            return input;
        }
        public static int Number_by_keyboard()
        {
            int value = 0;
            bool valid = false;

            while (!valid)
            {
                Console.Write("Ingrese un numero: ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out value))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Entrada invalida, por favor ingrese un numero: ");
                }
            }
            return value;
        }

        //Cree esta funcion porque queria ver los valores de los Coleccionables
        public static void print_collectable(ICollectable collectable)
        {
            foreach (INumberComparable c in ((Collectable)collectable).GetElements())
            {
                Console.WriteLine(((INumberComparable)c).getValue());
            }
        }


        public static void loadNames()
        {
            if (File.Exists(filepath))
            {
                studentsNames = new List<string>(File.ReadAllLines(filepath));
            }
            else
            {
                throw new FileNotFoundException("No se encontro el archivo de nombres: " + filepath);
            }
        }

        public static void randomLoadStudents(ICollectable collectable, IcomparableStrategy comparableStrategy, int load = 20)
        {
            loadNames();
            if (studentsNames == null || studentsNames.Count == 0)
                throw new Exception("La lista de nombres no fue cargada o este vacia.");

            for (int i = 0; i < load; i++)
            {
                string name = studentsNames[random.Next(studentsNames.Count)];
                int dni = random.Next(10000000, 50000000);
                int studentID = random.Next(1000, 9999);
                double average = Math.Round(random.NextDouble() * 10, 2);

                Student student = new Student(name, dni, studentID, average);
                student.setStrategy(comparableStrategy);
                collectable.add(student);
            }
        }

        public static void changeStrategy(Collectable collectable, IcomparableStrategy comparableStrategy)
        {
            Iiterator iterator = collectable.createIterator();
            while (!iterator.End())
            {
                ((IUseCompareStrategy)iterator.Current()).setStrategy(comparableStrategy);
                iterator.Next();
            }
        }
        public static void printCollectable(Collectable collectable)
        {
            Iiterator iterator = collectable.createIterator();
            while (!iterator.End())
            {
                Console.WriteLine(iterator.Current().ToString());
                iterator.Next();
            }

        }
    }
}

using System;

namespace CreatingClass
{
    class Program
    {

        public enum Genders { Male, Female }; 

        static void Main(string[] args)
        {
            Person david = new Person("David", DateTime.Now, 0);
            Console.WriteLine(david.ToString());

            Room room = new Room(8);
            Emlpoyee _david = new Emlpoyee("David", DateTime.Now, 0, "Programmer", 1000, room);
            Console.WriteLine(_david.ToString());

            Emlpoyee Kovacs = new Emlpoyee("Géza", DateTime.Now, 0, "léhűtő", 1000, room);
            Emlpoyee Kovacs2 = (Emlpoyee)Kovacs.Clone();
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();
        }
    }
}
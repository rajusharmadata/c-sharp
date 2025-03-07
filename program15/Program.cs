using System;
using System.Linq; // Language Integrated Query

namespace MyNamespace // Corrected namespace
{
    // Inheritance
    class Vehicle  // Fixed spelling mistake (Vechical → Vehicle)
    {
        public string brand = "Ford";

        public void Fork()
        {
            Console.WriteLine("This is Fork Method");
        }
    }

    class Car1 : Vehicle
    {
        public Car1() // Constructor should be public
        {
            Console.WriteLine("This is Car1 constructor");
        }
    }

    class Car2 : Car1
    {
        public Car2() // Constructor should be public
        {
            Console.WriteLine("Car2 Constructor call");
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Car2 obj = new Car2();
            obj.Fork(); // Corrected method call (removed Console.WriteLine)
        }
    }
}
using System;
using System.Linq; // Language Integrated Query

namespace MyNamespace // Corrected namespace
{
    // Inheritance
    class Vehicle  // Fixed spelling mistake (Vechical → Vehicle)
    {
        public string brand = "Ford";

        public void Fork()
        {
            Console.WriteLine("This is Fork Method");
        }
    }

    class Car1 : Vehicle
    {
        public Car1() // Constructor should be public
        {
            Console.WriteLine("This is Car1 constructor");
        }
    }

    class Car2 : Car1
    {
        public Car2() // Constructor should be public
        {
            Console.WriteLine("Car2 Constructor call");
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Car2 obj = new Car2();
            obj.Fork(); // Corrected method call (removed Console.WriteLine)
        }
    }
}

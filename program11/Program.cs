using System;
using System.Linq;// Language integrated Query
namespace std
{
    class main
    {
        // function  defenation 
        static void printHello()
        {
            Console.WriteLine("Hello world");
        }
        // function defanation 
        static void printname(string str, int age)
        {
            Console.WriteLine(str + "is " + age);
        }
        static void Main(string[] args)
        {
            // function  calling 
            printname("Raju ", 18);
            printname("shayam ", 18);


        }
    }
}
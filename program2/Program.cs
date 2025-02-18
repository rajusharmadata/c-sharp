using System;

namespace radea
{
    public class kk
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Corrected way to call the method
            first.print();
            play.printplayer();  // No need to create an object since print() is static.
        }
    }

    public class first
    {
        public static void print()
        {
            Console.WriteLine("Hello first");
        }
    }
}

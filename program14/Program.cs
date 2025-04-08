using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace std
{
    class main
    {
        string color = "red";
        string color2 = "pink";

        static long plusMethodLong(long x, long y)
        {
            return x + y;
        }

        static string plusMethodString(string x, string y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            // // multiple object in one class 
            // long sum = plusMethodLong(4,5);
            // string str = plusMethodString("FirstName  ","LastName");
            // Console.WriteLine(sum);// sum 
            //  Console.WriteLine(str);// Concenet two string 
            // /// obj n
            // main obj = new main();
            // main obj2 = new main();
            // Console.WriteLine(obj.color);
            // Console.WriteLine(obj2.color2);

            int num = 10; // int to string 
            string str = Convert.ToString(num);
            Console.WriteLine("Convert into string: " + str);

            // conversion double to int
            double num1 = 99.3d;
            int ans = (int)num1;
            Console.WriteLine("Convert double to int: " + ans);
            int n = Convert.ToInt32(Console.ReadLine());

            if(n>0){
                Console.WriteLine("Positive");
            }
             if(n<0){
                Console.WriteLine("Negative");
            }
            else{
                Console.WriteLine("Zero");
            }
        }
    }
}
using System;
using System.Linq;// Language integrated Query
namespace std
{
    class main
    {
     string color = "red";
     string color2 = "pink";
    static long plusMethodLong(long x,long y){
        return x+y;
    }
    static string plusMethodString(string x,string y){
        return x+y;
    }
      
        static void Main(string[] args)
        {
            // multiple object in one class 
            long sum = plusMethodLong(4,5);
            string str = plusMethodString("FirstName  ","LastName");
            Console.WriteLine(sum);// sum 
             Console.WriteLine(str);// Concenet two string 
            /// obj 
            main obj = new main();
            main obj2 = new main();
            Console.WriteLine(obj.color);
            Console.WriteLine(obj2.color2);

          
        }
    }
}
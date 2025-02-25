using System;
using System.Linq;// Language integrated Query
namespace std
{
    class main
    {
     
        string color = "red";
        string colorblue = "blue";
      
        static void Main(string[] args)
        {
            // multiple object in one class 
            main myobj = new main();
            main myobj2 = new main();
            Console.WriteLine(myobj.color);
            Console.WriteLine(myobj2.colorblue);
     
        }
    }
}
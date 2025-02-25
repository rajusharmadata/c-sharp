using System;
using System.Linq;// Language integrated Query
namespace std
{
    class main
    {
        // How to handle function overloading 

        //--> so funtion overlading 
       static int PluseMethodInt(int x,int y){
        return x+y;
       }

       static double PluseMethodDouble(double x,double y){
        return x+y;
       }
        static void Main(string[] args)
        {
            // function  overloading 
           int ans = PluseMethodInt(4,5);
           double result = PluseMethodDouble(4.2,6.35);
           Console.WriteLine("Two integer  sum = " + ans);
           Console.WriteLine("Two Double  sum = " + result);

        }
    }
}
// Take to number input 

using System;
namespace std{
    class program6{
        static void Main(string [] args){
            Console.WriteLine("Enter First number ");
            int num1 = Convert.ToInt32(Console.ReadLine());// Take a integer input 
            Console.WriteLine("Enter Second number ");
            int num2 = Convert.ToInt32(Console.ReadLine());// Take a integer input 
            int sum = num1+ num2;
            Console.WriteLine("sum = " + sum);
        }
    }
}
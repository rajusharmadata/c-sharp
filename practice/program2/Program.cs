using System;
namespace std{
    class program{
        static void Main(string[] args){
            Console.WriteLine("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            // // print fibonacci series
            // int a = 0; // first turm
            // int b = 1;  
            // int c = 0;
            // Console.Write("[ ");   // for better look of output 
            // for(int i = 0;i<n;i++){
            //     Console.Write(a + " ");
            //     c = a+b; // This line is the main logic of fibonacci series
            //     a = b;// reasing a to b
            //     b = c;// reasing b to c
            // }
            // Console.WriteLine("]"); // for better look of output

           Factorial fact  = new Factorial();
              fact.Factorial(n);
    }
}
}
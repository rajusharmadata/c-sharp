using System;
using System.Linq;
namespace std {
    class main{
         static void Main(string[] args){
            int[] arr = {4,3,7,2,8,1};
            Array.Sort(arr);
            // foreach(int i in arr){
            //     Console.WriteLine(i);
            // }

            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Sum());


         }
    }
}
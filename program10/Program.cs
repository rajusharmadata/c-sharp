using System;
using System.Linq;// Language integrated Query
namespace std
{
    class main
    {
        static void Main(string[] args)
        {
            // 2d array 
            // intilize array 
            int[,] numbers = {
            {1,4,2},{3,6,8}
           };

            numbers[0, 0] = 5;

            //    Console.WriteLine(numbers[0,2]);
            // Console.WriteLine(numbers[0, 0]);

            //    foreach(int i in numbers){
            //     Console.WriteLine(i);
            //    }

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for(int j = 0;j<numbers.GetLength(1);j++){
                    Console.WriteLine(numbers[i,j]);
                }

            }

            {


            }


        }
    }
}
using System;// This contain console functiona
namespace Raju // providing memory space for program body 
{
    class program // for storing  recalling object ,method and data
    {
        static void Main(string[] args) // for convert any undefind data to string 
        {
        //   Array  -- unhandle excepation error
        //string [] cars = {"volvo","sfhdsh","udgfdh","hdfjd"};
        
        //cars[0] = "Raju"; // reasing
        //Console.WriteLine(cars[0]);

        // Length  
       // Console.WriteLine(cars.Length);

       string[]cars;
       cars = new string[] {"volvo","raju ", "my car"};
       //Console.WriteLine(cars[2]);
      
      // using for loop
      for(int i = 0; i<cars.Length;i++){
        Console.WriteLine(cars[i]);
      }

        }
    }
}
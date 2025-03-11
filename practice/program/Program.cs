using System ;
namespace std
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to check prime or not");
            int n = Convert.ToInt32(Console.ReadLine());
            Prime obj = new Prime();
            bool ans = n>1 ? obj.PrimeNUM(n) : false;
            Console.WriteLine(ans);
        }
    }
}
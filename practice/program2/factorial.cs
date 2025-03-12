class factorial
{
  public  void Factorial(int n)
    {
        int fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }
        System.Console.WriteLine("Factorial of " + n + " is " + fact);
    }
}
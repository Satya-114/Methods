using System;

namespace Method4
{
    class Program
    {
        static int factorial(int n)
        {
            int f = 1;

           
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
            }

            return f;
        }

        
        static void Main(string[] args)
        {
            int p = 4;

            
            Console.WriteLine("Factorial is : " + factorial(p));
        }
    }
}
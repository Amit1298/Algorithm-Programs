using System;

namespace PrimeNumberExm
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsPrime = true;
            int i, j;
            Console.WriteLine("Prime Number is : ");
            for (i = 2; i <= 100; i++)
            {
                for (j = 2; j <= 100; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                if (IsPrime)
                {
                    Console.WriteLine("\n" + i);
                }
                IsPrime = true;
            }
        }
    }
}

using System;

namespace Factorial
{
    class Program
    {
        static int Factorial(int i)
        {
            if (i <= 1)
            {
                return 1;
            }
            return i * Factorial(i-1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Factorial(5));
        }
    }
}

using System;

namespace VP_Assignment__1

{
    internal class Q6
    {// FactorialCalculator
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine() ?? "0");
            long fact = 1;
            int i = 1;

            while (i <= num)
            {
                fact *= i;
                i++;
            }

            Console.WriteLine($"Factorial of {num} = {fact}");
        }
    }
}

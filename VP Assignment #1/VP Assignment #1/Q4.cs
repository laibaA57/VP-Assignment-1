using System;

namespace VP_Assignment__1
{
    internal class Q4
    {//SumOfNaturalNumbers
        public static void Run()
        {
            Console.Write("Enter a number (n): ");
            int n = int.Parse(Console.ReadLine() ?? "0");
            int sum = 0;

            for (int i = 1; i <= n; i++)
                sum += i;

            Console.WriteLine($"Sum of first {n} natural numbers = {sum}");
        }
    }
}

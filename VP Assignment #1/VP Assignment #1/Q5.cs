using System;

namespace VP_Assignment__1
{
    internal class Q5
    {//MultiplicationTable
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine($"\nMultiplication Table of {num}:");
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{num} x {i} = {num * i}");
        }
    }
}

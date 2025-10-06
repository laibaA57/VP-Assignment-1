using System;

namespace VP_Assignment__1
{
    internal class Q1
    {//EvenOrOdd
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine() ?? "0");

            if (num % 2 == 0)
                Console.WriteLine(num+" is Even.");
            else
                Console.WriteLine(num+" is Odd.");
        }
    }
}

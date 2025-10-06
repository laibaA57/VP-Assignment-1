using System;

namespace VP_Assignment__1
{
    internal class Q7
    {
        //ReverseNumber
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine() ?? "0");
            int rev = 0;

            while (num > 0)
            {
                int digit = num % 10;
                rev = rev * 10 + digit;
                num /= 10;
            }

            Console.WriteLine($"Reversed number = {rev}");
        }
    }
}

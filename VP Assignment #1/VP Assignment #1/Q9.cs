using System;

namespace VP_Assignment__1
{
    internal class Q9
    {//ArrayEvenOdd
        public static void Run()
        {
            int[] arr = new int[10];
            int evenCount = 0, oddCount = 0;

            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = int.Parse(Console.ReadLine() ?? "0");
                if (arr[i] % 2 == 0) evenCount++;
                else oddCount++;
            }

            Console.WriteLine($"Even numbers: {evenCount}");
            Console.WriteLine($"Odd numbers: {oddCount}");
        }
    }
}

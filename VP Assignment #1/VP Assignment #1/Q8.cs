using System;

namespace VP_Assignment__1
{
    internal class Q8
    {//ArrayMaxMin
        public static void Run()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 numbers:");

            for (int i = 0; i < 10; i++)
                arr[i] = int.Parse(Console.ReadLine() ?? "0");

            int max = arr[0];
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }

            Console.WriteLine($"Maximum = {max}, Minimum = {min}");
        }
    }
}

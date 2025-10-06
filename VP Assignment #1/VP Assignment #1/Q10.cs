using System;

namespace VP_Assignment__1
{
    internal class Q10
    {// ArraySearch
        public static void Run()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < 10; i++)
                arr[i] = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter a number to search: ");
            int search = int.Parse(Console.ReadLine() ?? "0");

            bool found = false;
            foreach (int num in arr)
            {
                if (num == search)
                {
                    found = true;
                    break;
                }
            }

            if (found)
                Console.WriteLine($"{search} exists in the array.");
            else
                Console.WriteLine($"{search} not found in the array.");
        }
    }
}

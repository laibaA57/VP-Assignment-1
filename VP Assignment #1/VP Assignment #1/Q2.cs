using System;

namespace VP_Assignment__1
{
    internal class Q2
    {//SimpleCalculator
        public static void Run()
        {
            double num1, num2;
            char op;

            Console.Write("Enter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            op = Convert.ToChar(Console.ReadLine());

            if (op == '+')
            {
                Console.WriteLine("Result = " + (num1 + num2));
            }
            else if (op == '-')
            {
                Console.WriteLine("Result = " + (num1 - num2));
            }
            else if (op == '*')
            {
                Console.WriteLine("Result = " + (num1 * num2));
            }
            else if (op == '/')
            {
                if (num2 != 0)
                    Console.WriteLine("Result = " + (num1 / num2));
                else
                    Console.WriteLine("Error: Division by zero!");
            }
            else
            {
                Console.WriteLine("Invalid operator!");
            }
        }
    }
}

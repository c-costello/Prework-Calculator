using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello! Enter your first number: ");
            string firstNumStr = Console.ReadLine();
            Console.Write("Enter your second number: ");
            string secondNumStr = Console.ReadLine();
            int firstNum = Convert.ToInt32(firstNumStr);
            int secondNum = Convert.ToInt32(secondNumStr);
                       
            Add(firstNum, secondNum);
            Subtract(firstNum, secondNum);
            Console.ReadLine();
        }

        //Declares add function with two arguments
        public static void Add(int x, int y)
        {
            int sum = x + y;
            Console.Write("Sum = " + sum);
        }
        //Declases subtract function with two arguments
        public static void Subtract(int x, int y)
        {
            int difference = x - y;
            Console.Write("Difference = " + difference);
        }

    }
}

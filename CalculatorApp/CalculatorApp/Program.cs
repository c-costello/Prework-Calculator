using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            Add(2, 3);
        }
        public static void Add(int x, int y)
        {
            int sum = x + y;
            Console.Write("Sum = " + sum);
            Console.ReadLine();
        } 
    }
}

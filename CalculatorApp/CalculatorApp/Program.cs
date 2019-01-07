using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool for breaking the loop
            bool runn = true;
            //loop that re-runs code until user is done doing math
            while ( runn == true)
            {
                //code block that captures user input
                Console.Write("First Number: ");
                string firstNumStr = Console.ReadLine();
                Console.Write("Operator (+ , - , * , / ): ");
                string whichOpp = Console.ReadLine();
                Console.Write("Second Number: ");
                string secondNumStr = Console.ReadLine();
                double firstNum = double.Parse(firstNumStr);
                double secondNum = double.Parse(secondNumStr);

                //Conditional that determines which math function is called
                if (whichOpp == "+")
                {
                    Add(firstNum, secondNum);
                }
                else if (whichOpp == "-")
                {
                    Subtract(firstNum, secondNum);
                }
                else if (whichOpp == "*")
                {
                    Multiply(firstNum, secondNum);
                }
                else if (whichOpp == "/")
                {
                    Divide(firstNum, secondNum);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
                Console.Write("Begin Again? y/n: ");
                string resp = Console.ReadLine();
                //conditional that breaks the loop if the user is done doing math
                if (resp == "n")
                {
                    runn = false;
                }
            }
        }

        //Declares add function with two arguments
        public static void Add(double x, double y)
        {
            double sum = x + y;
            Console.WriteLine("Sum = " + sum);
        }
        //Declares subtract function with two arguments
        public static void Subtract(double x, double y)
        {
            double difference = x - y;
            Console.WriteLine("Difference = " + difference);
        }
        //Declares multiply function with two arguments
        public static void Multiply(double x, double y)
        {
            double product = x * y;
            Console.WriteLine("Product = " + product);
        }
        //Declares divition function with two arguments
        public static void Divide(double x, double y)
        {
            double quotient = x / y;
            Console.WriteLine("Quotient = " + quotient);
        }

    }
}

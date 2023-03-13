using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            char operation;
            string anotherOp;

            Console.WriteLine("Welcome to the Calculator!");

            do
            {
                Console.Write("Enter the first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the operation (+, -, *, /): ");
                operation = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        Console.WriteLine($"The sum of {num1} and {num2} is {result}.");
                        break;

                    case '-':
                        result = num1 - num2;
                        Console.WriteLine($"The difference between {num1} and {num2} is {result}.");
                        break;

                    case '*':
                        result = num1 * num2;
                        Console.WriteLine($"The product of {num1} and {num2} is {result}.");
                        break;

                    case '/':
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: division by zero.");
                        }
                        else
                        {
                            result = num1 / num2;
                            Console.WriteLine($"The quotient of {num1} and {num2} is {result}.");
                        }
                        break;

                    default:
                        Console.WriteLine("Error: invalid operation.");
                        break;
                }

                Console.Write("Do you want to perform another operation? (Yes/No): ");
                anotherOp = Console.ReadLine().ToLower();

                if (anotherOp == "yes")
                {
                    Console.Clear();
                }

            } while (anotherOp == "yes");

            Console.WriteLine("Thank you for using the Calculator!");
            Console.ReadKey();
        }
    }
}


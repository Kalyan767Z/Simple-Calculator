using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Number 1: ");
            if (!double.TryParse(Console.ReadLine(), out double number1))
            {
                Console.WriteLine("\nInvalid number");
                return;
            }
            Console.Write("Number 2: ");

            if (!double.TryParse(Console.ReadLine(), out double number2))
            {
                Console.WriteLine("\nInvalid number");
                return;
            }
            
            Console.WriteLine("Enter the symbol of operacion (+ - * /");
            Console.Write("Your answer: ");
            char.TryParse(Console.ReadLine(), out char operation);

            switch (operation)
            {
                case '+':
                    Console.WriteLine("\nResult of adding = " + (number1 + number2));
                    break;

                case '-':
                    Console.WriteLine("\nResult of subtraction = " + (number1 - number2));
                    break;

                case '*':
                    Console.WriteLine("\nResult of multiplication = " + (number1 * number2));
                    break;

                case '/':
                    if (number2 != 0)
                    {
                        Console.WriteLine("\nResult of division = " + (number1 / number2));
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nDivision by 0 is not possible");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("\nInvalid operation");
                        break;
                    }
            }
        }
    }
}

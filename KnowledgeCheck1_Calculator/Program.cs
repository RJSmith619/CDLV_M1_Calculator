using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter 2 integers to add");
                    
                    if (int.TryParse(calculator.NumberEntry(), out int addNumOne) && int.TryParse(calculator.NumberEntry(), out int addNumTwo))
                    {
                        Console.Write($"{addNumOne} + {addNumTwo} = ");
                        Console.Write(calculator.Add(addNumOne, addNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "2":
                    Console.WriteLine("Enter 2 integers to subtract");

                    if (int.TryParse(calculator.NumberEntry(), out int subNumOne) && int.TryParse(calculator.NumberEntry(), out int subNumTwo))
                    {
                        Console.Write($"{subNumOne} - {subNumTwo} = ");
                        Console.Write(calculator.Subtract(subNumOne, subNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "3":
                    // Add code here
                    Console.WriteLine("Enter 2 integers to multiply");

                    if (int.TryParse(calculator.NumberEntry(), out int multNumOne) && int.TryParse(calculator.NumberEntry(), out int multNumTwo))
                    {
                        Console.Write($"{multNumOne} * {multNumTwo} = ");
                        Console.Write(calculator.Multiply(multNumOne, multNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }

                    break;

                case "4":
                    Console.WriteLine("Enter 2 integers to divide");

                    if (double.TryParse(calculator.NumberEntry(), out double divNumOne) && double.TryParse(calculator.NumberEntry(), out double divNumTwo))
                    {
                        Console.Write($"{divNumOne} / {divNumTwo} = ");
                        Console.Write(calculator.Divide(divNumOne, divNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }
    }
}
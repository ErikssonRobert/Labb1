using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            Calculator calc = new Calculator();

            while (run)
            {
                Console.Clear();
                Console.WriteLine("1. Add two numbers\n" +
                                  "2. Multiply two numbers\n" +
                                  "3. Sum the numbers between two numbers\n" +
                                  "4. Add number to memory\n" +
                                  "5. Clear memory\n" +
                                  "6. Print calculator contents\n" +
                                  "7. Quit");
                Console.Write("Please type a number from the menu: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        GetFirstAndSecondNumber();
                        Add();
                        Console.ReadLine();
                        break;
                    case 2:
                        GetFirstAndSecondNumber();
                        Multiply();
                        Console.ReadLine();
                        break;
                    case 3:
                        GetFirstAndSecondNumber();
                        Sum();
                        Console.ReadLine();
                        break;
                    case 4:
                        AddNumberToMemory();
                        Console.ReadLine();
                        break;
                    case 5:
                        ClearMemory();
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine(calc.ToString());
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("Goodbye!");
                        run = false;
                        break;
                    default:
                        break;
                }
            }


            void GetFirstAndSecondNumber()
            {
                Console.Write("Please type the first number: ");
                calc.FirstNumber = int.Parse(Console.ReadLine());
                Console.Write("Please type the second number: ");
                calc.SecondNumber = int.Parse(Console.ReadLine());
            }

            void GetNumber()
            {
                Console.Write("Please type the number: ");
                calc.NumberInMemory = int.Parse(Console.ReadLine());
            }

            void AddNumberToMemory()
            {
                GetNumber();
                Console.WriteLine("Number successfully added to memory.");
            }

            void ClearMemory()
            {
                calc.NumberInMemory = 0;
                Console.WriteLine("Number in memory cleared.");
            }

            void Add()
            {
                Console.WriteLine("Sum of {0} + {1} = {2}", 
                                  calc.FirstNumber, 
                                  calc.SecondNumber, 
                                  calc.SumNumbers());
            }

            void Multiply()
            {
                Console.WriteLine("Sum of {0} * {1} = {2}", 
                                  calc.FirstNumber, 
                                  calc.SecondNumber, 
                                  calc.MultiplyNumbers());
            }

            void Sum()
            {
                Console.WriteLine("Sum of {0} to {1} = {2}",
                                  calc.FirstNumber,
                                  calc.SecondNumber,
                                  calc.SumInBetween());
            }
        }
    }
}

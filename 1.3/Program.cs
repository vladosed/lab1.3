using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloOperators_stud
{
    class Program
    {
        static void Main(string[] args)
        {
            long a;
            Console.WriteLine(@"Please,  type the number:
            1. Farmer, wolf, goat and cabbage puzzle
            2. Console calculator
            3. Factirial calculation
            ");

            a = long.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Farmer_puzzle();
                    Console.WriteLine("");
                    break;
                case 2:
                    Calculator();
                    Console.WriteLine("");
                    break;
                case 3:
                    Factorial_calculation();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
        #region farmer
        static void Farmer_puzzle()
        {
            //Key sequence: 3817283 or 3827183
            int number1, number2, number3, number4, number5, number6, number7;
            int tFarmerAndWolf = 1, tFarmerAndCabbage = 2, tFarmerAndGoat = 3, tFatmer = 4, bFarmerAndWolf = 5, bFarmerAndCabbage = 6, bFarmerAndGoat = 7, bFarmer = 8;
            bool check;
            // Declare 7 int variables for the input numbers and other variables
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"From one bank to another should carry a wolf, goat and cabbage. 
At the same time can neither carry nor leave together on the banks of a wolf and a goat, 
a goat and cabbage. You can only carry a wolf with cabbage or as each passenger separately. 
You can do whatever how many flights. How to transport the wolf, goat and cabbage that all went well?");
            Console.WriteLine("There: farmer and wolf - 1");
            Console.WriteLine("There: farmer and cabbage - 2");
            Console.WriteLine("There: farmer and goat - 3");
            Console.WriteLine("There: farmer  - 4");
            Console.WriteLine("Back: farmer and wolf - 5");
            Console.WriteLine("Back: farmer and cabbage - 6");
            Console.WriteLine("Back: farmer and goat - 7");
            Console.WriteLine("Back: farmer  - 8");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please,  type numbers by step ");
            number1 = int.Parse(Console.ReadLine());
            if (number1 == tFarmerAndGoat)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Please, type the next number: ");
                number2 = int.Parse(Console.ReadLine());

                if (number2 == bFarmer)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Please, type the next number: ");
                    number3 = int.Parse(Console.ReadLine());
                    check = (number3 == tFarmerAndWolf) || (number3 == tFarmerAndCabbage);

                    if (check == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Please, type the next number: ");
                        number4 = int.Parse(Console.ReadLine());

                        if (number4 == bFarmerAndGoat)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Please, type the next number: ");
                            number5 = int.Parse(Console.ReadLine());
                            check = (number5 == tFarmerAndCabbage) || (number5 == tFarmerAndWolf);

                            if (check == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Please, type the next number: ");
                                number6 = int.Parse(Console.ReadLine());

                                if (number6 == bFarmer)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Please, type the next number: ");
                                    number7 = int.Parse(Console.ReadLine());

                                    if (number7 == tFarmerAndGoat)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Success :)");
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Failure :(");
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Failure :(");
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Failure :(");
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Failure :(");
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Failure :(");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Failure :(");
                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failure :(");
            }

            // Implement input and checking of the 7 numbers in the nested if-else blocks with the  Console.ForegroundColor changing

        }
        #endregion

        #region calculator
        static void Calculator()
        {
            // Set Console.ForegroundColor  value
            Console.WriteLine(@"Select the arithmetic operation:
1. Multiplication 
2. Divide 
3. Addition 
4. Subtraction
5. Exponentiation ");
            string number = Console.ReadLine();
            float firstNumber, secondNumber;
            Console.WriteLine("Enter first number: ");
            firstNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            secondNumber = float.Parse(Console.ReadLine());
            switch (number)
            {
                case "1":
                    Console.WriteLine("The result of the multiplication is: {0}", firstNumber * secondNumber);
                    return;
                case "2":
                    Console.WriteLine("The result of the division is: {0}", firstNumber / secondNumber);
                    return;
                case "3":
                    Console.WriteLine("The result of the addition is: {0}", firstNumber + secondNumber);
                    return;
                case "4":
                    Console.WriteLine("The result of the subtraction is: {0}", firstNumber - secondNumber);
                    return;
                case "5":
                    Console.WriteLine("The result of the exponentation is: {0}", Math.Pow(firstNumber, secondNumber));
                    return;
                default:
                    Console.WriteLine("default case");
                    return;
            }
            // Implement option input (1,2,3,4,5)
            //     and input of  two or one numbers
            //  Perform calculations and output the result 
        }
        #endregion

        #region Factorial
        static void Factorial_calculation()
        {
            Console.WriteLine("Enter your number: ");
            int num = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("Result: {0}", factorial);

            // Implement input of the number
            // Implement input the for circle to calculate factorial of the number
            // Output the result
        }
        #endregion
    }
}

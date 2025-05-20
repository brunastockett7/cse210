// See https://aka.ms/new-console-template for more information

using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayWelcome();
            string userName = PromptUserName();
            int favoriteNumber = PromptUserNumber();
            int squared = SquareNumber(favoriteNumber);
            DisplayResult(userName, squared);
        }

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine()!;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string? input = Console.ReadLine();
            int number;
            while (!int.TryParse(input, out number))
            {
                Console.Write("Invalid input. Enter a valid integer: ");
                input = Console.ReadLine();
            }
            return number;
        }

        static int SquareNumber(int number)
        {
            return number * number;
        }

        static void DisplayResult(string name, int squaredNumber)
        {
            Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
        }
    }
}


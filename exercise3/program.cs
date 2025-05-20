// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        bool playAgain;

        do
        {
            int magicNumber = randomGenerator.Next(1, 101);
            int guess;
            int guessCount = 0;

            Console.WriteLine("Guess My Number game!");
            Console.WriteLine("I'm thinking of a number between 1 and 100.");

            do
            {
                Console.Write("Enter your guess: ");
                string? input = Console.ReadLine();

                while (!int.TryParse(input, out guess))
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                    input = Console.ReadLine();
                }

                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {guessCount} guesses!");
                }

            } while (guess != magicNumber);

            Console.Write("Do you want to play again? (yes/no): ");
            string? response = Console.ReadLine()?.ToLower();

            playAgain = (response == "yes");

        } while (playAgain);

        Console.WriteLine("Thanks for playing!");
    }
}


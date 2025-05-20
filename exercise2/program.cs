// See https://aka.ms/new-console-template for more information

using System;

Console.Write("Enter your grade percentage: ");
string? input = Console.ReadLine();

int grade;
while (!int.TryParse(input, out grade))
{
    Console.Write("Invalid input. Please enter a valid grade percentage (0-100): ");
    input = Console.ReadLine();
}

string letter;

if (grade >= 90)
    letter = "A";
else if (grade >= 80)
    letter = "B";
else if (grade >= 70)
    letter = "C";
else if (grade >= 60)
    letter = "D";
else
    letter = "F";

Console.WriteLine($"Your letter grade is: {letter}");

if (grade >= 70)
    Console.WriteLine("Congratulations, you passed the course!");
else
    Console.WriteLine("Don't give up! Try harder next time.");


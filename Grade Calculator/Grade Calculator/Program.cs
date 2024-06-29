// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Grade Calculator");
        Console.Write("Enter a numerical grade between 0 and 100: ");

        string? input = Console.ReadLine();

        if (input != null && int.TryParse(input, out int grade))
        {
            if (grade >= 0 && grade <= 100)
            {
                char letterGrade = CalculateLetterGrade(grade);
                Console.WriteLine($"The letter grade is: {letterGrade}");
            }
            else
            {
                Console.WriteLine("Error: Grade must be between 0 and 100.");
            }
        }
        else
        {
            Console.WriteLine("Error: Invalid input. Please enter a valid number.");
        }
    }

    static char CalculateLetterGrade(int grade)
    {
        if (grade >= 90) return 'A';
        if (grade >= 80) return 'B';
        if (grade >= 70) return 'C';
        if (grade >= 60) return 'D';
        return 'F';
    }
}


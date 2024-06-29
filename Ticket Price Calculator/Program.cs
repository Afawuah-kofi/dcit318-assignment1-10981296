// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        const int regularPrice = 10;
        const int discountedPrice = 7;

        Console.Write("Enter your age: ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int age) && age >= 0)
        {
            int ticketPrice = (age <= 12 || age >= 65) ? discountedPrice : regularPrice;
            Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }
}
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Triangle Type Identifier");

        // Input for the three sides
        double side1 = GetValidSideLength("Enter the length of side 1: ");
        double side2 = GetValidSideLength("Enter the length of side 2: ");
        double side3 = GetValidSideLength("Enter the length of side 3: ");

        // Determine and display the triangle type
        string triangleType = IdentifyTriangleType(side1, side2, side3);
        Console.WriteLine($"The triangle is: {triangleType}");
    }

    static double GetValidSideLength(string prompt)
    {
        double side;
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out side) && side > 0)
            {
                return side;
            }
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }
    }

    static string IdentifyTriangleType(double side1, double side2, double side3)
    {
        if (side1 == side2 && side2 == side3)
        {
            return "Equilateral";
        }
        else if (side1 == side2 || side2 == side3 || side1 == side3)
        {
            return "Isosceles";
        }
        else
        {
            return "Scalene";
        }
    }
}

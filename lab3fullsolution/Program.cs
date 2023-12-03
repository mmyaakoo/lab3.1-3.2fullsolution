using System;


class Program
{
    static void Main()
    {
        // Get input from the user
        Console.Write("Enter the length of side 1: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 2: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        // Create an instance of the Rectangle class
        Rectangle rectangle = new Rectangle(side1, side2);

        // Display rectangle information
        Console.WriteLine($"Rectangle Perimeter: {rectangle.Perimeter}");
        Console.WriteLine($"Rectangle Area: {rectangle.Area}");

        // Keep the console window open
        Console.ReadLine();
    }
}

using System;



class Program
{
    static void Main()
    {
        // Create points for the figure
        Point point1 = new Point(0, 0, "A");
        Point point2 = new Point(0, 3, "B");
        Point point3 = new Point(4, 0, "C");

        // Create an instance of the Figure class with 3 points
        Figure triangle = new Figure(point1, point2, point3);

        // Calculate and display the perimeter of the figure
        triangle.CalculatePerimeter();

        // Keep the console window open
        Console.ReadLine();
    }
}

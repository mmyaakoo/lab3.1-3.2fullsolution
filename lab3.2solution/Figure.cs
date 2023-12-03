class Figure
{
    private Point[] points;

    public Figure(Point point1, Point point2, Point point3)
    {
        points = new Point[] { point1, point2, point3 };
    }

    public Figure(Point point1, Point point2, Point point3, Point point4)
    {
        points = new Point[] { point1, point2, point3, point4 };
    }

    public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
    {
        points = new Point[] { point1, point2, point3, point4, point5 };
    }

    private double GetSideLength(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    public void CalculatePerimeter()
    {
        double perimeter = 0;
        int numPoints = points.Length;

        for (int i = 0; i < numPoints; i++)
        {
            Point currentPoint = points[i];
            Point nextPoint = points[(i + 1) % numPoints]; // Circular iteration to connect the last and first points

            perimeter += GetSideLength(currentPoint, nextPoint);
        }

        Console.WriteLine($"Figure Perimeter: {perimeter}");
    }
}

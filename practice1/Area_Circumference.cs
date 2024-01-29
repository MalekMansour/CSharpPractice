// Basic C# Program to calculate the area and the circumference of a circle by using the radius
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = CalculateArea(radius);
        double circumference = CalculateCircumference(radius);

        Console.WriteLine($"Area of the circle: {area}");
        Console.WriteLine($"Circumference of the circle: {circumference}");
    }

    static double CalculateArea(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    static double CalculateCircumference(double radius)
    {
        return 2 * Math.PI * radius;
    }
}

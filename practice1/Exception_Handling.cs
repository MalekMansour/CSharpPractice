using System;
public class Circle
{
    private double Radius;

    public void SetRadius(double radius) => Radius = radius > 0 ? radius : throw new InvalidRadiusException(radius);

    public override string ToString() => Radius > 0 ? $"Circle with Radius: {Radius}" : throw new InvalidRadiusException(Radius);
}

public class InvalidRadiusException : Exception
{
    public InvalidRadiusException(double radius) : base(radius > 0 ? $"Invalid Radius: {radius}" : $"Invalid Radius: {radius}. Radius must be greater than 0.") { }
}

class Program
{
    static void Main(string[] args)
    {
        PrintValidCircle(6);
        PrintValidCircle(-2);
        PrintValidCircle(0);
        Console.ReadKey();
    }

    static void PrintValidCircle(double radius)
    {
        try
        {
            var circle = new Circle();
            circle.SetRadius(radius);
            Console.WriteLine(circle);
        }
        catch (InvalidRadiusException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

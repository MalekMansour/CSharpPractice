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
        try
        {
            Circle Circle1 = new Circle();
            Circle1.SetRadius(9);
            Console.WriteLine(Circle1);
        }
        catch (InvalidRadiusException ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            Circle Circle2 = new Circle();
            Circle2.SetRadius(-4);
            Console.WriteLine(Circle2);
        }
        catch (InvalidRadiusException ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            Circle Circle3 = new Circle();
            Circle3.SetRadius(0);
            Console.WriteLine(Circle3);
        }
        catch (InvalidRadiusException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadKey();
    }
}

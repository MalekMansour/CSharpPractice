using system;

namespace Hypotenuse
{
    internal class Hypotenuse
    {
        static void Main5(string[] args)
        {
            Console.WriteLine("Enter side a for the triangle: ");
            double a  = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side b for the triangle: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt((a*a) + (b * b));
            Console.WriteLine($"The Hypotenuse is : {c}");

            Console.ReadKey();
        }
    }
}

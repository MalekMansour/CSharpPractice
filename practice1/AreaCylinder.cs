using System;

namespace Examples
{
    class AreaCylinder
    {
        // Base or Parent class
        class Circle
        {
            public double Radius { get; set; }            

            public double Area_Cr()
            {
                return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
            }
            
        }

        // Derived or child class
        class Cylinder : Circle
        {
            public double Height { get; set; }            

            public double Area_Cy()
            {
                return Math.Round(2 * Math.PI * Radius * Height + 2 * Area_Cr(), 2);
            }
        }

        static void Main1(string[] args)
        {
            Console.WriteLine("Working on Circle Object");
            Circle circle = new Circle();
            circle.Radius = 10.0;
            Console.WriteLine($"Circle with radius {circle.Radius} has area as: {circle.Area_Cr()}");

            Console.WriteLine("\nWorking on Cylinder Object");
            Cylinder cylinder = new Cylinder();
            cylinder.Radius = 7.0;
            cylinder.Height = 20.0;
            Console.WriteLine($"Cylinder with base radius {cylinder.Radius} and Height {cylinder.Height} has area as: {cylinder.Area_Cy()}");

            Console.ReadKey();
        }
    }
}

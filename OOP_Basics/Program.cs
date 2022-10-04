// Madde Lundström NET22
using System;

namespace OOP_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            _ = new Circle(5);                                                              // Instance of class Circle with argument for radius
            Console.WriteLine();                                                            // For cleaner look in output
            _ = new Circle(6);                                                              // "_" because VS told me to do so 
            Console.WriteLine();                                                            // first I wrote Circle C1 = new Circle(6);
                                                                                            // but was told since C1 wasnt used I should use _
            _ = new Triangle(4);                                                            
            Console.WriteLine();
            _ = new Triangle(9);                                                            // Instance of class Triangle with argument for side
        }
    }
    public class Circle                                                                     // New class
    {
        public float pi = 3.14f;                                                            // Public class field
        public int radius;                                                                  // Public class field
        public Circle(int radius)                                                           // Constructor of Circle class with int parameter
        {
            this.radius = radius;                                                           // Makes so the global variable/field is reached and the same as local
            Console.Write("En cirkel med radie {0} cm har arean: ", radius);                
            Console.WriteLine(GetArea(radius) + " cm");                                     
            Console.Write("En cirkel med radie {0} cm har omkretsen: ", radius);
            Console.WriteLine(GetCircum(radius) + " cm");
        }
        float GetArea(int radius)                                                           // Method to calculate area based on radius
        {
            this.radius = radius;
            float area = radius * radius * pi;                                              // Area calculation
            return area;                                                                    // Returns area calculation
        }
        float GetCircum(int radius)                                                         // Method to calculate circumference based on radius
        {
            this.radius = radius;
            float circum = 2 * pi * radius;                                                 // Circumference calculation
            return circum;                                                                  // Returns circumference calculation
        }  
    }
    public class Triangle
    {
        public int side;                                                                    // Public class field
        public Triangle(int side)                                                           // Constructor of Triangle class with int parameter
        {
            this.side = side;
            Console.Write("En triangel med {0} cm långa sidor har arean: ", side);
            Console.WriteLine(GetArea(side) + " cm");
            Console.Write("En triangel med {0} cm långa sidor har omkretsen: ", side);
            Console.WriteLine(GetCircum(side) + " cm");
        }
        float GetArea(int side)                                                             // Method to calculate area based on side
        {
            this.side = side;
            float area = side * side / 2;                                                   // Area calculation
            return area;                                                                    // Returns area calculation
        }
        float GetCircum(int side)                                                           // Method to calculate circumference based on side
        {
            this.side = side;
            float circum = side * 3;                                                        // Circumference calculation
            return circum;                                                                  // Returns circumference calculation
        }
    }
}

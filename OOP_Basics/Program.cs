// Madde Lundström NET22
using System;

namespace OOP_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            _ = new Circle(5);                                                              // Instance of class Circle with argument for radius
            Console.WriteLine();                                                            // WriteLine added for better looking output
            _ = new Circle(6);                                                              // Output of info happens in method
            Console.WriteLine();                                             
                                                                                            
            Triangle T1 = new Triangle(4);                                                  // Instance of class Triangle with argument for side variable        
            Triangle T2 = new Triangle(9);                                                  
            Console.Write("En triangel med {0} cm långa sidor har arean: ", T1.side);       // Output info
            Console.WriteLine(T1.GetArea(T1.side) + " cm");                                 // Output info
            Console.Write("En triangel med {0} cm långa sidor har omkretsen: ", T2.side);
            Console.WriteLine(T2.GetCircum(T2.side) + " cm");
        }
    }
    public class Circle                                                                     // New class
    {
        public float pi = 3.14f;                                                            // Public class field
        public int radius;                                                                  // Public class field
        public Circle(int radius)                                                           // Constructor of Circle class with int parameter
        {
            this.radius = radius;                                                           // Makes so the global variable/field is reached and the same as local
            Console.Write("En cirkel med radie {0} cm har arean: ", radius);                // Output happens in method
            Console.WriteLine(GetArea(radius) + " cm");                                     // Output happens in method
            Console.Write("En cirkel med radie {0} cm har omkretsen: ", radius);
            Console.WriteLine(GetCircum(radius) + " cm");
        }
        public float GetArea(int radius)                                                    // Method to calculate area based on radius
        {
            this.radius = radius;
            float area = radius * radius * pi;                                              // Area calculation
            return area;                                                                    // Returns area calculation
        }
        public float GetCircum(int radius)                                                  // Method to calculate circumference based on radius
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
        }
        public float GetArea(int side)                                                      // Method to calculate area based on side
        {
            this.side = side;
            float area = side * side / 2;                                                   // Area calculation
            return area;                                                                    // Returns area calculation
        }
        public float GetCircum(int side)                                                    // Method to calculate circumference based on side
        {
            this.side = side;
            float circum = side * 3;                                                        // Circumference calculation
            return circum;                                                                  // Returns circumference calculation
        }
    }
}

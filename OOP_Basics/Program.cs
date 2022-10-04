using System;

namespace OOP_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            _ = new Circle(5);
            Console.WriteLine();
            _ = new Circle(6);
            Console.WriteLine();

            _ = new Triangle(4);
            Console.WriteLine();
            _ = new Triangle(9);
        }
    }
    public class Circle
    {
        public float pi = 3.14f;
        public int radius;
        public Circle(int radius)
        {
            this.radius = radius;
            Console.Write("En cirkel med radie {0} cm har arean: ", radius);
            Console.WriteLine(GetArea(radius) + " cm");
            Console.Write("En cirkel med radie {0} cm har omkretsen: ", radius);
            Console.WriteLine(GetCircum(radius) + " cm");
        }
        float GetArea(int radius)
        {
            this.radius = radius;
            float area = radius * radius * pi;
            return area;
        }
        float GetCircum(int radius)
        {
            this.radius = radius;
            float circum = 2 * pi * radius;
            return circum;
        }  
    }
    public class Triangle
    {
        public int side;
        public Triangle(int side)
        {
            this.side = side;
            Console.Write("En triangel med {0} cm långa sidor har arean: ", side);
            Console.WriteLine(GetArea(side) + " cm");
            Console.Write("En triangel med {0} cm långa sidor har omkretsen: ", side);
            Console.WriteLine(GetCircum(side) + " cm");
        }
        float GetArea(int side)
        {
            this.side = side;
            float area = side * side / 2;
            return area;
        }
        float GetCircum(int side)
        {
            this.side = side;
            float circum = side * 3;
            return circum;
        }
    }
}

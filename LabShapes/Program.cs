using Shapes;
using System;
using System.Collections.Generic;
using System.Numerics;


namespace LabShapes
{
    class Program
    {
        static void Main(string[] args)
        {

           
            
            var shapes = new List<Shape>();
            for (int i = 0; i < 20; i++)
            {
                shapes.Add(Shape.GenerateShape());
            }

            float sumTriangleCircumference = 0;
            Shape3D largestShape3d = null;
            float sumShapeArea = 0;
            
            foreach (Shape s in shapes)
            {
                Console.WriteLine(s);

                sumShapeArea += s.Area;

                if (s is Triangle triangle)
                {

                    sumTriangleCircumference += triangle.Circumference;
                }

                if (s is Shape3D shape3d && (largestShape3d == null  || largestShape3d.Volume < shape3d.Volume))
                    
                {
                  
                        largestShape3d = shape3d;
                    
                }
            }
            if (largestShape3d == null)
            {
                Console.WriteLine("No 3DShape");

            }
            else
            {
                Console.WriteLine($"\nLargest shape 3d is  = { largestShape3d}");
            }
            
            Console.WriteLine($"Average Area of the shapes is: {sumShapeArea / shapes.Count}");
            Console.WriteLine($"Sum of triangle circumference = {sumTriangleCircumference}");
            Console.Write("\nPress any key to continue . . .");
            Console.ReadKey();
        }
        
    }
}

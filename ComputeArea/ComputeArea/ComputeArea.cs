using System;

namespace ComputeArea
{
    class TestComputeArea
    {
        static void Main(string[] args)
        {

            ShapeCalculation(GetShapeToCalculate());

        }

        static string GetShapeToCalculate()
        {
            Console.WriteLine("Please enter the shape for which you want to compute the area");
            Console.WriteLine("c = circle");
            Console.WriteLine("r = rectangle");
            Console.WriteLine("t = triangle");
            Console.WriteLine("cy = cylinder");



            string shapeToCalculate = "c";

            shapeToCalculate = Console.ReadLine();

            return shapeToCalculate.ToLower();
        }

        static void ShapeCalculation(string shape)
        {
            if (shape == "c")
            {
                Console.WriteLine("The area of the circle is: " + circleArea());
            }
            else if (shape == "r")
            {
                Console.WriteLine("The area of the rectangle is: " + rectangleArea());
            }
            else if (shape == "t")
            {
                Console.WriteLine("The area of the triangle is: " + triangleArea());
            }
            else if (shape == "cy")
            {
                Console.WriteLine("The surface of the cylinder is: " + cylinderArea());
            }
            else
            {
                Console.WriteLine("Please enter a valid shape choice!");
            }


            static double circleArea()
            {
                double radius;
                Console.WriteLine("Please enter the radius:");
                radius = double.Parse(Console.ReadLine());
                return Math.PI * (radius * radius);
            }

            static double rectangleArea()
            {
                double length, width;

                Console.WriteLine("Please enter the length:");
                length = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the width:");
                width = double.Parse(Console.ReadLine());

                return length * width;

            }


            static double triangleArea()
            {
                double baseMeasurment, height;

                Console.WriteLine("Please enter the base:");
                baseMeasurment = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the height:");
                height = double.Parse(Console.ReadLine());

                return .5 * baseMeasurment * height;

            }

            static double cylinderArea()
            {
                double radius, height;

                Console.WriteLine("Please enter the radius:");
                radius = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the height:");
                height = double.Parse(Console.ReadLine());

                return 2 * Math.PI * radius * height + 2 * Math.PI * (radius * radius);

            }


        }


    }

}





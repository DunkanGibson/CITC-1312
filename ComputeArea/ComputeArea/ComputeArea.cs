using System;

namespace ComputeArea
{
    class TestComputeArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the shape for which you want to compute the area(c = circle, r = rectangle, t = triangle, and cy = cylinder)");

            if (ShapeCalculation(GetShapeToCalculate()) == 0)
            {
                Console.WriteLine("Please enter a valid shape choice");
            }
            else
            {
                Console.WriteLine(ShapeCalculation(GetShapeToCalculate()));
            }
        }

        static string GetShapeToCalculate()
        {
            string shapeToCalculate = "c";

            shapeToCalculate = Console.ReadLine();

            return shapeToCalculate.ToLower();
        }

        static double ShapeCalculation(string shape)
        {
            if (shape == "c")
            {
                return circleArea();
            }
            else if (shape == "r")
            {
                return rectangleArea();
            }
            else if (shape == "t")
            {
                return triangleCalculate();
            }
            else if (shape == "cy")
            {
                return cylinderCalculate();
            }
            else
            {
                return 0;
            }


            static double circleArea()
            {
                double radius;
                radius = double.Parse(Console.ReadLine());
                return Math.PI * (radius * radius);
            }

        }


    }

}





using System;

namespace Calculate_Dimensions
{
    class CalculateDimensions
    {
        static float height;
        static float width;
        static void Main(string[] args)
        {
            SetHeight();
            SetWidth();
            CalculatePerimeterOfRectangle();
            CalculateAreaOfRectangle();
            DisplayResults();
        }

        static void SetHeight()
        {
            Console.Write("Enter the Height: ");
            height = float.Parse(Console.ReadLine());
        }

        static void SetWidth()
        {
            Console.Write("Enter the Width: ");
            width = float.Parse(Console.ReadLine());
        }

        static float CalculateAreaOfRectangle()
        {
            return width * height;
        }

        static float CalculatePerimeterOfRectangle()
        {
            return 2 * (width * height);
        }

        static void DisplayResults()
        {

            Console.WriteLine("Perimeter of the Rectangle is: {0:F1}", CalculatePerimeterOfRectangle());
            Console.WriteLine("Area of the Rectangle is: {0:F1}", CalculateAreaOfRectangle());
        }
    }
}

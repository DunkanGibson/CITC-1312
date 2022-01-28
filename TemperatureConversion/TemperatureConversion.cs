using System;


namespace TemperatureConversion
{
    class TemperatureConversion
    {
        static void Main(string[] args)
        {
            string tempInCelsius;


            Console.Write("Please enter a temperature to convert: ");

            tempInCelsius = Console.ReadLine();

            Console.WriteLine("Celsius {0:####.0}" , int.Parse(tempInCelsius));
            Console.WriteLine("Fahrenheit: {0:F1}" , (float.Parse(tempInCelsius) * 9/5 + 32));

        }
    }
}

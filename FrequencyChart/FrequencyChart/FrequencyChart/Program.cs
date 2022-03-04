using System;
using static System.Console;

namespace FrequencyChart
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Write("How many scores will you enter?");

            //string sSize = ReadLine();

            //int arraySize = Convert.ToInt32(sSize);

            //int[] score = new int[arraySize];


            int[] counterValues = new int[11];




            int n = -1;
            while (n <= 0)
            {
                Console.Write("Enter number of values >0: ");
                if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.WriteLine("Wrong number.");
                    n = -1;
                }
            }
            int[] values = new int[n];


            for (int i = 0; i < n; i++)
            {
                int value = -1;
                while (value < 0 || value > 10)
                {
                    Console.Write("Enter value between 0 and 10: ");
                    if (!int.TryParse(Console.ReadLine(), out value) || value < 0 || value > 10)
                    {
                        Console.WriteLine("Wrong value.");
                        value = -1;
                    }
                }
                values[i] = value;
            }





            for (int i = 0; i < values.Length; i++)
            {
                counterValues[values[i]]++;


            }


            for (int i = 0; i <= 10; i++)
            {
                Console.Write("{0} {1} ", i, counterValues[i]);
                for (int j = 0; j < counterValues[i]; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }




            Console.ReadLine();


        }
    }
}

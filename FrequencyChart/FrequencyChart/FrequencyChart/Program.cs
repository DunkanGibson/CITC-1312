using System;
using static System.Console;

namespace FrequencyChart
{
    class Program
    {
        static void Main(string[] args)
        {

            int arraySize = numberOfValuesForArray();

            int[] numbers = new int[arraySize];

            int[] counterForNumbers = new int[11];

            promptForNumbers();

            createFrequnecyChart();




            int numberOfValuesForArray()
            {
                Console.Write("How many numbers will you enter: ");
                return int.Parse(Console.ReadLine());

            }

            void promptForNumbers()
            {
                for (int i = 0; i < arraySize; i++)
                {

                    int tester = -1;
                    int valueEntered;
                    bool sucess;

                    while (tester == -1)
                    {
                        Console.Write("Enter a number between 0 and 10: ");
                        sucess = int.TryParse(Console.ReadLine(), out valueEntered);


                        if (!sucess)
                        {
                            Console.WriteLine("This is not a valid value!");

                        }
                        else if (valueEntered < 0 || valueEntered > 10)
                        {
                            Console.WriteLine("Please enter a number > 0 or < 10");
                        }

                        else
                        {
                            numbers[i] = valueEntered;
                            break;
                        }

                    }

                }
            }


            void createFrequnecyChart()
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    counterForNumbers[numbers[i]]++;


                }

                for (int i = 0; i <= 10; i++)
                {
                    Console.Write("{0} ", i, counterForNumbers[i]);
                    for (int j = 0; j < counterForNumbers[i]; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}

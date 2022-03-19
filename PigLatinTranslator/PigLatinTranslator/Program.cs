using System;
using System.Collections;

namespace PigLatinTranslator
{
    class PigLatinTranslator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a phrase to convert to Pig Latin");

            string input = Console.ReadLine();

            PigLatin(input.Split(" "));

            void PigLatin(string[] phrase)
            {
                foreach (string i in phrase)
                {
                    Console.Write(string.Concat(i.Substring(1), string.Concat(i.Substring(0, 1), "ay ")));
                }
            }


        }
    }
}

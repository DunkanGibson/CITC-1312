using System;

namespace GPACalculation
{
    class GPACalculation
    {
        static void Main(string[] args)
        {
            CalculateGPA();

        }

        static void CalculateGPA()
        {
            string continueEntering = "Y";
            double gpa;
            double qualityPoints = 0.0;
            double creditHoursTaken = 0.0;
            string gradeForClass;
            double creditHoursPerClass;
            double creditHoursEarned = 0.0;


            while (continueEntering == "Y")
            {
                Console.Write("Please enter the grade for your class:");
                gradeForClass = Console.ReadLine(); ;
                Console.Write("Please enter the credit hours for this class:");
                creditHoursPerClass = Double.Parse(Console.ReadLine());
                creditHoursTaken += creditHoursPerClass;
                qualityPoints += getQualityPointsPerHour(gradeForClass) * creditHoursPerClass;

                if (getQualityPointsPerHour(gradeForClass) > 0)
                {
                    creditHoursEarned += creditHoursPerClass;
                }

                Console.Write("Do you want to continue?(Y for Yes, N for No)");
                continueEntering = Console.ReadLine().ToUpper();
            }

            gpa = qualityPoints / creditHoursTaken;

            Console.WriteLine("Your GPA is: " + gpa);
            Console.WriteLine("You earned " + creditHoursEarned + " credit hours");

        }

        static double getQualityPointsPerHour(string ClassGrade)
        {
            if (ClassGrade.ToUpper() == "A")
            {
                return 4.0;
            }
            else if (ClassGrade.ToUpper() == "B")
            {
                return 3.0;
            }
            else if (ClassGrade.ToUpper() == "C")
            {
                return 2.0;
            }
            else if (ClassGrade.ToUpper() == "D")
            {
                return 1.0;
            }
            else
            {
                return 0;
            }
        }
    }
}

using System;

namespace StudentGradeApplication
{
    class frmStudentGradeProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GOOD DAY STIER, Please put your name and grades below");
            Console.WriteLine("\n-----------------------------------------------------");

            // for student's name
            Console.Write("\nName: ");
            string Sname = Console.ReadLine();

            Console.WriteLine("\n-------------------------------------------------------");
            Console.WriteLine("Subjects");

            // get grade on 5 sub
            double engG = GetValidGrade("\nEnglish");
            double mathG = GetValidGrade("Math");
            double sciG = GetValidGrade("Science");
            double filiG = GetValidGrade("Filipino");
            double historyG = GetValidGrade("History");

            Console.WriteLine("\n-------------------------------------------------------");

            // average grade computation
            double Ave = engG + mathG + sciG + filiG + historyG;
            double TotalAve = Ave / 5;

            // ternary pass or fail
            string result = TotalAve >= 75.00 ? "Passed" : "Failed";

            // Output the results
            Console.WriteLine($"\n{Sname}'s Average Grade: {TotalAve:F2}");
            Console.WriteLine($"\nResult: ");
            Console.WriteLine($"       The Student {result}.");
            Console.WriteLine($"The general average of {Sname} is {TotalAve:F2}");
            Console.WriteLine("                                _____");
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }

        //  get a valid grade from the user
        static double GetValidGrade(string subjectName)
        {
            double grade;
            do
            {
                Console.Write($"{subjectName}: ");
                if (double.TryParse(Console.ReadLine(), out grade) && grade >= 0 && grade <= 100)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value between 0 and 100.");
                }
            } while (true);

            return grade;
        }
    }
}

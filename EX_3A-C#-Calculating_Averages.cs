using System;
using System.Linq;
using System.Collections.Generic;

namespace CalculatingAverages
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(SumOfNumbers()); //Answer #1
            //AverageTenScores(); //Answer #2
            //AverageSpecificScores(); //Answer #3
            AverageNonSpecificScores(); //Answer #4
        }

        private static void AverageNonSpecificScores()
        {
            Console.WriteLine("Enter test scores and press 'Enter' (Example: score, score, etc.):  ");
            string userInput = Console.ReadLine();
            List<int> scoreList = new List<int> { };
            scoreList = userInput.Split(", ").Select(int.Parse).ToList();
            double avg = (1.0 * scoreList.Aggregate((a, b) => a + b)) / scoreList.Count();
            Console.WriteLine(avg);
            
        }

        private static void AverageSpecificScores()
        {
            Console.WriteLine("Enter Number of Tests:");
            string userInputNumberOfTests = Console.ReadLine();
            int numTests = int.Parse(userInputNumberOfTests);
            for (int i = 0; i < numTests; i++)
            {
                Console.WriteLine($"Enter the scores for test {i + 1}");
                AverageTenScores();
            }
        }

        private static void AverageTenScores()
        {
            double avg;
            string grade;
            NewMethod(out avg, out grade);
            Console.WriteLine($"Student Percentage: {avg} \nLetter Grade: {grade}");
        }

        private static void NewMethod(out double avg, out string grade)
        {
            avg = SumOfNumbers() / 10.0;
            if (Math.Round(avg) >= 90)
            {
                grade = "A";
            }
            else if (avg >= 80 && avg <= 89)
            {
                grade = "B";
            }
            else if (avg >= 70 && avg <= 79)
            {
                grade = "C";
            }
            else if (avg >= 60 && avg <= 69)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }
        }

        private static int SumOfNumbers()
        {
            int[] number = GetInput();
            int sum;
            sum = number.Aggregate((a, b) => a + b);

            //Console.WriteLine(string.Join(", ", number)); // Required to show an Array as a string
            //Console.WriteLine($"The sum of our inputs is {sum}"); // This will answer question 1 (sum of 10 numbers).
            return sum;
        }

        private static int[] GetInput()
        {
            int[] number = new int[10];
            for (int i = 0; i < 10; i++)
            {
                string input;

                Console.WriteLine($"Input grade {i}");
                input = Console.ReadLine();

                number[i] = int.Parse(input);
                if (number[i] < 0 || number[i] > 100)
                {
                    Console.WriteLine("Input number between 0 and 100");
                    i--;
                }
            }

            return number;
        }
    }
}

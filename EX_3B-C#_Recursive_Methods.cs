using System;
using System.Linq;
using System.Collections.Generic;


namespace _3A_Calculating_Averages
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(SumOfNumbers());
            // AverageTenScores();
            //AverageSpecificScores();
            // AverageNonSpecificScores();
            Console.Write("1, 1");
            Fibonachi(1,1,2);


        }

        private static void Fibonachi(int currentNumber, int previousNumber, int count)
        {
            if(count < 40)
            {
            
            
            count++;
            int nextNumber = currentNumber + previousNumber;
                Console.Write($", {nextNumber}");
                Fibonachi(nextNumber, currentNumber, count++);
                
            }
            else
            {
                double phi;
                int nextNumber = currentNumber + previousNumber;
                phi = 1.0 * nextNumber / currentNumber;
                Console.WriteLine($"\nPhi is {phi}");
            }
    }

        private static void AverageNonSpecificScores()
        {
            Console.WriteLine("Enter Test Scores: (score, score,...)");
            string input = Console.ReadLine();
            List<int> scoreList = new List<int> { };
            scoreList = input.Split(", ").Select(int.Parse).ToList();
            //Console.WriteLine(string.Join(",", scoreList));
            double avg;
            avg = 1.0 * scoreList.Aggregate((a, b) => a + b) / scoreList.Count();
            //Console.WriteLine(avg);
            GetGrade(avg);

        }

        private static void AverageSpecificScores()
        {
            Console.WriteLine("Enter number of test");
            string input = Console.ReadLine();
            int numTests = int.Parse(input);
            for (int i = 0; i < numTests; i++)
            {
                Console.WriteLine($"Enter the scores for test {i + 1}");
                AverageTenScores();
            }
        }


        private static void AverageTenScores()
        {

            double avg = SumOfNumbers() / 10.0;
            Console.WriteLine(avg);
            GetGrade(avg);



        }

        private static void GetGrade(double avg)
        {
            string grade;
            if (Math.Round(avg) >= 90)
            {
                grade = "A";

            }
            else if (avg >= 80 && avg < 90)
            {
                grade = "B";

            }
            else if (avg >= 70 && avg < 80)
            {
                grade = "C";

            }
            else if (avg >= 60 && avg < 70)
            {
                grade = "D";

            }
            else
            {
                grade = "F";
            }
            Console.WriteLine($"The numerical average is {avg} and the letter grade is {grade}");

        }

        private static int SumOfNumbers()
        {
            int[] number = GetInput();
            int sum;
            sum = number.Aggregate((a, b) => a + b);
            //Console.WriteLine(string.Join(",", number));
            //Console.WriteLine($"The sum of our inputs is {sum}");
            return sum;

        }

        private static int[] GetInput()
        {
            int[] number = new int[10];
            for (int i = 0; i < 10; i++)
            {
                string input;
                Console.WriteLine($"Input {i} value");
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
   

using System;

namespace MSSA_Homework
{
    class Program
    {
        private static void Main(string[] args)
        {
         //1. Perimeter and Area of Circle

            double radius, perimeterCircle, areaCircle;

            Console.WriteLine("Input the radius of the circle:  ");
            radius = Convert.ToDouble(Console.ReadLine());

            perimeterCircle = 2 * Math.PI * radius;
            areaCircle = Math.PI * radius * radius;

            Console.WriteLine("Perimeter of Circle: {0}", perimeterCircle);
            Console.WriteLine("Area of Circle: {0}", areaCircle);


         //2. Volume of Hemisphere

            double r, volumeHemisphere;

            Console.WriteLine("\nInput the radius of the hemisphere:  ");
            r = Convert.ToDouble(Console.ReadLine());

            volumeHemisphere = 1.33 * Math.PI * r * r * r / 2;

            Console.WriteLine("Volume of the Hemisphere is: {0}", volumeHemisphere);


         //3. Area of triangle given the length of the sides

            double a, b, c, p, areaTriangle;

            Console.WriteLine("\nInput side A of triangle:  ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nInput side B of triangle:  ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nInput side C of triangle:  ");
            c = Convert.ToDouble(Console.ReadLine());

            p = (a + b + c) / 2;

            areaTriangle = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine("The Area of the Triangle is:  {0}", areaTriangle);


         //4.Solving A Quadratic Equation

            double aa, bb, cc, xPositive, xNegative;

            Console.WriteLine("\nInput value for A:  ");
            aa = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("\nInput value for B:  ");
            bb = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("\nInput value for C:  ");
            cc = Convert.ToDouble(Console.ReadLine());

            xPositive = (-bb + Math.Sqrt((bb * bb) - 4 * aa * cc)) / (2 * aa);
            xNegative = (-bb - Math.Sqrt((bb * bb) - 4 * aa * cc)) / (2 * aa);

            Console.WriteLine("The Positive Solution is:  {0}", xPositive);
            Console.WriteLine("The Negative Solution is:  {0}", xNegative);

            Console.ReadLine();
        }
    }
}

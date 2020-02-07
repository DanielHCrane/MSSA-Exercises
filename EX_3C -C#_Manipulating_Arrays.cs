using System;

namespace Manipulating_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayA = new int[] { 0, 2, 4, 6, 8, 10 };
            int[] arrayB = new int[] { 1, 3, 5, 7, 9 };
            int[] arrayC = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            //CountingSummingComputingMean(arrayA);
            //ReverseArray(arrayB);
            //RotateArray("left", 2, arrayA);
            //RotateArray("right", 2, arrayB);
            //RotateArray("left", 4, arrayC);
            //BubbleSortArray(arrayC);
            SortArray(arrayC);

        }

        private static void SortArray(int[] array)
        {
            int lowNum;
            int[] sortedArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                lowNum = array[i];
                for (int a = i + 1; a < array.Length; a++)
                {
                    if (array[a] < array[i])
                    {
                        lowNum = array[a];
                        array[a] = array[i];
                        array[i] = lowNum;
                    }
                }
                sortedArray[i] = lowNum;
            }
            Console.WriteLine(string.Join(", ", sortedArray));
        }

        //private static void BubbleSortArray(int[] array)
        //{
        //    int temp;
        //    int[] bArray = new int[array.Length];
        //    for (int j = 0; j <= array.Length - 2; j++)
        //    {
        //        for (int i = 0; i <= array.Length - 2; i++)
        //        {
        //            if (bArray[i] > bArray[i + 1])
        //            {
        //                temp = bArray[i + 1];
        //                bArray[i + 1] = bArray[i];
        //                bArray[i] = temp;
        //            }
        //        }
        //    }
        //    Console.WriteLine("Sorted:");
        //    foreach (int p in bArray)
        //        Console.Write(p + " ");
        //    Console.Read();
        //}

        private static void RotateArray(string direction, int numPlaces, int[] array)
        {
            int[] roArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (direction == "left")
                {
                    if (i + numPlaces >= array.Length)
                    {
                        roArray[i] = array[(i + numPlaces) - array.Length];
                    }
                    else
                    {
                        roArray[i] = array[i + numPlaces];
                    }
                }
                else
                {
                    if (i - numPlaces < 0)
                    {
                        roArray[i] = array[array.Length + (i - numPlaces)];
                    }
                    else
                    {
                        roArray[i] = array[i - numPlaces];
                    }
                }
                Console.WriteLine(string.Join(", ", roArray));
            }
        }

        private static void ReverseArray(int[] array)
        {
            int[] rArray = new int[array.Length];
            for (int i = 1; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                rArray[array.Length - i] = array[i - 1];
                Console.WriteLine(string.Join(", ", rArray));
            }
            Console.WriteLine($"The reversed of the passed array is {string.Join(", ", rArray)}");
        }

        private static void CountingSummingComputingMean(int[] array)
        {
            double meanA = 0;
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            meanA = 1.0 * sum / array.Length;
            Console.WriteLine($"The mean of this array is {meanA}");
        }
    }
}

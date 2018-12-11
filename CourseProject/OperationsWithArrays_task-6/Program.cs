using System;
using System.Text;

namespace OperationsWithArrays_task_6
{
    class Program
    {
        //1. точка от задачата
        static void ArrayInput(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"element[{i}] = ");
                array[i] = double.Parse(Console.ReadLine());
            }
        }

        static double ArrayAverage(double[] array)
        {
            double arrSum = 0;
            int arrCounter = 0;
            double arrAverage;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 3 == 0)
                {
                    arrSum = arrSum + array[i];
                    arrCounter++;
                }
            }
            arrAverage = arrSum / arrCounter;
            return arrAverage;
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            try
            {
                Console.WriteLine("Задача 413.");
                Console.WriteLine("1. Да се направят 2 метода:");
                Console.WriteLine("а) за въвеждане на едномерен масив от реални числа");
                Console.WriteLine("б) за изчисляване на средноаритметичното на тези елементи на масива, чиито индекси се делят на 3 без остатък.");
                Console.WriteLine("2. В главния метод въведете цяло число n и три едномерни масива A[n], B[n] и C[n]. За всеки масив изчислете и отпечатайте стойността на средноаритметичното по точка 1б. Намерете и отпечатайте средноаритметичното на средноквадратичното на трите намерени числа.");
                Console.WriteLine("3. Преизчислете елементите на масива C по следния начин:");
                Console.WriteLine("(A[n]^2 + B[1]^4 , A[n-1]^2 + B[2]^4 ,..., A[1]^2 + B[n]^4)");
                Console.WriteLine("\n");
                Console.WriteLine("Enter the number of elements in the array:");


                //2. точка от задачата
                n = int.Parse(Console.ReadLine());
                double[] A = new double[n], B = new double[n], C = new double[n];
                Console.WriteLine("Enter the elements of array A:");
                ArrayInput(A);
                Console.WriteLine("Enter the elements of array B:");
                ArrayInput(B);
                Console.WriteLine("Enter the elements of array C:");
                ArrayInput(C);
                Console.WriteLine($"\n2. The arithmetic means of the elements of arrays A[],B[],C[] with indexes which are divided to 3 without residue are: A={ArrayAverage(A)}  ,  B={ArrayAverage(B)}  ,  C={ArrayAverage(C)}\n");
                Console.WriteLine($"\nThe Root mean square of the three Arithmetic means is:{Math.Round(Math.Sqrt((Math.Pow(ArrayAverage(A),2) + Math.Pow(ArrayAverage(B),2) + Math.Pow(ArrayAverage(C),2)) / 3),2)}");



                //3. точка от задачата
                Console.WriteLine("\n3. The recalculated values of the elements of array C are:");
                for (int i = 0; i < n; i++)
                {
                    C[i] = Math.Pow(A[(n-1) - i], 2) + Math.Pow(B[i], 4);
                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"C[{i}] = {C[i]}");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

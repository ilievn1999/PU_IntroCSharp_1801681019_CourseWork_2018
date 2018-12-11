using System;
using System.Text;

namespace RandomNumbersProductAndSum_task_5
{
    class Program
    {
        static void NonZero()
        {
            Random rand = new Random();
            int[] generatedNumbers = new int[70];
            for (int i = 0; i < generatedNumbers.Length; i++)
            {
                generatedNumbers[i] = rand.Next(201);
            }
            Console.WriteLine("The generated numbers that are not 0 are: ");
            for (int i = 0; i < generatedNumbers.Length; i++)
            {
                if (generatedNumbers[i] != 0)
                {
                    Console.WriteLine(generatedNumbers[i]);
                }
            }
        }


        static double ProductOfNumbers(double[] numbers)
        {
            double Product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 10 && numbers[i] <= 20)
                {
                    Product = Product * numbers[i];
                }

            }
            return Product;
        }


        static int Sum(int numbersCount)
        {
            Random rand = new Random();
            int[] generatedNumbers = new int[numbersCount];
            int sumOfEvenNumbers = 0;


            Console.WriteLine($"The randomly generated numbers for Sum({numbersCount}) are:");
            for (int i = 0; i < generatedNumbers.Length; i++)
            {
                generatedNumbers[i] = rand.Next(1000);
                Console.WriteLine($"generated number[{i}] = {generatedNumbers[i]}");
                if (generatedNumbers[i] % 2 == 0)
                {
                    sumOfEvenNumbers += generatedNumbers[i];
                }
            }
            Console.WriteLine("\n");
            return sumOfEvenNumbers;
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Задача 373. 1. Да се генерира редица от 70 случайни цели числа, принадлежащи на интервала [0,200]. Да се отпечатат тези от тях, които са различни от нула.");
            Console.WriteLine("2. Да се въведат от клавиатурата 10 числа. Да се намери и отпечата на екрана произведението на тези от тях, които са в интервала [10,20]");
            Console.WriteLine("3. Да се създаде метод Sum(k), който генерира k на брой случайни цели числа и като резултат връща сумата на тези от тях, които са четни. В главния метод да се въведат 3 цели положителни числа a, b и c. Да се намери и отпечата: Sum(a) + Sum(b*c).");
            Console.WriteLine("\n");
            // 1.
            Console.WriteLine("Let's generate 70 random numbers between 0 and 200 and print the ones bigger than 0. \nPress any key to continue...");
            Console.ReadKey();
            NonZero();
            Console.WriteLine("\n");

            // 2.
            Console.WriteLine("Now, enter 10 numbers to be multiplied (You will get the product of the values between 10 and 20) : ");
            double[] numbersForMultiplication = new double[10];
            for (int i = 0; i < numbersForMultiplication.Length; i++)
            {
                Console.Write($"number[{i}]: ");
                numbersForMultiplication[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The product of the numbers which are between 10 and 20 is: {ProductOfNumbers(numbersForMultiplication)}");
            Console.WriteLine("\n");


            // 3.
            int a, b, c;
            Console.WriteLine("And now, let's calculate the expression: Sum(a) + Sum(b*c)");
            Console.WriteLine("if a,b,c specify the count of the randomly generated numbers, and Sum() returns the sum of the even numbers.\n");
            Console.WriteLine("Enter values of the variables: a, b, c:");
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine($"Sum(a) + Sum(b*c) = {Sum(a) + Sum(b * c)}");
        }
    }
}

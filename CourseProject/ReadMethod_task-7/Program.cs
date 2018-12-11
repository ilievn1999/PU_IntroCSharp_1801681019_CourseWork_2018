using System;
using System.Text;

namespace ReadMethod_task_7
{
    class Program
    {
        public static double Read(double x, double y)
        {
            Random rand = new Random();
            double generatedNumber = rand.NextDouble() * (y - x) + x;
            return generatedNumber;
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Задача 354. Да се направи метод double Read(double x, double y), който да връща като резултат число от тип double в интервала (x,y)");
            Console.WriteLine("\n");
            double minValue, maxValue;
            Console.Write("Enter minimum value: ");
            minValue = double.Parse(Console.ReadLine());
            Console.Write("Enter maximum value: ");
            maxValue = double.Parse(Console.ReadLine());
            Console.WriteLine($"The randomly generated number between {minValue} and {maxValue}: {Math.Round(Read(minValue, maxValue), 3)}");
        }
    }
}

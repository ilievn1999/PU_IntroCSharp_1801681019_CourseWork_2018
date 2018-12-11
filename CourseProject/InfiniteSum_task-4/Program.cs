using System;
using System.Text;

namespace InfiniteSum_task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Задача 122. з) По дадени х и ε да се пресметне сумата (абсолютна грешка):");
            Console.WriteLine("\nY = [(1/2)*(x/2)] + [(1/2)*(3/4)*(x^2 / 4)] + ... + {[1*3*5...(2n-1)] / [2*4*6...(2*n)] * [(x^n) / (2*n)]} +.....,|x|<1");
            Console.WriteLine("Сравнете с ln(2(1-sqrt(1-x))/x)");
            Console.WriteLine("\n");


            double x, eps;
            do
            {
                Console.Write("x=");
                x = double.Parse(Console.ReadLine());
            } while (Math.Abs(x) >= 1);
            do
            {
                Console.Write("accuracy ε:");
                eps = double.Parse(Console.ReadLine());
            } while (eps <= 0 || eps >= 0.01);


            double i = 1;              // итератор
            double n = 1;              // знаменател
            double a = 1;              // числител 
            double y = 0;              // сума
            do
            {
                n = n * (2 * i);
                a = a * (2 * i - 1);
                Console.Write($"{y} + ({(a / n)} * {(Math.Pow(x, i) / (2 * n))})=");
                y = y + ((a / n) * (Math.Pow(x, i) / (2 * n)));
                Console.WriteLine(y);
                i++;
            } while (Math.Abs((a * Math.Pow(x, i)) / (n * 2 * n)) >= eps);
            Console.WriteLine($"\na=({a}*{x}^{i}) / {n}*{2 * n}");
            Console.WriteLine($"Common member: {Math.Round((a * Math.Pow(x, i)) / (n * 2 * n), 4)} < ε: {eps}");
            Console.WriteLine("\n");
            Console.WriteLine($"Result: Y={Math.Round(y, 4)}  ;  Control={Math.Round(Math.Log(2 * (1 - Math.Sqrt(1 - x)) / x), 4)}");
        }
    }
}

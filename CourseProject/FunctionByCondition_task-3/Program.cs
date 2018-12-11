using System;
using System.Text;

namespace FunctionByCondition_task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double y, z;
            Console.WriteLine("Задача 55. Напишете програма за изчисляване на функцията: f(y,z)=y^2+z^2+1 (if y<=0 and z>=0)");
            Console.WriteLine("Или функцията: f(y,z)=y*z+1 (if y>0 and z<0)");
            Console.WriteLine("\n");
            Console.WriteLine("Please enter values of x & y: ");
            Console.Write("y=");
            y = double.Parse(Console.ReadLine());
            Console.Write("z=");
            z = double.Parse(Console.ReadLine());
            double f;
            Console.WriteLine("\n");
            if (y <= 0 && z >= 0)
            {
                f = Math.Pow(y, 2) + Math.Pow(z, 2) + 1;
                Console.WriteLine("f=y^2+z^2+1");
                Console.WriteLine("f = " + f);
            }
            else if (y > 0 && z < 0)
            {
                f = y * z + 1;
                Console.WriteLine("f=y*z+1");
                Console.WriteLine("f = " + f);
            }
            else
            {
                Console.WriteLine("The values of Y and Z are invalid for the function f");
            }
        }
    }
}

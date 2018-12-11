using System;
using System.Text;

namespace PickADigit_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Задача 13. Да се напише програма, която въвежда положително седемцифрено число и извежда неговата k-та цифра (1<=k<=7), като цифрите се броят: а) отляво-надясно; б) отдясно-наляво.");
            Console.WriteLine("\n");
            Console.WriteLine("Please input a 7-digit number: ");
            int number = int.Parse(Console.ReadLine());


            if (number / 1000000 > 0 && number / 1000000 < 10)
            {
                Console.WriteLine("Pick a digit from 1 to 7: ");
                int pickedDigit = int.Parse(Console.ReadLine());

                int digit1 = number / 1000000;
                int digit2 = number / 100000 % 10;
                int digit3 = number / 10000 % 10;
                int digit4 = number / 1000 % 10;
                int digit5 = number / 100 % 10;
                int digit6 = number / 10 % 10;
                int digit7 = number % 10;


                switch (pickedDigit)
                {
                    case 1:
                        Console.WriteLine("The first digit from left to right is: " + digit1);
                        Console.WriteLine("The first digit from right to left is:" + digit7);
                        break;
                    case 2:
                        Console.WriteLine("The second digit from left to right is: " + digit2);
                        Console.WriteLine("The second digit from right to left is: " + digit6);
                        break;
                    case 3:
                        Console.WriteLine("The third digit from left to right is: " + digit3);
                        Console.WriteLine("The third digit from right to left is: " + digit5);
                        break;
                    case 4:
                        Console.WriteLine("The fourth digit from left to right and from right to left is: " + digit4);
                        break;
                    case 5:
                        Console.WriteLine("The fifth digit from left to right is: " + digit5);
                        Console.WriteLine("The fifth digit from right to left is: " + digit3);
                        break;
                    case 6:
                        Console.WriteLine("The sixth digit from left to right is: " + digit6);
                        Console.WriteLine("The sixth digit from right to left is: " + digit2);
                        break;
                    case 7:
                        Console.WriteLine("The seventh digit from left to right is: " + digit7);
                        Console.WriteLine("The seventh digit from right to left is: " + digit1);
                        break;
                    default:
                        Console.WriteLine("The digit you picked is incorrect");
                        break;
                }
            }
            else
            {
                Console.WriteLine("The number you have entered is incorrect!");
            }


        }
    }
}

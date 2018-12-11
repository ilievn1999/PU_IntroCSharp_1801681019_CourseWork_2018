using System;

namespace NumberSystemConverter_task_1
{
    class Program
    {
        static string intoBinary(int decimalNumber)
        {
            int number = decimalNumber;
            int quotient = 2;
            int binaryNumber;
            string binaryResultReverse = "";
            string binaryResult = "";


            do
            {
                binaryNumber = number % quotient;
                binaryResultReverse = binaryResultReverse + binaryNumber.ToString();
                Console.WriteLine($"{number} % {quotient} = {binaryNumber}");
                number = number / quotient;
            } while (number != 0);


            int i = binaryResultReverse.Length - 1;
            while (i >= 0)
            {
                binaryResult = binaryResult + binaryResultReverse[i];
                i--;
            }

            Console.Write($"{decimalNumber} in binary is: {binaryResult}");
            Console.WriteLine("\n");
            return binaryResult;
        }


        //INTO OCTAL
        static void intoOctal(int decimalNumber)
        {
            int number = decimalNumber;
            int quotient = 8;
            int octalNumber;
            string octalResult = "";

            do
            {
                octalNumber = number % quotient;
                octalResult = octalResult + octalNumber.ToString();
                Console.WriteLine($"{number} % {quotient} = {octalNumber}");
                number = number / quotient;
            } while (number != 0);

            Console.Write($"{decimalNumber} in octal is: ");
            int i = octalResult.Length - 1;
            while (i >= 0)
            {
                Console.Write(octalResult[i]);
                i--;
            }
            Console.WriteLine("\n");
        }



        //INTO HEXADECIMAL
        static void intoHexaDecimal(string binaryNumber)
        {
            string binary = binaryNumber;

            int rem = binary.Length % 4;


            string tetrades = "";

            switch (rem)
            {
                case 1:
                    tetrades = "000" + binary;
                    break;
                case 2:
                    tetrades = "00" + binary;
                    break;
                case 3:
                    tetrades = "0" + binary;
                    break;
                default:
                    tetrades = binary;
                    break;
            }

            int tetrades_count = tetrades.Length / 4;

            //Divides the binary number into tetrades and fits the tetrades in the elements of an array
            string[] tetrades_arr = new string[tetrades_count];
            for (int i = 0; i < tetrades_arr.Length; i++)
            {
                tetrades_arr[i] = "" + tetrades[0 + 4 * i] + tetrades[1 + 4 * i] + tetrades[2 + 4 * i] + tetrades[3 + 4 * i];
            }


            Console.Write($"2019 = {binary} =");
            for (int i = 0; i < tetrades_arr.Length; i++)
            {
                Console.Write($" {tetrades_arr[i]}");
            }
            Console.Write("\n");


            //Calculates the value of each tetrade in hexadecimal
            for (int i = 0; i < tetrades_arr.Length; i++)
            {
                Console.WriteLine($"{tetrades_arr[i]} = {String.Format("{0:X}", Convert.ToUInt64(tetrades_arr[i], 2))}");
            }

            //Shows the value of the whole binary number
            Console.Write($"{binary} in hexadecimal is: ");
            for (int i = 0; i < tetrades_arr.Length; i++)
            {
                Console.Write($"{String.Format("{0:X}", Convert.ToUInt64(tetrades_arr[i], 2))}");
            }
            Console.WriteLine("\n");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Converts the number 2019 to binary:");
            int number = 2019;
            string binar_Number = intoBinary(number);
            Console.WriteLine("\n");
            Console.WriteLine("Converts 2019 to octal:");
            intoOctal(number);
            Console.WriteLine("\n");
            Console.WriteLine("Converts 2019 to hexadecimal");
            intoHexaDecimal(binar_Number);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{

    public static class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter the Decimal Number : ");
            //int number = int.Parse(Console.ReadLine());
            int number = 0;
            Console.WriteLine("the number is: {0}", number);
            int i;
            int count = 0;
            int[] numberArray = new int[32];
            for (i = 0; number > 0; i++)
            {

                numberArray[i] = number % 2;
                number = number / 2;
            }
            Console.Write("Binary Represenation of the given Number : ");
            for (i = i - 1; i >= 0; i--)
            {
                if (numberArray[i] == 1)
                {
                    count += 1;
                }
                Console.Write(numberArray[i].ToString());
            }
            Console.WriteLine("\n");
            Console.WriteLine("number of 1 in this number is : {0}", count);

            Console.ReadKey();
        }
    }
}
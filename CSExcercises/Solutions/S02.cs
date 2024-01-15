using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSExcercises.Solutions
{
    public class S02
    {
        /*
         * Print times table upto 10 for a given number using your desired loop
         * 
         */
        public static void TimesTable()
        {
            int num = 5;

            for (int i = 1; i <= 10; i++)
            {
                int product = i * num;
                Console.WriteLine($" {num} * {i} = "+product);
            }

        }

        /*
         * Print values from 1 - 10 in ascending order and descending order
         *
        */

        public static void AscendingAndDecendingOrder()
        {
            Console.WriteLine("Ascending Order:");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i} ");
            }

            // Add a newline for better formatting
            Console.WriteLine();

            // Print values in descending order
            Console.WriteLine("Descending Order:");

            for (int i = 10; i >= 1; i--)
            {
                Console.Write($"{i} ");
            }
            // Add a newline for better formatting
            Console.WriteLine();

        }

        /*
         * Using a for loop try to iterate an int value from 0 -10 and break when the value is 7.

        */

        public static void BreatAt7()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Current value: {i}");

                if (i == 7)
                {
                    Console.WriteLine("Breaking the loop because the value is 7.");
                    break;
                }
            }
        }


    }
}

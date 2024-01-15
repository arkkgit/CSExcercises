using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExcercises.Solutions
{
    public class S01
    {
      /*
     * Write some code to find the number given is Even number or Odd
     * 
     */

        public static void EvenOrOdd()
        {
            int num = 10;
            if (num % 2 == 0)
            {
                Console.WriteLine($"The number {num} is Even number");
            }
            else
            {
                Console.WriteLine($"The number {num} is Odd number");
            }
        }

        /*
         * Write code using nested if else to print as  

         * less than 5 years  as Child
         * 5 - 12  as Kid
         * 13 - 18 as Teen
         * 18 - 100 as Adult.
         * 
         */

        public static void AgeAndStage()
        {

            int age = 7;

            if (age < 5)
            {
                Console.WriteLine("Child");
            }
            else if ((age >= 5) && (age < 12))
            {
                Console.WriteLine("Kid");
            }
            else if ((age >= 13) && (age < 18))
            {
                Console.WriteLine("Teen");
            }
            else if ((age >= 18) && (age < 100))
            {
                Console.WriteLine("Adult");
            }

            else
            {
                Console.WriteLine("Miracle Human");
            }
        }

    }
}

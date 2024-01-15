using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExcercises.Solutions
{
    public class S05
    {

        /*
        * 
        * 
        * Demonstrate overloading for a Report method with different parameters.

       */
        public static void Report(bool result, String description)
        {
            Console.WriteLine($"Reporting result: {result} with description {description}");
        }

        public static void Report(bool result)
        {
            Console.WriteLine($"Reporting result: {result} ");
        }

        public static void Report(String description)
        {
            Console.WriteLine($"Reporting Description : {description} ");
        }


        public static void Report(String description, string info)
        {
            Console.WriteLine($"Reporting Description : {description}  and information {info}");
        }

    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExcercises.Solutions
{
    public class S09
    {
        /*
         * Generate a  System.IO.IOException  and handle it
         * with appropriate exception and print the stack trace.
         */


        public static void ExceptionDemo()
        {
            try
            {
                // Attempt to open a file that doesn't exist
                string filePath = @"C:\temp\NonexistentFile.txt";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // Code to read from the file (will not be executed in this case)
                }
            }
            catch (IOException ex)
            {
                // Handle the IOException
                Console.WriteLine("IOException caught!");
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine("Stack Trace:");
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}


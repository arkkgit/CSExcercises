using CSExcercises.Excercises;
using CSExcercises.Solutions;
using CSExcercises.Solutions.UserDefinedClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExcercises
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // Excercises 
            Console.WriteLine("********** Excercises ********");
            //E01 - Conditional Statements
            E01.EvenOrOdd();
            E01.AgeAndStage();


            //E02- Loops
            E02.TimesTable();
            E02.AscendingAndDecendingOrder();
            E02.BreatAt7();

            //E03 Lists 
            E03.ListPractice();


            //E04 -Object passing and returning
            E04.ChocFactory();

            //E05.Method Overloading

            //E06 - Composition Demo
            E06.CompositionDemo();

            //E07 Up and Down Casting
            E07.CastingDemo();

            //E08 Shared Driver From BasePage
            E08.SharedDriverFromBasePage();

            //E09 - Exception handling
            E09.ExceptionDemo();

            //E10 - ReadData from External File
            E10.DemoReadDataKeyValuesFromFile();

/*




            // Solutions
            Console.WriteLine("********** Solutions ********");
            //S01 - Conditional statements
            S01.EvenOrOdd();
            S01.AgeAndStage();
            
            //S02- Loops
            S02.TimesTable();
            S02.AscendingAndDecendingOrder();
            S02.BreatAt7();
            
            //S03 - Lists
            S03.ListPractice();
            
            //S04 - Object pass and return
            CocoPowder c = new CocoPowder();
            Sugar s = new Sugar();
            Choclate Cadbury = S04.ChocFactory(c, s);
            
            //S05 - Method Overloading
            S05.Report("Some description");
            S05.Report(true);
            S05.Report(false, "the button is not enabled");
            S05.Report("Is the button visible?", "This is the signin button");
            
            //S06 - Composition
            S06.CompositionDemo();

            //S07 - Up and Down Casting
            S07.CastingDemo();


            //S08 Shared Driver From BasePage
            S08.SharedDriverFromBasePage();

            //S09 - Exception handling
            S09.ExceptionDemo();

            //S10 - ReadData from External File
            S10.DemoReadDataKeyValuesFromFile();

*/



        }
    }
}

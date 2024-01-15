using CSExcercises.Solutions.UserDefinedClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExcercises.Solutions
{
    public class S08
    {


        /*
         * Develop a base class called BasePage with a member called sso 
         * that gets initializes in its constructor,
         * and subsequently demonstrate the  utilization of this member sso 
         * in its derived class called HomePage. 
         * 
         */

        public static void SharedDriverFromBasePage()
        {
            // Creating an instance of the derived class (HomePage)
            HomePage myHomePage = new HomePage("SharedDriver");

            // Utilizing the method from the derived class
            myHomePage.DisplayHome();

        }
    }
}

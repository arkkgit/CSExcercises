using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExcercises.Solutions.UserDefinedClasses
{
    public class HomePage : BasePage
    {
// Constructor calling the base class constructor
        public HomePage(string sso) : base(sso)
        {
        }

        // Additional method specific to HomePage
        public void DisplayHome()
        {
            Click(); //From base class
            Console.WriteLine($"using {sso} is displaying the home page.");
        }
    }
}

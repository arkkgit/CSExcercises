using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExcercises.Solutions.UserDefinedClasses
{
    public  class BasePage
    {
        // Member
        protected string sso;

        // Constructor
        public BasePage(string sso)
        {
            this.sso = sso;
        }

        // Method using the member
        public void Click()
        {
            Console.WriteLine($"Clicking on button using the shared driver: {sso}");
        }
    }
}

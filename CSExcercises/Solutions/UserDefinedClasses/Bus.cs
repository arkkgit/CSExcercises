using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExcercises.Solutions.UserDefinedClasses
{
    public class Bus
    {

        private Engine busEngine;

        // Constructor that initializes the Engine
        public Bus()
        {
            busEngine = new Engine();
        }

        // Method to start the Bus
        public void StartBus()
        {
            Console.WriteLine("Bus starting...");
            // Using the Engine's Start method
            busEngine.Start();
        }

        // Method to stop the Bus
        public void StopBus()
        {
            Console.WriteLine("Bus stopping...");
            // Using the Engine's Stop method
            busEngine.Stop();
        }
    }
}

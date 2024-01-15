using CSExcercises.Solutions.UserDefinedClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExcercises.Solutions
{
    public  class S07
    {
        public static void CastingDemo()
        {
            {
                // Upcasting
                Dog myDog = new Dog();
                Animal myAnimal = myDog; // Upcasting Dog to Animal
                myAnimal.Eat(); // Accessing Animal's method using upcasting

                // Downcasting
                if (myAnimal is Dog)
                {
                    Dog downcastedDog = (Dog)myAnimal; // Downcasting Animal to Dog
                    downcastedDog.Bark(); // Accessing Dog's method using downcasting
                }

                /*
                 * 
                 * The analogy here is that all dogs are animals, 
                 * so you can treat a dog as an animal (upcasting). 
                 * However, not all animals are dogs, 
                 * so you need to check and make sure before 
                 * treating an animal as a dog (downcasting).
                 * 
                 */

            }
        }

    }
}

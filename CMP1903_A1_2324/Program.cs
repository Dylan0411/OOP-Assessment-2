using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
             /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */

        ///////////////////////////////////////////////////////////////////////////////////////////////
        ///
        static void Main(string[] args)
        {
            //"Create a Game object."
            Game gameObject = new Game();
            Console.WriteLine(gameObject.Run());//PRINT THE RESULT+RUN THE GAME

            //testing object
            Testing testObject = new Testing();
            testObject.verifyRollAndSum();
        }
    }
}

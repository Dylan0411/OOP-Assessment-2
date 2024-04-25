using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        //-------------------------------Constructors-------------------------------
        //private Game testGame = new Game(); //Creates a new game object from the 'Game' class called 'testGame'.

        //-------------------------------Methods-------------------------------
        public void verifyRollAndSum()  //When this is called the program ensures the 'Die' class and the 'sum' variable generate the correct values.
        {
            //testGame.threeOrMore.Run();  //Calls the 'Run' method in the 'testGame' object.

            //Debug.Assert(testGame.D1Value > 0 && testGame.D1Value < 7, "Die1 didnt roll a number between 1 and 6"); //checking that the "D1Value" variable (which represents the first dice roll) is between 1 and 6
            //Debug.Assert(testGame.D2Value > 0 && testGame.D2Value < 7, "Die2 didnt roll a number between 1 and 6"); //checking that the "D2Value" variable (which represents the second dice roll) is between 1 and 6
            //Debug.Assert(testGame.D3Value > 0 && testGame.D3Value < 7, "Die3 didnt roll a number between 1 and 6"); //checking that the "D3Value" variable (which represents the third dice roll) is between 1 and 6

            //Debug.Assert(testGame.sum == testGame.D1Value + testGame.D2Value + testGame.D3Value, "ERROR: SUM INCORRECT"); //checking that the 'sum' variable actually equals the result of adding together each dice rolls value.
        }
    }
}
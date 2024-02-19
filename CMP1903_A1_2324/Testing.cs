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
        //Constructor
        private Game testGame = new Game();

        //Methods
        public void verifyRollAndSum()
        {
            //run test game object
            testGame.Run();

            //Use debug.assert() to verify: Die rolls are between 1 and 6 (inclusive)."
            Debug.Assert(testGame.D1Value > 0 && testGame.D1Value < 7, "Die1 didnt roll a number between 1 and 6");
            Debug.Assert(testGame.D2Value > 0 && testGame.D2Value < 7, "Die2 didnt roll a number between 1 and 6");
            Debug.Assert(testGame.D3Value > 0 && testGame.D3Value < 7, "Die3 didnt roll a number between 1 and 6");

            //Use debug.assert() to verify: The sum of the three values are as you expect."
            Debug.Assert(testGame.sum == testGame.D1Value + testGame.D2Value + testGame.D3Value, "ERROR: SUM INCORRECT");
        }
    }
}
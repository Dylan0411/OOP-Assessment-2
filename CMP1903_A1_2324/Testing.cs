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
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method


        ///////////////////////////////////////////////////////////////////////////
        Game game = new Game();
        



        public void verifyRolls()
        {
            //Use debug.assert() to verify: Die rolls are between 1 and 6 (inclusive)."
            Debug.Assert(game.D1Value > 1 && game.D1Value < 7);
            Debug.Assert(game.D2Value > 1 && game.D2Value < 7);
            Debug.Assert(game.D3Value > 1 && game.D3Value < 7);
        }

        public void verifySum()
        {
            //Use debug.assert() to verify: The sum of the three values are as you expect."
            Debug.Assert(game.sum == game.D1Value + game.D2Value + game.D3Value);
        }
    }
}

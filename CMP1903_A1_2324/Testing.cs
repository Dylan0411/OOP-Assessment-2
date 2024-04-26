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
        //-------------------------------Methods-------------------------------
        public void runTests()  //When this is called the program ensures the 'Die' class and the 'sum' variable generate the correct values.
        {
            Console.WriteLine("OPTIONS:");
            Console.WriteLine("=======================");
            Console.WriteLine("(1) Run tests on: 'Sevens Out'");
            Console.WriteLine("(2) Run tests on: 'Three Or More'");
            Console.WriteLine("=======================");
            Console.Write("Select an Option (eg '1' or '2'): ");
            string selectedGame = Console.ReadLine();//record the user input

            if (selectedGame == "1")
            {
                SevensOut sevensOutOBJ = new SevensOut();
                sevensOutOBJ.Run();

                Debug.Assert(sevensOutOBJ.D1Value + sevensOutOBJ.D2Value == sevensOutOBJ.DiceRollsTotalP1, "PLAYER 1 TOTAL IS INCORRECT!");
                Debug.Assert(sevensOutOBJ.DiceRollsTotalP1 == 7, "PLAYER 1 GAME ENDED BUT PLAYER 1 DIDNT ROLL A 7!");
                Debug.Assert(sevensOutOBJ.D3Value + sevensOutOBJ.D4Value == sevensOutOBJ.DiceRollsTotalP2, "PLAYER 2 TOTAL IS INCORRECT!");
                Debug.Assert(sevensOutOBJ.DiceRollsTotalP2 == 7, "PLAYER 2 GAME ENDED BUT PLAYER 2 DIDNT ROLL A 7!");

            }
            else if (selectedGame == "2")
            {
                ThreeOrMore threeOrMoreOBJ = new ThreeOrMore();
                threeOrMoreOBJ.Run();

                Debug.Assert(threeOrMoreOBJ.Player1Score >= 20 || threeOrMoreOBJ.Player2Score >= 20, "GAME ENDED BUT NOBODY SCORED 20 OR ABOVE!");

                //+Three Or More: Scores set and added correctly
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }
}
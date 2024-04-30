using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    /// <summary>
    /// This class is a blueprint for both of the game classes
    /// </summary>
    internal abstract class Game
    {
        public int D1Value;
        public int D2Value;
        public int D3Value;
        public int D4Value;
        public int D5Value;
        public int Player1Score = 0;
        public int Player2Score = 0;
        public int ComputerScore = 0;
        public int DiceRollsTotalP1;
        public int DiceRollsTotalP2;

        /// <summary>
        /// This gives the user an option to either play against a partner or the computer
        /// </summary>
        public virtual void Run()
        {
            try
            {
                Console.WriteLine("####GAME TITLE HERE####");
                Console.WriteLine("=======================");
                Console.WriteLine("(1) Play against partner");
                Console.WriteLine("(2) Play against computer");
                Console.WriteLine("=======================");
                Console.Write("Select an Option (eg '1' or '2'): ");
                string selectedGame = Console.ReadLine();

                if (selectedGame == "1")
                {
                    againstPartner();
                }
                else if (selectedGame == "2")
                {
                    againstComputer();
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input!");
            }
        }

        /// <summary>
        /// forces the games that inherit this class to have an option where the player plays against a partner
        /// </summary>
        public abstract void againstPartner();

        /// <summary>
        /// forces the games that inherit this class to have an option where the player plays against the computer
        /// </summary>
        public abstract void againstComputer();
    }
}
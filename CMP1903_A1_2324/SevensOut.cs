using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{

    /// <summary>
    /// This class is inherited from the Game class
    /// </summary>
    internal class SevensOut:Game
    {
        public int D1Value;
        public int D2Value;
        public int D3Value;
        public int D4Value;
        public int DiceRollsTotalP1;
        public int DiceRollsTotalP2;
        public int originalScore;
        int player1Total = 0;
        int player2Total = 0;
        private Die dice1 = new Die();
        private Die dice2 = new Die();

        /// <summary>
        /// This gives the user an option to either play against a partner or the computer        
        /// </summary>
        public override void Run()
        {
            try
            {
                Console.WriteLine("\n      SEVENS OUT");
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
        /// This is a version of the game where the user plays against a partner
        /// </summary>
        public override void againstPartner()
        {
            Console.WriteLine("PLAYING AGAINST A PARTNER!");

            bool player1Running = true;
            bool player2Running = false;
            Console.WriteLine("\nPLAYER 1'S TURN");

            bool playing = true;
            while (playing == true)
            {
                if (player1Running == true)
                {
                    Statistsics.SEVincPlayer1NumberOfPlays();

                    Console.WriteLine("Press any key to Roll...");
                    Console.ReadKey();

                    DiceRollsTotalP1 = 0;

                    D1Value = dice1.Roll();
                    Console.WriteLine("1st Dice Roll: " + D1Value);
                    D2Value = dice2.Roll();
                    Console.WriteLine("2nd Dice Roll: " + D2Value);
                    DiceRollsTotalP1 = D1Value + D2Value;

                    if (DiceRollsTotalP1 == 7)
                    {
                        player1Total = player1Total + 7;
                        Console.WriteLine("Player 1's final score: " + player1Total);

                        Console.WriteLine("\nPLAYER 2'S TURN");
                        player1Running = false;
                        player2Running = true;
                    }
                    else
                    {
                        if (D1Value == D2Value)
                        {
                            player1Total = player1Total + (D1Value * D2Value);
                        }
                        else
                        {
                            player1Total = player1Total + DiceRollsTotalP1;
                        }
                        Console.WriteLine("Player 1 Current Score: " + player1Total);
                    }
                }

                if (player2Running == true)
                {
                    Statistsics.SEVincPlayer2NumberOfPlays();

                    Console.WriteLine("Press any key to Roll...");
                    Console.ReadKey();

                    DiceRollsTotalP2 = 0;

                    D3Value = dice1.Roll();
                    Console.WriteLine("1st Dice Roll: " + D3Value);
                    D4Value = dice2.Roll();
                    Console.WriteLine("2nd Dice Roll: " + D4Value);
                    DiceRollsTotalP2 = D3Value + D4Value;

                    if (DiceRollsTotalP2 == 7)
                    {
                        player2Total = player2Total + 7;

                        Console.WriteLine("Player 2's final score: " + player2Total);

                        player2Running = false;
                        player1Running = false;
                        playing = false;

                        Console.WriteLine("\nFINAL SCORES:");
                        Console.WriteLine("Player 1 Score: " + player1Total);
                        Console.WriteLine("Player 2 Score: " + player2Total);

                        if (player1Total>player2Total)
                        {
                            Console.WriteLine("player 1 wins!");
                            Statistsics.SEVincPlayer1NumberOfWins();

                        }
                        else if (player1Total == player2Total)
                        {
                            Console.WriteLine("Draw!");
                        }
                        else
                        {
                            Console.WriteLine("player 2 wins!");
                            Statistsics.SEVincPlayer2NumberOfWins();
                        }
                        Statistsics.SEVPlayer1HighScore(player1Total);
                        Statistsics.SEVPlayer2HighScore(player2Total);
                    }
                    else
                    {
                        if (D3Value == D4Value)
                        {
                            player2Total = player2Total + (D3Value * D4Value);
                        }
                        else
                        {
                            player2Total = player2Total + DiceRollsTotalP2;
                        }
                        Console.WriteLine("Player 2 Current Score: " + player2Total);
                    }
                }
            }
        }

        /// <summary>
        /// This is a version of the game where the user plays against the computer
        /// </summary>
        public override void againstComputer()
        {
            Console.WriteLine("PLAYING AGAINST THE COMPUTER!");

            bool player1Running = true;
            bool player2Running = false;
            Console.WriteLine("\nPLAYER 1'S TURN");

            bool playing = true;
            while (playing == true)
            {
                if (player1Running == true)
                {
                    Statistsics.SEVincPlayer1NumberOfPlays();

                    Console.WriteLine("Press any key to Roll...");
                    Console.ReadKey();

                    DiceRollsTotalP1 = 0;

                    D1Value = dice1.Roll();
                    Console.WriteLine("1st Dice Roll: " + D1Value);
                    D2Value = dice2.Roll();
                    Console.WriteLine("2nd Dice Roll: " + D2Value);
                    DiceRollsTotalP1 = D1Value + D2Value;

                    if (DiceRollsTotalP1 == 7)
                    {
                        player1Total = player1Total + 7;
                        Console.WriteLine("Player 1's final score: " + player1Total);

                        Console.WriteLine("\nCOMPUTER'S TURN");
                        player1Running = false;
                        player2Running = true;
                    }
                    else
                    {
                        if (D1Value == D2Value)
                        {
                            player1Total = player1Total + (D1Value * D2Value);
                        }
                        else
                        {
                            player1Total = player1Total + DiceRollsTotalP1;
                        }
                        Console.WriteLine("Player 1 Current Score: " + player1Total);
                    }
                }

                if (player2Running == true)
                {
                    Statistsics.SEVincComputerNumberOfPlays();

                    DiceRollsTotalP2 = 0;

                    D3Value = dice1.Roll();
                    Console.WriteLine("1st Dice Roll: " + D3Value);
                    D4Value = dice2.Roll();
                    Console.WriteLine("2nd Dice Roll: " + D4Value);
                    DiceRollsTotalP2 = D3Value + D4Value;

                    if (DiceRollsTotalP2 == 7)
                    {
                        player2Total = player2Total + 7;

                        Console.WriteLine("Computer's final score: " + player2Total);

                        player2Running = false;
                        player1Running = false;
                        playing = false;

                        Console.WriteLine("\nFINAL SCORES:");
                        Console.WriteLine("Player 1 Score: " + player1Total);
                        Console.WriteLine("Computer Score: " + player2Total);

                        if (player1Total > player2Total)
                        {
                            Console.WriteLine("player 1 wins!");
                            Statistsics.SEVincPlayer1NumberOfWins();
                        }
                        else if (player1Total == player2Total)
                        {
                            Console.WriteLine("Draw!");
                        }
                        else
                        {
                            Console.WriteLine("Computer wins!");
                            Statistsics.SEVincComputerNumberOfWins();
                        }
                        Statistsics.SEVPlayer1HighScore(player1Total);
                        Statistsics.SEVComputerHighScore(player2Total);
                    }
                    else
                    {
                        if (D3Value == D4Value)
                        {
                            player2Total = player2Total + (D3Value * D4Value);
                        }
                        else
                        {
                            player2Total = player2Total + DiceRollsTotalP2;
                        }
                        Console.WriteLine("Computer Current Score: " + player2Total);
                    }
                }
            }
        }
    }
}
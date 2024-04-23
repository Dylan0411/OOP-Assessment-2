using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class SevensOut
    {
        //-------------------------------Variables-------------------------------
        public int D1Value; //This variable will hold the value of the first rolled dice.
        public int D2Value; //This variable will hold the value of the second rolled dice.

        int player1Total = 0;
        int player2Total = 0;

        //-------------------------------Constructors-------------------------------
        private Die dice1 = new Die(); //Creates the first dice object from the 'die' class called 'dice1'.
        private Die dice2 = new Die(); //Creates the second dice object from the 'die' class called 'dice2'.

        //-------------------------------Methods-------------------------------
        public void Run() //When this is called the game runs (the 3 die's each roll and get totalled).
        {
            Console.WriteLine("\n    THREE OR MORE");
            Console.WriteLine("=======================");
            Console.WriteLine("(1) Play against partner");
            Console.WriteLine("(2) Play against computer");
            Console.WriteLine("=======================");
            Console.Write("Select an Option (eg '1' or '2'): ");
            string selectedGame = Console.ReadLine();//record the user input

            if (selectedGame == "1")
            {
                againstPartner();
            }
            else if (selectedGame == "2")
            {
                againstComputer();
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }


        public void againstPartner()
        {
            Console.WriteLine("PLAYING AGAINST A PARTNER!");

            bool player1Running = true;
            bool player2Running = false;
            Console.WriteLine("\nPLAYER 1'S TURN");

            int twoOfAKind;

            bool playing = true;
            while (playing == true)
            {

                ///////////////////////////////////
                if (player1Running == true)
                {
                    Console.WriteLine("Press any key to Roll...");
                    Console.ReadKey(); // Waits for a key press to roll die

                    int DiceRollsTotal = 0;

                    D1Value = dice1.Roll(); //Calls the 'roll' method in the 'dice1' object and assigns the returned value to 'D1Value' variable.
                    Console.WriteLine("1st Dice Roll: " + D1Value);
                    D2Value = dice2.Roll(); //Calls the 'roll' method in the 'dice2' object and assigns the returned value to 'D2Value' variable.
                    Console.WriteLine("2nd Dice Roll: " + D2Value);
                    DiceRollsTotal = D1Value + D2Value;

                    if (DiceRollsTotal == 7)
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
                            player1Total = player1Total + DiceRollsTotal;
                        }
                        Console.WriteLine("Player 1 Current Score: " + player1Total);
                    }
                }

                if (player2Running == true)
                {
                    Console.WriteLine("Press any key to Roll...");
                    Console.ReadKey(); // Waits for a key press to roll die

                    int DiceRollsTotal = 0;

                    D1Value = dice1.Roll(); //Calls the 'roll' method in the 'dice1' object and assigns the returned value to 'D1Value' variable.
                    Console.WriteLine("1st Dice Roll: " + D1Value);
                    D2Value = dice2.Roll(); //Calls the 'roll' method in the 'dice2' object and assigns the returned value to 'D2Value' variable.
                    Console.WriteLine("2nd Dice Roll: " + D2Value);
                    DiceRollsTotal = D1Value + D2Value;

                    if (DiceRollsTotal == 7)
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
                        }
                        else if (player1Total == player2Total)
                        {
                            Console.WriteLine("Draw!");
                        }
                        else
                        {
                            Console.WriteLine("player 2 wins!");
                        }

                    }
                    else
                    {
                        if (D1Value == D2Value)
                        {
                            player2Total = player2Total + (D1Value * D2Value);
                        }
                        else
                        {
                            player2Total = player2Total + DiceRollsTotal;
                        }
                        Console.WriteLine("Player 2 Current Score: " + player2Total);

                    }
                }
            }
        }








        public void againstComputer()
        {
            Console.WriteLine("PLAYING AGAINST THE COMPUTER!");

            bool player1Running = true;
            bool player2Running = false;
            Console.WriteLine("\nPLAYER 1'S TURN");

            int twoOfAKind;

            bool playing = true;
            while (playing == true)
            {

                ///////////////////////////////////
                if (player1Running == true)
                {
                    Console.WriteLine("Press any key to Roll...");
                    Console.ReadKey(); // Waits for a key press to roll die

                    int DiceRollsTotal = 0;

                    D1Value = dice1.Roll(); //Calls the 'roll' method in the 'dice1' object and assigns the returned value to 'D1Value' variable.
                    Console.WriteLine("1st Dice Roll: " + D1Value);
                    D2Value = dice2.Roll(); //Calls the 'roll' method in the 'dice2' object and assigns the returned value to 'D2Value' variable.
                    Console.WriteLine("2nd Dice Roll: " + D2Value);
                    DiceRollsTotal = D1Value + D2Value;

                    if (DiceRollsTotal == 7)
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
                            player1Total = player1Total + DiceRollsTotal;
                        }
                        Console.WriteLine("Player 1 Current Score: " + player1Total);
                    }
                }

                if (player2Running == true)
                {

                    int DiceRollsTotal = 0;

                    D1Value = dice1.Roll(); //Calls the 'roll' method in the 'dice1' object and assigns the returned value to 'D1Value' variable.
                    Console.WriteLine("1st Dice Roll: " + D1Value);
                    D2Value = dice2.Roll(); //Calls the 'roll' method in the 'dice2' object and assigns the returned value to 'D2Value' variable.
                    Console.WriteLine("2nd Dice Roll: " + D2Value);
                    DiceRollsTotal = D1Value + D2Value;

                    if (DiceRollsTotal == 7)
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
                        }
                        else if (player1Total == player2Total)
                        {
                            Console.WriteLine("Draw!");
                        }
                        else
                        {
                            Console.WriteLine("Computer wins!");
                        }

                    }
                    else
                    {
                        if (D1Value == D2Value)
                        {
                            player2Total = player2Total + (D1Value * D2Value);
                        }
                        else
                        {
                            player2Total = player2Total + DiceRollsTotal;
                        }
                        Console.WriteLine("Computer Current Score: " + player2Total);

                    }
                }
            }
        }
    }



}
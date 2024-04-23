using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class ThreeOrMore
    {
        //-------------------------------Variables-------------------------------
        public int D1Value; //This variable will hold the value of the first rolled dice.
        public int D2Value; //This variable will hold the value of the second rolled dice.
        public int D3Value;
        public int D4Value;
        public int D5Value;
        public int Player1Sum = 0; //This variable will hold the value of sum of the 3 dice values.
        public int Player2Sum = 0; //This variable will hold the value of sum of the 3 dice values.
        public int ComputerSum = 0; //This variable will hold the value of sum of the 3 dice values.
        public int Player1Score = 0;
        public int Player2Score = 0;
        public int ComputerScore = 0;


        //-------------------------------Constructors-------------------------------
        private Die dice1 = new Die(); //Creates the first dice object from the 'die' class called 'dice1'.
        private Die dice2 = new Die(); //Creates the second dice object from the 'die' class called 'dice2'.
        private Die dice3 = new Die();
        private Die dice4 = new Die();
        private Die dice5 = new Die();

        List<int> DiceRollsList = new List<int>();
        List<int> DiceRepeatsList = new List<int>();


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
            bool player1Running = true;
            bool player2Running = false;
            Console.WriteLine("\nPLAYER 1'S TURN");

            bool playing = true;
            while (playing == true)
            {

                ///////////////////////////////////
                if (player1Running == true)
                {
                    Console.WriteLine("Press any key to Play...");
                    Console.ReadKey(); // Waits for a key press to roll die
                    RollTheDie();

                    int Location2 = 0;
                    for (int i = 0; i < 6; i++)//loops for each POSSIBLE DIE ROLL VALUE)
                    {
                        if (DiceRepeatsList[Location2] == 2)//checks for 3 of a kind
                        {

                            Console.WriteLine("TWO OF A KIND");
                            Console.WriteLine("OPTIONS");
                            Console.WriteLine("(1) reroll ALL die");
                            Console.WriteLine("(1) reroll ALL die");
                            Console.Write("Select an Option (eg '1' or '2'): ");
                            string selectedOption = Console.ReadLine();//record the user input

                            if (selectedOption == "1")
                            {
                                RollTheDie();
                            }
                            else if (selectedOption == "2")
                            {
                                againstComputer();
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input!");
                            }
                            //REROLL ALL DIE
                            //..Location2 = 0;
                            //..BREAK LOOP
                            //or REROLL REMAINING DIE
                            //..GL
                        }
                        Location2++;
                    }
                    Location2 = 0;
                    for (int i = 0; i < 6; i++)//loops for each POSSIBLE DIE ROLL VALUE)
                    {
                        if (DiceRepeatsList[Location2] == 3)//checks for 3 of a kind
                        {
                            Console.WriteLine("THREE OF A KIND");
                            Player1Score = Player1Score + 3;
                        }
                        Location2++;
                    }
                    Location2 = 0;
                    for (int i = 0; i < 6; i++)//loops for each POSSIBLE DIE ROLL VALUE)
                    {
                        if (DiceRepeatsList[Location2] == 4)//checks for 3 of a kind
                        {
                            Console.WriteLine("FOUR OF A KIND");
                            Player1Score = Player1Score + 6;
                        }
                        Location2++;
                    }
                    Location2 = 0;
                    for (int i = 0; i < 6; i++)//loops for each POSSIBLE DIE ROLL VALUE)
                    {
                        if (DiceRepeatsList[Location2] == 5)//checks for 3 of a kind
                        {
                            Console.WriteLine("FIVE OF A KIND");
                            Player1Score = Player1Score + 12;
                        }
                        Location2++;
                    }
                    Console.WriteLine("Player 1 Current Score: " + Player1Score);
                    if (Player1Score >= 20)
                    {
                        Console.WriteLine("Player 1 win!");
                        player1Running = false;
                        playing = false;

                        //BREAK LOOP
                    }
                    else
                    {
                        Console.WriteLine("\nPLAYER 2'S TURN");
                        //player2
                        player1Running = false;
                        player2Running = true;
                    }



                }
                if (player2Running == true)
                {
                    Console.WriteLine("Press any key to Play...");
                    Console.ReadKey(); // Waits for a key press to roll die
                    RollTheDie();

                    int Location2 = 0;
                    for (int i = 0; i < 6; i++)//loops for each POSSIBLE DIE ROLL VALUE)
                    {
                        if (DiceRepeatsList[Location2] == 2)//checks for 3 of a kind
                        {
                            Console.WriteLine("TWO OF A KIND");
                            //REROLL ALL DIE
                            //..Location2 = 0;
                            //..BREAK LOOP
                            //or REROLL REMAINING DIE
                            //..GL
                        }
                        Location2++;
                    }
                    Location2 = 0;
                    for (int i = 0; i < 6; i++)//loops for each POSSIBLE DIE ROLL VALUE)
                    {
                        if (DiceRepeatsList[Location2] == 3)//checks for 3 of a kind
                        {
                            Console.WriteLine("THREE OF A KIND");
                            Player2Score = Player2Score + 3;
                        }
                        Location2++;
                    }
                    Location2 = 0;
                    for (int i = 0; i < 6; i++)//loops for each POSSIBLE DIE ROLL VALUE)
                    {
                        if (DiceRepeatsList[Location2] == 4)//checks for 3 of a kind
                        {
                            Console.WriteLine("FOUR OF A KIND");
                            Player2Score = Player2Score + 6;
                        }
                        Location2++;
                    }
                    Location2 = 0;
                    for (int i = 0; i < 6; i++)//loops for each POSSIBLE DIE ROLL VALUE)
                    {
                        if (DiceRepeatsList[Location2] == 5)//checks for 3 of a kind
                        {
                            Console.WriteLine("FIVE OF A KIND");
                            Player2Score = Player2Score + 12;
                        }
                        Location2++;
                    }
                    Console.WriteLine("Player 2 Current Score: " + Player2Score);
                    if (Player2Score >= 20)
                    {
                        Console.WriteLine("Player 2 win!");
                        player2Running = false;
                        playing = false;

                        //BREAK LOOP
                    }
                    else
                    {
                        Console.WriteLine("\nPLAYER 1'S TURN");
                        //player2
                        player1Running = true;
                        player2Running = false;

                    }



                }




            }











        }

        public List<int> RollTheDie()
        {
            //EMPTY LIST
            DiceRollsList.Clear();

            D1Value = dice1.Roll(); //Calls the 'roll' method in the 'dice1' object and assigns the returned value to 'D1Value' variable.
            DiceRollsList.Add(D1Value);
            Console.WriteLine("1st Dice Roll: " + D1Value);
            D2Value = dice2.Roll(); //Calls the 'roll' method in the 'dice2' object and assigns the returned value to 'D2Value' variable.
            DiceRollsList.Add(D2Value);
            Console.WriteLine("2nd Dice Roll: " + D2Value);
            D3Value = dice3.Roll();
            DiceRollsList.Add(D3Value);
            Console.WriteLine("3rd Dice Roll: " + D3Value);
            D4Value = dice4.Roll();
            DiceRollsList.Add(D4Value);
            Console.WriteLine("4th Dice Roll: " + D4Value);
            D5Value = dice5.Roll();
            DiceRollsList.Add(D5Value);
            Console.WriteLine("5th Dice Roll: " + D5Value);

            //DIE CHECKER

            int ones = 0;
            int twos = 0;
            int threes = 0;
            int fours = 0;
            int fives = 0;
            int sixes = 0;
            int Location = 0;

            for (int ii = 0; ii < 5; ii++)//loops for each die (5 dies = loops 5 times)
            {
                //loop to check one die at a time
                if (DiceRollsList[Location] == 1)
                {
                    ones++;
                }
                if (DiceRollsList[Location] == 2)
                {
                    twos++;
                }
                if (DiceRollsList[Location] == 3)
                {
                    threes++;
                }
                if (DiceRollsList[Location] == 4)
                {
                    fours++;
                }
                if (DiceRollsList[Location] == 5)
                {
                    fives++;
                }
                if (DiceRollsList[Location] == 6)
                {
                    sixes++;
                }
                Location++;
            }
            //EMPTY LIST
            DiceRepeatsList.Clear();

            DiceRepeatsList.Add(ones);
            DiceRepeatsList.Add(twos);
            DiceRepeatsList.Add(threes);
            DiceRepeatsList.Add(fours);
            DiceRepeatsList.Add(fives);
            DiceRepeatsList.Add(sixes);
            //DEBUGGER
            //Console.WriteLine(ones);
            //Console.WriteLine(twos);
            //Console.WriteLine(threes);
            //Console.WriteLine(fours);
            //Console.WriteLine(fives);
            //Console.WriteLine(sixes);

            return DiceRepeatsList;
        }




























        public void againstComputer()
        {
            //D1Value = dice1.Roll(); //Calls the 'roll' method in the 'dice1' object and assigns the returned value to 'D1Value' variable.
            //D2Value = dice2.Roll(); //Calls the 'roll' method in the 'dice2' object and assigns the returned value to 'D2Value' variable.
            //D3Value = dice3.Roll(); //Calls the 'roll' method in the 'dice3' object and assigns the returned value to 'D3Value' variable.

            //sum = D1Value + D2Value + D3Value; //This adds the values from the 3 dice rolls and assigns the result to the 'sum' variable.
        }

    }
}
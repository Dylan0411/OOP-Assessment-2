using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{

    /// <summary>
    /// This class is inherited from the Game class
    /// </summary>
    internal class ThreeOrMore:Game
    {
        private Die dice1 = new Die();
        private Die dice2 = new Die();
        private Die dice3 = new Die();
        private Die dice4 = new Die();
        private Die dice5 = new Die();
        List<int> DiceRollsList = new List<int>();
        public List<int> DiceRepeatsList = new List<int>();
        public int originalScore;

        /// <summary>
        /// This gives the user an option to either play against a partner or the computer        
        /// </summary>
        public override void Run()
        {
            try
            {
                Console.WriteLine("\n     THREE OR MORE");
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

            int twoOfAKind;

            bool playing = true;
            while (playing == true)
            {
                if (player1Running == true)
                {
                    Statistsics.THREEincPlayer1NumberOfPlays();

                    Console.WriteLine("Press any key to Play...");
                    Console.ReadKey();
                    RollTheDie(0);

                    int Location2 = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        if (DiceRepeatsList[Location2] == 2)
                        {
                            try
                            {
                                Console.WriteLine("TWO OF A KIND");
                                Console.WriteLine("OPTIONS");
                                Console.WriteLine("(1) reroll ALL die");
                                Console.WriteLine("(2) reroll the REMAINING die");
                                Console.Write("Select an Option (eg '1' or '2'): ");
                                string selectedOption = Console.ReadLine();

                                if (selectedOption == "1")
                                {
                                    RollTheDie(0);
                                }
                                else if (selectedOption == "2")
                                {
                                    twoOfAKind = 0;
                                    int Location3 = 0;

                                    bool searching = true;
                                    while (searching == true)
                                    {
                                        if (DiceRepeatsList[Location3] == 2)
                                        {
                                            twoOfAKind = Location3 + 1;
                                            searching = false;
                                            RollTheDie(twoOfAKind);
                                        }
                                        else
                                        {
                                            Location3++;
                                        }
                                    }
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Invalid Input!");
                            }
                        }
                        Location2++;
                    }
                    Location2 = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        if (DiceRepeatsList[Location2] == 3)
                        {
                            Console.WriteLine("THREE OF A KIND");
                            originalScore = Player2Score;
                            Player1Score = Player1Score + 3;
                        }
                        Location2++;
                    }
                    Location2 = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        if (DiceRepeatsList[Location2] == 4)
                        {
                            Console.WriteLine("FOUR OF A KIND");
                            originalScore = Player2Score;
                            Player1Score = Player1Score + 6;
                        }
                        Location2++;
                    }
                    Location2 = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        if (DiceRepeatsList[Location2] == 5)
                        {
                            Console.WriteLine("FIVE OF A KIND");
                            originalScore = Player2Score;
                            Player1Score = Player1Score + 12;
                        }
                        Location2++;
                    }
                    Console.WriteLine("Player 1 Current Score: " + Player1Score);
                    if (Player1Score >= 20)
                    {
                        Console.WriteLine("Player 1 win!");

                        Statistsics.THREEincPlayer1NumberOfWins();

                        player1Running = false;
                        playing = false;
                    }
                    else
                    {
                        Console.WriteLine("\nPLAYER 2'S TURN");

                        player1Running = false;
                        player2Running = true;
                    }
                }
                if (player2Running == true)
                {
                    Statistsics.THREEincPlayer2NumberOfPlays();

                    Console.WriteLine("Press any key to Play...");
                    Console.ReadKey();
                    RollTheDie(0);

                    int Location2 = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        if (DiceRepeatsList[Location2] == 2)
                        {
                            try
                            {
                                Console.WriteLine("TWO OF A KIND");
                                Console.WriteLine("OPTIONS");
                                Console.WriteLine("(1) reroll ALL die");
                                Console.WriteLine("(2) reroll the REMAINING die");
                                Console.Write("Select an Option (eg '1' or '2'): ");
                                string selectedOption = Console.ReadLine();

                                if (selectedOption == "1")
                                {
                                    RollTheDie(0);
                                }
                                else if (selectedOption == "2")
                                {
                                    twoOfAKind = 0;
                                    int Location3 = 0;

                                    bool searching = true;
                                    while (searching == true)
                                    {
                                        if (DiceRepeatsList[Location3] == 2)
                                        {
                                            twoOfAKind = Location3 + 1;
                                            searching = false;
                                            RollTheDie(twoOfAKind);
                                        }
                                        else
                                        {
                                            Location3++;
                                        }
                                    }
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Invalid Input!");
                            }
                            Location2++;
                        }
                    }
                    Location2 = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        if (DiceRepeatsList[Location2] == 3)
                        {
                            Console.WriteLine("THREE OF A KIND");
                            originalScore = Player2Score;
                            Player2Score = Player2Score + 3;
                        }
                        Location2++;
                    }
                    Location2 = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        if (DiceRepeatsList[Location2] == 4)
                        {
                            Console.WriteLine("FOUR OF A KIND");
                            originalScore = Player2Score;
                            Player2Score = Player2Score + 6;
                        }
                        Location2++;
                    }
                    Location2 = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        if (DiceRepeatsList[Location2] == 5)
                        {
                            Console.WriteLine("FIVE OF A KIND");
                            originalScore = Player2Score;
                            Player2Score = Player2Score + 12;
                        }
                        Location2++;
                    }
                    Console.WriteLine("Player 2 Current Score: " + Player2Score);
                    if (Player2Score >= 20)
                    {
                        Console.WriteLine("Player 2 win!");

                        Statistsics.THREEincPlayer2NumberOfWins();

                        player2Running = false;
                        playing = false;
                    }
                    else
                    {
                        Console.WriteLine("\nPLAYER 1'S TURN");
                        player1Running = true;
                        player2Running = false;
                    }
                }
            }
        }

        /// <summary>
        /// This method rolls 5 of the die if its the start of the game or 3 die if they previously rolled a 'two of a kind' (based on parameter value)
        /// </summary>
        /// <param name="twoOfAKindValueDie"></param>
        /// <returns></returns>
        public List<int> RollTheDie(int twoOfAKindValueDie)
        {
            DiceRollsList.Clear();

            if (twoOfAKindValueDie == 0)
            {
                D1Value = dice1.Roll();
                DiceRollsList.Add(D1Value);
                Console.WriteLine("1st Dice Roll: " + D1Value);
                D2Value = dice2.Roll();
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
            }
            else
            {
                D1Value = twoOfAKindValueDie;
                DiceRollsList.Add(D1Value);
                Console.WriteLine("1st Dice Roll: " + D1Value);
                D2Value = twoOfAKindValueDie;
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
            }

            int ones = 0;
            int twos = 0;
            int threes = 0;
            int fours = 0;
            int fives = 0;
            int sixes = 0;
            int Location = 0;

            for (int ii = 0; ii < 5; ii++)
            {
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
            DiceRepeatsList.Clear();

            DiceRepeatsList.Add(ones);
            DiceRepeatsList.Add(twos);
            DiceRepeatsList.Add(threes);
            DiceRepeatsList.Add(fours);
            DiceRepeatsList.Add(fives);
            DiceRepeatsList.Add(sixes);

            return DiceRepeatsList;
        }

        /// <summary>
        /// This is a version of the game where the user plays against the computer
        /// </summary>
        public override void againstComputer()
        {
            Console.WriteLine("PLAYING AGAINST THE COMPUTER!");

            bool player1Running = true;
            bool computerRunning = false;
            Console.WriteLine("\nPLAYER 1'S TURN");

            int twoOfAKind;

            bool playing = true;
            while (playing == true)
            {
                if (player1Running == true)
                {
                    Statistsics.THREEincPlayer1NumberOfPlays();

                    Console.WriteLine("Press any key to Play...");
                    Console.ReadKey();
                    RollTheDie(0);

                    int Location2 = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        if (DiceRepeatsList[Location2] == 2)
                        {
                            try
                            {
                                Console.WriteLine("TWO OF A KIND");
                                Console.WriteLine("OPTIONS");
                                Console.WriteLine("(1) reroll ALL die");
                                Console.WriteLine("(2) reroll the REMAINING die");
                                Console.Write("Select an Option (eg '1' or '2'): ");
                                string selectedOption = Console.ReadLine();

                                if (selectedOption == "1")
                                {
                                    RollTheDie(0);
                                }
                                else if (selectedOption == "2")
                                {
                                    twoOfAKind = 0;
                                    int Location3 = 0;

                                    bool searching = true;
                                    while (searching == true)
                                    {
                                        if (DiceRepeatsList[Location3] == 2)
                                        {
                                            twoOfAKind = Location3 + 1;
                                            searching = false;
                                            RollTheDie(twoOfAKind);
                                        }
                                        else
                                        {
                                            Location3++;
                                        }
                                    }
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Invalid Input!");
                            }
                        }
                        Location2++;
                    }
                    Location2 = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        if (DiceRepeatsList[Location2] == 3)
                        {
                            Console.WriteLine("THREE OF A KIND");
                            originalScore = Player1Score;
                            Player1Score = Player1Score + 3;
                        }
                        Location2++;
                    }
                    Location2 = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        if (DiceRepeatsList[Location2] == 4)
                        {
                            Console.WriteLine("FOUR OF A KIND");
                            originalScore = Player1Score;
                            Player1Score = Player1Score + 6;
                        }
                        Location2++;
                    }
                    Location2 = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        if (DiceRepeatsList[Location2] == 5)
                        {
                            Console.WriteLine("FIVE OF A KIND");
                            originalScore = Player1Score;
                            Player1Score = Player1Score + 12;
                        }
                        Location2++;
                    }
                    Console.WriteLine("Player 1 Current Score: " + Player1Score);
                    if (Player1Score >= 20)
                    {
                        Console.WriteLine("Player 1 win!");

                        Statistsics.THREEincPlayer1NumberOfWins();

                        player1Running = false;
                        playing = false;
                    }
                    else
                    {
                        Console.WriteLine("\nCOMPUTERS TURN");
                        player1Running = false;
                        computerRunning = true;
                    }
                }
                if (computerRunning == true)
                {
                    Statistsics.THREEincComputerNumberOfPlays();

                    Console.WriteLine("Computer rolls the die...");
                    RollTheDie(0);

                    int Location2 = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        if (DiceRepeatsList[Location2] == 2)
                        {
                            try
                            {
                                Console.WriteLine("TWO OF A KIND");
                                Console.WriteLine("OPTIONS");
                                Console.WriteLine("(1) reroll ALL die");
                                Console.WriteLine("(2) reroll the REMAINING die");

                                Random random = new Random();
                                int selectedOption = random.Next(1, 3);
                                Console.WriteLine("Computer Chooses Option: " + selectedOption);

                                if (selectedOption == 1)
                                {
                                    RollTheDie(0);
                                }
                                else if (selectedOption == 2)
                                {
                                    twoOfAKind = 0;
                                    int Location3 = 0;

                                    bool searching = true;
                                    while (searching == true)
                                    {
                                        if (DiceRepeatsList[Location3] == 2)
                                        {
                                            twoOfAKind = Location3 + 1;
                                            searching = false;
                                            RollTheDie(twoOfAKind);
                                        }
                                        else
                                        {
                                            Location3++;
                                        }
                                    }
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Invalid Input!");
                            }
                            Location2++;
                        }
                    }
                    Location2 = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        if (DiceRepeatsList[Location2] == 3)
                        {
                            Console.WriteLine("THREE OF A KIND");
                            originalScore = Player2Score;
                            Player2Score = Player2Score + 3;
                        }
                        Location2++;
                    }
                    Location2 = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        if (DiceRepeatsList[Location2] == 4)
                        {
                            Console.WriteLine("FOUR OF A KIND");
                            originalScore = Player2Score;
                            Player2Score = Player2Score + 6;
                        }
                        Location2++;
                    }
                    Location2 = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        if (DiceRepeatsList[Location2] == 5)
                        {
                            Console.WriteLine("FIVE OF A KIND");
                            originalScore = Player2Score;
                            Player2Score = Player2Score + 12;
                        }
                        Location2++;
                    }
                    Console.WriteLine("Computer Current Score: " + Player2Score);
                    if (Player2Score >= 20)
                    {
                        Console.WriteLine("Computer win!");

                        Statistsics.THREEincComputerNumberOfWins();

                        computerRunning = false;
                        playing = false;
                    }
                    else
                    {
                        Console.WriteLine("\nPLAYER 1'S TURN");

                        player1Running = true;
                        computerRunning = false;
                    }
                }
            }
        }
    }
}
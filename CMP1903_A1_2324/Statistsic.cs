using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Statistsics
    {
        //store: number of plays, high-scores, etc 
        public static int SEVp1NOP = 0; //"player one number of plays" 
        public static int SEVp2NOP = 0; //"player two number of plays" 
        public static int SEVcomNOP = 0; //"computer number of plays" 
        public static int SEVp1NOW = 0; //"player one number of wins" 
        public static int SEVp2NOW = 0; //"player two number of wins" 
        public static int SEVcomNOW = 0; //"computer number of wins" 
        public static int SEVP1HS = 0;  //"player one high score" 
        public static int SEVP2HS = 0;  //"player one high score" 
        public static int SEVcomHS = 0;  //"computer high score" 
        //
        public static int THREEp1NOP = 0; //"player one number of plays" 
        public static int THREEp2NOP = 0; //"player two number of plays" 
        public static int THREEcomNOP = 0; //"computer number of plays" 

        public static string filePath = Path.Combine(Environment.CurrentDirectory, "StatisticsClassLogFile.txt");
        public static List<string> Stats = File.ReadAllLines(filePath).ToList(); //Read each line and add it to the array

        public static void Run()
        {
            //Console.WriteLine(fullPath);

            Console.WriteLine("OPTIONS");
            Console.WriteLine("(1) Display Data within the TXT File");
            Console.WriteLine("(2) Reset All data within the TXT File");
            Console.Write("Select an Option (eg '1' or '2'): ");
            string selectedOption = Console.ReadLine();//record the user input

            if (selectedOption == "1")
            {
                DisplayStats();
            }
            else if (selectedOption == "2")
            {
                resetData();
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }

        public static void SEVincPlayer1NumberOfPlays()
        {
            SEVp1NOP++;
        }
        public static void SEVincPlayer2NumberOfPlays()
        {
            SEVp2NOP++;
        }
        public static void SEVincComputerNumberOfPlays()
        {
            SEVcomNOP++;
        }
        //
        public static void SEVPlayer1HighScore(int newScore)
        {
            if (newScore > SEVP1HS)
            {
                SEVP1HS = newScore;

                int tempVal = Convert.ToInt32(Stats[2]);
                tempVal = tempVal + SEVP1HS;
                Stats[2] = tempVal.ToString();

                File.WriteAllLines(filePath, Stats);
            }
            int tempVal1 = Convert.ToInt32(Stats[0]);
            tempVal1 = tempVal1 + SEVp1NOP;
            Stats[0] = tempVal1.ToString();

            File.WriteAllLines(filePath, Stats);
        }
        public static void SEVPlayer2HighScore(int newScore)
        {
            if (newScore > SEVP2HS)
            {
                SEVP2HS = newScore;

                int tempVal = Convert.ToInt32(Stats[5]);
                tempVal = tempVal + SEVP2HS;
                Stats[5] = tempVal.ToString();

                File.WriteAllLines(filePath, Stats);
            }
            int tempVal1 = Convert.ToInt32(Stats[3]);
            tempVal1 = tempVal1 + SEVp2NOP;
            Stats[3] = tempVal1.ToString();

            File.WriteAllLines(filePath, Stats);
        }
        public static void SEVComputerHighScore(int newScore)
        {
            if (newScore > SEVcomHS)
            {
                SEVcomHS = newScore;

                int tempVal = Convert.ToInt32(Stats[8]);
                tempVal = tempVal + SEVcomHS;
                Stats[8] = tempVal.ToString();

                File.WriteAllLines(filePath, Stats);
            }
            int tempVal1 = Convert.ToInt32(Stats[6]);
            tempVal1 = tempVal1 + SEVcomNOP;
            Stats[6] = tempVal1.ToString();

            File.WriteAllLines(filePath, Stats);
        }
        //
        public static void SEVincPlayer1NumberOfWins()
        {
            SEVp1NOW++;

            int tempVal = Convert.ToInt32(Stats[1]);
            tempVal = tempVal + SEVp1NOW;
            Stats[1] = tempVal.ToString();

            File.WriteAllLines(filePath, Stats);
        }
        public static void SEVincPlayer2NumberOfWins()
        {
            SEVp2NOW++;

            int tempVal = Convert.ToInt32(Stats[4]);
            tempVal = tempVal + SEVp2NOW;
            Stats[4] = tempVal.ToString();

            File.WriteAllLines(filePath, Stats);
        }
        public static void SEVincComputerNumberOfWins()
        {
            SEVcomNOW++;

            int tempVal = Convert.ToInt32(Stats[7]);
            tempVal = tempVal + SEVcomNOW;
            Stats[7] = tempVal.ToString();

            File.WriteAllLines(filePath, Stats);
        }
        /////////
        public static void THREEincPlayer1NumberOfPlays()
        {
            THREEp1NOP++;
        }
        public static void THREEincPlayer2NumberOfPlays()
        {
            THREEp2NOP++;
        }
        public static void THREEincComputerNumberOfPlays()
        {
            THREEcomNOP++;
        }
        //
        public static void THREEincPlayer1NumberOfWins()
        {
            int tempVal = Convert.ToInt32(Stats[10]);
            tempVal = tempVal + 1;
            Stats[10] = tempVal.ToString();

            File.WriteAllLines(filePath, Stats);
            ////RECORD NUMBER OF PLAYS
            int tempVal1 = Convert.ToInt32(Stats[9]);
            tempVal1 = tempVal1 + THREEp1NOP;
            Stats[9] = tempVal1.ToString();
            File.WriteAllLines(filePath, Stats);
            //
            int tempVal2 = Convert.ToInt32(Stats[11]);
            tempVal2 = tempVal2 + THREEp2NOP;
            Stats[11] = tempVal2.ToString();
            File.WriteAllLines(filePath, Stats);
            //
            int tempVal3 = Convert.ToInt32(Stats[13]);
            tempVal3 = tempVal3 + THREEcomNOP;
            Stats[13] = tempVal3.ToString();
            File.WriteAllLines(filePath, Stats);
        }
        public static void THREEincPlayer2NumberOfWins()
        {
            int tempVal = Convert.ToInt32(Stats[12]);
            tempVal = tempVal + 1;
            Stats[12] = tempVal.ToString();

            File.WriteAllLines(filePath, Stats);
            ////RECORD NUMBER OF PLAYS
            int tempVal1 = Convert.ToInt32(Stats[9]);
            tempVal1 = tempVal1 + THREEp1NOP;
            Stats[9] = tempVal1.ToString();
            File.WriteAllLines(filePath, Stats);
            //
            int tempVal2 = Convert.ToInt32(Stats[11]);
            tempVal2 = tempVal2 + THREEp2NOP;
            Stats[11] = tempVal2.ToString();
            File.WriteAllLines(filePath, Stats);
            //
            int tempVal3 = Convert.ToInt32(Stats[13]);
            tempVal3 = tempVal3 + THREEcomNOP;
            Stats[13] = tempVal3.ToString();
            File.WriteAllLines(filePath, Stats);
        }
        public static void THREEincComputerNumberOfWins()
        {
            int tempVal = Convert.ToInt32(Stats[14]);
            tempVal = tempVal + 1;
            Stats[14] = tempVal.ToString();

            File.WriteAllLines(filePath, Stats);
            ////RECORD NUMBER OF PLAYS
            int tempVal1 = Convert.ToInt32(Stats[9]);
            tempVal1 = tempVal1 + THREEp1NOP;
            Stats[9] = tempVal1.ToString();
            File.WriteAllLines(filePath, Stats);
            //
            int tempVal2 = Convert.ToInt32(Stats[11]);
            tempVal2 = tempVal2 + THREEp2NOP;
            Stats[11] = tempVal2.ToString();
            File.WriteAllLines(filePath, Stats);
            //
            int tempVal3 = Convert.ToInt32(Stats[13]);
            tempVal3 = tempVal3 + THREEcomNOP;
            Stats[13] = tempVal3.ToString();
            File.WriteAllLines(filePath, Stats);
        }

        public static void DisplayStats()
        {
            Console.WriteLine("\n  STATISTICS FOR SEVENS OUT:");
            Console.WriteLine("=============================");

            Console.WriteLine("Player 1 stats...");
            Console.WriteLine("Number of plays: " + Stats[0]);
            Console.WriteLine("Number of wins: " + Stats[1]);
            Console.WriteLine("High Score: " + Stats[2]);
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Player 2 stats...");
            Console.WriteLine("Number of plays: " + Stats[3]);
            Console.WriteLine("Number of wins: " + Stats[4]);
            Console.WriteLine("High Score: " + Stats[5]);
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Computers stats...");
            Console.WriteLine("Number of plays: " + Stats[6]);
            Console.WriteLine("Number of wins: " + Stats[7]);
            Console.WriteLine("High Score: " + Stats[8]);

            Console.WriteLine("=============================");
            //
            Console.WriteLine("\nSTATISTICS FOR THREE OR MORE:");
            Console.WriteLine("=============================");

            Console.WriteLine("Player 1 stats...");
            Console.WriteLine("Number of plays: " + Stats[9]);
            Console.WriteLine("Number of wins: " + Stats[10]);
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Player 2 stats...");
            Console.WriteLine("Number of plays: " + Stats[11]);
            Console.WriteLine("Number of wins: " + Stats[12]);
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Computers stats...");
            Console.WriteLine("Number of plays: " + Stats[13]);
            Console.WriteLine("Number of wins: " + Stats[14]);

            Console.WriteLine("=============================");
        }
        public static void resetData()
        {
            Stats[0] = "00";
            Stats[1] = "00";
            Stats[2] = "00";
            Stats[3] = "00";
            Stats[4] = "00";
            Stats[5] = "00";
            Stats[6] = "00";
            Stats[7] = "00";
            Stats[8] = "00";
            Stats[9] = "00";
            Stats[10] = "00";
            Stats[11] = "00";
            Stats[12] = "00";
            Stats[13] = "00";
            Stats[14] = "00";

            File.WriteAllLines(filePath, Stats);

            Console.WriteLine("DATA RESET");
            DisplayStats();
        }
    }
}
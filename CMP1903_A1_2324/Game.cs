using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        private static void Main(string[] args) //Where the program starts...
        {
            Console.WriteLine("OPTIONS:");
            Console.WriteLine("=======================");
            Console.WriteLine("(1) Play 'Sevens Out'");
            Console.WriteLine("(2) Play 'Three Or More'");
            Console.WriteLine("(3) Statistical Data");
            Console.WriteLine("(4) Perform Tests");
            Console.WriteLine("=======================");
            Console.Write("Select an Option (eg '1', '2', '3' or '4'): ");
            string selectedGame= Console.ReadLine();//record the user input

            if (selectedGame == "1")
            {
                Console.WriteLine("SEVENS OUT");

                SevensOut sevensOut = new SevensOut();
                sevensOut.Run();
            }
            else if (selectedGame == "2")
            {
                Console.WriteLine("\n    THREE OR MORE");

                ThreeOrMore threeOrMore = new ThreeOrMore();
                threeOrMore.Run();
            }
            else if (selectedGame == "3")
            {
                Statistsics.Run();
            }
            else if (selectedGame == "4")
            {
                Console.WriteLine("NOT YET MADE!");
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }
}
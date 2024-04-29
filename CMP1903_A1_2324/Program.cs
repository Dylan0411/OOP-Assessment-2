using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    /// <summary>
    /// This class is where the program starts
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// This allows the user to select what they initially want to do
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("OPTIONS:");
                Console.WriteLine("=======================");
                Console.WriteLine("(1) Play 'Sevens Out'");
                Console.WriteLine("(2) Play 'Three Or More'");
                Console.WriteLine("(3) Statistical Data");
                Console.WriteLine("(4) Perform Tests");
                Console.WriteLine("=======================");
                Console.Write("Select an Option (eg '1', '2', '3' or '4'): ");
                string selectedGame = Console.ReadLine();

                if (selectedGame == "1")
                {
                    SevensOut sevensOut = new SevensOut();
                    sevensOut.Run();
                }
                else if (selectedGame == "2")
                {
                    ThreeOrMore threeOrMore = new ThreeOrMore();
                    threeOrMore.Run();
                }
                else if (selectedGame == "3")
                {
                    Statistsics.Run();
                }
                else if (selectedGame == "4")
                {
                    Console.WriteLine("\n-TESTING MODE ACTIVATED-");
                    Testing testingOBJ = new Testing();
                    testingOBJ.runTests();
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }
}
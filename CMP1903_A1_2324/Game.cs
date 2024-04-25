using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal abstract class Game
    {
        public virtual void Run() //When this is called the game runs (the 3 die's each roll and get totalled).
        {
            Console.WriteLine("####GAME TITLE HERE####");
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

        public abstract void againstPartner();
        public abstract void againstComputer();

    }
}
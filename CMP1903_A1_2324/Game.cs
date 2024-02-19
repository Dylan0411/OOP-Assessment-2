using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        //-------------------------------Variables-------------------------------
        public int D1Value; //This variable will hold the value of the first rolled dice.
        public int D2Value; //This variable will hold the value of the second rolled dice.
        public int D3Value; //This variable will hold the value of the third rolled dice.
        public int sum; //This variable will hold the value of sum of the 3 dice values.

        //-------------------------------Constructors-------------------------------
        private Die dice1 = new Die(); //Creates the first dice object from the 'die' class called 'dice1'.
        private Die dice2 = new Die(); //Creates the second dice object from the 'die' class called 'dice2'.
        private Die dice3 = new Die(); //Creates the third dice object from the 'die' class called 'dice3'.

        //-------------------------------Methods-------------------------------
        public int Run() //When this is called the game runs (the 3 die's each roll and get totalled).
        {
            D1Value = dice1.Roll(); //Calls the 'roll' method in the 'dice1' object and assigns the returned value to 'D1Value' variable.
            D2Value = dice2.Roll(); //Calls the 'roll' method in the 'dice2' object and assigns the returned value to 'D2Value' variable.
            D3Value = dice3.Roll(); //Calls the 'roll' method in the 'dice3' object and assigns the returned value to 'D3Value' variable.

            sum = D1Value + D2Value + D3Value; //This adds the values from the 3 dice rolls and assigns the result to the 'sum' variable.
            return sum; //This returns the result.
        }
    }
}
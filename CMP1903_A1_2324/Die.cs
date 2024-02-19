using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        //-------------------------------Variables-------------------------------
        private int currentDieValue; //This variable will hold the value of the rolled dice.

        //-------------------------------Constructors-------------------------------
        private static Random value = new Random(); //Creates a new 'random' object called 'value'.

        //-------------------------------Methods-------------------------------
        public int Roll() //When this is called the dice is rolled (a number between 1-6 is chosen).
        {
            currentDieValue = value.Next(1, 7); //Generate a number between 1 and 6.
            return currentDieValue; //Returns the generated number.
        }
    }
}
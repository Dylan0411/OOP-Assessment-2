using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property


        //Method


        ///////////////////////////////////////////////////////////////////////////////////////////////
        ///        //"should contain one property to hold the die current value..."
        public int currentDieValue;

        //"...and one method that returns an integer and takes no parameters."
        public int Roll()
        {
            Random value = new Random();
            currentDieValue = value.Next(1, 7);
            return currentDieValue;
        }


    }
}

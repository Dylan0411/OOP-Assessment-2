﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        //Variables
        private int currentDieValue;

        //Constructor
        private static Random value = new Random();

        //Methods
        public int Roll()
        {
            //generate a number between 1 and 6, returning it
            currentDieValue = value.Next(1, 7);
            return currentDieValue;
        }
    }
}
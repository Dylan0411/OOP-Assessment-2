using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        //Variables
        public int currentDieValue;

        //Constructor
        static Random value = new Random();

        //Methods
        public int Roll()
        {
            currentDieValue = value.Next(1, 7);
            return currentDieValue;
        }
    }
}
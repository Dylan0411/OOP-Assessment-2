using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        //Variables
        public int D1Value;
        public int D2Value;
        public int D3Value;
        public int sum;

        //Constructor
        private Die dice1 = new Die();
        private Die dice2 = new Die();
        private Die dice3 = new Die();

        //Methods
        public int Run()
        {
            //Roll all three
            D1Value = dice1.Roll();
            D2Value = dice2.Roll();
            D3Value = dice3.Roll();

            //"Sum and report the total of the three dice rolls."
            sum = D1Value + D2Value + D3Value;
            return sum;
        }
    }
}
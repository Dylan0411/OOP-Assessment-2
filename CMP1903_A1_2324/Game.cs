using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        //Methods


        //////////////////////////////////////////////////////////////////////////////////

        public int D1Value;
        public int D2Value;
        public int D3Value;
        public int sum;

        public int Run()
        {
            //"Create three dice objects."
            Die dice1 = new Die();
            Die dice2 = new Die();
            Die dice3 = new Die();

            //Roll all three
            D1Value = dice1.Roll();
            D2Value = dice2.Roll();
            D3Value = dice3.Roll();

            //===============================================================
            //DELETE THESEEEEE...
            Console.WriteLine("D1: " + D1Value);
            Console.WriteLine("D2: " + D2Value);
            Console.WriteLine("D3: " + D3Value);
            //===============================================================

            //"Sum and report the total of the three dice rolls."
            sum = D1Value + D2Value + D3Value;
            return sum;
        }
    }
}

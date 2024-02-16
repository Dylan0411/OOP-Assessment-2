using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a 'Game object' with the 'Game class' and call the 'Run()' method within a print statement;
            Game gameObject = new Game();
            Console.WriteLine(gameObject.Run());

            //create a 'test object' with the 'Testing class' and call the 'verifyRollAndSum()' method. 
            Testing testObject = new Testing();
            testObject.verifyRollAndSum();
        }
    }
}
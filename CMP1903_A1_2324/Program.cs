using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        private static void Main(string[] args) //Where the program starts...
        {
            Game gameObject = new Game();  //Creates a new game object from the 'Game' class called 'gameObject'.
            Console.WriteLine(gameObject.Run()); //Calls the 'Run' method in the 'gameObject' object and prints the value it gets returned back.

            Testing testObject = new Testing(); //Creates a new test object from the 'Testing' class called 'testObject'.
            testObject.VerifyRollsAndSum(); //Calls the 'verifyRollAndSum' method in the 'testObject' object.
        }
    }
}
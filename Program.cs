using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignorance_is_Blissful
{
    class Program
    {
        //ask for players name
        //allow players name to be recalled through text
        //introduce player to the storyline
        //introduce a combat class
        //introduce a player class
        //call dialogue from a .txt file 

        static void Main(string[] args)
        {
            IntroScreen();
            DialogueOne();
        }
        //starting scene
        static public void IntroScreen()
        {
            Console.WriteLine("Ignorance is Blissful");
            Console.WriteLine("A C# program written by: Trinity Prichard");
            Console.WriteLine("Through-out the length of this application please use the 'Enter' key to proceed.");
            Console.ReadKey();
            Console.Clear();
        }

        static public void DialogueOne()
        {

        }

    }
}
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
            GatheringThePlayersName();
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
        //First intro dialogue using a .txt file
        static public void DialogueOne()
        {
            string filePath = @"C:\Users\Trinity\Desktop\School Work\Ignorance is Blissful\Ignorance is Blissful\DialogueOneWhatIsYourName.txt";

            //string[] lines = File.ReadAllLines(filePath);
             List<string> lines = new List<string>();
             lines = File.ReadAllLines(filePath).ToList();
             foreach (String line in lines)
             {
                 Console.WriteLine(line);
             }
             Console.ReadLine();
            Console.ReadKey();
            Console.Clear();
        }
        static public void GatheringThePlayersName()
        {

        }

    }
}
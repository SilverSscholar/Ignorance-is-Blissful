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
        public static Player currentPlayer = new Player();
        static void Main(string[] args)
        {
            IntroScreen();
            DialogueOne();
            GatheringThePlayersName();
            SceneOne();
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
 
           
        }
        static public void GatheringThePlayersName()
        {
            currentPlayer.name = Console.ReadLine();
            Console.WriteLine("Is "+ currentPlayer.name+ " correct? (Y)es/(N)o?");
            string PlayersNameCorrect = Console.ReadLine();
            if(PlayersNameCorrect.ToLower()== "yes" || PlayersNameCorrect.ToLower()=="y")
            {
                Console.WriteLine("It's very nice to meet you " + currentPlayer.name + " please enjoy your stay.");
                Console.ReadKey();
            }
            else if (PlayersNameCorrect.ToLower() == "no" || PlayersNameCorrect.ToLower() == "n")
            {
                Console.WriteLine(currentPlayer.name + " is incorrect? Please think hard on your name, this is your last opportunity to change it.");
                currentPlayer.name = Console.ReadLine();
                Console.WriteLine(currentPlayer.name + " is your name now. Please enjoy your stay!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("I'm sorry I don't recongnize that input. Please try again.");
                Console.ReadKey();
                Console.Clear();
                DialogueOne();
                GatheringThePlayersName();
                
            }

            Console.ReadKey();
            Console.Clear();
        }
        static public void SceneOne()
        {
            string filePath = @"C:\Users\Trinity\Desktop\School Work\Ignorance is Blissful\Ignorance is Blissful\SceneOneDialogueOneCarTrip.txt";

            //string[] lines = File.ReadAllLines(filePath);
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();
            foreach (String line in lines)
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();
            Console.Clear();
        }

    }
}
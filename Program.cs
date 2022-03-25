﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignorance_is_Blissful
{
    class Program
    {
        
        //set command prompt window size
        //ask for players name
        //allow players name to be recalled through text
        //introduce player to the storyline
        //introduce a combat class
        //introduce a player class
        //call dialogue from a .txt file 

        public static Player currentPlayer = new Player();
        public static Inventory inventory = new Inventory();
        static void Main(string[] args)
        {
            IntroScreen();
            DialogueOne();
            GatheringThePlayersName();
            SceneOne();
            EnteringTheGrocer();
            UsingThePhone();
            DoneWithThePhone();
        }
        //starting scene
        static public void IntroScreen()
        {
            Console.WriteLine("Ignorance is Blissful");
            Console.WriteLine("A C# program written by: Trinity Prichard");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("!!!!!!!!!!!!!!!!!\nTrigger Warnings:\nThis game contains topics of abuse, divorce, gore, and implied cannibalism.\nIf this is not something you wish to see" +
                "please exit now.\nUsing the [Close] button on the top right corner of your screen.\n(until i figure out how set [ESC] to escape.)");
            Console.ForegroundColor = ConsoleColor.Gray;
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
            Console.WriteLine("Is " + currentPlayer.name + " correct? (Y)es/(N)o?");
            string PlayersNameCorrect = Console.ReadLine();
            if (PlayersNameCorrect.ToLower() == "yes" || PlayersNameCorrect.ToLower() == "y")
            {
                Console.WriteLine("It's very nice to meet you " + currentPlayer.name + " remember your values.");
                Console.ReadKey();
            }
            else if (PlayersNameCorrect.ToLower() == "no" || PlayersNameCorrect.ToLower() == "n")
            {
                Console.WriteLine(currentPlayer.name + " is incorrect? Please think hard on your name, this is your last opportunity to change it.");
                currentPlayer.name = Console.ReadLine();
                Console.WriteLine(currentPlayer.name + " is your name now. Remember your values!");
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
            if (currentPlayer.name == "")
            {
                Console.WriteLine("Ah, hey sweetie are you finally awake? You were out like a light! Did you get any sleep at all at your father's?");
            }
            else
            {
                Console.WriteLine("Ah " + currentPlayer.name + " are you finally awake sweetheart? You were out like a light!\nDid you get any sleep at your father's?");
            }
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please type, your answer.");
            Console.ForegroundColor = ConsoleColor.Gray;

            string CharacterAnswer = Console.ReadLine();

            switch (CharacterAnswer)
            {
                case "Yes":
                    Console.WriteLine("For some reason, you can't physically bring yourself to say this response.\nYou admit to your mother you haven't" +
                        " been sleeping weel at your father's.");
                    break;
                case "No":
                    Console.WriteLine("You can't lie to your mother, you admit you haven't been getting sleeping at your fathers.");
                    break;
                default:
                    Console.WriteLine("You stare at your mother tiredly. She takes this as a yes.");
                    break;
            }

            Console.ReadKey();
            Console.Clear();


        }
        public static void EnteringTheGrocer()
        {
            string filePath = @"C:\Users\Trinity\Desktop\School Work\Ignorance is Blissful\Ignorance is Blissful\EnteringTheGrocery.txt";

            //string[] lines = File.ReadAllLines(filePath);
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();
            foreach (String line in lines)
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Always so eager to please, you look up at your mom ready for the responsibility she was about to give you.");
            Console.WriteLine("She reached in her pocket digging out her cellphone, and a PEAR pen. She began to scribble on it, and handed it to you.");

            Console.WriteLine("I think your getting old enough. To grab some groceries yourself.\nThe store is empty, and if anything goes wrong you can yell for me okay?");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(currentPlayer.name + " recieved one **Mom's Phone/Grocery List**!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
            Console.Clear();

            DateTime currentDateTime = DateTime.Now;
            DateTime upcomingDateTime = DateTime.Now.AddDays(3);
            Console.WriteLine("In the top corner of the grocery list you see the date.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(currentDateTime);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("In the right hand corner of the grocery list, you see a different date.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(upcomingDateTime);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("You ask your mom why there's two dates on her phone.");
            Console.WriteLine("\nShe smiles at you fondly and informs you that your birthday is in three days. Don't you remember silly?");
            Console.WriteLine("\n\n...Strangely enough you don't remember...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Your mother, smiles and tells you that you can use the notepad app on her phone to look at the grocery list.\nShowing you how to turn it on.");
            Console.ReadKey();
            Console.Clear();
        }
        public static void UsingThePhone()
        {
            CellPhone.PHONEGUI();
        }
        public static void DoneWithThePhone()
        {
            Console.WriteLine("You exited the phones interface.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You mom smiles fondly at you. ");
            Console.WriteLine("'Good job sweetie!\nNow,I'm gonna run see if I can find a worker, can you get the stuff on that list for me?");
            Console.WriteLine("You give your mom an affirmative nod, as you begin your trek, to the aisles.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

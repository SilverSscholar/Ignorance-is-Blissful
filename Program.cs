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
            StartingYourMission();
            FirstEncounter();
            Encounter1.FirstEncounter();
        }
        //starting scene
        static public void IntroScreen()
        {
            Console.WriteLine("Ignorance is Blissful");
            Console.WriteLine("A C# program written by: Trinity Prichard");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("!!!!!!!!!!!!!!!!!\nTrigger Warnings:\nThis game contains topics of abuse, divorce, gore, and implied cannibalism.\nIf this is not something you wish to see" +
                "please exit now.\nUsing the [Close] button on the top right corner of your screen.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Through-out the length of this application please use the 'Enter' key to proceed.");
            Console.ReadKey();
            Console.Clear();
        }
        //First intro dialogue using a .txt file
        static public void DialogueOne()
        {
            string filePath = @"DialogueOneWhatIsYourName.txt";
            string[] lines;
            try
            {
                lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
            catch (FileNotFoundException exnotfound)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("File not found. Backup-file produced: ");
                Console.ForegroundColor= ConsoleColor.Gray;
                Console.WriteLine("\nWithin the befuddling recesses of your mind.\n " +
                    "You struggle to think about what you would like to be called.\n\nPlease insert your name.");
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
          
            string filePath = @"SceneOneDialogueOneCarTrip.txt";

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
            string filePath2 = @"EnteringTheGrocery.txt";
            string[] lines2;
            try
            {
                lines2 = File.ReadAllLines(filePath2);
                lines2 = File.ReadAllLines(filePath2);
                foreach (string line in lines2)
                {
                    Console.WriteLine(line);
                }
            }
          
            catch (Exception FileNotFoundException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("File not displayed properly, backup text produced:");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Your mother gives you a pitying look.");
                Console.WriteLine("'It'll be okay honey,' she assures you.");
                Console.WriteLine("\n'We just have to stop at the market and then we'll go home I promise, and you can sleep in your bed.'");
                Console.WriteLine("\nYou nod tiredly, there wasn't much more you could do.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("The rain is coming down harder now as you arrive off the interstate. The KREUGER lights welcoming you to your exit.\n"
                    + "The lot was mostly empty, and why wouldn't it be it was practically midnight. You think.");
                Console.WriteLine("You sleepily take off your seatbelt buckle, and your mom opens the door for you.\n\nDamn child-locks.");
                Console.WriteLine("Your Pukicho footies were immediately drenched in the waters of the lot. Neither one of you had an umbrella.");
                Console.WriteLine("You both made a mad dash for the door.\nOnly managing to get completely drenched in the process.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("It was a little strange going inside the empty store.\nThere were no employees at the register, giving you an eerie feeling.");
                Console.WriteLine("You asked your mom why it was so empty.");
                Console.WriteLine("\nShe assured you that it was late, and that most people are home at this time except for janitors.");
                Console.WriteLine("You asked her how you were going to by groceries without cashiers.");
                Console.WriteLine("She assures you that you both can use the self scans.");
                Console.WriteLine("\nYou inform her that dad said Self-Scans are evil.");
                Console.WriteLine("\nShe scoffs and very visibly rolls her eyes.");
                Console.WriteLine("\n'That aside' she muses, 'I do have a very important job for you come here.");

                
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Always so eager to please, you look up at your mom ready for the responsibility she was about to give you.");
            Console.WriteLine("She reached in her pocket digging out her cellphone, and a PEAR pen. She began to scribble on it, and handed it to you.");

            Console.WriteLine("'I think your getting old enough. To grab some groceries yourself.\nThe store is empty, and if anything goes wrong you can yell for me okay?'");
            Console.WriteLine("\nYou nod eager for this independence you have just recieved.");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(currentPlayer.name + " recieved one **Mom's Phone/Grocery List**!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|=================|");
            Console.WriteLine("| --------------- |");
            Console.WriteLine("|                 |");
            Console.WriteLine("|                 |");
            Console.WriteLine("|                 |");
            Console.WriteLine("|                 |");
            Console.WriteLine("|                 |");
            Console.WriteLine("|                 |");
            Console.WriteLine("|                 |");
            Console.WriteLine("|                 |");
            Console.WriteLine("|-----------------|");
            Console.WriteLine("|      [   ]      |");
            Console.WriteLine("|-----------------|");
            Console.WriteLine("|=================|");
            Console.ReadKey();
            Console.Clear();
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
            Console.Clear();
        }
        public static void StartingYourMission()
        {
            Console.WriteLine("You mom smiles fondly at you. ");
            Console.WriteLine("'Good job sweetie!\nNow,I'm gonna run see if I can find a worker, can you get the stuff on that list for me?");
            Console.WriteLine("You give your mom an affirmative nod, as you begin your trek, to the aisles.");
            Console.ReadKey();
            Console.Clear();
        }
        public static void FirstEncounter()
        {
            Console.WriteLine("You find yourself walking down the aisle's the list in your hand.");
            Console.WriteLine("\nThe first thing on your list is Pizza Rolls.");
            Console.WriteLine("\nYou make your way down to the frozen aisle.");
            Console.WriteLine("Walking down the aisle, you see fridges stocked with multiple goods.");
            Console.WriteLine("There was nothing particularly off at first glance of the aisles goods.");
            Console.WriteLine("\nYou approached the frozen pizza's and stared intently at the packages.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("The first package to catch your eye is a circular pizza.\nWrapped in saran wrap, with a cardbord base.");
            Console.WriteLine("You also take note that toppings on the pizza don't quite look like sausages.\nThe toppings are " +
                "bright pink, looking more akin to hotdogs with segmented notches upon it.\n");
            Console.WriteLine("\nYou continue your trek for pizza rolls observing more of the boxes in the fridges.");
            Console.WriteLine("As you look through the boxes you see one that reads Pizza Rolls.");
            Console.WriteLine("You open the fridge, reaching in and grabbing the box.\nAs you take out the pizza roll box" +
                "you feel a syrupy texture on the box.\nIt was a thick red and dripped slightly on the floor.");
            Console.ReadKey();
            Console.Clear();
            
            Console.WriteLine("You recieved:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n*****Pizza Roll Box?*****");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("   __________________________________          ");
            Console.WriteLine("  /                                / |         ");
            Console.WriteLine(" /                                /  |         ");
            Console.WriteLine("/________________________________/  /|         ");
            Console.WriteLine("|   KREUGER BRAND                | / |         ");
            Console.WriteLine("|  Frozen Pizza Rolls        ____|/  |         ");
            Console.WriteLine("|                           /    |  /          ");
            Console.WriteLine("|  A treat just for kids!  /     | /           ");
            Console.WriteLine("|_________________________/______|/            ");
            
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\nYou shove the pizza box into your shirt, and you start to head back down the aisle.");
            Console.WriteLine("However; you are stopped when running into something that feels like a wall.");
        }
        public static void EndOfDemo()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Once the horrific monster is gone, you notice the lights in the building suddenly dim.");
            Console.WriteLine("The once lit up aisles flickered, and the buzzing of the breaker came to a halt.");
            Console.WriteLine("Darkness entrapted you except for the light of your mother's phone.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You hear a terrified womens shriek in the distance.");
            Console.WriteLine("It sounded familiar.");
            Console.WriteLine("\n'Mom!' You call out in futile desperation.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("...");
            Console.Clear();
            Console.WriteLine("....");
            Console.Clear();
            Console.WriteLine(".....");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You don't hear your mom, but you hear something moving in the dark at the end of the aisle.");
            Console.WriteLine("You quickly turn off your phone.");
            Console.WriteLine("\nYou hear footsteps coming closer.");
            Console.WriteLine("\nand closer...");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("~~~~~~     ~~~~~~~");
            Console.WriteLine("______    /_______");
            Console.WriteLine("| [|] |    | [|] |");
            Console.WriteLine("=======    =======");
            Console.WriteLine("   ==   _     ==  ");
            Console.WriteLine("       /          ");
            Console.WriteLine("       -          ");
            Console.WriteLine("__________________");

            Console.WriteLine("\nA man stands before you.");
            Console.WriteLine("He looks at you with disdain.");
            Console.WriteLine("\n'What the hell are you?'");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("=====================================================");
            Console.WriteLine("End of Demo! Thank you for playing! -Trinity Prichard");
            Console.WriteLine("=====================================================");
            Console.ReadKey();
            Console.Clear();

        }
    }
}

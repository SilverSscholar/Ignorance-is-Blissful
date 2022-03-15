using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignorance_is_Blissful
{
    public class CellPhone
    {
        public static void PHONEGUI()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("========================================");
            Console.WriteLine("| [1] Contacts  [2] Messages  [3] Memos |");
            Console.WriteLine("| [4] Notes     [5] Weather   [6] Items |");
            Console.WriteLine("| [7] Exit                              |");
            Console.WriteLine("========================================");

            Console.WriteLine("Please input your option.");

            string options = Console.ReadLine();
            switch (options)
            {
                case "1":
                    Console.Clear();
                    Contacts();
                    break;
                case "2":
                    Console.Clear();
                    Messages();
                    break;
                case "3":
                    Console.Clear();
                    Memos();
                    break;
                case "4":
                    Console.Clear();
                    Notes();
                    break;
                case "5":
                    Console.Clear();
                    Weather();
                    break;
                case "6":
                    Console.Clear();
                    Items();
                    break;
                case "7":
                    Console.Clear();
                    Exit();
                    break;
            }

        }    
        public static void Contacts()
        {
            List<string> contacts = new List<string>();
            contacts.Add("Rubert >:( :  \n-You recongnize the name Rubert. It's your dad.");
            contacts.Add("Mom/Gramma : \n-She makes the best cookies.");
            contacts.Add("Dad/Grandpa : \n-He says he'll take you fishing one day.");
            contacts.Add("Alex <3 : \n-Who is Alex?");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("There are " + contacts.Count +" contact's in your mom's phone.");
            Console.ReadKey();
            Console.Clear();
            foreach (String item in contacts)
            {
                Console.WriteLine(item);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
            Console.Clear();
            PHONEGUI();
        }
        public static void Messages ()
        {
            Console.WriteLine("This is where your mom's messages are located.");
            Console.WriteLine("|               |");
            Console.WriteLine("|[1]Rubert >:(  |");
            Console.WriteLine("|[2]Mom/Gramma  |");
            Console.WriteLine("|[3]Alex <3     |");
            Console.WriteLine("|[4]Exit        |");
            Console.WriteLine("|               |");
            string displayMessages = Console.ReadLine();
            switch(displayMessages)
            {
                case "1":
                    string filePath = @"C:\Users\Trinity\Desktop\School Work\Ignorance is Blissful\Ignorance is Blissful\RubertVSNicole.txt";
                    //string[] lines = File.ReadAllLines(filePath);
                    List<string> lines = new List<string>();
                    lines = File.ReadAllLines(filePath).ToList();
                    foreach (String line in lines)
                    {
                        Console.WriteLine(line);
                    }
                    Console.ReadKey();
                    Console.Clear();
                    Messages();
                    break;
                case "2":
                    Console.Clear();
                    string filePath2 = @"C:\Users\Trinity\Desktop\School Work\Ignorance is Blissful\Ignorance is Blissful\NicoleVSGrandma.txt";
                    //string[] lines = File.ReadAllLines(filePath);
                    List<string> lines1 = new List<string>();
                    lines1 = File.ReadAllLines(filePath2).ToList();
                    foreach (String line in lines1)
                    {
                        Console.WriteLine(line);
                    }
                    Console.ReadKey();
                    Console.Clear();
                    Messages();
                    break;
                case "3":
                    Console.Clear();
                     string filePath3 = @"C:\Users\Trinity\Desktop\School Work\Ignorance is Blissful\Ignorance is Blissful\NicoleVsAlex.txt";
                    //string[] lines = File.ReadAllLines(filePath);
                    List<string> lines3 = new List<string>();
                    lines3 = File.ReadAllLines(filePath3).ToList();
                    foreach (String line in lines3)
                    {
                        Console.WriteLine(line);
                    }
                    Console.ReadKey();
                    Console.Clear();
                    Messages();
                    break;
                case "4":
                    PHONEGUI();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                default:
                    PHONEGUI();
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
            Console.ReadKey();
            Console.Clear();
            PHONEGUI();
        }

        public static void Memos()
        {
            Console.WriteLine("Your name is :" +Program.currentPlayer.name);
            Console.WriteLine("Your current health is : "+Program.currentPlayer.health);
            Console.WriteLine("Your defense is : "+ Program.currentPlayer.defense);
            Console.ReadKey();
            Console.Clear();
            PHONEGUI();
        }
        public static void Notes()
        {
            Console.WriteLine("This is where the grocery list is located.");

            string filePath = @"C:\Users\Trinity\Desktop\School Work\Ignorance is Blissful\Ignorance is Blissful\GroceryList.txt";

            //string[] lines = File.ReadAllLines(filePath);
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();
            foreach (String line in lines)
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();
            Console.Clear();
            PHONEGUI();
        }
        public static void Weather()
        {
            Console.WriteLine("This will display the weather.");
           
            Console.ReadKey();
            Console.Clear();
            PHONEGUI();
        }
        public static void Items()
        {
            Console.WriteLine("This will access your character inventory/items.");
            Console.ReadKey();
            Console.Clear();
            PHONEGUI();
        }
        public static void Exit()
        {
            Console.WriteLine("This will allow you to exit the GUI");
            Console.ReadKey();
            Console.Clear();
            
        }
    }
}

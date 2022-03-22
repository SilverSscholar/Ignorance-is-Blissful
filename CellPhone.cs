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
            Console.WriteLine("=========================================");
            Console.WriteLine("| [1] Contacts  [2] Messages   [3] Memos |");
            Console.WriteLine("| [4] Notes     [5] Calculator [6] Items |");
            Console.WriteLine("| [7] Exit                               |");
            Console.WriteLine("=========================================");

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
                    Calculator();
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
                    string filePath3 = @"RubertVSNicole.txt";
                    string[] lines3;
                    try
                    {
                        lines3 = File.ReadAllLines(filePath3);
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("File Could not be produced back up file implemented.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("-FFS Nicole Come get your fucking kid!");
                        Console.WriteLine("-Sent 4:00AM");
                        Console.WriteLine("\n     -Are you being fucking serious,\n" +
                            "                        it's their birthday this week!\n" +
                            "                                         -Sent 4:02AM");
                        Console.WriteLine("\n-I don't want to keep the brat,");
                        Console.WriteLine("and no you crazy b**** it's not this week!");
                        Console.WriteLine("Sent 4:03AM");
                        Console.WriteLine("\n        -I can't fucking believe you, " +
                            "\n                         don't even want to see your child on their birthday"+
                            "\n                                                         I'll be there at 7." +
                            "\n                                                                -Sent 4:10AM");
                    }
                    Console.ReadKey();
                    Console.Clear();
                    Messages();
                    break;
                case "2":
                    Console.Clear();
                    string filePath5 = @"NicoleVSGrandma.txt";
                    string[] lines5;
                    try
                    {
                        lines5 =File.ReadAllLines(filePath5);
                    }
                    catch(Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("File could not be read, back up file intiated.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("                     -Mom I'm super worried.");
                        Console.WriteLine("                               - Sent 7:15AM");
                        Console.WriteLine("\n-What did that b*stard do now?");
                        Console.WriteLine(" -Sent 7:17AM");
                        Console.WriteLine("\n    -I dunno but their being super quiet rn,");
                        Console.WriteLine("                        it's very unlike them.");
                        Console.WriteLine("                                  -Sent 7:18AM");
                        Console.WriteLine("\n-Do you think its more than just Rubert?");
                        Console.WriteLine("-Sent 7:20AM");
                        Console.WriteLine("\n            -I'm sure Rubert has been an ass,");
                        Console.WriteLine("               but I think it's more than that.");
                        Console.WriteLine("               we're at the WCNolads rn. They, ");
                        Console.WriteLine("                    haven't ate anything yet.  ");
                        Console.WriteLine("                                   -Sent 7:25AM");
                        Console.WriteLine("\nWell it could just be stress sweetie,");
                        Console.WriteLine("they're still too young to develop the 'condition'");
                        Console.WriteLine("Sent 7:28AM");
                    }
                    Console.ReadKey();
                    Console.Clear();
                   
                    break;
                case "3":
                    Console.Clear();
                     string filePath4 = @"C:\Users\Trinity\Desktop\School Work\Ignorance is Blissful\Ignorance is Blissful\NicoleVSAlex.txt";
                    //string[] lines = File.ReadAllLines(filePath);
                    List<string> lines4 = new List<string>();
                    lines4 = File.ReadAllLines(filePath4).ToList();
                    foreach (String line in lines4)
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
        public static void Calculator()
        {
            char op;
            double num1, num2;
            Console.WriteLine("First, enter the operator (+, -, /, *)");
            op = Console.ReadLine()[0];
            Console.WriteLine("Enter the two numbers, inserting one hitting enter, then inputting the second one.");
            Console.WriteLine("Press any other button to leave the interface.");
            num1 = Convert.ToDouble(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine("{0} + {1} = {2}",num1, num2,(num1+num2));
                    break;
                case '-':
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, (num1 - num2));
                    break;
                case '/':
                    if (num2 == 0.0)
                        Console.WriteLine("Divide by zero situation.");
                    else
                        Console.WriteLine("{0} / {1} = {2}", num1,num2, (num1 / num2));
                    break;
                case '*':
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 * num2));
                    break;
                default:
                    PHONEGUI();
                    break;
                   
            }

            Console.ReadKey();
            Console.Clear();
            PHONEGUI();
        }
        public static void Items()
        {
            Inventory.INVENTORYGUI();
            Console.ReadKey();
            Console.Clear();
            PHONEGUI();
        }
        public static void Exit()
        {
            
            Console.ReadKey();
            Console.Clear();
            Program.DoneWithThePhone();
            
            
        }
    }
}

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
            Console.WriteLine("|=================|");
            Console.WriteLine("| --------------- |");
            Console.WriteLine("| [1]Contacts     |");
            Console.WriteLine("| [2]Messages     |");
            Console.WriteLine("| [3]Memos        |");
            Console.WriteLine("| [4]Notes        |");
            Console.WriteLine("| [5]Calculator   |");
            Console.WriteLine("| [6]Items        |");
            Console.WriteLine("| [7]Exit         |");
            Console.WriteLine("|                 |");
            Console.WriteLine("|-----------------|");
            Console.WriteLine("|      [   ]      |");
            Console.WriteLine("|-----------------|");
            Console.WriteLine("|=================|");

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
                        foreach (string line in lines3)
                        {
                            Console.WriteLine(line);
                        }
                        Console.ReadKey();
                        Console.Clear();
                        
                        
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
                        foreach (string line in lines5)
                        {
                            Console.WriteLine(line);
                        }
                        Console.ReadKey();
                        Console.Clear();
                     
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
                    Messages();
                   
                    break;
                case "3":
                    Console.Clear();
                     string filePath4 = @"NicoleVSAlex.txt";
                    string[] lines4;
                    try
                    {
                        lines4 = File.ReadAllLines(filePath4);
                        foreach (string line in lines4)
                        {
                            Console.WriteLine(line);
                        }
                        Console.ReadKey();
                        Console.Clear();
                        
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("File could not be intiated, back up text produced.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("-So your mom told me what was going on,");
                        Console.WriteLine(" you doing alright?");
                        Console.WriteLine("Sent 11:45AM");
                        Console.WriteLine("\n          Ugh to be honest not really,");
                        Console.WriteLine("                   I'm mad as all hell.-");
                        Console.WriteLine("                            Sent 11:47AM");
                        Console.WriteLine("\n-That's fair enough honey, also sorry for");
                        Console.WriteLine("asking but your not texting and driving?   ");
                        Console.WriteLine("Sent 11:49AM");
                        Console.WriteLine("\n        No, no pitstop at the gas station,");
                        Console.WriteLine("                 drinks, gas, and the like.-");
                        Console.WriteLine("                            Sent 11:50AM    ");
                        Console.WriteLine("\n-Okay cool, I was worried there,");
                        Console.WriteLine("for a second there ngl.");
                        Console.WriteLine("Sent 11:51AM");
                        Console.WriteLine("\n           I'm pissed not a moron, honey.-");
                        Console.WriteLine("                              Sent 11:51AM  ");
                        Console.WriteLine("\nFair enough, I'll see you tonight! Please,");
                        Console.WriteLine("be careful on the roads! <3!<3!<3!");
                        Console.ReadKey();
                        Console.Clear();
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
            }
            
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

            string filePath6 = @"GroceryList.txt";
            try
            {
                List<string> lines6 = new List<string>();
                lines6 = File.ReadAllLines(filePath6).ToList();
                foreach (string line in lines6)
                {
                    Console.WriteLine(lines6);
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This file could not be produced, backup file applied.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();

                List<string> items = new List<string>();
                items.Add("Pizza Rolls");
                items.Add("Milk");
                items.Add("Bread");
                items.Add("Flour/Sugar");
                items.Add("USB-C Charger Cord");
                //Display item list
               
               foreach (String item in items)
                {
                    Console.WriteLine(item);
                }
                Console.ReadKey();
                Console.Clear();
            }
            //string[] lines = File.ReadAllLines(filePath);
           
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
        }
        public static void Exit()
        {
            Console.WriteLine("You exit the phone's interface.");
            Console.ReadKey();
            Program.DoneWithThePhone();   
        }
    }
}

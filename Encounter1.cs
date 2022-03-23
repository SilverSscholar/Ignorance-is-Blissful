using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignorance_is_Blissful
{
    internal class Encounter1
    {
        static Random rand = new Random();
        

        public static void FirstEncounter()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The figure that stands before you is ominous to say the least.");
            Console.WriteLine("\nIt's a...man? ... person? Your unsure. They look as tall as a tree. ");
            Console.WriteLine("\nThey has very spindly arms, that slide down to the floor dragging down on the tile.");
            Console.WriteLine("Their skin is gray, with sunken in eyes that looked exhausted.");
            Console.WriteLine("Their jaw hangs down low, keeping their mouth perpetually open.");
            Console.WriteLine("\nIt makes an agonizing screech as it reaches it's hands out at you-");
            Console.ReadKey();
            Console.Clear();
            Combat(false, "Grangy Monster", 10, 10);
        }

        public static void Combat(bool random, string name, int power, int health)
        {
            string n = "";
            int p = 0;
            int h = 0;

            if (random)
            {


            }
            else
            {
                n = name;
                p = power;
                h = health;
            }
            while(h>0)
            {
                Console.Clear();
                Console.ForegroundColor= ConsoleColor.Blue;
                Console.WriteLine(n);
                Console.WriteLine(p+"/"+h);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("-----------------------");
                Console.WriteLine("| [A]Attack [D]Defend |");
                Console.WriteLine("| [F]Flee   [H]Heal   |");
                Console.WriteLine("-----------------------");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Health: "+ Program.currentPlayer.health +"  Available Snacks: " +Program.inventory.bugJuiceInInventory);
                Console.ForegroundColor = ConsoleColor.White;
                string input = Console.ReadLine();
                if( input.ToLower()=="a" || input.ToLower() =="attack")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("You attack the " + n + " as it reaches it's hand out to you. As you pass the," + n + "strikes you.");
                    int damageV = p - Program.currentPlayer.armourValue;
                    if (damageV < 0)
                        damageV = 0;

                    int attackV = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1, 6);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("You lose " + damageV + " health, and deal " + attackV + " damage.");
                    Program.currentPlayer.health -= damageV;
                    h -= attackV;

                }
                else if (input.ToLower()=="d"||input.ToLower()=="defend")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("As the " + n + " lunges towards you. You hold your arms up in a defensive stance.");
                    int damageV = (p / 4) - Program.currentPlayer.armourValue;
                    if (damageV < 0)
                        damageV = 0;

                    int attackV = rand.Next(0, Program.currentPlayer.weaponValue) / 2;

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("You lose " + damageV + " health, and deal " + attackV + " damage.");
                    Program.currentPlayer.health -= damageV;
                    h -= attackV;
                }
                else if (input.ToLower()=="f"||input.ToLower()=="flee")
                    if (rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("As you sprint away from the " + n + " it's strike catches you in the back, sending you sprawling\n " +
                            "on the tile floor.");
                        int damageV = p - Program.currentPlayer.armourValue;
                        if (damageV < 0)
                            damageV = 0;

                        Console.WriteLine("You lose " + damageV + "  health and are unable to escape.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("You manage to flee the " + n + " successfully running down the end of the aisle!");
                        Console.ReadKey();
                        //go to end of Demo.
                    }
                else if (input.ToLower()=="h"||input.ToLower()=="heal")
                {
                    if (Program.inventory.bugJuiceInInventory == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("As you desperately reach in your pocket for a drink, all you feel is empty plastic bottles.");
                        int damageV = p - Program.currentPlayer.armourValue;
                        if (damageV < 0)
                            damageV = 0;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The " + n + "takes your fumbling as an opportunity to strike. Hitting you for " + damageV + " health.");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.ReadKey();

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("You reach into your pocket, and pull out a bottle of Bug Juice. You take a drink.");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You gain, " + Program.inventory.bugJuiceHealth + " health");
                        Console.WriteLine("You lose 1, " + (Program.inventory.bugJuiceInInventory -= 1) + " Bug Juice.");
                        Program.currentPlayer.health += Program.inventory.bugJuiceHealth;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.ReadKey();
                    }
                }
                Console.ReadKey();
            }
            if(Program.currentPlayer.health<=0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("The " + n + " strikes you with a final blow, sending you carening into the tile floor.");
                Console.WriteLine("The world around you starts to fade to black, as you lay on the ground.");
                Console.WriteLine("The "+n+ " comes towards you as you stare at your reflection on the tiles. A sickly, syrupy red covers the floor.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Soon enough. The light will leave you eyes.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("  ----  G   A  M  E    O   V   E   R    ----  ");
                Console.WriteLine("==============================================");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Thank you so much for playing my demo! -Trinity Prichard");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
            int c = rand.Next(10, 50);
            Console.WriteLine("As you stand victorious over the " +n+" it's body dissolves into a puddle on the floor.\nFrom this puddle on the floor" +
                "you recieved "+c+" coins? They're covered in red syrupy liquid.");
            Console.ReadKey();
        }
        
    }
}

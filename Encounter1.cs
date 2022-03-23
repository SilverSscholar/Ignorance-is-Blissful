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
            Console.WriteLine("It's a...man? ... person? Your unsure. They look as tall as a tree. ");
            Console.WriteLine("They has very spindly arms, that slide down to the floor dragging down on the tile.");
            Console.WriteLine("Their skin is gray, with sunken in eyes that looked exhausted.");
            Console.WriteLine("Their jaw hangs down low, keeping their mouth perpetually open.");
            Console.WriteLine("It makes an agonizing screech as it reaches it's hands out at you-");
            Console.ReadKey();
            Console.Clear();
            Combat(false, "Monster", 10, 10);
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
                Console.WriteLine("------------------------------");
                Console.WriteLine("| [1]Attack [2]Dodge [3]Flee |");
                Console.WriteLine("| [4]Item   [5]Cower         |");
                Console.WriteLine("------------------------------");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Health: "+ Program.currentPlayer.health +"Current DamageOutput: "+Program.currentPlayer.damage);
                string input = Console.ReadLine();
            }
        }
    }
}

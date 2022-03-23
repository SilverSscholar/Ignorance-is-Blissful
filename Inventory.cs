using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignorance_is_Blissful
{
    public class Inventory
    {
        public int puckichoArmour = 5;
        public int toyKnifeDamage = 3;
        public int stickDamage = 2;
        public int bugJuiceHealth = 4;
        public int trexHealth = 4;
        public int bugJuiceInInventory = 4;
        public int trexInInventory = 4;

        public static void INVENTORYGUI()
        {
            Console.Clear();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("| [1] Armour [2] Weapons [3] Food   |");
            Console.WriteLine("-------------------------------------");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Please make a selection! Use any other key to return to the CellPhone.");

            string InventoryOptions = Console.ReadLine();
            switch (InventoryOptions)
            {
                case "1":
                    Armour();
                    break;
                case "2":
                    Weapons();
                    break;
                case "3":
                    Food();
                    break;
                    default:
                    CellPhone.PHONEGUI();
                    break;
                    

            }

        }
        public static void Armour()
        {
            Console.WriteLine("Your Pukicho armor provides + "+Program.inventory.puckichoArmour+" defense.");
            Console.ReadKey();
            Console.Clear();
            INVENTORYGUI();
        }
        public static void Weapons()
        {
            Console.WriteLine("Your stick provides + " +Program.inventory.stickDamage+ "attack");
            Console.ReadKey();
            Console.Clear();
            INVENTORYGUI();
        }
        public static void Food()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Trex provides you with +" +Program.inventory.trexHealth+ " additional health.");
            Console.WriteLine("You have "+Program.inventory.trexInInventory+"in your inventory,");
            Console.WriteLine("Bug Juice provides you with +" +Program.inventory.bugJuiceHealth+" additional health.");
            Console.WriteLine("You have "+ Program.inventory.bugJuiceInInventory +"Bug Juice(s) in your inventory.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ReadKey();
            Console.Clear();
            INVENTORYGUI();
        }
    }
}

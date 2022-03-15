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
            Console.WriteLine("This is where you check your messages");
            Console.ReadKey();
            Console.Clear();
            PHONEGUI();
        }

        public static void Memos()
        {
            Console.WriteLine("This is your player status.");
            Console.ReadKey();
            Console.Clear();
            PHONEGUI();
        }
        public static void Notes()
        {
            Console.WriteLine("This is where the grocery list is located.");
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

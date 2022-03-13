using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignorance_is_Blissful
{
    public class CellPhone
    {
        public string MomName;
        public string Messages;
        public int PhoneNumber;
        public int Calculator;
        public string Contacts;


        public void Greeting()
        {
            Console.WriteLine("Hello welcome to  " + MomName + "'s cellphone!");

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADDRESS_BOOK_SYSTEM
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO ADDRESS BOOK");
            Contacts contacts = new Contacts();
            contacts.CheckContacts();
        }
    }
}

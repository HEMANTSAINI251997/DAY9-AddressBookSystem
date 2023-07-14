using ADDRESS_BOOK_SYSTEM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ADDRESS_BOOK_SYSTEM
{
    public class Contacts
    {
        List<AddressBook> list = new List<AddressBook>();
        public void CheckContacts()
        {
            Console.WriteLine("Enter the number of details you want to print:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                AddressBook address = new AddressBook();

                Console.WriteLine("\nInformation {0}", i);
                Console.Write("Enter firstName: ");
                address.firstname = Console.ReadLine();
                Console.Write("Enter Last Name: ");
                address.lastname = Console.ReadLine();
                Console.Write("Enter Address: ");
                address.address = Console.ReadLine();
                Console.Write("Enter city: ");
                address.city = Console.ReadLine();
                Console.Write("Enter state: ");
                address.state = Console.ReadLine();
                Console.Write("Enter phone number: ");
                address.phoneNo = Console.ReadLine();
                Console.Write("Enter postcode: ");
                address.postcode = Console.ReadLine();
                Console.Write("Enter Country: ");
                address.country = Console.ReadLine();
                Console.Write("Enter email: ");
                address.email = Console.ReadLine();

                list.Add(address);

                Console.WriteLine("\n" + "FirstName   = " + address.firstname + "\n" + "Last Name   = " + address.lastname + "\n" + "Address     = " + address.address + "\n"
                    + "City        = " + address.city + "\n" + "State       = " + address.state + "\n" + "PhoneNumber = " + address.phoneNo + "\n" +
                    "Zip Code    = " + address.postcode + "\n" + "Country     = " + address.country + "\n" + "Email       = " + address.email);
            }

            Console.WriteLine("Remove by using First Name:");
            Console.WriteLine("Enter the first name");
            string name = Console.ReadLine();
            bool contactRemoved = false;

            foreach (var data in list)
            {
                if (data.firstname == name)
                {
                    list.Remove(data);
                    Console.WriteLine("Contact was deleted:\n" + "FirstName   = " + data.firstname + "\n" + "Last Name   = " + data.lastname + "\n" + "Address     = " + data.address + "\n"
                        + "City        = " + data.city + "\n" + "State       = " + data.state + "\n" + "PhoneNumber = " + data.phoneNo + "\n" +
                        "Zip Code    = " + data.postcode + "\n" + "Country     = " + data.country + "\n" + "Email       = " + data.email);
                    contactRemoved = true;
                    break;
                }
            }

            if (!contactRemoved)
            {
                Console.WriteLine("Contact with the given first name was not found.");
            }
        }
    }

}
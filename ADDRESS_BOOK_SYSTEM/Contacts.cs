﻿using ContactSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADDRESS_BOOK_SYSTEM
{
    public class Contacts
    {
        public void CheckContacts()
        {
            List<AddressBook> list = new List<AddressBook>();

            {
                AddressBook address = new AddressBook();
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
                Console.Write("Enter postcode: ");
                address.postcode = Console.ReadLine();
                Console.Write("Enter email: ");
                address.email = Console.ReadLine();
                Console.Write("Enter phone Number: ");
                address.phoneNo = Console.ReadLine();
                Console.Write("Enter Country: ");
                address.country = Console.ReadLine();
                             
                list.Add(address);
                Console.WriteLine("\n" + "FirstName   = " + address.firstname + "\n" + "Second Name = " + address.lastname + "\n" + "Address     = " + address.address + "\n"
                    + "City        = " + address.city + "\n" + "State       = " + address.state + "\n" + "PhoneNumber = " + address.phoneNo + "\n" +
                    "Zip Code    = " + address.postcode + "\n" + "Country     = " + address.country + "\n" + "Email       = " + address.email);
            }
        }
    }
}

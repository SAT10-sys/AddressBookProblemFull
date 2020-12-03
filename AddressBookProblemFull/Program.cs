using System;

namespace AddressBookProblemFull
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookMain addressBookMain = new AddressBookMain();
            Console.WriteLine("Welcome to Address Book Problem ");
            Console.WriteLine("Enter the following details seperated by ,");
            string[] details;
            details = Console.ReadLine().Split(",");
            addressBookMain.AddContact(details[0], details[1], details[2], details[3], details[4], details[5], details[6], details[7]);
            Console.WriteLine("Contact added");
        }
    }
}

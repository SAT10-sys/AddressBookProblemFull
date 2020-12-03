using System;

namespace AddressBookProblemFull
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookMain addressBookMain = new AddressBookMain();
            Console.WriteLine("Welcome to Address Book Problem ");
            Console.WriteLine("Enter choices");
            Console.WriteLine("1.ADD CONTACT\n2.EDIT CONTACT\n3.REMOVE CONTACT");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter the following details seperated by ,");
                    string[] details;
                    details = Console.ReadLine().Split(",");
                    addressBookMain.AddContact(details[0], details[1], details[2], details[3], details[4], details[5], details[6], details[7]);
                    Console.WriteLine("Contact added");
                    break;
                case 2:
                    Console.WriteLine("Enter First Name of the Contact to be edited");
                    string firstName = Console.ReadLine();
                    bool result = addressBookMain.CheckFirstName(firstName);
                    if (result == true)
                    {
                        Console.WriteLine("Enter the edited details seperated by ,");
                        string[] newDetails = Console.ReadLine().Split(",");
                        addressBookMain.EditContact(firstName, newDetails[0], newDetails[1], newDetails[2], newDetails[3], newDetails[4], newDetails[5], newDetails[6]);
                        Console.WriteLine("Contact edited successfully");
                    }
                    else
                        Console.WriteLine("No contacts found");
                    break;
                case 3:
                    Console.WriteLine("Enter First Name of the Contact to be deleted");
                    string firstName1 = Console.ReadLine();
                    bool result1 = addressBookMain.CheckFirstName(firstName1);
                    if (result1 == true)
                    {
                        addressBookMain.RemoveContact(firstName1);                     
                        Console.WriteLine("Contact deleted successfully");
                    }
                    else
                        Console.WriteLine("No contacts found");
                    break;
            }                       
        }
    }
}

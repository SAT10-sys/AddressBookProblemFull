using System;

namespace AddressBookProblemFull
{
    class Program
    {
        static void Main(string[] args)
        {
            MultipleAddressBooks multipleAddressBooks = new MultipleAddressBooks();
            AddressBookMain addressBookMain;
            addressBookMain = null;
            while (true)
            {
                bool flag = true;
                Console.WriteLine("Name of Address Book");
                string name = Console.ReadLine();
                Console.WriteLine("1.ADD ADDRESSBOOK\n2.OPEN ADDRESSBOOK");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    multipleAddressBooks.AddAddressBook(name);
                    addressBookMain = multipleAddressBooks.GetAddressBook(name);
                }
                else if (choice == 2)
                {
                    addressBookMain = multipleAddressBooks.GetAddressBook(name);
                    if (addressBookMain == null)
                        Console.WriteLine("No such address book");
                }
                else
                { Console.WriteLine("Incorrect choice"); break; }
                while (flag)
                {
                    if (addressBookMain == null)
                        break;
                    Console.WriteLine("Enter choices");
                    Console.WriteLine("1.ADD CONTACT\n2.EDIT CONTACT\n3.REMOVE CONTACT");
                    int choiceOfOperation = Convert.ToInt32(Console.ReadLine());
                    switch (choiceOfOperation)
                    {
                        case 1:
                        RegStart:
                            Console.WriteLine("Enter the following details seperated by ,");
                            string[] details;
                            details = Console.ReadLine().Split(",");
                            addressBookMain.AddContact(details[0], details[1], details[2], details[3], details[4], details[5], details[6], details[7]);
                            Console.WriteLine("Contact added");
                            Console.WriteLine("Add More Contacts(Yes/No");
                            string ans = Console.ReadLine().ToLower();
                            if (ans == "yes")
                                goto RegStart;
                            else if (ans == "no")
                                break;
                            else
                                Console.WriteLine("Invalid choice");
                            break;
                        case 2:
                            Console.WriteLine("Enter First Name, LastName and PhoneNumber of the Contact to be edited");
                            string firstName = Console.ReadLine();
                            string lastName = Console.ReadLine();
                            string phoneNumber = Console.ReadLine();
                            bool result = addressBookMain.CheckName(firstName, lastName, phoneNumber);
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
                            Console.WriteLine("Enter First Name, LastName and PhoneNumber of the Contact to be edited");
                            string firstName1 = Console.ReadLine();
                            string lastName1 = Console.ReadLine();
                            string phoneNumber1 = Console.ReadLine();
                            bool result1 = addressBookMain.CheckName(firstName1, lastName1, phoneNumber1);
                            if (result1 == true)
                            {
                                addressBookMain.RemoveContact(firstName1);
                                Console.WriteLine("Contact deleted successfully");
                            }
                            else
                                Console.WriteLine("No contacts found");
                            break;
                        default:
                            flag = false;
                            break;
                    }
                }
            }
        }
    }
}
    

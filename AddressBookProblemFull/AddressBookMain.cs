using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProblemFull
{
    public class AddressBookMain
    {
        public List<Contacts> contactList;
        public AddressBookMain()
        {
            contactList = new List<Contacts>();
        }
        public void AddContact(string firstName, string lastName, string address, string city, string state, string zipCode, string phoneNumber, string emailID)
        {
            bool result = CheckName(firstName, lastName, phoneNumber);
            if (result == false)
            {
                Contacts contacts = new Contacts(firstName, lastName, address, city, state, zipCode, phoneNumber, emailID);
                contactList.Add(contacts);
            }
            else
                Console.WriteLine("Contact already exists");
        }
        public void EditContact(string firstName, string lastName, string address, string city, string state, string zipCode, string phoneNumber, string emailID)
        {
            foreach(Contacts c in contactList)
            {
                if(c.firstName.Equals(firstName))
                {
                    c.lastName = lastName;
                    c.address = address;
                    c.city = city;
                    c.state = state;
                    c.zipCode = zipCode;
                    c.phoneNumber = phoneNumber;
                    c.emailID = emailID;
                }
            }
        }
        public bool CheckName(string firstName, string lastName, string phoneNumber)
        {
            foreach(Contacts c in contactList)
            {
                if (c.firstName.Equals(firstName) && c.lastName.Equals(lastName) && c.phoneNumber.Equals(phoneNumber))
                    return true;                   
            }
            return false;
        }
        public void RemoveContact(string firstName)
        {
            foreach(Contacts c in contactList)
            {
                if (c.firstName.Equals(firstName))
                    contactList.Remove(c);
            }
        }
    }
}

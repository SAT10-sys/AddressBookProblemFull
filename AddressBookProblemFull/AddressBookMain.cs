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
            Contacts contacts = new Contacts(firstName, lastName, address, city, state, zipCode, phoneNumber, emailID);
            contactList.Add(contacts);
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
        public bool CheckFirstName(string firstName)
        {
            foreach(Contacts c in contactList)
            {
                if (c.firstName.Equals(firstName))
                    return true;                   
            }
            return false;
        }
    }
}

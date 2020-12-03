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
    }
}

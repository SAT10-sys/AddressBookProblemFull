using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProblemFull
{
    public class MultipleAddressBooks
    {
        Dictionary<string, AddressBookMain> addressBookCollection = new Dictionary<string, AddressBookMain>();
        public MultipleAddressBooks()
        {
            addressBookCollection = new Dictionary<string, AddressBookMain>();
        }
        public void AddAddressBook(string name)
        {
            AddressBookMain addressBookMain = new AddressBookMain();
            addressBookCollection.Add(name, addressBookMain);
        }
        public AddressBookMain GetAddressBook(string name)
        {
            if (addressBookCollection.ContainsKey(name))
                return addressBookCollection[name];
            return null;
        }
    }
}

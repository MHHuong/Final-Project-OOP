using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library_Management_System
{
    public class ContactInformation
    {
        string phoneNumber;
        string address;

        public ContactInformation(string phoneNumber, string address)
        {
            this.phoneNumber = phoneNumber;
            this.address = address;
        }
        public string displayInfor()
        {
            return $"phone number: {phoneNumber}, address: {address}";
        }
    }
}
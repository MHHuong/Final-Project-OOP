using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library_Management_System
{
    public class Person
    {
        string name;
        ContactInformation contactInformation;

        public Person(string name, ContactInformation contactInformation)
        {
            this.name = name;
            this.contactInformation = contactInformation;
        }

        public string Name { get => name; set => name = value; }
        public virtual string PrintDetails()
        {
            return $"Name: {name}, {contactInformation.displayInfor()}";
        }
    }
}
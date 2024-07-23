using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Person
    {
        // Encapsulated fields
        private string name;
        private string phone_num;

        // Constructor
        public Person(string name, string phoneNum)
        {
            this.name = name;
            this.phone_num = phoneNum;
        }

        // Properties for encapsulation
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string PhoneNumber
        {
            get { return phone_num; }
            set { phone_num = value; }
        }

        // Overridable method to demonstrate polymorphism
        public virtual string ToString()
        {
            return $"Name: {name}\nPhone Number: {phone_num}";
        }
    }
}

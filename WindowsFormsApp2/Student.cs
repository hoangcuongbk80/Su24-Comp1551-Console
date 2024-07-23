using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Student : Person
    {
        private int id;
        public string email;
        public Student(int id, string name, string email, string phone_num) : base(name, phone_num)
        {
            this.id = id;
            this.email = email;
        }

        public int Id
        {
            get { return  id; }
            set { id = value; }
        }

        public string getInfo()
        {
            string info = id.ToString() + ", " + Name + ", " + email + ", " + PhoneNumber;
            return info;
        }

        public override string ToString()
        {
            return id + " " + base.ToString() + " " + email;
        }
    }
}

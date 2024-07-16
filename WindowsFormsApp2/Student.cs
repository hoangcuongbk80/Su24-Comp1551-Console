using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Student
    {
        int id;
        string name;
        string email;
        string phone_num;

        public Student(int id, string name, string email, string phone_num)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.phone_num = phone_num;
        }

        public string getInfo()
        {
            string info = id.ToString() + ", " + name + ", " + email + ", " + phone_num;
            return info;
        }
    }
}

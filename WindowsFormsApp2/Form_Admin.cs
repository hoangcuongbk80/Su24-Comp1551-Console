using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form_Admin : Form
    {
        List<Student> students = new List<Student>();
        public Form_Admin()
        {
            InitializeComponent();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            string[] newrow = {tb_id.Text, tb_name.Text, tb_email.Text, tb_Phone.Text, "Student" };
            dataGridView1.Rows.Add(newrow);

            if(tb_role.Text == "Student")
            {
                // Step 1: Creating a new student
                int id = Convert.ToInt32(tb_id.Text);
                string name = tb_name.Text;
                string email = tb_email.Text;
                string phone = tb_Phone.Text;
                Student newStu = new Student(id, name, email, phone);

                // Step 2: Adding the new student to the list students
                students.Add(newStu);
            }
        }

        private void bt_remove_Click(object sender, EventArgs e)
        {
            int row_index = dataGridView1.CurrentCell.RowIndex;
            if(row_index >= 0 && row_index < students.Count)
            {
                dataGridView1.Rows.RemoveAt(row_index);
                students.RemoveAt(row_index);
            }
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            // Save all student to the text file students.txt
            StreamWriter writer = new StreamWriter("student.txt");
            foreach(Student student in students)
            {
                writer.WriteLine(student.getInfo());
            }
            writer.Close();
            MessageBox.Show("Student data saved to student.txt");

        }
        private void bt_load_Click(object sender, EventArgs e)
        {
            // Load students info from text to the list students and dataGridView1
            StreamReader reader = new StreamReader("student.txt");
            
            string line = reader.ReadLine();
            dataGridView1.Rows.Clear();
            students.Clear();
            while(line != null)
            {
                string[] parts = line.Split(',');
                int id = Convert.ToInt32(parts[0]);
                string name = parts[1];
                string email = parts[2];
                string phone = parts[3];
                dataGridView1.Rows.Add(id, name, email, phone, "Student");
                Student newStu = new Student(id, name, email, phone);
                students.Add(newStu);
                line = reader.ReadLine();
            }
            reader.Close();
        }

        private void bt_sort_Click(object sender, EventArgs e)
        {

        }
    }
}

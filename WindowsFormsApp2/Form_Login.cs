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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
            tb_password.PasswordChar = '*';
            try{
                StreamReader reader = new StreamReader("login.txt");
                string line = reader.ReadLine();
                if (line != null)
                {
                    string[] info = line.Split(' ');
                    tb_user.Text = info[0];
                    tb_password.Text = info[1];
                    cb_role.Text = info[2];
                }
                reader.Close();
            }
            catch {}
        }
        private void bt_login_Click(object sender, EventArgs e)
        {
            if(this.cb_role.Text == "Admin")
            {
                if(this.tb_user.Text == "admin" && tb_password.Text == "123")
                {
                    if (this.checkBox1.Checked)
                    {
                        StreamWriter writer = new StreamWriter("login.txt");
                        string info = tb_user.Text + " " + tb_password.Text + " " 
                                      + cb_role.Text;
                        writer.WriteLine(info);
                        writer.Close();
                        MessageBox.Show("You login with admin role successfully " +
                                        "and the info saved to login.txt");
                    }
                    else
                    {
                        MessageBox.Show("You login with admin role successfully");
                    }
                    Form_Admin form_Admin = new Form_Admin();
                    form_Admin.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid user name of password");
                }
                
            }
        }
    }
}

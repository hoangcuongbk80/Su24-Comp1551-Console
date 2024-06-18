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

namespace WFApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Say_Hi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi");
        }

        private void bt_swap_Click(object sender, EventArgs e)
        {
            string temp =tb_swap_1.Text;
            tb_swap_1.Text = tb_swap_2.Text;  
            tb_swap_2.Text = temp;  
        }

        private void bt_write_Text_Click(object sender, EventArgs e)
        {
            StreamWriter writetext = new StreamWriter("MyFile.txt");
            writetext.Write(richTextBox1.Text);
            writetext.Close();
        }

        private void bt_read_text_Click(object sender, EventArgs e)
        {
            StreamReader readtext = new StreamReader("MyFile.txt");
            string text = readtext.ReadToEnd();
            richTextBox1.Text = text;
        }
    }
}

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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Say_Hi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Say hi");
        }

        private void bt_swap_Click(object sender, EventArgs e)
        {
            string temp = this.tb_swap_1.Text;
            this.tb_swap_1.Text = this.tb_swap_2.Text; 
            this.tb_swap_2.Text = temp;
        }

        private void bt_equal_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(tb_first.Text);
            int second = Convert.ToInt32(tb_second.Text);

            if (cb_operator.Text == "+")
            {
                int result = first + second;
                tb_result.Text = result.ToString();
            }
            if (cb_operator.Text == "-")
            {
                int result = first - second;
                tb_result.Text = result.ToString();
            }
            if (cb_operator.Text == "*")
            {
                int result = first * second;
                tb_result.Text = result.ToString();
            }
            if (cb_operator.Text == "/")
            {
                if(second != 0)
                {
                    int result = first / second;
                    tb_result.Text = result.ToString();
                }
            }
            if (cb_operator.Text == "%")
            {
                int result = first + second;
                tb_result.Text = result.ToString();
            }
        }

        private void bt_write_text_Click(object sender, EventArgs e)
        {
            StreamWriter textWriter = new StreamWriter("MyFile.txt");
            textWriter.Write(richTextBox1.Text);
            textWriter.Close();
        }

        private void bt_read_text_Click(object sender, EventArgs e)
        {
            StreamReader textReader = new StreamReader("MyFile1.txt");
            richTextBox1.Text = textReader.ReadToEnd();
        }
    }
}

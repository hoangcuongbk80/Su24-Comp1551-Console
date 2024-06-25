using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form_Admin : Form
    {
        public Form_Admin()
        {
            InitializeComponent();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            string[] newrow = {tb_id.Text, tb_name.Text, tb_email.Text, tb_role.Text};
            dataGridView1.Rows.Add(newrow);
        }

        private void bt_remove_Click(object sender, EventArgs e)
        {
            int row_index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(row_index);
        }
    }
}

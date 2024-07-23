using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Extract data from the selected row and populate textboxes
                tb_id.Text = selectedRow.Cells["Id"].Value.ToString();
                tb_name.Text = selectedRow.Cells["Name"].Value.ToString();
                tb_salary.Text = selectedRow.Cells["Salary"].Value.ToString();
                cb_role.Text = selectedRow.Cells["Role"].Value.ToString();
            }
            else
            {
                // Clear textboxes if no row is selected
                tb_id.Text = "";
                tb_name.Text = "";
                tb_salary.Text = "";
                cb_role.Text = "";
            }
        }

        private void bt_connect_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\FGW\Courses\COMP1551-ApplicationDevelopment\Su24-CO1103\code\Su24-Comp1551-Console\WindowsFormsApp3\Database1.mdf;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Employee";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tb_id.Text);
            string name = tb_name.Text;
            int salary = Convert.ToInt32(tb_salary.Text);
            string role = cb_role.Text;
            DateTime dateTime = DateTime.Parse(dateTimePicker1.Text);

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\FGW\Courses\COMP1551-ApplicationDevelopment\Su24-CO1103\code\Su24-Comp1551-Console\WindowsFormsApp3\Database1.mdf;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Employee (Id, Name, Salary, Role, Date) VALUES (@Id, @Name, @Salary, @Role, @Date)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Salary", salary);
                    command.Parameters.AddWithValue("@Role", role);
                    command.Parameters.AddWithValue("@Date", dateTime);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            // Refresh DataGridView to reflect changes
            bt_connect_Click(sender, e);
        }

        private void bt_modify_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int id = Convert.ToInt32(tb_id.Text);
                string name = tb_name.Text; //selectedRow.Cells["Name"].Value.ToString();
                int salary = Convert.ToInt32(tb_salary.Text); //Convert.ToInt32(selectedRow.Cells["Salary"].Value);
                string role = cb_role.Text; //selectedRow.Cells["Role"].Value.ToString();
                DateTime date = DateTime.Now;

                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\FGW\Courses\COMP1551-ApplicationDevelopment\Su24-CO1103\code\Su24-Comp1551-Console\WindowsFormsApp3\Database1.mdf;Integrated Security=True";


                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE Employee SET Name = @Name, Salary = @Salary, Role = @Role, Date = @Date WHERE Id = @Id";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Salary", salary);
                        command.Parameters.AddWithValue("@Role", role);
                        command.Parameters.AddWithValue("@Date", date); // Use the correct parameter
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                bt_connect_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Please select a row to modify.");
            }
        }

        private void bt_remove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string Name = Convert.ToString(selectedRow.Cells["Name"].Value);
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\FGW\Courses\COMP1551-ApplicationDevelopment\Su24-CO1103\code\Su24-Comp1551-Console\WindowsFormsApp3\Database1.mdf;Integrated Security=True";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM Employee WHERE Name = @Name";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Name", Name);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                bt_connect_Click(null, null);
            }
            else
            {
                MessageBox.Show("Please select a row to remove.");
            }
        }
    }
}

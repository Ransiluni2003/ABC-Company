using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ABC_Company
{

    public partial class Department : Form
    {
        private string CONNECTION_STRING = @"Data Source=DESKTOP-7HL430B\SQLEXPRESS;Initial Catalog=""ABC Company"";Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        //read
        SqlDataAdapter adpt;
        DataTable dt;
        SqlConnection conn = new SqlConnection();

        public Department()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string department_id, department_name;
            department_id = textBoxDepID.Text.ToString();
            department_name = textBoxDepName.Text.ToString();


            if (String.IsNullOrEmpty(department_id) || String.IsNullOrEmpty(department_name))
            {
                MessageBox.Show("Np empty fields allowed except email address of the customer");
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = CONNECTION_STRING;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO Department (department_id,department_name) VALUES ('" + department_id + "' , '" + department_name + "')";
                cmd.Connection = conn;
                int v = cmd.ExecuteNonQuery();

                conn.Close();
                if (v > 0)
                {
                    MessageBox.Show("Customer Successfull register.");
                    textBoxDepID.Text = "";
                    textBoxDepName.Text = "";

                    showDataDepartment();
                }

            }
        }

        private void Department_Load(object sender, EventArgs e)
        {
            showDataDepartment();
        }
        private void showDataDepartment()
        {
            //read
            conn.ConnectionString = CONNECTION_STRING;
            adpt = new SqlDataAdapter("select * from Department", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewAllDepartment.DataSource = dt;
        }

        private void dataGridViewAllDepartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Department dep = new Department();
            dep.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Position pos = new Position();
            pos.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string department_id = textBoxDepID.Text.Trim();

            if (string.IsNullOrEmpty(department_id))
            {
                MessageBox.Show("Please enter the Department ID to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this department?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    string query = "DELETE FROM Department WHERE department_id = @department_id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@department_id", department_id);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Department deleted successfully.");
                        showDataDepartment();

                        // Clear fields
                        textBoxDepID.Text = "";
                        textBoxDepName.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("No department found with that number.");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string department_id = textBoxDepID.Text.Trim();
            string department_name = textBoxDepName.Text.Trim();


            if (string.IsNullOrEmpty(department_id))
            {
                MessageBox.Show("Please enter the Department ID to update.");
                return;
            }
            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                string query = "UPDATE Department SET department_id=@department_id, department_name=@department_name";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@department_id", department_id);
                cmd.Parameters.AddWithValue("@department_name", department_name);


                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Department updated successfully.");
                    showDataDepartment();
                }
                else
                {
                    MessageBox.Show("Update failed. Check Department ID.");
                }
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}

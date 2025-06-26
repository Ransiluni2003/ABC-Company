using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Company
{
    public partial class Employee : Form
    {
        private string CONNECTION_STRING = @"Data Source=DESKTOP-7HL430B\SQLEXPRESS;Initial Catalog=""ABC Company"";Integrated Security=True;Trust Server Certificate=True";
        //read
        SqlDataAdapter adpt;
        DataTable dt;
        SqlConnection conn = new SqlConnection();

        public Employee()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            {
                string employee_no, employee_name, gender, department, position, mobile, phone, email, fax, picture;
                employee_no = textBoxEmpNo.Text.ToString();
                employee_name = textBoxEmpName.Text.ToString();
                gender = comboBox3.SelectedItem.ToString();
                department = comboBox1.SelectedItem.ToString();
                position = comboBox2.SelectedItem.ToString();
                mobile = textBoxMobile.Text.ToString();
                phone = textBoxPhone.Text.ToString();
                email = textBoxEmail.Text.ToString();
                fax = textBoxFax.Text.ToString();
                picture = textBoxPic.Text.ToString();


                if (String.IsNullOrEmpty(employee_no) || String.IsNullOrEmpty(employee_name) || String.IsNullOrEmpty(gender) || String.IsNullOrEmpty(department) || String.IsNullOrEmpty(position) || String.IsNullOrEmpty(mobile) || String.IsNullOrEmpty(phone) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(fax))
                {
                    MessageBox.Show("No empty fields allowed except email address of the customer");
                }
                else
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = CONNECTION_STRING;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO Employee (employee_no,employee_name,gender,department,position,mobile,phone,email,fax,picture) VALUES ('" + employee_no + "','" + employee_name + "' , '" + gender + "' , '" + department + "' ,'" + position + "','" + mobile + "','" + phone + "','" + email + "','" + fax + "','" + picture + "')";
                    cmd.Connection = conn;
                    int v = cmd.ExecuteNonQuery();

                    conn.Close();
                    if (v > 0)
                    {
                        MessageBox.Show("Customer Successfull register.");
                        textBoxEmpNo.Text = "";
                        textBoxEmpName.Text = "";
                        textBoxMobile.Text = "";
                        textBoxPhone.Text = "";
                        textBoxEmail.Text = "";
                        textBoxFax.Text = "";
                        textBoxPic.Text = "";

                        showDataEmployee();
                    }

                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            bool idSearchSelected = radioButtonIdentity.Checked;
            conn.ConnectionString = CONNECTION_STRING;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            string textToSearch = textBoxSearch.Text.ToString();

            if (idSearchSelected)
            {
                try
                {
                    conn.Open();

                    cmd.CommandText = "SELECT * FROM Employee WHERE employee_no = @empno";
                    cmd.Parameters.AddWithValue("@empno", textToSearch);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Fill TextBoxes with employee data
                        textBoxEmpNo.Text = reader["employee_no"].ToString();
                        textBoxEmpName.Text = reader["employee_name"].ToString();
                        comboBox3.SelectedItem = reader["gender"].ToString();
                        comboBox1.SelectedItem = reader["department"].ToString();
                        comboBox2.SelectedItem = reader["position"].ToString();
                        textBoxMobile.Text = reader["mobile"].ToString();
                        textBoxPhone.Text = reader["phone"].ToString();
                        textBoxEmail.Text = reader["email"].ToString();
                        textBoxFax.Text = reader["fax"].ToString();
                        textBoxPic.Text = reader["picture"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Employee not found.");
                    }

                    reader.Close();

                    // Now fill DataGridView
                    adpt = new SqlDataAdapter("SELECT * FROM Employee WHERE employee_no = @empno", conn);
                    adpt.SelectCommand.Parameters.AddWithValue("@empno", textToSearch);
                    dt = new DataTable();
                    adpt.Fill(dt);
                    dataGridViewSearch.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        private void showDataEmployee()
        {
            //read
            conn.ConnectionString = CONNECTION_STRING;
            adpt = new SqlDataAdapter("select * from Employee", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewAllEmployees.DataSource = dt;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Employee_Load_1(object sender, EventArgs e)
        {
            showDataEmployee();

            comboBox3.Items.Clear();
            comboBox3.Items.Add("Male");
            comboBox3.Items.Add("Female");
            comboBox3.Items.Add("Other");
            comboBox3.SelectedIndex = 0;

            // ✅ Populate department ComboBox
            comboBox1.Items.Clear();
            comboBox1.Items.Add("IT");
            comboBox1.Items.Add("HR");
            comboBox1.Items.Add("Other");
            comboBox1.SelectedIndex = 0;

            // ✅ Populate position ComboBox
            comboBox2.Items.Clear();
            comboBox2.Items.Add("Head");
            comboBox2.Items.Add("Tech lead");
            comboBox2.Items.Add("Other");
            comboBox2.SelectedIndex = 0;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string employee_no = textBoxEmpNo.Text.Trim();

            if (string.IsNullOrEmpty(employee_no))
            {
                MessageBox.Show("Please enter the Employee No to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    string query = "DELETE FROM Employee WHERE employee_no = @empno";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@empno", employee_no);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee deleted successfully.");
                        showDataEmployee();

                        // Clear fields
                        textBoxEmpNo.Text = "";
                        textBoxEmpName.Text = "";
                        textBoxMobile.Text = "";
                        textBoxPhone.Text = "";
                        textBoxEmail.Text = "";
                        textBoxFax.Text = "";
                        textBoxPic.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("No employee found with that number.");
                    }
                }
            }
        }


        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string employee_no = textBoxEmpNo.Text.Trim();
            string employee_name = textBoxEmpName.Text.Trim();
            string gender = comboBox3.SelectedItem?.ToString();
            string department = comboBox1.SelectedItem?.ToString();
            string position = comboBox2.SelectedItem?.ToString();
            string mobile = textBoxMobile.Text.Trim();
            string phone = textBoxPhone.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string fax = textBoxFax.Text.Trim();
            string picture = textBoxPic.Text.Trim();

            if (string.IsNullOrEmpty(employee_no))
            {
                MessageBox.Show("Please enter the Employee No to update.");
                return;
            }
            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                string query = "UPDATE Employee SET employee_name=@name, gender=@gender, department=@department, position=@position, mobile=@mobile, phone=@phone, email=@email, fax=@fax, picture=@picture WHERE employee_no=@empno";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@empno", employee_no);
                cmd.Parameters.AddWithValue("@name", employee_name);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@department", department);
                cmd.Parameters.AddWithValue("@position", position);
                cmd.Parameters.AddWithValue("@mobile", mobile);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@fax", fax);
                cmd.Parameters.AddWithValue("@picture", picture);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Employee updated successfully.");
                    showDataEmployee();
                }
                else
                {
                    MessageBox.Show("Update failed. Check Employee No.");
                }
            }


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Department dep = new Department();
            dep.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
            this.Hide();
        }





        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxEmpName_TextChanged(object sender, EventArgs e)
        {

        }



        private void label15_Click_1(object sender, EventArgs e)
        {
            Position pos = new Position();
            pos.Show();
            this.Hide();
        }
    }
}


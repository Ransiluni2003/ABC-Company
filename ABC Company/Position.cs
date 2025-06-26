using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Company
{
    public partial class Position : Form
    {
        private string CONNECTION_STRING = @"Data Source=DESKTOP-7HL430B\SQLEXPRESS;Initial Catalog=""ABC Company"";Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        //read
        SqlDataAdapter adpt;
        DataTable dt;
        SqlConnection conn = new SqlConnection();
        public Position()
        {
            InitializeComponent();
        }

        private void textBoxPosID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPosName_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string position_id, position_name;
            position_id = textBoxPosID.Text.ToString();
            position_name = textBoxPosName.Text.ToString();

            if (String.IsNullOrEmpty(position_id) || String.IsNullOrEmpty(position_name))
            {
                MessageBox.Show("Np empty fields allowed except email address of the customer");
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = CONNECTION_STRING;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO Position (position_id,position_name) VALUES ('" + position_id + "' , '" + position_name + "')";
                cmd.Connection = conn;
                int v = cmd.ExecuteNonQuery();

                conn.Close();
                if (v > 0)
                {
                    MessageBox.Show("Position Successfull register.");
                    textBoxPosID.Text = "";
                    textBoxPosName.Text = "";

                    showDataPosition();
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Position_Load(object sender, EventArgs e)
        {
            showDataPosition();
        }
        private void showDataPosition()
        {
            //read
            conn.ConnectionString = CONNECTION_STRING;
            adpt = new SqlDataAdapter("select * from Position", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewAllPosition.DataSource = dt;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Department dep = new Department();
            dep.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Position pos = new Position();
            pos.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string position_id = textBoxPosID.Text.Trim();
            string position_name = textBoxPosName.Text.Trim();


            if (string.IsNullOrEmpty(position_id))
            {
                MessageBox.Show("Please enter the Position ID to update.");
                return;
            }
            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                string query = "UPDATE Position SET position_id=@position_id, position_name=@position_name";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@position_id", position_id);
                cmd.Parameters.AddWithValue("@position_name", position_name);


                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Position updated successfully.");
                    showDataPosition();
                }
                else
                {
                    MessageBox.Show("Update failed. Check Position ID.");
                }
            }

        }

        private void buttondelete_Click(object sender, EventArgs e)
        {

            string position_id = textBoxPosID.Text.Trim();

            if (string.IsNullOrEmpty(position_id))
            {
                MessageBox.Show("Please enter the Position ID to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this position?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    string query = "DELETE FROM Position WHERE position_id = @position_id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@position_id", position_id);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Position deleted successfully.");
                        showDataPosition();

                        // Clear fields
                        textBoxPosID.Text = "";
                        textBoxPosName.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("No position found with that number.");
                    }
                }
            }
        }
    }
}

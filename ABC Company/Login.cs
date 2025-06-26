using System.Data.SqlClient;
using System.Data.Sql;
using Microsoft.Data.SqlClient;

namespace ABC_Company
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            string username = textBoxUserName.Text.ToString();
            string password = textBoxPassword.Text.ToString();
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                DialogResult dialogResult = MessageBox.Show("No empty feilds allowed", "You can not continue", MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-7HL430B\\SQLEXPRESS;Initial Catalog=\"ABC Company\";Integrated Security=True;Trust Server Certificate=True");
                con.Open();

                String sqlQuery = "SELECT * FROM [UserLogin] WHERE user_name = '" + textBoxUserName.Text + "' AND password = '" + textBoxPassword.Text + "' ";
                SqlCommand com = new SqlCommand(sqlQuery, con);
                SqlDataReader reader = com.ExecuteReader();

                if (reader.HasRows)
                {
                    Home home = new Home();
                    home.Show();
                    this.Hide();

                    reader.Read();
                    MessageBox.Show("User found: " + reader.GetString(0));
                    reader.Close();

                }
                else
                {
                    reader.Close();
                    String insertQuery = "INSERT INTO [UserLogin] VALUES('" + textBoxUserName.Text + "','" + textBoxPassword.Text + "')";
                    SqlCommand cmd = new SqlCommand(insertQuery, con);
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Successfully added.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add user.", "Error");
                    }

                    Home home = new Home();
                    home.Show();
                    this.Hide();

                    // MessageBox.Show("Username or  Password incorrect.");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

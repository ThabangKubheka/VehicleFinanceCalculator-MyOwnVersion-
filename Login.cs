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

namespace VehicleFinanceCalculator
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string user_email = email.Text.Trim();
            string user_password = password.Text.Trim();

            if (string.IsNullOrEmpty(user_email) || string.IsNullOrEmpty(user_password))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            string connectionString = "Data Source=BBD-KT\\SQLEXPRESS;Initial Catalog=VehicleFinanceDB;Integrated Security=True";
            string query = "SELECT COUNT(*) FROM Users WHERE email = @Email AND password = @Password";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", user_email);
                        command.Parameters.AddWithValue("@Password", user_password);

                        connection.Open();
                        int userCount = (int)command.ExecuteScalar();

                        if (userCount > 0)
                        {

                            MessageBox.Show("Login successful.");
                            Form1 form = new();
                            this.Hide();
                            form.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while logging in: " + ex.Message);
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }
    }
}

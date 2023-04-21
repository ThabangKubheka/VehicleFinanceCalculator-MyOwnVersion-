using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace VehicleFinanceCalculator
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }


        public void AddUser(string email, string password)
        {
            string connectionString = "Data Source=BBD-KT\\SQLEXPRESS;Initial Catalog=VehicleFinanceDB;Integrated Security=True";
            string query = "INSERT INTO Users (email, password) VALUES (@Email, @Password)";


            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            message.Text = "Registered Successfully,redirecting to login screen";
                            Login lg = new Login();
                            this.Hide();
                            lg.Show();

                        }
                        else
                        {
                            message.Text = "Unable to Register User";

                        }
                    }
                }
            }
            catch (Exception ex)
            {

                message.Text = ("Error adding user: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user_email = email.Text.Trim();
            string user_password = password.Text.Trim();
            string validated =validatedPassword.Text.Trim();

            if (string.IsNullOrEmpty(user_email) || string.IsNullOrEmpty(user_password) || string.IsNullOrEmpty(validated))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }
            else if(!user_password.Equals(validated)) {
                MessageBox.Show("Password must match!.");
                return;
            }

            AddUser(email.Text, validatedPassword.Text);
        }

    }
}

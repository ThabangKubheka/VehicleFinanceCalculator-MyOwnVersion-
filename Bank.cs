using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace VehicleFinanceCalculator
{
    internal class Bank
    {
        DBConnect DBConnect =new DBConnect();
        public Bank() { }
        public void PopulateComboBox(ComboBox bank)
        {
            string query = "SELECT name FROM Bank";

            using (SqlConnection connection = new SqlConnection(DBConnect.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            bank.Items.Add(reader["name"].ToString());
                            
                        }
                    }
                }
            }
        }

        public string GetDataFromBankTable(string selectedBankName)
        {
            string query = "SELECT * FROM Bank WHERE name = @SelectedBankName";

            using (SqlConnection connection = new SqlConnection(DBConnect.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SelectedBankName", selectedBankName);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    decimal interest=0;

                    while (reader.Read())
                    {
                        interest = reader.GetDecimal(2);
                        
                    }
                    return interest.ToString();
                }
            }
        }
    }
}

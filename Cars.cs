using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFinanceCalculator
{
    internal class Cars
    {
        DBConnect DBConnect = new DBConnect();
        public Cars() { }
        public void PopulateComboBox(ComboBox cars)
        {
            string query = "SELECT name FROM Vehicle";

            using (SqlConnection connection = new SqlConnection(DBConnect.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cars.Items.Add(reader["name"].ToString());

                        }
                    }
                }
            }
        }


        public string GetDataFromBankTable(string selectedVehicleName)
        {
            string query = "SELECT * FROM Vehicle WHERE name = @SelectedVehicleName";

            using (SqlConnection connection = new SqlConnection(DBConnect.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SelectedVehicleName", selectedVehicleName);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    decimal value = 0;

                    while (reader.Read())
                    {
                        value = reader.GetDecimal(2);

                    }
                    return value.ToString();
                }
            }
        }
    }
}

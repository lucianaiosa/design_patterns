using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveRecord
{
    public class Customer
    {
        private const string CONNECTION_STRING =
            "Data Source=(local);Initial Catalog=DesignPatterns;Integrated Security=True";

        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsPremiumMember { get; set; }

        public Customer(int id, string name, bool isPremiumMember)
        {
            ID = id;
            Name = name;
            IsPremiumMember = isPremiumMember;
        }
        public static Customer GetByID(int id)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.Text;

                    command.CommandText = "SELECT TOP 1 * FROM [Customer] WHERE [ID] = @ID";
                    command.Parameters.AddWithValue("@ID", id);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();

                        string name = (string)reader["Name"];
                        bool isPremiumMember = (bool)reader["IsPremiumMember"];

                        return new Customer(id, name, isPremiumMember);
                    }
                }
            }

            return null;
        }

        public void Delete()
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.Text;

                    command.CommandText = "DELETE FROM [Customer] WHERE [ID] = @ID";
                    // This method uses the ID value from this object's property.
                    // This function didn't need to receive that value from a parameter.
                    command.Parameters.AddWithValue("@ID", ID);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

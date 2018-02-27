using System.Data;
using System.Data.SqlClient;

namespace DataMapper
{
    public class CustomerDataMapper
    {
        private const string CONNECTION_STRING =
            "Data Source=(local);Initial Catalog=DesignPatterns;Integrated Security=True";

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

                    // If the query returned a row, create the Customer object and return it.
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

        // We also could have only passed in the ID for this method, 
        // because that is the only value from the Customer object that this method needs.
        public void Delete(Customer customer)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.Text;

                    command.CommandText = "DELETE FROM [Customer] WHERE [ID] = @ID";
                    command.Parameters.AddWithValue("@ID", customer.ID);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

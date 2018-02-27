using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class CustomerService
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

        public void Delete(int customerId)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.Text;

                    command.CommandText = "DELETE FROM [Customer] WHERE [ID] = @customerId";
                    // This method uses the ID value from this object's property.
                    // This function didn't need to receive that value from a parameter.
                    command.Parameters.AddWithValue("@ID", customerId);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

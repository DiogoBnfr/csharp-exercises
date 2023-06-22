using System.Data.SqlClient;

namespace ex007_db_connection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=DESKTOP-BNFR\SQLEXPRESS;Initial Catalog=testDB;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string username = "";
            while (username == "")
            {
                Console.Write("Username: ");
                username = Console.ReadLine();
            }

            try
            {
                sqlConnection.Open();

                string insertQuery = @"INSERT INTO [User] (Username) VALUES (@Username)";
                SqlCommand command = new SqlCommand(insertQuery, sqlConnection);

                command.Parameters.AddWithValue("@Username", username);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Username added successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to add the username.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString()); 
            }

        }
    }
}
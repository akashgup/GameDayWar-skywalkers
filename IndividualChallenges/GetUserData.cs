public void GetUserData(int id)
{
    // SQL injection vulnerability
    string connectionString = Environment.GetEnvironmentVariable("Connection-String");
    string query = "SELECT * FROM Users WHERE id=@id";

    using (var connection = new SqlConnection(connectionString))
    {
        connection.Open();
        using (var command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@id", id); 
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"User ID: {reader["Id"]}, Username: {reader["Username"]}");
                }
            }
        }
    }
}

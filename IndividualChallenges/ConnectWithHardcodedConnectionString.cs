public void ConnectWithHardcodedConnectionString()
{
    var connectionString = Environment.GetEnvironmentVariable("Connectionstring");; // Insecure: Hardcoded credentials
    Console.WriteLine("Connecting with hardcoded connection string.");

    // Simulate database connection
    Console.WriteLine("Connected to database using: " + connectionString);
}

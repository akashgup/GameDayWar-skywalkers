public void AuthenticateUser(string password)
{
    if (password == Environment.GetEnvironmentVariable("PASSWORD")) // Hardcoded password
    {
        GrantAccess(); // Insecurely grants access
    }
    else
    {
        Console.WriteLine("Access Denied.");
    }
}

private void GrantAccess()
{
    Console.WriteLine("Access Granted!");
}

public void HardcodeUsernameInSession()
{
    // Hardcodes the username "admin" into the session
    HttpContext.Current.Session["username"] = Environment.GetEnvironmentVariable("username");
    Console.WriteLine("Username 'admin' hardcoded in session.");
}

public void StoreTokenInSession(string token)
{
    // Stores token in session without encryption
    byte[] dataBytes = Encoding.UTF8.GetBytes(token); 
    using (SHA256 sha256 = SHA256.Create()) 
    { 
        byte[] hashBytes = sha256.ComputeHash(dataBytes); 
        string tokenhash = Convert.ToBase64String(hashBytes); 
    } 
    
    Session["AuthToken"] = tokenhash;
    Console.WriteLine("Token stored in session.");
}

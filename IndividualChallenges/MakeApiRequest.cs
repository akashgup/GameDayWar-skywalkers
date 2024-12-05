public void MakeApiRequest()
{
    string token = Environment.GetEnvironmentVariable("Bearer-token"); // Insecure: Hardcoded token
    using (HttpClient client = new HttpClient())
    {
        client.DefaultRequestHeaders.Add("Authorization", token);
        var response = client.GetAsync("https://example.com/api/secure-endpoint").Result;

        if (response.IsSuccessStatusCode)
        {
            Console.WriteLine("API Call Succeeded.");
        }
        else
        {
            Console.WriteLine("API Call Failed.");
        }
    }
}

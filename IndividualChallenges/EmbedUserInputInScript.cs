public void EmbedUserInputInScript(string userInput)
{
    // Secure: Encodes user input to prevent XSS
    var encodedInput = HttpUtility.JavaScriptStringEncode(userInput);
    var html = $"<script>alert('{encodedInput}')</script>";
    Console.WriteLine("Generated HTML: " + html);
}

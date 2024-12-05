public void OpenFileStream(string filePath)
{
    // Opens a file using an unvalidated file path
    if (filePath.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0) 
    { 
        throw new ArgumentException("Invalid file name."); 
    } 
    string filePath = Path.GetFullPath(filePath); 
    
    using (var fs = new FileStream(filePath, FileMode.Open))
    {
        Console.WriteLine("File opened successfully: " + filePath);
    }
}

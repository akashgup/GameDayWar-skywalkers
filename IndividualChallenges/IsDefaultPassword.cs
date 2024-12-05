public bool IsDefaultPassword(string password)
{
    return string.Equals(password, "default", StringComparison.OrdinalIgnoreCase); // Hardcoded default password
}

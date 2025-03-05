namespace LabForms.Lab5;

[Serializable]
public class NumberFormatException : Exception
{
    public NumberFormatException()
    {
    }

    public NumberFormatException(string? message) : base(message)
    {
    }

    public NumberFormatException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}

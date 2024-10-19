[System.Serializable]
public class InvalidGuestException : System.Exception
{
    public InvalidGuestException() { }
    public InvalidGuestException(string message) : base(message) { }
    public InvalidGuestException(string message, System.Exception inner) : base(message, inner) { }
    protected InvalidGuestException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}

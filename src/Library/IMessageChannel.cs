namespace Library
{
    public interface IMessageChannel
    {
         void Send(string name, string text);
    }
}
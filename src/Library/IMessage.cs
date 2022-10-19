namespace Library
{

    public interface IMessage
    {
        public void Send(Message message);
        public Message GetMessage(Contact contact, string text);
    }
}
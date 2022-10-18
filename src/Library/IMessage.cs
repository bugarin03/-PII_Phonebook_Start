namespace Library;
public interface IMessage
{
    public void send(Message message);
    public Message GetMessage(Contact contact);
}
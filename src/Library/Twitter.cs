using TwitterUCU;
namespace Library
{
    public class Twitter : IMessage
    {
        public void Send(Message message) 
        {
            var twitter = new TwitterMessage();
            twitter.SendMessage(message.Text, message.To);
        }

        public Message GetMessage(Contact contact, string text)
        {
            return new WhatsAppMessage(contact, text);
        }
    }
}
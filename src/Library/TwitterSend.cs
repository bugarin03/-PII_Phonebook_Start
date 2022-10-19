namespace Library
{
    public class TwitterSend : Message
    {
        public TwitterSend (Contact contact, string text) : base (null, contact.TwitterId, text)
        {

        }
    }
}
namespace Library
{
    public class WhatsAppMessage : Message
    {
        public WhatsAppMessage (Contact contact, string text) : base (null, contact.Phone, text)
        {
            
        }
    }
}
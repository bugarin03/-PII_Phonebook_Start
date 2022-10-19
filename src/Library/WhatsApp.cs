using System;
using WhatsAppApiUCU;

namespace Library

{
    public class WhatsApp : IMessage
    {
        public void Send(Message message)
        {
            var whatsApp = new WhatsAppApi();
            whatsApp.Send($"+598{message.To}", message.Text);
        }

        public Message GetMessage(Contact contact, string text)
        {
            return new WhatsAppMessage(contact, text);
        }
    }
}
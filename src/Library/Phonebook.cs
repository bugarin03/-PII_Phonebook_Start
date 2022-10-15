using System;
using System.Collections.Generic;
using WhatsAppApiUCU;

namespace Library
{
    public class Phonebook : IMessageChannel
    {
        private List<Contact> persons;

        public Phonebook(Contact owner)
        {
            this.Owner = owner;
            this.persons = new List<Contact>();
        }

        public Contact Owner { get; }

        public void AddToContacts (string name, string phone, string email)
        /*
            Hice que la instancia de "Contact" se cree en este metodo para respetar 
        */
        {
           Contact contact = new Contact(name, phone, email);
           persons.Add(contact);
        }

        public void RemoveFromContacts (string name)
        {
            foreach (Contact person in this.persons)
            {
                if (person.Name == name )
                {
                   persons.Add(person); 
                }
                
            }        
        }

        public List<Contact> Search(string[] names)
        {
            List<Contact> result = new List<Contact>();

            foreach (Contact person in this.persons)
            {
                foreach (string name in names)
                {
                    if (person.Name.Equals(name))
                    {
                        result.Add(person);
                    }
                    else
                    {
                        Console.WriteLine("El contacto que usted selecciono no existe");
                    }
                }
            }

            return result;
        }

        public void Send (Message message)
        {
            var whatsApp = new WhatsAppApi();
            whatsApp.Send($"+598{message.To}", message.Text); 
        }
    }
}
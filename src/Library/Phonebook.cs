using System;
using System.Collections.Generic;
using WhatsAppApiUCU;

namespace Library
{
    public class Phonebook 
    {
        private List<Contact> persons;

        public Phonebook(Contact owner)
        {
            this.Owner = owner;
            this.persons = new List<Contact>();
            
        }

        public Contact Owner { get; }

        public void AddToContacts (string name, string phone, string email, string twitterId)
        /*
            Realize que la instancia de "Contact" se cree en este metodo para respetar el patrón "Creator"
        */
        {
           Contact contact = new Contact(name, phone, email, twitterId);
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

        public Contact Search(string name)
        {
            Contact result = null;
            foreach (Contact person in this.persons)
            {
                if (person.Name.Equals(name))
                {
                    result = person;
                }
                else
                {
                    Console.WriteLine("El contacto que usted selecciono no existe");
                }
            }
            return result;
        }

        public void Send (List<string> names, IMessage channel, string text)
        {
            List<Contact> contacts = new List<Contact>();

            foreach(string name in names)
            {
                contacts.Add(this.Search(name));
            }
    
           foreach (Contact person in contacts)
           {
                Message message = channel.GetMessage(person, text);
                channel.Send(message);
           }
        }
    }
}

/*
Decidí cambiar el método "Search" debido a la lógica del mismo, ya que antes se le pasaba una lista como parámetro,
pero de acuerdo con mi punto de vista en las agendas únicamente tenemos una persona agendada con el mismo nombre, 
por esta misma razón asocieque capaz q se le quería mandar a varios a la vez, por lo que al método Send,
lo cree de forma q pudiera hacer esta misma función.
*/



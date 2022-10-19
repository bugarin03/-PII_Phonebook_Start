using System;
using Library;
using System.Collections.Generic;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el contacto dueño
            Contact rey= new Contact("B", "093583046", "b","123456789");
            
            // Crear la lista de contactos
            Phonebook emisor = new Phonebook(rey);

            // Agregar contactos a la lista
            emisor.AddToContacts("p", "095232459", "p","123456789");

            // Enviar un correo a algunos contactos


            // Enviar un WhatsApp a algunos contactos
            List<string> list = new List<string>{("Bruno")};
            emisor.Send(list, new WhatsApp(),"hola");

            // Enviar un SMS a algunos contactos

        }
    }
}

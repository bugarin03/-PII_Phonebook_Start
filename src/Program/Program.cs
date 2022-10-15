using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el contacto dueño
            Contact rey= new Contact("B", "093583046", "b");
            Phonebook emisor = new Phonebook(rey);
            // Crear la lista de contactos
            Contact receptor= new Contact("p", "095232459", "p");
            // Agregar contactos a la lista
            emisor.AddToContacts(receptor);
            // Enviar un correo a algunos contactos

            // Enviar un WhatsApp a algunos contactos
            emisor.Send("p", "Pop");
            // Enviar un SMS a algunos contactos
        }
    }
}

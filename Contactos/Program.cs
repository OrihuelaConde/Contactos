using System;
using System.Collections.Generic;
using System.Linq;

namespace Contactos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> Contactos = new List<Persona>();
            string respuesta = "";            
            do
            {
                Console.Clear();
                Console.WriteLine("Hola, esta es tu lista de contactos");
                Console.WriteLine();
                foreach (Persona contacto in Contactos)
                {
                    Console.WriteLine($"{contacto.Id} - {contacto.NombreCompleto}: {contacto.Telefono}");
                }
                Console.WriteLine();
                Console.Write("Ingresa 'n' para cargar un nuevo contacto, 'b' para borrar o 's' para salir: ");
                respuesta = Console.ReadLine();
                if(respuesta == "n")
                {
                    Console.Clear();
                    Persona nuevoContacto = new Persona();
                    // Si hay al menos 1 contacto entonces el Id va a ser el mayor Id que exista más 1, caso contrario 1
                    if(Contactos.Count >= 1)
                    {
                        nuevoContacto.Id = Contactos.Max(c => c.Id) + 1;
                    }
                    else
                    {
                        nuevoContacto.Id = 1;
                    }
                    Console.Write("Nombre: ");
                    nuevoContacto.Nombre = Console.ReadLine();
                    Console.Write("Apellido: ");
                    nuevoContacto.Apellido = Console.ReadLine();
                    Console.Write("Teléfono: ");
                    nuevoContacto.Telefono = Console.ReadLine();
                    Contactos.Add(nuevoContacto);
                }
                if(respuesta == "b")
                {
                    Console.WriteLine();
                    int idContactoBorrar;
                    Console.Write("Ingrese el Id del contacto a borrar: ");
                    idContactoBorrar = int.Parse(Console.ReadLine());
                    // Elimino de la lista todos los contactos que coincidan con el Id ingresado
                    Contactos.RemoveAll(c => c.Id == idContactoBorrar);
                }
            } while (respuesta != "s");
            Console.Write("¡Nos vemos!");
        }
    }
}

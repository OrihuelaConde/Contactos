using System;
using System.Collections.Generic;
using System.Text;

namespace Contactos
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string NombreCompleto 
        { 
            get 
            { 
                return $"{Nombre}, {Apellido}"; 
            } 
        }
    }
}

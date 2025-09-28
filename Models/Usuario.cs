using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSimple.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Usuario()
        {
            FechaRegistro = DateTime.Now;
        }

        public Usuario(int id, string nombre, string email, string telefono)
        {
            Id = id;
            Nombre = nombre;
            Email = email;
            Telefono = telefono;
            FechaRegistro = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Id} - {Nombre} ({Email})";
        }
    }
}
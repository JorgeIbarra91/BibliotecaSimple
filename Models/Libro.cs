using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSimple.Models
{
    public class Libro
    {
        public int LibroId { get; set; }
        public string LibroTitulo { get; set; }
        public string LibroAutor { get; set; }
        public string LibroISBN { get; set; }
        public string LibroCategoria { get; set; }
        public bool LibroDisponible { get; set; }
        public DateTime LibroFechaIngreso { get; set; }

        public Libro()
        {
            LibroDisponible = true;
            LibroFechaIngreso = DateTime.Now;
        }

        public Libro(int id, string titulo, string autor, string isbn, string categoria)
        {
            LibroId = id;
            LibroTitulo = titulo;
            LibroAutor = autor;
            LibroISBN = isbn;
            LibroCategoria = categoria;
            LibroDisponible = true;
            LibroFechaIngreso = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{LibroId} - {LibroTitulo} por {LibroAutor}";
        }
    }
}
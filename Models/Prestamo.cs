using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSimple.Models
{
    public class Prestamo
    {
        public int PrestamoId { get; set; }
        public int PrestamoUsuarioId { get; set; }
        public int PrestamoLibroId { get; set; }
        public DateTime PrestamoFecha { get; set; }
        public DateTime PrestamoFechaDevolucion { get; set; }
        public bool PrestamoDevuelto { get; set; }

        public Prestamo()
        {
            PrestamoFecha = DateTime.Now;
            PrestamoFechaDevolucion = DateTime.Now.AddDays(14);
            PrestamoDevuelto = false;
        }

        public Prestamo(int id, int usuarioId, int libroId)
        {
            PrestamoId = id;
            PrestamoUsuarioId = usuarioId;
            PrestamoLibroId = libroId;
            PrestamoFecha = DateTime.Now;
            PrestamoFechaDevolucion = DateTime.Now.AddDays(14);
            PrestamoDevuelto = false;
        }

        public override string ToString()
        {
            return $"Préstamo {PrestamoId} - Usuario: {PrestamoUsuarioId}, Libro: {PrestamoLibroId}";
        }
    }
}
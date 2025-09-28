using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaSimple.Models;

namespace BibliotecaSimple.Managers
{
    public class GestorBiblioteca
    {
        private List<Usuario> usuarios;
        private List<Libro> libros;
        private List<Prestamo> prestamos;
        private int siguienteIdUsuario;
        private int siguienteIdLibro;
        private int siguienteIdPrestamo;

        public GestorBiblioteca()
        {
            usuarios = new List<Usuario>();
            libros = new List<Libro>();
            prestamos = new List<Prestamo>();
            siguienteIdUsuario = 1;
            siguienteIdLibro = 1;
            siguienteIdPrestamo = 1;

            // Datos de prueba
            InicializarDatosPrueba();
        }

        private void InicializarDatosPrueba()
        {
            // Usuarios de prueba
            AgregarUsuario("Juan Pérez", "juan@email.com", "123456789");
            AgregarUsuario("María García", "maria@email.com", "987654321");

            // Libros de prueba
            AgregarLibro("El Quijote", "Miguel de Cervantes", "978-84-376-0494-7", "Clásicos");
            AgregarLibro("1984", "George Orwell", "978-84-376-0496-1", "Ciencia Ficción");
        }

        // Métodos para Usuarios
        public bool AgregarUsuario(string nombre, string email, string telefono)
        {
            try
            {
                var usuario = new Usuario(siguienteIdUsuario++, nombre, email, telefono);
                usuarios.Add(usuario);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return usuarios.ToList();
        }

        public Usuario BuscarUsuario(int id)
        {
            return usuarios.FirstOrDefault(u => u.Id == id);
        }

        // Métodos para Libros
        public bool AgregarLibro(string titulo, string autor, string isbn, string categoria)
        {
            try
            {
                var libro = new Libro(siguienteIdLibro++, titulo, autor, isbn, categoria);
                libros.Add(libro);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Libro> ObtenerLibros()
        {
            return libros.ToList();
        }

        public List<Libro> ObtenerLibrosDisponibles()
        {
            return libros.Where(l => l.LibroDisponible).ToList();
        }

        public Libro BuscarLibro(int id)
        {
            return libros.FirstOrDefault(l => l.LibroId == id);
        }

        // Métodos para Préstamos
        public bool CrearPrestamo(int usuarioId, int libroId)
        {
            try
            {
                var usuario = BuscarUsuario(usuarioId);
                var libro = BuscarLibro(libroId);

                if (usuario == null || libro == null || !libro.LibroDisponible)
                    return false;

                var prestamo = new Prestamo(siguienteIdPrestamo++, usuarioId, libroId);
                prestamos.Add(prestamo);
                libro.LibroDisponible = false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DevolverLibro(int prestamoId)
        {
            try
            {
                var prestamo = prestamos.FirstOrDefault(p => p.PrestamoId == prestamoId && !p.PrestamoDevuelto);
                if (prestamo == null) return false;

                prestamo.PrestamoDevuelto = true;
                var libro = BuscarLibro(prestamo.PrestamoLibroId);
                if (libro != null)
                    libro.LibroDisponible = true;

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Prestamo> ObtenerPrestamos()
        {
            return prestamos.ToList();
        }

        public List<Prestamo> ObtenerPrestamosActivos()
        {
            return prestamos.Where(p => !p.PrestamoDevuelto).ToList();
        }
    }
}
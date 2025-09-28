## Descripción

Aplicación de escritorio en C# para la gestión de una biblioteca llamada *BookWorld*. Permite administrar usuarios, libros y préstamos, utilizando una base de datos MySQL.

---

## Base de Datos

- Se utiliza **MySQL** como sistema gestor de base de datos.
- Para facilitar la instalación y administración, se recomienda usar **XAMPP** (https://www.apachefriends.org/index.html).
- La base de datos se llama `BookWorldDB` y contiene las tablas principales:
  - `usuarios`
  - `libros`
  - `prestamos`
- La estructura de la tabla `prestamos` incluye campos como:
  - `PrestamoId` (PK, auto incremental)
  - `PrestamoUsuarioId` (FK a usuarios)
  - `PrestamoLibroId` (FK a libros)
  - `PrestamoFecha`
  - `FechaDevolucionEsperada`
  - `PrestamoDevuelto`

---

## Estructura de Carpetas

- **Managers/**: Contiene la clase `GestorBibliotecaMySQL.cs` que maneja la conexión y operaciones con la base de datos.
- **Models/**: Clases que representan las entidades del sistema (`Usuario`, `Libro`, `Prestamo`).
- **Form1.cs** y otros formularios: Interfaz gráfica para interactuar con el sistema.

---

## Requisitos Básicos

- Tener instalado **Visual Studio** para compilar y ejecutar la aplicación.
- Tener instalado y configurado **XAMPP** con MySQL activo.
- Crear la base de datos `BookWorldDB` y las tablas según la estructura definida.
- Configurar la cadena de conexión en `GestorBibliotecaMySQL.cs` si es necesario.

---

## Uso Básico

1. Ejecutar XAMPP y arrancar el servicio MySQL.
2. Abrir la aplicación en Visual Studio y compilar.
3. Usar la interfaz para agregar usuarios, libros y gestionar préstamos.

---

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaSimple.Models;
using BibliotecaSimple.Managers;

namespace BibliotecaSimple
{
    public partial class Form1 : Form
    {
        private GestorBiblioteca gestor;
        private string vistaActual = "";

        public Form1()
        {
            gestor = new GestorBiblioteca();
            InitializeComponent();
            MostrarUsuarios();
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new MenuStrip();
            this.usuariosToolStripMenuItem = new ToolStripMenuItem();
            this.librosToolStripMenuItem = new ToolStripMenuItem();
            this.prestamosToolStripMenuItem = new ToolStripMenuItem();
            this.reportesToolStripMenuItem = new ToolStripMenuItem();
            this.panelPrincipal = new Panel();
            this.lblTitulo = new Label();
            this.panelBotones = new Panel();
            this.btnAgregar = new Button();
            this.btnEditar = new Button();
            this.btnEliminar = new Button();
            this.dgvDatos = new DataGridView();

            this.menuStrip1.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();

            // menuStrip1
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
                this.usuariosToolStripMenuItem,
                this.librosToolStripMenuItem,
                this.prestamosToolStripMenuItem,
                this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.BackColor = Color.FromArgb(52, 73, 94);
            this.menuStrip1.ForeColor = Color.White;
            this.menuStrip1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);

            // usuariosToolStripMenuItem
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.usuariosToolStripMenuItem.Text = "👥 Usuarios";
            this.usuariosToolStripMenuItem.ForeColor = Color.White;
            this.usuariosToolStripMenuItem.Click += new EventHandler(this.usuariosToolStripMenuItem_Click);

            // librosToolStripMenuItem
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.librosToolStripMenuItem.Text = "📚 Libros";
            this.librosToolStripMenuItem.ForeColor = Color.White;
            this.librosToolStripMenuItem.Click += new EventHandler(this.librosToolStripMenuItem_Click);

            // prestamosToolStripMenuItem
            this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            this.prestamosToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.prestamosToolStripMenuItem.Text = "📋 Préstamos";
            this.prestamosToolStripMenuItem.ForeColor = Color.White;
            this.prestamosToolStripMenuItem.Click += new EventHandler(this.prestamosToolStripMenuItem_Click);

            // reportesToolStripMenuItem
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.reportesToolStripMenuItem.Text = "📊 Reportes";
            this.reportesToolStripMenuItem.ForeColor = Color.White;
            this.reportesToolStripMenuItem.Click += new EventHandler(this.reportesToolStripMenuItem_Click);

            // panelPrincipal
            this.panelPrincipal.BackColor = Color.White;
            this.panelPrincipal.BorderStyle = BorderStyle.FixedSingle;
            this.panelPrincipal.Controls.Add(this.dgvDatos);
            this.panelPrincipal.Controls.Add(this.panelBotones);
            this.panelPrincipal.Controls.Add(this.lblTitulo);
            this.panelPrincipal.Location = new System.Drawing.Point(30, 50);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1140, 600);
            this.panelPrincipal.TabIndex = 1;

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = Color.FromArgb(52, 73, 94);
            this.lblTitulo.Location = new System.Drawing.Point(30, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(300, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "👥 Gestión de Usuarios";

            // panelBotones
            this.panelBotones.BackColor = Color.FromArgb(236, 240, 241);
            this.panelBotones.BorderStyle = BorderStyle.FixedSingle;
            this.panelBotones.Controls.Add(this.btnEliminar);
            this.panelBotones.Controls.Add(this.btnEditar);
            this.panelBotones.Controls.Add(this.btnAgregar);
            this.panelBotones.Location = new System.Drawing.Point(30, 70);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(1080, 60);
            this.panelBotones.TabIndex = 1;

            // btnAgregar
            this.btnAgregar.BackColor = Color.FromArgb(39, 174, 96);
            this.btnAgregar.FlatStyle = FlatStyle.Flat;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(20, 10);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(130, 40);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "➕ AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Cursor = Cursors.Hand;
            this.btnAgregar.Click += new EventHandler(this.btnAgregar_Click);

            // btnEditar
            this.btnEditar.BackColor = Color.FromArgb(241, 196, 15);
            this.btnEditar.FlatStyle = FlatStyle.Flat;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = Color.White;
            this.btnEditar.Location = new System.Drawing.Point(170, 10);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(130, 40);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "✏️ EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Cursor = Cursors.Hand;
            this.btnEditar.Click += new EventHandler(this.btnEditar_Click);

            // btnEliminar
            this.btnEliminar.BackColor = Color.FromArgb(231, 76, 60);
            this.btnEliminar.FlatStyle = FlatStyle.Flat;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(320, 10);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 40);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "🗑️ ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Cursor = Cursors.Hand;
            this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);

            // dgvDatos
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.BackgroundColor = Color.White;
            this.dgvDatos.BorderStyle = BorderStyle.FixedSingle;
            this.dgvDatos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
            this.dgvDatos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvDatos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.dgvDatos.ColumnHeadersHeight = 40;
            this.dgvDatos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            this.dgvDatos.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dgvDatos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvDatos.Location = new System.Drawing.Point(30, 150);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowTemplate.Height = 35;
            this.dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(1080, 430);
            this.dgvDatos.TabIndex = 2;
            this.dgvDatos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "BookWorld Library - Sistema de Gestión";

            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem librosToolStripMenuItem;
        private ToolStripMenuItem prestamosToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private Panel panelPrincipal;
        private Label lblTitulo;
        private Panel panelBotones;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private DataGridView dgvDatos;

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarLibros();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarPrestamos();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarReportes();
        }

        private void MostrarUsuarios()
        {
            vistaActual = "usuarios";
            lblTitulo.Text = "👥 Gestión de Usuarios";

            var usuarios = gestor.ObtenerUsuarios();
            dgvDatos.DataSource = usuarios.Select(u => new {
                ID = u.Id,
                Nombre = u.Nombre,
                Email = u.Email,
                Teléfono = u.Telefono,
                FechaRegistro = u.FechaRegistro.ToString("dd/MM/yyyy")
            }).ToList();
        }

        private void MostrarLibros()
        {
            vistaActual = "libros";
            lblTitulo.Text = "📚 Catálogo de Libros";

            var libros = gestor.ObtenerLibros();
            dgvDatos.DataSource = libros.Select(l => new {
                ID = l.LibroId,
                Título = l.LibroTitulo,
                Autor = l.LibroAutor,
                ISBN = l.LibroISBN,
                Categoría = l.LibroCategoria,
                Disponible = l.LibroDisponible ? "Sí" : "No"
            }).ToList();
        }

        private void MostrarPrestamos()
        {
            vistaActual = "prestamos";
            lblTitulo.Text = "📋 Gestión de Préstamos";

            var prestamos = gestor.ObtenerPrestamos();
            dgvDatos.DataSource = prestamos.Select(p => new {
                ID = p.PrestamoId,
                Usuario = gestor.BuscarUsuario(p.PrestamoUsuarioId)?.Nombre ?? "No encontrado",
                Libro = gestor.BuscarLibro(p.PrestamoLibroId)?.LibroTitulo ?? "No encontrado",
                FechaPréstamo = p.PrestamoFecha.ToString("dd/MM/yyyy"),
                Estado = p.PrestamoDevuelto ? "Devuelto" : "Activo"
            }).ToList();
        }

        private void MostrarReportes()
        {
            vistaActual = "reportes";
            lblTitulo.Text = "📊 Reportes del Sistema";

            var totalUsuarios = gestor.ObtenerUsuarios().Count;
            var totalLibros = gestor.ObtenerLibros().Count;
            var librosDisponibles = gestor.ObtenerLibrosDisponibles().Count;
            var prestamosActivos = gestor.ObtenerPrestamosActivos().Count;

            var reportes = new List<object>
            {
                new { Estadística = "👥 Total de Usuarios", Cantidad = totalUsuarios, Descripción = "Usuarios registrados en el sistema" },
                new { Estadística = "📚 Total de Libros", Cantidad = totalLibros, Descripción = "Libros disponibles en el catálogo" },
                new { Estadística = "✅ Libros Disponibles", Cantidad = librosDisponibles, Descripción = "Libros disponibles para préstamo" },
                new { Estadística = "📖 Libros Prestados", Cantidad = totalLibros - librosDisponibles, Descripción = "Libros actualmente prestados" },
                new { Estadística = "🔄 Préstamos Activos", Cantidad = prestamosActivos, Descripción = "Préstamos pendientes de devolución" }
            };

            dgvDatos.DataSource = reportes;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            switch (vistaActual)
            {
                case "usuarios":
                    AgregarUsuario();
                    break;
                case "libros":
                    AgregarLibro();
                    break;
                case "prestamos":
                    AgregarPrestamo();
                    break;
                default:
                    MessageBox.Show("Selecciona una sección primero", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una fila para editar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Funcionalidad de edición disponible", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una fila para eliminar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var resultado = MessageBox.Show("¿Estás seguro de eliminar este elemento?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Funcionalidad de eliminación disponible", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AgregarUsuario()
        {
            var resultado = MessageBox.Show("¿Agregar usuario de prueba?\n\n'Nuevo Usuario' - nuevo@test.com",
                "Agregar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                if (gestor.AgregarUsuario("Nuevo Usuario", "nuevo@test.com", "123456789"))
                {
                    MessageBox.Show("✅ Usuario agregado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarUsuarios();
                }
                else
                {
                    MessageBox.Show("❌ Error al agregar usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AgregarLibro()
        {
            var resultado = MessageBox.Show("¿Agregar libro de prueba?\n\n'Nuevo Libro' - Autor Desconocido",
                "Agregar Libro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                if (gestor.AgregarLibro("Nuevo Libro", "Autor Desconocido", "978-0000000000", "General"))
                {
                    MessageBox.Show("✅ Libro agregado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarLibros();
                }
                else
                {
                    MessageBox.Show("❌ Error al agregar libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AgregarPrestamo()
        {
            var usuarios = gestor.ObtenerUsuarios();
            var librosDisponibles = gestor.ObtenerLibrosDisponibles();

            if (usuarios.Count == 0)
            {
                MessageBox.Show("❌ No hay usuarios registrados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (librosDisponibles.Count == 0)
            {
                MessageBox.Show("❌ No hay libros disponibles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultado = MessageBox.Show($"¿Crear préstamo?\n\nUsuario: {usuarios[0].Nombre}\nLibro: {librosDisponibles[0].LibroTitulo}",
                "Nuevo Préstamo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                if (gestor.CrearPrestamo(usuarios[0].Id, librosDisponibles[0].LibroId))
                {
                    MessageBox.Show("✅ Préstamo creado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarPrestamos();
                }
                else
                {
                    MessageBox.Show("❌ Error al crear préstamo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
using ProyectoTallerBaseDatos.Backend;
using ProyectoTallerBaseDatos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTallerBaseDatos.Frontend
{
    public partial class frmVerUsuarios : Form
    {
        public frmVerUsuarios()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga los elementos del formulario y les da formato
        /// (centrar, colocar imagenes, alterar tamaños, etc.). 
        /// También llena el grid con los datos de los usuarios recuperados
        /// de la Base de Datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmVerUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                clsDaoUsuarios dao = new clsDaoUsuarios();
                formatoGrid(dao.obtenerUsuarios());
                lblTitulo.Location = new Point((this.ClientSize.Width - lblTitulo.Width) / 2, lblTitulo.Location.Y);
                pcbSticker.Location = new Point(lblTitulo.Location.X - pcbSticker.Width - 5, (pnlTitulo.Height - pcbSticker.Height) / 2);
                pnlTitulo.Width = gridUsuarios.Width;
                pnlTitulo.Location = new Point(gridUsuarios.Location.X, pnlTitulo.Location.Y);
                btnRegresar.Image = (Image)Properties.Resources.img_regresar.GetThumbnailImage(40, 40, null, IntPtr.Zero);

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                ex.Message,
                "Administrador del sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
        }
        /// <summary>
        /// Llena el grid con la lista de los usuarios
        /// y le da un formato personalizado
        /// </summary>
        /// <param name="usuarios"></param>
        private void formatoGrid(List<clsUsuarios> usuarios)
        {
            gridUsuarios.Rows.Clear();
            gridUsuarios.AllowUserToAddRows = false;
            gridUsuarios.AutoGenerateColumns = false;
            gridUsuarios.Columns.Add("nombre", "Nombre");
            gridUsuarios.Columns.Add("aPaterno", "Apellido Paterno");
            gridUsuarios.Columns.Add("aMaterno", "Apellido Materno");
            gridUsuarios.Columns.Add("usuario", "Usuario");
            gridUsuarios.Columns.Add("email", "Email");
            gridUsuarios.Columns.Add("fechaNac", "Fecha de Nacimiento");
            gridUsuarios.Columns.Add("fechaCreacion", "Fecha de Creacion");
            gridUsuarios.Columns.Add("ultLogeo", "Ultimo Logeo");

            

            foreach(clsUsuarios u in usuarios)
            {
                gridUsuarios.Rows.Add(
                    u.nombre,
                    u.aPaterno,
                    u.aMaterno,
                    u.usuario,
                    u.email,
                    u.fechaNac,
                    u.fechaCreacion,
                    u.ultimoLogeo
                    );
            }
            int ancho = 0;

            foreach (DataGridViewColumn columna in gridUsuarios.Columns)
            {
                ancho += columna.Width;
            }
            gridUsuarios.Width = ancho+5;
            this.ClientSize = new Size(ancho + 30, this.ClientSize.Height);
            gridUsuarios.Location = new Point((this.ClientSize.Width - gridUsuarios.Width) / 2, gridUsuarios.Location.Y);
        }
        /// <summary>
        /// Botón que permite regresar al menú principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}

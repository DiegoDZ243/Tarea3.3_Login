using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ProyectoTallerBaseDatos.Frontend
{
    public partial class frmMenu : Form
    {
        public frmMenu(string user)
        {
            InitializeComponent();
            this.Text += " - Usuario: " + user;
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult opcion = MessageBox.Show(
            "¿Quiere salir de la aplicación?",
            "Confirmar salida",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (opcion == DialogResult.No)
            {
                e.Cancel=true;   
            }
        }

        private void btnVerUsuarios_Click(object sender, EventArgs e)
        {
            frmVerUsuarios verUsuarios=new frmVerUsuarios();
            this.Hide();
            verUsuarios.ShowDialog();
            this.Show(); 
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistrarUsuario registrarUsuario=new frmRegistrarUsuario(); 
            this.Hide();
            registrarUsuario.ShowDialog();
            this.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblMenu.Location = new Point((pnlTitulo.Width - lblMenu.Width) / 2 + 20, (pnlTitulo.Height - lblMenu.Height) / 2);
            pcbMenu.Location = new Point(lblMenu.Location.X - pcbMenu.Width - 5, (pnlTitulo.Height-pcbMenu.Height)/2);
            Image imgSalida = Properties.Resources.img_salir.GetThumbnailImage(40, 40, null, IntPtr.Zero);
            btnSalir.Image = imgSalida;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}

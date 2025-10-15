using Org.BouncyCastle.Utilities;
using ProyectoTallerBaseDatos.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTallerBaseDatos.Frontend
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga los componentes gráficos del login, centrandolos y
        /// dandole un mejor aspecto visual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblTitulo.Location=new Point(
            (this.pnlTitulo.Width-lblTitulo.Width)/2,lblTitulo.Location.Y);
            
            btnEntrar.Location=new Point((pnlCuerpo.Width-btnEntrar.Width)/2,btnEntrar.Location.Y);
            
            pnlCuerpo.Location =new Point((this.ClientSize.Width-pnlCuerpo.Width)/2,pnlCuerpo.Location.Y);
            pnlTitulo.Location = new Point((this.ClientSize.Width - pnlTitulo.Width) / 2, pnlTitulo.Location.Y);
        }
        
        /// <summary>
        /// Función del botón para iniciar sesión. 
        /// Revisa tanto el usuario como la contraseña ingresados por el usuario.
        /// Accede a la base de datos y revisa que las credenciales existan. 
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Deshabilita temporalmente el botón mientras se revisan
                //las credenciales 
                btnEntrar.Enabled = false;
                clsDaoUsuarios dao = new clsDaoUsuarios();
                string user = txtUsuario.Text;
                //Se toma la contraseña y se utiliza la función de hash SHA2()
                //para compararla con los datos de la BD
                string password = CalcularSHA256(txtPassword.Text);
                //Valida el inicio de sesión
                if (dao.validarInicioSesion(user, password))
                {
                    //Se actualiza la última fecha de inicio de sesión
                    dao.actualizarFechaLogeo(user);
                    //Se notifica el inicio de sesión exitoso y se lleva al menú principal
                    MessageBox.Show("Bienvenido " + user, "Inicio de Sesión",
                        MessageBoxButtons.OK,MessageBoxIcon.Information);
                    frmMenu menu = new frmMenu(user);
                    //Se esconde permanentemente el login
                    this.Hide();
                    menu.ShowDialog();
                    Application.Exit();
                }
                //Se notifica que el usuario y/o la contraseña no son correctas
                else
                {
                    MessageBox.Show("Parece que el usuario o la contraseña son incorrectos","Campos Incorrectos",
                        MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            //Manejo de excepciones
            catch (Exception ex)
            {
                MessageBox.Show(
                ex.Message,
                "Administrador del sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
            finally { 
                btnEntrar.Enabled = true;
            }
        }

        /// <summary>
        /// Función que toma el texto plano y aplica la función de hash
        /// SHA2() para asegurar que los datos del usuario estén protegidos
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private string CalcularSHA256(string input)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sb = new StringBuilder();

                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));

                return sb.ToString();
            }
        }
    }
}

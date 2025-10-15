using ProyectoTallerBaseDatos.Backend;
using ProyectoTallerBaseDatos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTallerBaseDatos.Frontend
{
    public partial class frmRegistrarUsuario : Form
    {
        public frmRegistrarUsuario()
        {
            InitializeComponent();
        }

        #region VALIDACIONES

        private bool validaNombre()
        {
            if (String.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                errNombre.SetError(txtNombre, "No puede dejar el campo de nombre vacío");
                return false;
            }
            else if (!(2 <= txtNombre.Text.Trim().Length && txtNombre.Text.Trim().Length <= 30))
            {
                errNombre.SetError(txtNombre, "El nombre debe tener entre 2 y 30 caracteres");
                return false;
            }
            errNombre.Clear();
            return true;
        }

        private bool validaPaterno()
        {
            if (String.IsNullOrEmpty(txtPaterno.Text.Trim()))
            {
                errPaterno.SetError(txtPaterno, "No puede dejar el campo del apellido paterno vacío");
                return false;
            }
            else if (!(2 <= txtPaterno.Text.Trim().Length && txtPaterno.Text.Trim().Length <= 20))
            {
                errPaterno.SetError(txtPaterno, "El apellido paterno debe tener entre 2 y 20 caracteres");
                return false;
            }
            errPaterno.Clear();
            return true;
        }


        private bool validaMaterno()
        {
            if (String.IsNullOrEmpty(txtMaterno.Text.Trim()))
            {
                errMaterno.SetError(txtMaterno, "No puede dejar el campo del apellido materno vacío");
                return false;
            }
            else if (!(2 <= txtMaterno.Text.Trim().Length && txtMaterno.Text.Trim().Length <= 20))
            {
                errMaterno.SetError(txtMaterno, "El apellido materno debe tener entre 2 y 20 caracteres");
                return true;
            }
            errMaterno.Clear();
            return true;
        }

        private bool validaUsuario()
        {
            if (String.IsNullOrEmpty(txtUsuario.Text.Trim()))
            {
                errUsuario.SetError(txtUsuario, "No puede dejar este campo vacío");
                return false;
            }
            else if (!(2 <= txtUsuario.Text.Trim().Length && txtUsuario.Text.Trim().Length <= 40))
            {
                errUsuario.SetError(txtUsuario, "El usuario debe tener entre 2 y 40 caracteres");
                return true;
            }
            errUsuario.Clear();
            return true;
        }

        private bool validaEmail()
        {
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.Focus();
                errEmail.SetError(txtEmail, "Debe escribir el correo");
                return false;
            }
            else if (!Regex.IsMatch(txtEmail.Text, patron))
            {
                txtEmail.Focus();
                errEmail.SetError(txtEmail, "Correo electrónico inválido");
                return false;
            }

            errEmail.Clear();
            return true;
        }

        private bool validaPassoword()
        {
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                txtPass.Focus();
                errPass.SetError(txtPass, "Escriba una contraseña");
                return false;
            }
            else if (string.IsNullOrEmpty(txtPass.Text))
            {
                txtConfirmar.Focus();
                errConfirmar.SetError(txtConfirmar, "Confirme su contraseña");
                return false;
            }
            else if (!(txtPass.Text.Trim().Length >= 8))
            {
                txtConfirmar.Focus();
                errPass.SetError(txtConfirmar, "Su contraseña debe tener al menos 8 caracteres");
                return false;
            }
            else if (txtConfirmar.Text.Trim() != txtPass.Text.Trim())
            {
                txtConfirmar.Focus();
                errPass.SetError(txtConfirmar, "Sus contraseñas no coinciden");
                return false;
            }
            errPass.Clear();
            errConfirmar.Clear();
            return true;
        }

        private bool validaRegistro()
        {
            return (validaNombre() && validaPaterno() && validaMaterno() &&
            validaUsuario() && validaPassoword() && validaEmail());
        }

        #endregion

        /// <summary>
        /// Toma los datos ingresados para el nuevo usuario, los valida
        /// y procede a guardarlos en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!validaRegistro()) return;
            clsDaoUsuarios dao = new clsDaoUsuarios();
            clsUsuariosRegistro usuario = new clsUsuariosRegistro(
                txtNombre.Text.Trim(),
                txtPaterno.Text.Trim(),
                txtMaterno.Text.Trim(),
                txtEmail.Text.Trim(),
                txtUsuario.Text.Trim(),
                CalcularSHA256(txtPass.Text.Trim()),
                dtpNac.Value);

            if (dao.registrarUsuario(usuario))
            {
                MessageBox.Show(
                    "El usuario fue registrado correctamente.",
                    "Registro exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.Dispose();
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Hubo un error inesperado al registrar el usuario.\nPor favor, inténtelo nuevamente.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        /// <summary>
        /// Función que toma el texto plano de la contraseña y le aplica
        /// la función de hash SHA2() para proteger los datos del usuario
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        /// <summary>
        /// Función que carga los elementos del formulario, coloca imagenes
        /// y centra los mismos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            lblTitulo.Location = new Point((this.ClientSize.Width - lblTitulo.Width) / 2, lblTitulo.Location.Y);
            Image imgAceptar = Properties.Resources.img_aceptar.GetThumbnailImage(40, 40, null, IntPtr.Zero);
            Image imgRechazar = Properties.Resources.img_rechazar.GetThumbnailImage(40, 40, null, IntPtr.Zero);
            btnRegistrar.Image = imgAceptar;
            btnCancelar.Image= imgRechazar;
            btnRegresar.Image = (Image)Properties.Resources.img_regresar.GetThumbnailImage(40, 40, null, IntPtr.Zero);
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

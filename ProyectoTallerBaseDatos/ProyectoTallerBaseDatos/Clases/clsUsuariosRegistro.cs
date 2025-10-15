using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTallerBaseDatos.Clases
{
    internal class clsUsuariosRegistro
    {

        public clsUsuariosRegistro(String nombre, String aPaterno, String aMaterno,
            String email, String usuario, string password,DateTime fechaNac)
        {
            this.nombre = nombre;
            this.aPaterno = aPaterno;
            this.aMaterno = aMaterno;
            this.email = email;
            this.usuario = usuario;
            this.password = password;
            this.fechaNac = fechaNac;
        }


        public String nombre { get; set; }
        public String password { get; set; }
        public String aPaterno { get; set; }
        public String aMaterno { get; set; }
        public String email { get; set; }
        public String usuario { get; set; }
        public DateTime fechaNac { get; set; }
    
    }
}

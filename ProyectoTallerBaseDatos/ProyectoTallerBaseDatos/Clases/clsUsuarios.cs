using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTallerBaseDatos.Clases
{
    internal class clsUsuarios
    {
        public clsUsuarios() { }

        
        public String nombre { get; set; }
       
        public String aPaterno { get; set; }
        public String aMaterno { get; set; }
        public String email { get; set; }
        public String usuario { get; set; }
        public String fechaNac { get; set; }
        public String fechaCreacion { get; set; }
        public String ultimoLogeo { get; set; }

    }
}

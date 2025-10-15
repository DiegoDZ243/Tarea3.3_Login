using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Utilities;
using ProyectoTallerBaseDatos.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTallerBaseDatos.Backend
{
    internal class clsDaoUsuarios
    {
        
        /// <summary>
        /// Obtiene los datos de la vista vwUsuarios que solo muestra 
        /// los datos no sensibles de los usuarios
        /// </summary>
        /// <returns>Lista de usuarios sin mostrar los datos sensibles</returns>
        /// <exception cref="Exception"></exception>
        public List<clsUsuarios> obtenerUsuarios()
        {
            MySqlConnection cn = new MySqlConnection(); 
            cn.ConnectionString = "server=localhost;database=appUsuarios;uid=root;pwd=whythough.210;";
            cn.Open();

            //

            string query = "SELECT * FROM vwUsuarios;";
            MySqlCommand cmd = new MySqlCommand(query, cn);

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                List<clsUsuarios> usuarios = new List<clsUsuarios>();

                while (reader.Read())
                {
                    clsUsuarios usuario = new clsUsuarios();
                    usuario.nombre = reader.GetString(0);
                    usuario.aPaterno = reader.GetString(1);
                    usuario.aMaterno = reader.GetString(2);
                    usuario.usuario = reader.GetString(3);
                    usuario.email = reader.GetString(4);
                    usuario.fechaNac = reader.GetString(5);
                    usuario.fechaCreacion = reader.GetString(6);
                    usuario.ultimoLogeo = reader.GetString(7);
                    usuarios.Add(usuario);
                }
                return usuarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al conectarse al servidor");
            }
            finally
            {
                cmd.Dispose();
                cn.Close();
                cn.Dispose();
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuario">Usuario ingresado</param>
        /// <param name="contrasena">Contraseña del usuario</param>
        /// <returns>"Verdadero" si las credenciales son validas, en caso contrario "Falso"</returns>
        /// <exception cref="Exception">Hay algún error al conectarse a la BD</exception>
        public bool validarInicioSesion(string usuario, string contrasena)
        {
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = "server=localhost;database=appUsuarios;uid=root;pwd=whythough.210;";
            cn.Open();

            string query = "SELECT usuario, password FROM usuarios where usuario=@usuario;";
            MySqlCommand cmd = new MySqlCommand(query, cn);
            try
            {
               
                cmd.Parameters.AddWithValue("@usuario", usuario);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (!reader.HasRows) return false;
                reader.Read();
                string user = reader.GetString(0);
                string pass = reader.GetString(1);
                return user == usuario && pass == contrasena;
            }
            catch
            {
                throw new Exception("ERROR. No fue posible iniciar sesión");
            }
            finally
            {
                cmd.Dispose();
                cn.Close();
                cn.Dispose();
            }
        }

        /// <summary>
        /// Función que inserta nuevos usuarios a la BD
        /// </summary>
        /// <param name="usuario">Datos del usuario que se registrará</param>
        /// <returns>"Verdadero" si se completa el registro; "Falso" en caso contrario</returns>
        public bool registrarUsuario(clsUsuariosRegistro usuario)
        {
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = "server=localhost;database=appUsuarios;uid=root;pwd=whythough.210;";
            cn.Open();
            string query = @"INSERT INTO usuarios
                (usuario,password,nombre,aPaterno,aMaterno,email,fechaNac) values
                (@usuario,@password,@nombre,@aPaterno,@aMaterno,@email,@fechaNac);";

            MySqlCommand cmd = new MySqlCommand(query, cn);
            try
            {

                // Asignar parámetros
                cmd.Parameters.AddWithValue("@nombre", usuario.nombre);
                cmd.Parameters.AddWithValue("password", usuario.password);
                cmd.Parameters.AddWithValue("@aPaterno", usuario.aPaterno);
                cmd.Parameters.AddWithValue("@aMaterno", usuario.aMaterno);
                cmd.Parameters.AddWithValue("@email", usuario.email);
                cmd.Parameters.AddWithValue("@usuario", usuario.usuario);
                cmd.Parameters.AddWithValue("@fechaNac", usuario.fechaNac);

                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex) {
                return false;
            }
            finally
            {
                cmd.Dispose();
                cn.Close();
                cn.Dispose();
            }
            return true;
        }


        /// <summary>
        /// Función que actualiza el último inicio de sesión para
        /// el usuario dado.
        /// </summary>
        /// <param name="user">Usuario</param>
        /// <exception cref="Exception">No se conectó a la BD</exception>
        public void actualizarFechaLogeo(string user)
        {
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = "server=localhost;database=appUsuarios;uid=root;pwd=whythough.210;";
            cn.Open();
            string query = "UPDATE usuarios SET ultimoLogeo=@fecha where usuario=@usuario;";
            MySqlCommand cmd = new MySqlCommand(query, cn);

            try
            {
                cmd.Parameters.AddWithValue("@usuario", user);
                cmd.Parameters.AddWithValue("@fecha", DateTime.Now);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR. Ocurrió un error inesperado al conectar con el servidor");
            }
            finally {
                cmd.Dispose();
                cn.Close();
                cn.Dispose();
            }
        }

    }
}

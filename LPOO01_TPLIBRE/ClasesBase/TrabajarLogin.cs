using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    /// <summary>
    /// Contiene métodos aplicados al Login de la APlicación.
    /// </summary>
    public class TrabajarLogin
    {
        /// <summary>
        /// Valida si un Usuario con los parámetros <paramref name="usuarioNombre"/> y <paramref name="password"/> se encuentra en la tabla Usuario.
        /// </summary>
        /// <param name="usuarioNombre">String que contiene el USUARIO_NOMBRE.</param>
        /// <param name="password">Stirng que contiene el USUARIO_PASSWORD.</param>
        /// <returns>Boolean que contiene el valor de la busqueda, TRUE si se ha encontrado y FALSE para el caso contrario.</returns>
        public static Boolean validarUsuario(String usuarioNombre, String password)
        {
            Boolean encontrado = false;
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Usu_NombreUsuario,Usu_Contraseña FROM Usuario WHERE Usu_NombreUsuario=@nombre AND Usu_Contraseña=@pass";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@nombre", usuarioNombre);
            cmd.Parameters.AddWithValue("@pass", password);

            cnn.Open();
            cmd.ExecuteNonQuery();

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                encontrado = true;
            }
            else
            {
                encontrado = false;
            }
            cnn.Close();

            return encontrado;
        }

        /// <summary>
        /// Obtiene el USUARIO_ROL de un Usuario en la tabla Usuario.
        /// </summary>
        /// <param name="usuarioNombre">String que contiene USUARIO_NOMBRE.</param>
        /// <param name="password">String que contiene USUARIO_PASSWORD.</param>
        /// <returns>String que contiene el valor de USUARIO_ROL_DESCRIPCIÓN.</returns>
        public static String obtenerRolUsuario(String usuarioNombre, String password)
        {
            int rolID = 0;
            String rolDescripcion = String.Empty;
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Usuario WHERE Usu_NombreUsuario=@nombre AND Usu_Contraseña=@pass";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@nombre", usuarioNombre);
            cmd.Parameters.AddWithValue("@pass", password);

            cnn.Open();
            cmd.ExecuteNonQuery();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                rolID = reader.GetInt32(6);
                switch (rolID)
                {
                    case 1: rolDescripcion = "ADMINISTRADOR";
                        break;
                    case 2: rolDescripcion = "USUARIO";
                        break;
                    default: rolDescripcion = string.Empty;
                        break;
                }
            }
            cnn.Close();

            return rolDescripcion;
        }

        /// <summary>
        /// Obtiene el Usuario logueado en la Apliación.
        /// </summary>
        /// <param name="usuarioNombre">String que contiene el USUARIO_NOMBREUSUARIO.</param>
        /// <returns>Objeto de tipo Usuario.</returns>
        public static Usuario obtnerUsuarioActual(String usuarioNombre)
        {
            Usuario usuario = new Usuario();
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Usuario WHERE Usu_NombreUsuario=@nombre";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@nombre", usuarioNombre);

            cnn.Open();
            cmd.ExecuteNonQuery();

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario.Usu_ID = Convert.ToInt32(dr["Usu_ID"].ToString());
                usuario.Usu_NombreUsuario = dr["Usu_NombreUsuario"].ToString();
                usuario.Usu_Nombre = dr["Usu_Nombre"].ToString();
                usuario.Usu_Apellido = dr["Usu_Apellido"].ToString();
                usuario.Usu_Email = dr["Usu_Email"].ToString();
            }
            cnn.Close();
            return usuario;
        }
    }
}

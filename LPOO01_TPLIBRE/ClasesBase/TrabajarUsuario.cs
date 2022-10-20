using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    /// <summary>
    /// Contiene métodos aplicados a la clase Usuario.
    /// </summary>
    public class TrabajarUsuario
    {
        /// <summary>
        /// Retorna una el contenido de la tabla Roles.
        /// </summary>
        /// <returns>Un DataTable con el contenido</returns>
        public static DataTable listarRoles()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM roles";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la consola.
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable.
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        /// <summary>
        /// Retorna contenido de la tabla Usuario. 
        /// </summary>
        /// <returns>Una lista de Usuario</returns>
        public static DataTable listarUsuarios()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "listarUsuarios_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            //Ejecuta la consola.
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable.
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        /// <summary>
        /// Retorna una lista de la tabla Usuario.
        /// </summary>
        /// <returns>Un DataTable con una lista de Usuario según el Rol</returns>
        public static DataTable listarUsuariosPorRol()
        {
            string rolUsuario = "USUARIO";
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "listarUsuariosRolUsuario_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@rol", rolUsuario);
            //Ejecuta la consola.
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable.
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        /// <summary>
        /// Busca el valor (<paramref name="nombreUsuario"/>) en la tabla Usuario.
        /// </summary>
        /// <param name="nombreUsuario">Cadena que contiene el Nombre del Usuario.</param>
        /// <returns>Un Boolean con el estado TRUE, si se ha encontrado y FALSE, si no se ha encontrado</returns>
        public static Boolean buscarNombreUsuario(String nombreUsuario)
        {

            Boolean encontrado = false;
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Usu_NombreUsuario FROM Usuario WHERE Usu_NombreUsuario=@nombre";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@nombre", nombreUsuario);

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
        /// Agrega un Usuario a la tabla Usuario.
        /// </summary>
        /// <param name="usuario">Objeto de tipo Usuario</param>
        public static void agregarUsuario(Usuario usuario)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Usuario(Usu_NombreUsuario,Usu_Contraseña,Usu_Apellido,Usu_Nombre,Usu_Email,Rol_ID) values(@usuario,@pass,@apellido,@nombre,@mail,@rol)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@usuario", usuario.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@pass", usuario.Usu_Contraseña);
            cmd.Parameters.AddWithValue("@apellido", usuario.Usu_Apellido);
            cmd.Parameters.AddWithValue("@nombre", usuario.Usu_Nombre);
            cmd.Parameters.AddWithValue("@mail", usuario.Usu_Email);
            cmd.Parameters.AddWithValue("@rol", usuario.Rol_ID);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /// <summary>
        /// Modifica un Usuario en la tabla Usuario.
        /// </summary>
        /// <param name="usuario">Objeto de tipo Usuario</param>
        public static void modificarUsuario(Usuario usuario)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Usuario SET Usu_NombreUsuario=@usuario,Usu_Contraseña=@pass,Usu_Apellido=@apellido,Usu_Nombre=@nombre,Usu_Email=@mail,Rol_ID=@rol WHERE Usu_ID=@id";
            //cmd.CommandText = "UPDATE Usuario SET  Rol_ID=@rol,usu_NombreUsuario=@nombre,usu_Contraseña=@pass,usu_ApellidoNombre=@ayn WHERE usu_NombreUsuario=@nombre";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id",usuario.Usu_ID);
            cmd.Parameters.AddWithValue("@usuario", usuario.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@pass", usuario.Usu_Contraseña);
            cmd.Parameters.AddWithValue("@apellido", usuario.Usu_Apellido);
            cmd.Parameters.AddWithValue("@nombre", usuario.Usu_Nombre);
            cmd.Parameters.AddWithValue("@mail", usuario.Usu_Email);
            cmd.Parameters.AddWithValue("@rol", usuario.Rol_ID);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /// <summary>
        /// Elimina un Usuario de la tabla Usuario.
        /// </summary>
        /// <param name="usuario">Objeto de tipo Usuario</param>
        public static void eliminarUsuario(Usuario usuario)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DELETE FROM Usuario WHERE Usu_NombreUsuario=@nombre";
            cmd.Parameters.AddWithValue("@nombre", usuario.Usu_NombreUsuario);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /// <summary>
        /// Cuenta la cantidad de Usuarios que tiene asignado el (<paramref name="rolID"/>), en la tabla Usuario.
        /// </summary>
        /// <param name="rolID">Entero que contiene el valor de ROL_ID</param>
        /// <returns>Entero con la cantidad encontrada</returns>
        public static int contarUsuariosPorRol(int rolID)
        {
            int cantidad = 0;
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "contarUsuariosRol_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            //Parámetro de entrada.
            cmd.Parameters.AddWithValue("@idRol",rolID );

            //Parámetro de Salida.
            cmd.Parameters.Add("@cantidadUsuarios", SqlDbType.Int);
            cmd.Parameters["@cantidadUsuarios"].Direction = ParameterDirection.Output;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            
            //Obtengo el valor del Parámetro de Salida.
            cantidad = (int)cmd.Parameters["@cantidadUsuarios"].Value;

            return cantidad;
        }

        /// <summary>
        /// Busca un Usuario en la tabla Usuario, a partir del patrón (<paramref name="sPattern"/>).
        /// </summary>
        /// <param name="sPattern">String que contiene el patrón a buscar</param>
        /// <returns>Boolean que contiene el valor de la busqueda, TRUE si ha sido encontrado, FALSE para el caso contrario</returns>
        public static Boolean buscarUsuarioBool(String sPattern)
        {
            Boolean encontrado;
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "buscarUsuario_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");
            //Ejecuta la consulta.
            SqlDataAdapter da = new SqlDataAdapter(cmd);

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
        /// Busca un Usuario según el patrón (<paramref name="sPattern"/>), en la tabla Usuario.
        /// </summary>
        /// <param name="sPattern">String que contiene el valor del pátron</param>
        /// <returns>Un DataTable con todos los Usuario que contengan (<paramref name="sPattern"/>), de la tabla Usuario</returns>
        public static DataTable buscarUsuario(String sPattern)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();
            
            cmd.CommandText = "buscarUsuario_sp";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    /// <summary>
    /// Contenedor de métodos de la clase Cliente.
    /// </summary>
    public class TrabajarCliente
    {
        /// <summary>
        /// Lista la tabla Cliente.
        /// </summary>
        /// <returns>DataTable que contiene el valor de la tabla Cliente.</returns>
        public static DataTable listarClientes()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listarClientes_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            //Ejecuta la consola.
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable.
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}

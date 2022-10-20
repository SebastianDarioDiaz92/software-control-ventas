using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    /// <summary>
    /// Contiene métodos aplicados a la clase Venta.
    /// </summary>
    public class TrabajarVenta
    {
        /// <summary>
        /// Lista la tabla Venta.
        /// </summary>
        /// <returns>Un DataTable con el contenido de la tabla Venta.</returns>
        public static DataTable listarVentas()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "listarVentas_sp";
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
        /// Agrega una Venta a la tabla Venta.
        /// </summary>
        /// <param name="venta">Objeto de tipo Venta.</param>
        public static void agregarVenta(Venta venta)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Venta(Venta_Fecha,Cliente_ID,Venta_Identificador,Usu_ID) values(@fecha,@idCliente,@identificador,@idUsuario)";
            cmd.CommandType = CommandType.Text;

            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@fecha", venta.Venta_Fecha);
            cmd.Parameters.AddWithValue("@idCliente", venta.Cliente_ID);
            cmd.Parameters.AddWithValue("@identificador", venta.Venta_Identificador);
            cmd.Parameters.AddWithValue("@idUsuario", venta.Usu_ID);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /// <summary>
        /// Busca una Venta por la Fecha, en la tabla Venta.
        /// </summary>
        /// <param name="ventaFecha">Objeto de tipo DateTime que contiene la Fecha.</param>
        /// <returns>Entero con el valor de ID_VENTA.</returns>
        public static int buscarVentaID(DateTime ventaFecha)
        {
            int idVenta;
            string id = string.Empty;
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "buscarVentaID_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            //Parámetro de entrada.
            cmd.Parameters.AddWithValue("@fecha", ventaFecha);
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                id = dr["Venta_ID"].ToString(); ;
            }
            cnn.Close();
            idVenta= Convert.ToInt32(id);
            return idVenta;
        }

        /// <summary>
        /// Obtiene el Identificador de la Venta del último registro de la tabla Venta.
        /// </summary>
        /// <returns>Entero con el valor del IDENTIFICADOR_VENTA, convertido a Entero.</returns>
        public static int obtenerUltimoIdentificador()
        {
            int identificador = 0;
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "obtenerUltimoRegistroVenta_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                identificador = Convert.ToInt32(dr["Venta_Identificador"].ToString());
            }
            else
            {
                identificador = 99;
            }
            cnn.Close();
            return identificador;
        }
        /*
        public static List<Carrito> listaItemsCarrito = new List<Carrito>();

        public static void capturarItemCarrito(Carrito carrito)
        {
            listaItemsCarrito.Add(carrito);
        }*/
    }
}

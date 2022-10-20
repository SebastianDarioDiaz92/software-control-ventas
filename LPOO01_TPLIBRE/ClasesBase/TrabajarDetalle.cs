using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    /// <summary>
    /// Contiene métodos de la clase Detalle.
    /// </summary>
    public class TrabajarDetalle
    {
        /// <summary>
        /// Agrega un Detalle a la Tabla Detalle.
        /// </summary>
        /// <param name="detalle">Objeto de tipo Detalle.</param>
        public static void agregarDetalle(Detalle detalle)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Detalle(Prod_ID,Prod_PrecioUnitario,Prod_Cantidad,Detalle_Total,Cliente_ID,Venta_Identificador) values(@prodID,@precio,@cantidad,@total,@idCliente,@identificador)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@prodID", detalle.Prod_ID);
            cmd.Parameters.AddWithValue("@precio", detalle.Prod_PrecioUnitario);
            cmd.Parameters.AddWithValue("@cantidad", detalle.Prod_Cantidad);
            cmd.Parameters.AddWithValue("@total", detalle.Detalle_Total);
            cmd.Parameters.AddWithValue("@idCliente", detalle.Cliente_ID);
            cmd.Parameters.AddWithValue("@identificador", detalle.Venta_Identificador);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /// <summary>
        /// Lista la tabla Detalle.
        /// </summary>
        /// <returns>DataTable que contiene los valores de la tabla Detalle.</returns>
        public static DataTable listarDetalle()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "listarItemsCarrito_sp";
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
        /// Lista la tabla Detalle, anexando propiedades de las tablas Venta, Cliente, Producto y Usuario.
        /// </summary>
        /// <returns>DataTable con el valor de la tabla Detalle y sus anexos.</returns>
        public static DataTable listarItemsDetalle()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "listarDetalleResumen_sp";
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
        /// Filtra los valores de la tabla Detalle que se encuentra entre las fechas 1 y 2 respectivamente <paramref name="fechaDesde"/> - <paramref name="fechaHasta"/>.
        /// </summary>
        /// <param name="fechaDesde">DateTime que contiene la fecha de Inicio para la busqueda.</param>
        /// <param name="fechaHasta">DataTime que contiene la fecha de Fin para la busqueda.</param>
        /// <returns></returns>
        public static DataTable filtrarEntreFechas(DateTime fechaDesde, DateTime fechaHasta)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "filtrarEntreFechas_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde);
            cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta);

            //Ejecuta la consola.
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable.
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        /// <summary>
        /// Filtra la tabla Detalle, según <paramref name="dniCliente"/>.
        /// </summary>
        /// <param name="dniCliente">String que contiene CLIENTE_DNI</param>
        /// <returns>DataTable que contiene el valor de la tabla Detalle filtrada.</returns>
        public static DataTable filtrarPorCliente(string dniCliente)
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "filtrarPorCliente_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dniCliente", dniCliente);

            //Ejecuta la consola.
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable.
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        /// <summary>
        /// Filtra la tabla Detalle, según <paramref name="categoria"/>.
        /// </summary>
        /// <param name="categoria">String que contiene PRODUCTO_CATEGORIA</param>
        /// <returns>DataTable que contiene el valor de la tabla Detalle filtrada.</returns>
        public static DataTable filtrarPorCategoria(string categoria)
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "filtrarPorCategoria_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@categoria", categoria);

            //Ejecuta la consola.
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable.
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        /// <summary>
        /// Filtra la tabla Detalle, según <paramref name="descripcion"/>.
        /// </summary>
        /// <param name="descripcion">String que contiene PRODUCTO_DESCRIPCION</param>
        /// <returns>DataTable que contiene el valor de la tabla Detalle filtrada.</returns>
        public static DataTable filtrarPorDescripcion(string descripcion)
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "filtrarPorDescripcion_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@descripcion", descripcion);

            //Ejecuta la consola.
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable.
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        /// <summary>
        /// Filtra la tabla Detalle, según <paramref name="identificador"/>
        /// </summary>
        /// <param name="identificador">String que contiene VENTA_IDENTIFICADOR</param>
        /// <returns>DataTable que contiene el valor de la tabla Detalle filtrada.</returns>
        public static DataTable filtrarPorIdentificador(string identificador)
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "filtrarPorIdentificador_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@identificador", identificador);

            //Ejecuta la consola.
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable.
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        /// <summary>
        /// Filtra la tabla Detalle, según <paramref name="nombreUsuario"/>
        /// </summary>
        /// <param name="nombreUsuario">String que contiene USUARIO_NOMREUSUARIO</param>
        /// <returns>DataTable que contiene el valor de la tabla Detalle filtrada.</returns>
        public static DataTable filtrarPorVendedor(string nombreUsuario)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "filtrarPorVendedor_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@vendedor", nombreUsuario);

            //Ejecuta la consola.
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable.
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}

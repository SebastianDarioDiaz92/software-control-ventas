using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    /// <summary>
    /// Contenedor de Métodos aplicados a la clase Carrito.
    /// </summary>
    public class TrabajarCarrito
    {
        /// <summary>
        /// Lista la tabla Carrito.
        /// </summary>
        /// <returns>DataTable que contiene los valores de la tabla Carrito.</returns>
        public static DataTable listarItemsCarrito()
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
        /// Agrega un Carrito(item) a la tabla Carrito.
        /// </summary>
        /// <param name="carrito">Objeto de tipo Carrito.</param>
        public static void agregarItemCarrito(Carrito carrito)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Carrito(Prod_ID,Prod_PrecioUnitario,Prod_Cantidad,Carrito_Total,Cliente_ID) values(@idProd,@precio,@cantidad,@total,@idCliente)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@idProd", carrito.Prod_ID);
            cmd.Parameters.AddWithValue("@precio", carrito.Prod_PrecioUnitario);
            cmd.Parameters.AddWithValue("@cantidad", carrito.Prod_Cantidad);
            cmd.Parameters.AddWithValue("@total", carrito.Carrito_Total);
            cmd.Parameters.AddWithValue("@idCliente", carrito.Cliente_ID);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /// <summary>
        /// Vacía la tabla Carrito.
        /// </summary>
        public static void vaciarTablaCarrito()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "TRUNCATE TABLE [Carrito]";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /// <summary>
        /// Modifica un Carrito(item) en la tabla Carrito.
        /// </summary>
        /// <param name="itemCarrito">Objeto de tipo Carrito.</param>
        public static void modificarItemCarrito(Carrito itemCarrito)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Carrito SET Prod_ID=@idProd,Prod_PrecioUnitario=@precio,Prod_Cantidad=@cantidad,Carrito_Total=@total WHERE Carrito_ID=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", itemCarrito.Carrito_ID);
            cmd.Parameters.AddWithValue("@idProd", itemCarrito.Prod_ID);
            cmd.Parameters.AddWithValue("@precio", itemCarrito.Prod_PrecioUnitario);
            cmd.Parameters.AddWithValue("@cantidad", itemCarrito.Prod_Cantidad);
            cmd.Parameters.AddWithValue("@total", itemCarrito.Carrito_Total);
           
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        
        }

        /*public static Carrito buscarItemCarrito(int prodID)
        {
            Carrito carrito = new Carrito();

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "buscarProdRepetidoCarrito_sp";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@idProd", prodID);
            //Ejecuta la consulta.
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                carrito.Prod_ID = Convert.ToInt32(dr["Prod_ID"].ToString());
                carrito.Prod_PrecioUnitario = Convert.ToInt32(dr["Prod_PrecioUnitario"].ToString());
                carrito.Prod_Cantidad = Convert.ToInt32(dr["Prod_Cantidad"].ToString());
                carrito.Carrito_Total = Convert.ToInt32(dr["Carrito_Total"].ToString());
            }
            cnn.Close();
            return carrito;
        }*/

        /// <summary>
        /// Busca un Carrito(item), en la tabla Carrito según <paramref name="idProducto"/> 
        /// </summary>
        /// <param name="idProducto">Entero que contiene el valor de PRODUCTO_ID.</param>
        /// <returns>Entero que contiene el valor de PRODUCTO_CANTIDAD</returns>
        public static int buscarItemProductoCarritoRetornaStock(int idProducto)
        {
            int cantidad = 0;
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "buscarProdRepetidoCarrito_sp";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@idProd", idProducto);
            //Ejecuta la consulta.
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cantidad = Convert.ToInt32(dr["Prod_Cantidad"].ToString());
            }
            cnn.Close();
            return cantidad;
        }

        /// <summary>
        /// Busca un Carrito(item) en la tabla Carrito, según <paramref name="idProducto"/>
        /// </summary>
        /// <param name="idProducto">Entero que contiene PRODUCTO_ID.</param>
        /// <returns>Entero que contiene CARRITO_ID</returns>
        public static int buscaritemCarrito(int idProducto)
        {
            int idCarrito = 0;
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "buscarProdRepetidoCarrito_sp";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@idProd", idProducto);
            //Ejecuta la consulta.
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                idCarrito = Convert.ToInt32(dr["Carrito_ID"].ToString());
            }
            cnn.Close();
            return idCarrito;
        }

        /// <summary>
        /// Obtiene el Total de un Carrito(item) de la tabla Carrito.
        /// </summary>
        /// <param name="idProducto">Entero que contiene PRODUCTO_ID.</param>
        /// <returns>Decimal que contiene CARRITO_TOTAL.</returns>
        public static decimal obtenerTotalItemCarrito(int idProducto)
        {
            decimal total = 0;
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "buscarProdRepetidoCarrito_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@idProd", idProducto);
            //Ejecuta la consulta.
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                total = Convert.ToDecimal(dr["Carrito_Total"].ToString());
            }
            cnn.Close();

            return total;
        }

        /// <summary>
        /// Busca un Cliente en la tabla Carrito, según <paramref name="idCliente"/>.
        /// </summary>
        /// <param name="idCliente">Entero que contiene CLIENTE_ID.</param>
        /// <returns>Boolean que contiene el valor de la busqueda, TRUE si se ha encontrado, FALSE para el caso contrario.</returns>
        public static Boolean buscarClienteCarrito(int idCliente)
        {
            Boolean clienteEncontrado = false;
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT Cliente_ID FROM Carrito WHERE Cliente_ID=@idCliente";
            cmd.Parameters.AddWithValue("@idCliente", idCliente);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                clienteEncontrado = true;
            }
            cnn.Close();
            return clienteEncontrado;
        }

        /// <summary>
        /// Elimina un Carrito(item) de la tabla Carrito, según <paramref name="idCliente"/>.
        /// </summary>
        /// <param name="idCliente">Entero que contiene CLIENTE_IDC</param>
        public static void eliminarItemsClienteRepetido(int idCliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Producto WHERE Cliente_ID=@idCliente";
            cmd.Parameters.AddWithValue("@idCliente", idCliente);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}

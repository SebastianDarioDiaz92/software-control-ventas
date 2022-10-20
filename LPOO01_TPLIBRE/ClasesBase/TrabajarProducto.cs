using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    /// <summary>
    /// Contiene métodos aplicados a la clase Producto.
    /// </summary>
    public class TrabajarProducto
    {
        /// <summary>
        /// Lista Productos de la tabla Producto.
        /// </summary>
        /// <returns>Un DataTable con el contenido de la tabla Producto.</returns>
        public static DataTable listarProductos()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();
            
            cmd.CommandText = "listarProductos_sp";
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
        /// Lista Productos de la tabla Producto, utilizado cuando se inicia el formulario. 
        /// Ya que después la tabla es modificada y se necesita los valores iniciales en el sistema.
        /// </summary>
        /// <returns>DataTable con el contenido de la tabla Producto.</returns>
        public static DataTable listarProductosInicial()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "listarProductosInicial";
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
        /// Agrega un Producto a la tabla Producto.
        /// </summary>
        /// <param name="producto">Objeto de tipo Producto.</param>
        public static void agregarProducto(Producto producto)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Producto(Prod_Categoria,Prod_Descripcion,Prod_Stock,Prod_Precio) values(@categoria,@descripcion,@stock,@precio)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@categoria", producto.Prod_Categoria);
            cmd.Parameters.AddWithValue("@descripcion", producto.Prod_Descripcion);
            cmd.Parameters.AddWithValue("@stock", producto.Prod_Stock);
            cmd.Parameters.AddWithValue("@precio", producto.Prod_Precio);
            
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /// <summary>
        /// Elimina un Producto de la tabla Producto.
        /// </summary>
        /// <param name="producto">Objeto de tipo Producto.</param>
        public static void eliminarProducto(Producto producto)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DELETE FROM Producto WHERE prod_ID=@idProd";
            cmd.Parameters.AddWithValue("@idProd", producto.Prod_ID);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /// <summary>
        /// Modifica un Producto en la tabla Producto.
        /// </summary>
        /// <param name="producto">Objeto de tipo Producto.</param>
        public static void modificarProducto(Producto producto)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Producto SET Prod_Categoria=@categoria,Prod_Descripcion=@descripcion,Prod_Stock=@stock,Prod_Precio=@precio WHERE prod_ID=@idProd";
            
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@idProd", producto.Prod_ID);
            cmd.Parameters.AddWithValue("@categoria", producto.Prod_Categoria);
            cmd.Parameters.AddWithValue("@descripcion", producto.Prod_Descripcion);
            cmd.Parameters.AddWithValue("@stock", producto.Prod_Stock);
            cmd.Parameters.AddWithValue("@precio", producto.Prod_Precio);
           
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        
        /// <summary>
        /// Modifica la columna PRODUCTO_STOCK de un Producto <paramref name="producto"/>.
        /// </summary>
        /// <param name="producto">Objeto de tipo Producto.</param>
        public static void modificarStockProducto(Producto producto)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Producto SET Prod_Stock=@stock WHERE prod_ID=@idProd";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@idProd", producto.Prod_ID);
            cmd.Parameters.AddWithValue("@stock", producto.Prod_Stock);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /// <summary>
        /// Modifica la columna PRODUCTO_STOCK de un Producto, según su <paramref name="idProd"/>.
        /// </summary>
        /// <param name="idProd">Entero contenedor del valor PRODUCTO_ID.</param>
        /// <param name="stockProd">Entero contenedor del valor PRODUCTO_STOCK.</param>
        public static void modificarStockProductoByID(int idProd, int stockProd)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Producto SET Prod_Stock=@stock WHERE Prod_ID=@idProd";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@idProd", idProd);
            cmd.Parameters.AddWithValue("@stock", stockProd);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /// <summary>
        /// Obtiene el valor de la columna PRODUCTO_STOCK de la tabla Producto, según <paramref name="producto"/>. 
        /// </summary>
        /// <param name="producto">Objeto de tipo Producto.</param>
        /// <returns>Entero con el valor de PRODUCTO_STOCK.</returns>
        public static int obtnerStockProducto(Producto producto)
        {
            int stock = 0;
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Prod_Stock FROM Producto WHERE Prod_ID=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", producto.Prod_ID);

            cnn.Open();
            cmd.ExecuteNonQuery();

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                stock = Convert.ToInt32(dr["Prod_Stock"].ToString());
            }
            cnn.Close();
            return stock;
        }

        /// <summary>
        /// Busca un Producto de la tabla Producto, según los valores <paramref name="categoriaProducto"/> y <paramref name="descripcionProducto"/>.
        /// </summary>
        /// <param name="categoriaProducto">String que contiene PRODUCTO_CATEGORIA.</param>
        /// <param name="descripcionProducto">String que contiene PRODUCTO_DESCRIPCION.</param>
        /// <returns></returns>
        public static Boolean buscarCategoriaDescripcionProducto(String categoriaProducto, String descripcionProducto)
        {

            Boolean encontrado = false;
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Prod_Descripcion,Prod_Categoria FROM Producto WHERE Prod_Descripcion=@descripcion AND Prod_Categoria=@categoria";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@descripcion", descripcionProducto);
            cmd.Parameters.AddWithValue("@categoria", categoriaProducto);
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

        /*
        public static Boolean buscarProductoBool(String sPattern)
        {
            Boolean encontrado;
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Prod_Categoria,Prod_Descripcion FROM Producto WHERE Usu_NombreUsuario=@nombre";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.CommandText = "buscarProducto_sp";
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
        }*/

        /// <summary>
        /// Busca un Producto de la tabla Producto, según <paramref name="sPattern"/>
        /// </summary>
        /// <param name="sPattern">String que contiene el patrón.</param>
        /// <returns>DataTable que contiene los Productos encontrados.</returns>
        public static DataTable buscarProducto(String sPattern)
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.DB_indumentariaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "buscarProducto_sp";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");
            //Ejecuta la consulta.
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable.
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        
    }
}

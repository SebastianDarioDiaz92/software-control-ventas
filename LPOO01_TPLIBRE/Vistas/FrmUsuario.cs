using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
using System.Data.SqlClient;

namespace Vistas
{
    public partial class FrmUsuario : Form
    {
        /// <summary>
        /// Constructor del Formulario Usuario, que recibe por parámetros una Estructura <paramref name="usus"/> desde el Formulario Login.
        /// </summary>
        /// <param name="usu">Estructura.</param>
        public FrmUsuario(FrmLogin.NombreUsuarioActual usu)
        {
            Global.usuarioActual = usu.nombreUsuarioActual;
            InitializeComponent();
        }

        /// <summary>
        /// Constructor del Formulario Usuario.
        /// </summary>
        public FrmUsuario()
        {
            InitializeComponent();
        }

        public static Boolean permitirSoloNumeros(KeyPressEventArgs kpea)
        {
            if (Char.IsNumber(kpea.KeyChar))
            {
                kpea.Handled = false;
                return true;
            }
            else if (Char.IsControl(kpea.KeyChar))
            {
                kpea.Handled = false;
                return true;
            }
            else
            {
                kpea.Handled = true;
                return false;
            }
        }

        public static Boolean permitirSoloCadena(KeyPressEventArgs e){
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if(char.IsSeparator(e.KeyChar)){
                e.Handled = false;
                return true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                return false;
            }
        }

        public static Boolean controlarVacios(TextBox tb)
        {
            if (tb.Text.Equals(String.Empty))
            {
                tb.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Oculta Label, TextBox, ComboBox, DataGridView y Button que no son necesarios.
        /// </summary>
        private void ocultarPropiedadesProducto()
        {
            try
            {
                this.lblVendedor.Visible = false;
                this.lblProdCategoria.Visible = false;
                this.lblProdDescripcion.Visible = false;
                this.lblProdStock.Visible = false;
                this.lblProdPrecio.Visible = false;
                this.lblClienteDNI.Visible = false;
                this.lblClienteNombre.Visible = false;
                this.lblFechaActual.Visible = false;
                this.txtProdCategoria.Visible = false;
                this.txtProdDescripcion.Visible = false;
                this.txtProdStock.Visible = false;
                this.txtProdPrecio.Visible = false;
                this.txtProdBuscar.Visible = false;
                this.txtClienteNombre.Visible = false;
                this.txtFechaActual.Visible = false;
                this.grvProductos.Visible = false;
                this.grvDetalles.Visible = false;
                this.btnProdAgregar.Visible = false;
                this.btnProdLimpiar.Visible = false;
                this.btnProdModificar.Visible = false;
                this.btnProdEliminar.Visible = false;
                this.btnProdBuscar.Visible = false;
                this.btnConfirmarVenta.Visible = false;
                this.cmbProdStock.Visible = false;
                this.cmbClientes.Visible = false;
                this.cmbProdDescripcionDetalle.Visible = false;
                this.btnRecargar.Visible = false;
                this.btnCancelarCompra.Visible = false;
                this.btnFiltrarVendedor.Visible = false;
                this.cmbVendedor.Visible = false;
                this.txtVentaIdentificador.Visible = false;
                this.cmbVentaIdentificador.Visible = false;
                this.cmbProdCategoria.Visible = false;
                this.btnConfirmarVenta.Visible = false;
                this.btnAñadirCarrito.Visible = false;
                this.dtpFechaDesde.Visible = false;
                this.dtpFechaHasta.Visible = false;
                this.btnFiltrarEntreFechas.Visible = false;
                this.btnFiltrarPorCliente.Visible = false;
                this.btnFiltrarCategoria.Visible = false;
                this.txtProdDescripcionDetalle.Visible = false;
                this.btnFiltrarPorDescripcion.Visible = false;
                this.btnFiltrarVenta.Visible = false;
                this.ptbInfoUsuario.Visible = false;
                this.btnRecargarDetalles.Visible = false;
                /*this.grvProductos.Location = new Point(this.grvProductos.Location.X, 263);
                this.grvProductos.Location = new Point(this.grvProductos.Location.Y, 216);*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Visibiliza Label, TextBox, ComboBox, DataGridView y Button que son necesarios.
        /// </summary>
        private void mostrarCamposProducto()
        {
            try
            {
                this.lblProdCategoria.Visible = true;
                this.lblProdDescripcion.Visible = true;
                this.lblProdStock.Visible = true;
                this.lblProdPrecio.Visible = true;
                this.txtProdCategoria.Visible = true;
                this.txtProdDescripcion.Visible = true;
                this.txtProdStock.Visible = true;
                this.txtProdPrecio.Visible = true;
                this.txtProdBuscar.Visible = true;
                this.grvProductos.Visible = true;
                this.grvProductos.Size = new Size(605, 120);
                this.btnProdAgregar.Visible = true;
                this.btnProdLimpiar.Visible = true;
                this.btnProdModificar.Visible = true;
                this.btnProdEliminar.Visible = true;
                this.btnProdBuscar.Visible = true;
                this.btnRecargar.Visible = true;
                this.grvProductos.Location = new Point(this.grvProductos.Location.X, 263);
                this.grvProductos.Location = new Point(this.grvProductos.Location.Y, 270);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Visibiliza Label, TextBox, ComboBox, DataGridView y Button que son necesarios.
        /// </summary>
        private void mostrarCamposVenta()
        {
            try
            {
                this.lblProdCategoria.Visible = true;
                this.lblProdDescripcion.Visible = true;
                this.lblProdStock.Visible = true;
                this.lblProdPrecio.Visible = true;
                this.lblClienteDNI.Visible = true;
                this.lblClienteNombre.Visible = true;
                this.txtProdBuscar.Visible = true;
                this.txtProdCategoria.Visible = true;
                this.txtProdDescripcion.Visible = true;
                this.cmbProdStock.Visible = true;
                this.txtProdPrecio.Visible = true;
                this.txtProdBuscar.Visible = true;
                this.txtClienteNombre.Visible = true;
                this.grvProductos.Visible = true;
                this.grvProductos.Size = new Size(605, 120);
                this.cmbClientes.Visible = true;
                this.btnProdBuscar.Visible = true;
                this.btnCancelarCompra.Visible = true;
                this.btnCancelarCompra.Enabled = false;
                this.btnAñadirCarrito.Visible = true;
                this.btnAñadirCarrito.Enabled = false;
                this.btnConfirmarVenta.Visible = true;
                this.btnConfirmarVenta.Enabled = false;
                this.btnRecargar.Visible = true;
                this.grvProductos.Location = new Point(this.grvProductos.Location.X, 263);
                this.grvProductos.Location = new Point(this.grvProductos.Location.Y, 340);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Visibiliza Label, TextBox, ComboBox, DataGridView y Button que son necesarios.
        /// </summary>
        private void mostrarCamposDetalle()
        {
            try
            {
                this.dtpFechaDesde.Visible = true;
                this.dtpFechaHasta.Visible = true;
                this.lblClienteDNI.Visible = true;
                this.lblClienteNombre.Visible = true;
                this.txtClienteNombre.Visible = true;
                this.lblProdCategoria.Visible = true;
                this.cmbClientes.Visible = true;
                this.btnFiltrarEntreFechas.Visible = true;
                this.btnFiltrarPorCliente.Visible = true;
                this.grvProductos.Visible = false;
                this.grvDetalles.Visible = true;
                this.txtClienteNombre.ReadOnly = true;
                this.cmbProdCategoria.Visible = true;
                this.cmbProdDescripcionDetalle.Visible = true;
                this.btnFiltrarCategoria.Visible = true;
                this.btnFiltrarPorDescripcion.Visible = true;
                this.txtProdDescripcionDetalle.Visible = true;
                this.cmbVentaIdentificador.Visible = true;
                this.txtVentaIdentificador.Visible = true;
                this.btnFiltrarVenta.Visible = true;
                this.lblVendedor.Visible = true;
                this.cmbVendedor.Visible = true;
                this.btnFiltrarVendedor.Visible = true;
                this.btnRecargarDetalles.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Bloquea edición de Label, TextBox, ComboBox, DataGridView y Button específicos.
        /// </summary>
        private void asignarSoloLecturaCamposVentas()
        {
            try
            {
                txtProdCategoria.ReadOnly = true;
                txtProdDescripcion.ReadOnly = true;
                txtProdStock.ReadOnly = true;
                txtProdPrecio.ReadOnly = true;
                txtClienteNombre.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVentas_Leave(object sender, EventArgs e)
        {
            btnVentas.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            pnlNavUsuario.Visible = true;
            pnlNavUsuario.Height = btnProductos.Height;
            pnlNavUsuario.Top = btnProductos.Top;
            pnlNavUsuario.Left = btnProductos.Left;
            btnProductos.BackColor = Color.FromArgb(46, 51, 73);
            btnAñadirCarrito.Enabled = false;
            ocultarPropiedadesProducto();
            mostrarCamposProducto();       
        }

        private void btnProductos_Leave(object sender, EventArgs e)
        {
            btnProductos.BackColor = Color.FromArgb(24, 30, 54);
        }

        /// <summary>
        /// Carga el DataGridView Detalles con valores de la tabla Detalle.
        /// </summary>
        private void cargarDetalles()
        {
            try
            {
                grvDetalles.DataSource = TrabajarDetalle.listarItemsDetalle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDetalles_Click(object sender, EventArgs e)
        {
            btnAñadirCarrito.Enabled = false;
            pnlNavUsuario.Visible = true;
            pnlNavUsuario.Height = btnDetalles.Height;
            pnlNavUsuario.Top = btnDetalles.Top;
            pnlNavUsuario.Left = btnDetalles.Left;
            btnDetalles.BackColor = Color.FromArgb(46, 51, 73);

            ocultarPropiedadesProducto();
            cargarDetalles();
            //grvDetalles.DataSource = TrabajarDetalle.listarItemsDetalle();
            mostrarCamposDetalle();
            //cargarProductosCMBCategoria();
            cargarProductosCMBCate();
            cargarProductosCMBDescripcion();
            cargarClientesCMB();
            cargarVentaIdentificadorCMB();
            cargarVendedorCMB();
        }

        private void btnDetalles_Leave(object sender, EventArgs e)
        {
            btnDetalles.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Desea salir de la Aplicación?", "SALIR DE LA APLICACIÓN", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion.Equals(DialogResult.OK))
                {
                    Application.Exit();
                    //Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Carga Productos de la tabla Producto en el DataGridView de Producto.
        /// </summary>
        private void cargarProductos()
        {
            try
            {
                grvProductos.DataSource = TrabajarProducto.listarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// DataTable que contiene los valores de la tabla Producto al inciar el Sistema.
        /// </summary>
        DataTable dataTableProductosInicial = new DataTable();

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            ocultarPropiedadesProducto();
            Usuario usuario = obtenerUsuarioActual();
            cargarProductos();
            dataTableProductosInicial = TrabajarProducto.listarProductosInicial();
        }

        private void btnProdLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                txtProdDescripcion.Clear();
                txtProdCategoria.Clear();
                txtProdStock.Clear();
                txtProdPrecio.Clear();
                txtProdCategoria.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnProdAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = new Producto();
                producto.Prod_Categoria = txtProdCategoria.Text;
                producto.Prod_Descripcion = txtProdDescripcion.Text;
                producto.Prod_Stock = Convert.ToInt32(txtProdStock.Text);
                producto.Prod_Precio = Convert.ToDecimal(txtProdPrecio.Text);
                if (TrabajarProducto.buscarCategoriaDescripcionProducto(txtProdCategoria.Text,txtProdDescripcion.Text))
                {
                    MessageBox.Show("El producto ya se ecuentra registrado!");
                }
                else
                {
                    TrabajarProducto.agregarProducto(producto);
                    cargarProductos();  
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Asigna los valores de las etiquetas a un Producto nuevo.
        /// </summary>
        /// <returns>Objeto de tipo Producto.</returns>
        private Producto asignarProducto()
        {          
            Producto producto = new Producto();
            producto.Prod_ID = Convert.ToInt32(txtProdID.Text);
            producto.Prod_Categoria = txtProdCategoria.Text;
            producto.Prod_Descripcion = txtProdDescripcion.Text;
            producto.Prod_Stock = Convert.ToInt32(txtProdStock.Text);
            producto.Prod_Precio = Convert.ToDecimal(txtProdPrecio.Text);
            return producto;
        }

        private void btnProdModificar_Click(object sender, EventArgs e)
        {
            try
            {
                TrabajarProducto.modificarProducto(asignarProducto());
                cargarProductos();
                //retomarStock();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void modificarBordeBoton(Button buttom)
        {
            if(buttom.Focus()){
                buttom.FlatAppearance.BorderColor = Color.FromArgb(75, 180, 195);
                buttom.FlatAppearance.BorderSize = 2;
            }
        }

        private void grvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAñadirCarrito.Enabled = true;
            btnAñadirCarrito.Focus();
            modificarBordeBoton(btnAñadirCarrito);
            btnConfirmarVenta.FlatAppearance.BorderColor = Color.FromArgb(24, 30, 54);
            btnConfirmarVenta.FlatAppearance.BorderSize = 2;
            txtProdID.Text = grvProductos.CurrentRow.Cells["ID"].Value.ToString();
            obtenerCantidadActual();       
        }

        private void grvProductos_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (grvProductos.CurrentRow != null)
                {
                    txtProdID.Text = grvProductos.CurrentRow.Cells["ID"].Value.ToString();
                    txtProdCategoria.Text = grvProductos.CurrentRow.Cells["Categoria"].Value.ToString();
                    cmbProdCategoria.Text = grvProductos.CurrentRow.Cells["Categoria"].Value.ToString();
                    txtProdDescripcion.Text = grvProductos.CurrentRow.Cells["Descripción"].Value.ToString();
                    txtProdStock.Text = grvProductos.CurrentRow.Cells["Stock"].Value.ToString();
                    cmbProdStock.Text = grvProductos.CurrentRow.Cells["Stock"].Value.ToString();
                    txtProdPrecio.Text = grvProductos.CurrentRow.Cells["Precio"].Value.ToString();
                    Global.banderaGlobal = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnProdEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                TrabajarProducto.eliminarProducto(asignarProducto());
                cargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Carga valores de la tabla Cliente en el ComboBox de Cliente.
        /// </summary>
        private void cargarClientesCMB()
        {
            try
            {
                cmbClientes.DisplayMember = "DNI";
                cmbClientes.ValueMember = "ID";
                cmbClientes.DataSource = TrabajarCliente.listarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Data Source=. \\SQLEXPRESS;AttachDbFilename='C:\\Users\\sebas\\OneDrive\\Documentos\\Visual Studio 2010\\Projects\\LPOO01_TPLIBRE\\DataBase\\DB_indumentaria.mdf';Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "buscarCliente_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", cmbClientes.Text);
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtClienteNombre.Text = dr["Cliente_Apellido"].ToString() + " "+dr["Cliente_Nombre"].ToString();
                txtClienteID.Text = dr["Cliente_ID"].ToString();
            }
            cnn.Close();
        }
        
        private void btnVentas_Click(object sender, EventArgs e)
        {
            btnRecargar.Enabled = false;
            dataTableProductosInicial = TrabajarProducto.listarProductosInicial();
            //retomarStock();
            TrabajarCarrito.vaciarTablaCarrito();

            pnlNavUsuario.Visible = true;
            pnlNavUsuario.Height = btnVentas.Height;
            pnlNavUsuario.Top = btnVentas.Top;
            pnlNavUsuario.Left = btnVentas.Left;
            btnVentas.BackColor = Color.FromArgb(46, 51, 73);
            //cmbProdCategoria.Items.Clear();

            ocultarPropiedadesProducto();
            mostrarCamposVenta();
            asignarSoloLecturaCamposVentas();
            cargarClientesCMB();
            obtenerCantidadActual();

            lblFechaActual.Visible = true;
            txtFechaActual.Visible = true;          
        }
        /*
        private void cargarProductosCMBCategoria()
        {
            try
            {
                SqlConnection cnn = new SqlConnection("Data Source=. \\SQLEXPRESS;AttachDbFilename='C:\\Users\\sebas\\OneDrive\\Documentos\\Visual Studio 2010\\Projects\\LPOO01_TPLIBRE\\DataBase\\DB_indumentaria.mdf';Integrated Security=True;Connect Timeout=30;User Instance=True");
                SqlCommand cmd = new SqlCommand("SELECT * FROM Producto", cnn);
                cnn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbProdCategoria.Items.Add(dr.GetString(1));
                    //cmbProdDescripcion.Items.Add(dr.GetString(2));
                }
                cnn.Close();
                }
               
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }      
        }*/

        /// <summary>
        /// Carga valores de la tabla Productos en el ComboBox de Categorías.
        /// </summary>
        private void cargarProductosCMBCate()
        {
            try
            {
                cmbProdCategoria.DisplayMember = "Categoria";
                cmbProdCategoria.ValueMember = "ID";
                cmbProdCategoria.DataSource = TrabajarProducto.listarProductos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbProdCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
           SqlConnection cnn = new SqlConnection("Data Source=. \\SQLEXPRESS;AttachDbFilename='C:\\Users\\sebas\\OneDrive\\Documentos\\Visual Studio 2010\\Projects\\LPOO01_TPLIBRE\\DataBase\\DB_indumentaria.mdf';Integrated Security=True;Connect Timeout=30;User Instance=True");
           SqlCommand cmd = new SqlCommand("SELECT * FROM Producto WHERE Prod_Categoria='"+cmbProdCategoria.Text+"' ", cnn);
           cnn.Open();
           SqlDataReader dr = cmd.ExecuteReader();
           if(dr.Read()){
               txtProdID.Text = dr["Prod_ID"].ToString();
               txtProdDescripcion.Text = dr["Prod_Descripcion"].ToString();
               txtProdStock.Text = dr["Prod_Stock"].ToString();
               txtProdPrecio.Text = dr["Prod_Precio"].ToString();
           }
           cnn.Close();
        }

        private void btnProdBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProdBuscar.Text != "")
                {
                    grvProductos.DataSource = TrabajarProducto.buscarProducto(txtProdBuscar.Text);
                    this.cmbProdCategoria.Visible = false;
                    this.txtProdCategoria.Visible = true;
                    txtProdBuscar.Clear();
                    txtProdBuscar.Focus();
                }
                else
                {
                    MessageBox.Show("No se encontraron coincidencias...");
                    txtProdBuscar.Clear();
                    txtProdBuscar.Focus();
                    cargarProductos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Clase que contiene variables Globales en el Formulario.
        /// </summary>
        public static class Global
        {
            public static Boolean banderaGlobal = false;
            public static int enteroGlobal = 0;
            public static string usuarioActual = string.Empty;
        }

        /// <summary>
        /// Obtiene stock desde el DataGridView de Productos.
        /// </summary>
        /// <returns>Entero con el valor de PRODUCTOS_STOCK</returns>
        private int obtenerProdStock()
        {
            int cantidad = 0;
            cantidad = Convert.ToInt32(grvProductos.CurrentRow.Cells["Stock"].Value.ToString());

            return cantidad;
        }

        /// <summary>
        /// Obtiene el precio de un Productos desde la fila actual del DataGridView de Productos.
        /// </summary>
        /// <returns>Decimal que contiene PRODUCTO_PRECIO.</returns>
        private decimal obtenerProdPrecioUnitario()
        {
            decimal precioUnitario = Convert.ToDecimal(grvProductos.CurrentRow.Cells["Precio"].Value.ToString());
            return precioUnitario;
        }

        /// <summary>
        /// Carga valores de la tabla Carrito a el DataGridView de Carrito.
        /// </summary>
        private void cargarCarrito()
        {
            try
            {
                grvCarrito.DataSource = TrabajarCarrito.listarItemsCarrito();
                //obtenerCantidadActual();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Obtiene cantidad actual de Producto y lo carga en el ComboBox Stock.
        /// </summary>
        private void obtenerCantidadActual()
        {
            int stockProd = obtenerProdStock();
            cmbProdStock.Items.Clear();

            if (cmbProdStock.Items.Count <= 0)
            {
                for (int j = 1; j < stockProd + 1; j++)
                {
                    cmbProdStock.Items.Add(j);
                }
            }
        }

        Detalle detalle = new Detalle();

        private void btnAñadirCarrito_Click(object sender, EventArgs e)
        {
            btnSalir.Enabled = false;
            cmbProdStock.Items.Clear();
            obtenerCantidadActual();
            grvCarrito.Visible = true;

            Carrito carrito = new Carrito();
            carrito.Prod_ID = (Convert.ToInt32(txtProdID.Text)); 
            carrito.Prod_PrecioUnitario = obtenerProdPrecioUnitario();
            carrito.Prod_Cantidad = Convert.ToInt32(txtProdStock.Text);
            carrito.Carrito_Total = carrito.Prod_PrecioUnitario * carrito.Prod_Cantidad;
            carrito.Cliente_ID = Convert.ToInt32(txtClienteID.Text);
            
            /*Boolean clienteRepetido = TrabajarCarrito.buscarClienteCarrito(Convert.ToInt32(txtClienteID.Text));
            if(clienteRepetido){
                TrabajarCarrito.eliminarItemsClienteRepetido(Convert.ToInt32(txtClienteID.Text));
            }*/

            Boolean productoRepetido = controlarProductoRepetido(carrito.Prod_ID);
            if (productoRepetido)
            {
                int stockItemCarrito = TrabajarCarrito.buscarItemProductoCarritoRetornaStock(Convert.ToInt32(txtProdID.Text));
                carrito.Prod_Cantidad = stockItemCarrito + Convert.ToInt32(txtProdStock.Text);  
                carrito.Carrito_Total = carrito.Prod_Cantidad * obtenerProdPrecioUnitario();
                carrito.Carrito_ID = TrabajarCarrito.buscaritemCarrito(Convert.ToInt32(txtProdID.Text));
                TrabajarCarrito.modificarItemCarrito(carrito);
                //TrabajarVenta.capturarItemCarrito(carrito);
                
                Producto producto = asignarProducto();
                int stockProd = TrabajarProducto.obtnerStockProducto(producto);
                producto.Prod_Stock = stockProd - Convert.ToInt32(txtProdStock.Text);
                TrabajarProducto.modificarStockProducto(producto);
                cmbProdStock.Items.Clear();
                obtenerCantidadActual();
                cargarProductos();
                cargarCarrito();

                btnConfirmarVenta.Enabled = true;
                btnConfirmarVenta.Focus();
                modificarBordeBoton(btnConfirmarVenta);
                btnCancelarCompra.Visible = true;
                btnCancelarCompra.Enabled = true;
                btnCancelarCompra.Focus();
                modificarBordeBoton(btnCancelarCompra);
                btnProductos.Enabled = false;
                btnDetalles.Enabled = false;
            }
            else
            {
                carrito.Carrito_Total = Convert.ToInt32(txtProdStock.Text) * obtenerProdPrecioUnitario();
                TrabajarCarrito.agregarItemCarrito(carrito);
                
                //TrabajarVenta.capturarItemCarrito(carrito);

                Producto producto = asignarProducto(); 
                int stockProd = TrabajarProducto.obtnerStockProducto(producto);
                int stockItemCarrito = TrabajarCarrito.buscarItemProductoCarritoRetornaStock(Convert.ToInt32(txtProdID.Text));
                
                producto.Prod_Stock = stockProd - stockItemCarrito ;
                TrabajarProducto.modificarStockProducto(producto);
                cmbProdStock.Items.Clear();
                obtenerCantidadActual();
                cargarProductos();
                cargarCarrito();

                btnConfirmarVenta.Enabled = true;
                btnConfirmarVenta.Focus();
                modificarBordeBoton(btnConfirmarVenta);
                btnCancelarCompra.Visible = true;
                btnCancelarCompra.Enabled = true;
                btnCancelarCompra.Focus();
                modificarBordeBoton(btnCancelarCompra);
                btnProductos.Enabled = false;
                btnDetalles.Enabled = false;
            }
            cmbProdStock.Items.Clear();
            obtenerCantidadActual();                
        }

        private Boolean controlarProductoRepetido(int idProd)
        {
            Boolean repetido = false;
            int cantidad = TrabajarCarrito.buscarItemProductoCarritoRetornaStock(idProd);
            if(cantidad>0){
                repetido = true;
            }
            return repetido;
        }

        /// <summary>
        /// Carga valores de la tabla Producto a el ComboBox Descripcion.
        /// </summary>
        private void cargarProductosCMBDescripcion()
        {
            try
            {
                cmbProdDescripcionDetalle.DisplayMember = "Descripción";
                cmbProdDescripcionDetalle.ValueMember = "ID";
                cmbProdDescripcionDetalle.DataSource = TrabajarProducto.listarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbProdStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            int stockProd = cmbProdStock.SelectedIndex+1;
            decimal total = 0;

            total = stockProd * obtenerProdPrecioUnitario();
            txtProdPrecio.Text = total.ToString();
            txtProdStock.Text = stockProd.ToString();

            btnAñadirCarrito.Enabled = true;
            btnAñadirCarrito.Focus();
            modificarBordeBoton(btnAñadirCarrito);              
        }

        private void cmbProdStock_SelectedValueChanged(object sender, EventArgs e)
        {
            btnAñadirCarrito.FlatAppearance.BorderColor = Color.FromArgb(24, 30, 54);
            btnAñadirCarrito.FlatAppearance.BorderSize = 2;
        }

        private static int identificadorEntero = TrabajarVenta.obtenerUltimoIdentificador();
        private string convertirIdentificadorToString()
        {
            identificadorEntero++;
            string identificadorString = identificadorEntero.ToString("D7");
           
            return identificadorString;
        }

        /// <summary>
        /// Obtiene Items(Carrito) de la tabla Carrito.
        /// </summary>
        /// <returns>DataTable que contiene valores de la tabla Carrito.</returns>
        public DataTable recorrerCarrito()
        {
            DataTable dt = new DataTable();
            dt = TrabajarCarrito.listarItemsCarrito();
            return dt;
        }

        /// <summary>
        /// Obtiene el Usuario logueado en el Sistema.
        /// </summary>
        /// <returns>Objeto de tipo Usuario.</returns>
        public Usuario obtenerUsuarioActual()
        {
            Usuario usuarioActual = new Usuario();
            usuarioActual = TrabajarLogin.obtnerUsuarioActual(Global.usuarioActual);
            return usuarioActual;
        }
        
        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                Venta venta = new Venta();
                venta.Venta_Fecha = Convert.ToDateTime(txtFechaActual.Text);
                venta.Cliente_ID = Convert.ToInt32(cmbClientes.SelectedValue);
                venta.Venta_Identificador = convertirIdentificadorToString();
                venta.Usu_ID = obtenerUsuarioActual().Usu_ID; 
                TrabajarVenta.agregarVenta(venta);

                DataTable dt = new DataTable();
                dt = TrabajarCarrito.listarItemsCarrito();
                foreach(DataRow drow in dt.Rows){
                    detalle.Prod_ID = Convert.ToInt32(drow["ID Producto"].ToString());
                    detalle.Prod_PrecioUnitario = Convert.ToDecimal(drow["Precio"].ToString());
                    detalle.Prod_Cantidad = Convert.ToInt32(drow["Cantidad"].ToString());
                    detalle.Detalle_Total = Convert.ToDecimal(drow["Total"].ToString());
                    detalle.Cliente_ID = Convert.ToInt32(drow["ID Cliente"].ToString());
                    detalle.Venta_Identificador = venta.Venta_Identificador;
                    TrabajarDetalle.agregarDetalle(detalle);
                }

                MessageBox.Show("La compra se registró exitosamente. \nPodrá ver el detalle de la misma en el apartado: 'DETALLES' ");
                grvCarrito.Visible = false;
                TrabajarCarrito.vaciarTablaCarrito();
                btnDetalles.Focus();
                btnSalir.Enabled = true;
                btnProductos.Enabled = true;
                btnDetalles.Enabled = true;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                 
        }

        /// <summary>
        /// Retorna el valor original de PRODUCTO_STOCK al cancelar una Venta.
        /// </summary>
        private void retomarStock()
        {
            for (int i = 0; i < dataTableProductosInicial.Rows.Count; i++)
            {
                int id = Convert.ToInt32(dataTableProductosInicial.Rows[i]["Prod_ID"].ToString());
                int stock = Convert.ToInt32(dataTableProductosInicial.Rows[i]["Prod_Stock"].ToString());
                TrabajarProducto.modificarStockProductoByID(id, stock);
            }
        }

        private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                retomarStock();
                MessageBox.Show("COMPRA CANCELADA");
                cargarProductos();
                TrabajarCarrito.vaciarTablaCarrito();
                grvCarrito.Visible = false;
                btnSalir.Enabled = true;
                btnProductos.Enabled = true;
                btnDetalles.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }  

        /// <summary>
        /// Formatea el valor de moneda.
        /// </summary>
        /// <param name="money">Decimal que contiene el valor.</param>
        /// <returns>String que contiene el valor formateado.</returns>
        private string convertirMoneda(Decimal money)
        {
            string mstring = String.Format("{0:C}", money);
            return mstring;
        }

        private void tmrFechaActual_Tick(object sender, EventArgs e)
        {
            txtFechaActual.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }

        private void cmbProdStock_MouseClick(object sender, MouseEventArgs e)
        {
            cmbProdStock.Items.Clear();
            obtenerCantidadActual();       
        }

        private void btnFiltrarEntreFechas_Click(object sender, EventArgs e)
        {
            grvDetalles.DataSource = null;
            grvDetalles.DataSource = TrabajarDetalle.filtrarEntreFechas(dtpFechaDesde.Value, dtpFechaHasta.Value);
        }

        private void btnFiltrarPorCliente_Click(object sender, EventArgs e)
        {
            grvDetalles.DataSource = null;
            grvDetalles.DataSource = TrabajarDetalle.filtrarPorCliente(cmbClientes.Text);
        }

        private void btnFiltrarCategoria_Click(object sender, EventArgs e)
        {
            grvDetalles.DataSource = null;
            grvDetalles.DataSource = TrabajarDetalle.filtrarPorCategoria(cmbProdCategoria.Text);
        }

        private void btnFiltrarPorDescripcion_Click(object sender, EventArgs e)
        {
            grvDetalles.DataSource = null;
            grvDetalles.DataSource = TrabajarDetalle.filtrarPorDescripcion(cmbProdDescripcionDetalle.Text);
        }

        /// <summary>
        /// Carga valores de la tabla Venta en el ComboBox de Identificador.
        /// </summary>
        private void cargarVentaIdentificadorCMB()
        {
            try
            {
                cmbVentaIdentificador.DisplayMember = "Venta_Identificador";
                cmbVentaIdentificador.ValueMember = "Venta_ID";
                cmbVentaIdentificador.DataSource = TrabajarVenta.listarVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFiltrarVenta_Click(object sender, EventArgs e)
        {
            grvDetalles.DataSource = null;
            grvDetalles.DataSource = TrabajarDetalle.filtrarPorIdentificador(cmbVentaIdentificador.Text);
        }

        /// <summary>
        /// Carga valores de la tabla Usuario al ComboBox Vendedor.
        /// </summary>
        private void cargarVendedorCMB()
        {
            try
            {
                cmbVendedor.DisplayMember = "Usu_ID";
                cmbVendedor.DisplayMember = "NombreUsuario";
                cmbVendedor.DataSource = TrabajarUsuario.listarUsuariosPorRol();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFiltrarVendedor_Click(object sender, EventArgs e)
        {
            grvDetalles.DataSource = null;
            grvDetalles.DataSource = TrabajarDetalle.filtrarPorVendedor(cmbVendedor.Text);
        }

        private void btnInfoUsuario_Click(object sender, EventArgs e)
        {
            ocultarPropiedadesProducto();
            this.ptbInfoUsuario.Visible = true;
            this.ptbInfoUsuario.Size = new Size(617, 426);
            //this.ptbInfoUsuario.Location = new Point(this.ptbInfoUsuario.Location.X, 0);
            //this.ptbInfoUsuario.Location = new Point(this.ptbInfoUsuario.Location.X, 700);

        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            cargarProductos();
        }

        private void btnRecargarDetalles_Click(object sender, EventArgs e)
        {
            cargarDetalles();
        }

        ErrorProvider errorP = new ErrorProvider();
        private void txtProdStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            Boolean esValido = permitirSoloNumeros(e);
            if (!esValido)
            {
                errorP.SetError(txtProdStock, "Solo números!");
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txtProdCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                errorP.SetError(txtProdCategoria, "Solo se permiten letras!");
            }
        }
 
    }
}

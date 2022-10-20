namespace Vistas
{
    partial class FrmUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMenuUsuario = new System.Windows.Forms.Panel();
            this.btnInfoUsuario = new System.Windows.Forms.Button();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.pnlLogoUsuario = new System.Windows.Forms.Panel();
            this.pnlNavUsuario = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblProdCategoria = new System.Windows.Forms.Label();
            this.lblProdDescripcion = new System.Windows.Forms.Label();
            this.lblProdStock = new System.Windows.Forms.Label();
            this.lblProdPrecio = new System.Windows.Forms.Label();
            this.txtProdCategoria = new System.Windows.Forms.TextBox();
            this.txtProdDescripcion = new System.Windows.Forms.TextBox();
            this.txtProdStock = new System.Windows.Forms.TextBox();
            this.txtProdPrecio = new System.Windows.Forms.TextBox();
            this.grvProductos = new System.Windows.Forms.DataGridView();
            this.btnProdLimpiar = new System.Windows.Forms.Button();
            this.btnProdAgregar = new System.Windows.Forms.Button();
            this.btnProdModificar = new System.Windows.Forms.Button();
            this.btnProdEliminar = new System.Windows.Forms.Button();
            this.txtProdID = new System.Windows.Forms.TextBox();
            this.cmbProdCategoria = new System.Windows.Forms.ComboBox();
            this.cmbProdDescripcionDetalle = new System.Windows.Forms.ComboBox();
            this.txtProdBuscar = new System.Windows.Forms.TextBox();
            this.btnProdBuscar = new System.Windows.Forms.Button();
            this.grvCarrito = new System.Windows.Forms.DataGridView();
            this.cmbProdStock = new System.Windows.Forms.ComboBox();
            this.lblClienteDNI = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.lblClienteNombre = new System.Windows.Forms.Label();
            this.txtClienteNombre = new System.Windows.Forms.TextBox();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.tmrFechaActual = new System.Windows.Forms.Timer(this.components);
            this.txtFechaActual = new System.Windows.Forms.TextBox();
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.grvDetalles = new System.Windows.Forms.DataGridView();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrarEntreFechas = new System.Windows.Forms.Button();
            this.btnFiltrarPorCliente = new System.Windows.Forms.Button();
            this.btnFiltrarCategoria = new System.Windows.Forms.Button();
            this.txtProdDescripcionDetalle = new System.Windows.Forms.Label();
            this.btnFiltrarPorDescripcion = new System.Windows.Forms.Button();
            this.btnFiltrarVenta = new System.Windows.Forms.Button();
            this.cmbVentaIdentificador = new System.Windows.Forms.ComboBox();
            this.txtVentaIdentificador = new System.Windows.Forms.Label();
            this.btnFiltrarVendedor = new System.Windows.Forms.Button();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.ptbInfoUsuario = new System.Windows.Forms.PictureBox();
            this.btnConfirmarVenta = new System.Windows.Forms.Button();
            this.btnAñadirCarrito = new System.Windows.Forms.Button();
            this.btnCancelarCompra = new System.Windows.Forms.Button();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.btnRecargarDetalles = new System.Windows.Forms.Button();
            this.pnlMenuUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInfoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuUsuario
            // 
            this.pnlMenuUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlMenuUsuario.Controls.Add(this.btnInfoUsuario);
            this.pnlMenuUsuario.Controls.Add(this.btnDetalles);
            this.pnlMenuUsuario.Controls.Add(this.btnProductos);
            this.pnlMenuUsuario.Controls.Add(this.btnVentas);
            this.pnlMenuUsuario.Controls.Add(this.pnlLogoUsuario);
            this.pnlMenuUsuario.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuUsuario.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuUsuario.Name = "pnlMenuUsuario";
            this.pnlMenuUsuario.Size = new System.Drawing.Size(200, 750);
            this.pnlMenuUsuario.TabIndex = 0;
            // 
            // btnInfoUsuario
            // 
            this.btnInfoUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnInfoUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnInfoUsuario.FlatAppearance.BorderSize = 0;
            this.btnInfoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnInfoUsuario.Image = global::Vistas.Properties.Resources.iconoInfo;
            this.btnInfoUsuario.Location = new System.Drawing.Point(0, 703);
            this.btnInfoUsuario.Name = "btnInfoUsuario";
            this.btnInfoUsuario.Size = new System.Drawing.Size(200, 47);
            this.btnInfoUsuario.TabIndex = 70;
            this.btnInfoUsuario.Text = "INFORMACIÓN";
            this.btnInfoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInfoUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnInfoUsuario.UseVisualStyleBackColor = true;
            this.btnInfoUsuario.Click += new System.EventHandler(this.btnInfoUsuario_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDetalles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnDetalles.FlatAppearance.BorderSize = 0;
            this.btnDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDetalles.Image = global::Vistas.Properties.Resources.iconoDetalle;
            this.btnDetalles.Location = new System.Drawing.Point(0, 300);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(200, 50);
            this.btnDetalles.TabIndex = 23;
            this.btnDetalles.Text = "DETALLES";
            this.btnDetalles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetalles.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDetalles.UseVisualStyleBackColor = true;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            this.btnDetalles.Leave += new System.EventHandler(this.btnDetalles_Leave);
            // 
            // btnProductos
            // 
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnProductos.Image = global::Vistas.Properties.Resources.iconoRopa;
            this.btnProductos.Location = new System.Drawing.Point(0, 250);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(200, 50);
            this.btnProductos.TabIndex = 21;
            this.btnProductos.Text = "PRODUCTOS";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            this.btnProductos.Leave += new System.EventHandler(this.btnProductos_Leave);
            // 
            // btnVentas
            // 
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnVentas.Image = global::Vistas.Properties.Resources.iconoVentas;
            this.btnVentas.Location = new System.Drawing.Point(0, 200);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(200, 50);
            this.btnVentas.TabIndex = 22;
            this.btnVentas.Text = "VENTAS";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            this.btnVentas.Leave += new System.EventHandler(this.btnVentas_Leave);
            // 
            // pnlLogoUsuario
            // 
            this.pnlLogoUsuario.BackgroundImage = global::Vistas.Properties.Resources.logoIndumentaria;
            this.pnlLogoUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogoUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogoUsuario.Location = new System.Drawing.Point(0, 0);
            this.pnlLogoUsuario.Name = "pnlLogoUsuario";
            this.pnlLogoUsuario.Size = new System.Drawing.Size(200, 200);
            this.pnlLogoUsuario.TabIndex = 0;
            // 
            // pnlNavUsuario
            // 
            this.pnlNavUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(211)))), ((int)(((byte)(48)))));
            this.pnlNavUsuario.Location = new System.Drawing.Point(0, 200);
            this.pnlNavUsuario.Name = "pnlNavUsuario";
            this.pnlNavUsuario.Size = new System.Drawing.Size(3, 80);
            this.pnlNavUsuario.TabIndex = 0;
            this.pnlNavUsuario.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnSalir.Location = new System.Drawing.Point(918, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(20, 20);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblProdCategoria
            // 
            this.lblProdCategoria.AutoSize = true;
            this.lblProdCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdCategoria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProdCategoria.Location = new System.Drawing.Point(305, 27);
            this.lblProdCategoria.Name = "lblProdCategoria";
            this.lblProdCategoria.Size = new System.Drawing.Size(108, 20);
            this.lblProdCategoria.TabIndex = 23;
            this.lblProdCategoria.Text = "CATEGORÍA:";
            this.lblProdCategoria.Visible = false;
            // 
            // lblProdDescripcion
            // 
            this.lblProdDescripcion.AutoSize = true;
            this.lblProdDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdDescripcion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProdDescripcion.Location = new System.Drawing.Point(289, 71);
            this.lblProdDescripcion.Name = "lblProdDescripcion";
            this.lblProdDescripcion.Size = new System.Drawing.Size(124, 20);
            this.lblProdDescripcion.TabIndex = 24;
            this.lblProdDescripcion.Text = "DESCRIPCIÓN:";
            this.lblProdDescripcion.Visible = false;
            // 
            // lblProdStock
            // 
            this.lblProdStock.AutoSize = true;
            this.lblProdStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdStock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProdStock.Location = new System.Drawing.Point(347, 116);
            this.lblProdStock.Name = "lblProdStock";
            this.lblProdStock.Size = new System.Drawing.Size(66, 20);
            this.lblProdStock.TabIndex = 25;
            this.lblProdStock.Text = "STOCK:";
            this.lblProdStock.Visible = false;
            // 
            // lblProdPrecio
            // 
            this.lblProdPrecio.AutoSize = true;
            this.lblProdPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdPrecio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProdPrecio.Location = new System.Drawing.Point(339, 161);
            this.lblProdPrecio.Name = "lblProdPrecio";
            this.lblProdPrecio.Size = new System.Drawing.Size(74, 20);
            this.lblProdPrecio.TabIndex = 26;
            this.lblProdPrecio.Text = "PRECIO:";
            this.lblProdPrecio.Visible = false;
            // 
            // txtProdCategoria
            // 
            this.txtProdCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtProdCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdCategoria.ForeColor = System.Drawing.SystemColors.Window;
            this.txtProdCategoria.Location = new System.Drawing.Point(444, 24);
            this.txtProdCategoria.Name = "txtProdCategoria";
            this.txtProdCategoria.Size = new System.Drawing.Size(248, 26);
            this.txtProdCategoria.TabIndex = 27;
            this.txtProdCategoria.Visible = false;
            this.txtProdCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProdCategoria_KeyPress);
            // 
            // txtProdDescripcion
            // 
            this.txtProdDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtProdDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdDescripcion.ForeColor = System.Drawing.SystemColors.Window;
            this.txtProdDescripcion.Location = new System.Drawing.Point(444, 65);
            this.txtProdDescripcion.Name = "txtProdDescripcion";
            this.txtProdDescripcion.Size = new System.Drawing.Size(248, 26);
            this.txtProdDescripcion.TabIndex = 28;
            this.txtProdDescripcion.Visible = false;
            // 
            // txtProdStock
            // 
            this.txtProdStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtProdStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdStock.ForeColor = System.Drawing.SystemColors.Window;
            this.txtProdStock.Location = new System.Drawing.Point(444, 110);
            this.txtProdStock.Name = "txtProdStock";
            this.txtProdStock.Size = new System.Drawing.Size(248, 26);
            this.txtProdStock.TabIndex = 29;
            this.txtProdStock.Visible = false;
            this.txtProdStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProdStock_KeyPress);
            // 
            // txtProdPrecio
            // 
            this.txtProdPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtProdPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdPrecio.ForeColor = System.Drawing.SystemColors.Window;
            this.txtProdPrecio.Location = new System.Drawing.Point(444, 158);
            this.txtProdPrecio.Name = "txtProdPrecio";
            this.txtProdPrecio.Size = new System.Drawing.Size(248, 26);
            this.txtProdPrecio.TabIndex = 30;
            this.txtProdPrecio.Visible = false;
            // 
            // grvProductos
            // 
            this.grvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.grvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.grvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.grvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvProductos.DefaultCellStyle = dataGridViewCellStyle4;
            this.grvProductos.Location = new System.Drawing.Point(263, 345);
            this.grvProductos.Name = "grvProductos";
            this.grvProductos.Size = new System.Drawing.Size(617, 90);
            this.grvProductos.TabIndex = 31;
            this.grvProductos.Visible = false;
            this.grvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvProductos_CellClick);
            this.grvProductos.CurrentCellChanged += new System.EventHandler(this.grvProductos_CurrentCellChanged);
            // 
            // btnProdLimpiar
            // 
            this.btnProdLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnProdLimpiar.FlatAppearance.BorderSize = 2;
            this.btnProdLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdLimpiar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnProdLimpiar.Location = new System.Drawing.Point(725, 13);
            this.btnProdLimpiar.Name = "btnProdLimpiar";
            this.btnProdLimpiar.Size = new System.Drawing.Size(90, 37);
            this.btnProdLimpiar.TabIndex = 32;
            this.btnProdLimpiar.Text = "LIMPIAR";
            this.btnProdLimpiar.UseVisualStyleBackColor = true;
            this.btnProdLimpiar.Visible = false;
            this.btnProdLimpiar.Click += new System.EventHandler(this.btnProdLimpiar_Click);
            // 
            // btnProdAgregar
            // 
            this.btnProdAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnProdAgregar.FlatAppearance.BorderSize = 2;
            this.btnProdAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdAgregar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnProdAgregar.Location = new System.Drawing.Point(725, 61);
            this.btnProdAgregar.Name = "btnProdAgregar";
            this.btnProdAgregar.Size = new System.Drawing.Size(90, 37);
            this.btnProdAgregar.TabIndex = 33;
            this.btnProdAgregar.Text = "AGREGAR";
            this.btnProdAgregar.UseVisualStyleBackColor = true;
            this.btnProdAgregar.Visible = false;
            this.btnProdAgregar.Click += new System.EventHandler(this.btnProdAgregar_Click);
            // 
            // btnProdModificar
            // 
            this.btnProdModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnProdModificar.FlatAppearance.BorderSize = 2;
            this.btnProdModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdModificar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnProdModificar.Location = new System.Drawing.Point(725, 106);
            this.btnProdModificar.Name = "btnProdModificar";
            this.btnProdModificar.Size = new System.Drawing.Size(90, 37);
            this.btnProdModificar.TabIndex = 34;
            this.btnProdModificar.Text = "MODIFICAR";
            this.btnProdModificar.UseVisualStyleBackColor = true;
            this.btnProdModificar.Visible = false;
            this.btnProdModificar.Click += new System.EventHandler(this.btnProdModificar_Click);
            // 
            // btnProdEliminar
            // 
            this.btnProdEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnProdEliminar.FlatAppearance.BorderSize = 2;
            this.btnProdEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdEliminar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnProdEliminar.Location = new System.Drawing.Point(725, 154);
            this.btnProdEliminar.Name = "btnProdEliminar";
            this.btnProdEliminar.Size = new System.Drawing.Size(90, 37);
            this.btnProdEliminar.TabIndex = 35;
            this.btnProdEliminar.Text = "ELIMINAR";
            this.btnProdEliminar.UseVisualStyleBackColor = true;
            this.btnProdEliminar.Visible = false;
            this.btnProdEliminar.Click += new System.EventHandler(this.btnProdEliminar_Click);
            // 
            // txtProdID
            // 
            this.txtProdID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtProdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdID.ForeColor = System.Drawing.SystemColors.Window;
            this.txtProdID.Location = new System.Drawing.Point(215, 12);
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.Size = new System.Drawing.Size(41, 26);
            this.txtProdID.TabIndex = 36;
            this.txtProdID.Visible = false;
            // 
            // cmbProdCategoria
            // 
            this.cmbProdCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cmbProdCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProdCategoria.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbProdCategoria.FormattingEnabled = true;
            this.cmbProdCategoria.Location = new System.Drawing.Point(444, 24);
            this.cmbProdCategoria.Name = "cmbProdCategoria";
            this.cmbProdCategoria.Size = new System.Drawing.Size(248, 28);
            this.cmbProdCategoria.TabIndex = 37;
            this.cmbProdCategoria.Visible = false;
            this.cmbProdCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbProdCategoria_SelectedIndexChanged);
            // 
            // cmbProdDescripcionDetalle
            // 
            this.cmbProdDescripcionDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cmbProdDescripcionDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProdDescripcionDetalle.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbProdDescripcionDetalle.FormattingEnabled = true;
            this.cmbProdDescripcionDetalle.Location = new System.Drawing.Point(444, 117);
            this.cmbProdDescripcionDetalle.Name = "cmbProdDescripcionDetalle";
            this.cmbProdDescripcionDetalle.Size = new System.Drawing.Size(248, 28);
            this.cmbProdDescripcionDetalle.TabIndex = 39;
            this.cmbProdDescripcionDetalle.Visible = false;
            // 
            // txtProdBuscar
            // 
            this.txtProdBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtProdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdBuscar.ForeColor = System.Drawing.SystemColors.Window;
            this.txtProdBuscar.Location = new System.Drawing.Point(444, 476);
            this.txtProdBuscar.Name = "txtProdBuscar";
            this.txtProdBuscar.Size = new System.Drawing.Size(260, 26);
            this.txtProdBuscar.TabIndex = 40;
            this.txtProdBuscar.Visible = false;
            // 
            // btnProdBuscar
            // 
            this.btnProdBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnProdBuscar.FlatAppearance.BorderSize = 2;
            this.btnProdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdBuscar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnProdBuscar.Location = new System.Drawing.Point(715, 471);
            this.btnProdBuscar.Name = "btnProdBuscar";
            this.btnProdBuscar.Size = new System.Drawing.Size(90, 37);
            this.btnProdBuscar.TabIndex = 41;
            this.btnProdBuscar.Text = "BUSCAR";
            this.btnProdBuscar.UseVisualStyleBackColor = true;
            this.btnProdBuscar.Visible = false;
            this.btnProdBuscar.Click += new System.EventHandler(this.btnProdBuscar_Click);
            // 
            // grvCarrito
            // 
            this.grvCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvCarrito.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.grvCarrito.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.grvCarrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvCarrito.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.grvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvCarrito.DefaultCellStyle = dataGridViewCellStyle5;
            this.grvCarrito.Location = new System.Drawing.Point(263, 534);
            this.grvCarrito.Name = "grvCarrito";
            this.grvCarrito.Size = new System.Drawing.Size(617, 90);
            this.grvCarrito.TabIndex = 42;
            this.grvCarrito.Visible = false;
            // 
            // cmbProdStock
            // 
            this.cmbProdStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cmbProdStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProdStock.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbProdStock.FormattingEnabled = true;
            this.cmbProdStock.Location = new System.Drawing.Point(444, 108);
            this.cmbProdStock.Name = "cmbProdStock";
            this.cmbProdStock.Size = new System.Drawing.Size(248, 28);
            this.cmbProdStock.TabIndex = 44;
            this.cmbProdStock.Visible = false;
            this.cmbProdStock.SelectedIndexChanged += new System.EventHandler(this.cmbProdStock_SelectedIndexChanged);
            this.cmbProdStock.SelectedValueChanged += new System.EventHandler(this.cmbProdStock_SelectedValueChanged);
            this.cmbProdStock.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbProdStock_MouseClick);
            // 
            // lblClienteDNI
            // 
            this.lblClienteDNI.AutoSize = true;
            this.lblClienteDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteDNI.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClienteDNI.Location = new System.Drawing.Point(289, 206);
            this.lblClienteDNI.Name = "lblClienteDNI";
            this.lblClienteDNI.Size = new System.Drawing.Size(124, 20);
            this.lblClienteDNI.TabIndex = 45;
            this.lblClienteDNI.Text = "D.N.I. CLIENTE:";
            this.lblClienteDNI.Visible = false;
            // 
            // cmbClientes
            // 
            this.cmbClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cmbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientes.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(444, 203);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(248, 28);
            this.cmbClientes.TabIndex = 46;
            this.cmbClientes.Visible = false;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            // 
            // lblClienteNombre
            // 
            this.lblClienteNombre.AutoSize = true;
            this.lblClienteNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClienteNombre.Location = new System.Drawing.Point(259, 250);
            this.lblClienteNombre.Name = "lblClienteNombre";
            this.lblClienteNombre.Size = new System.Drawing.Size(154, 20);
            this.lblClienteNombre.TabIndex = 47;
            this.lblClienteNombre.Text = "NOMBRE CLIENTE:";
            this.lblClienteNombre.Visible = false;
            // 
            // txtClienteNombre
            // 
            this.txtClienteNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtClienteNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteNombre.ForeColor = System.Drawing.SystemColors.Window;
            this.txtClienteNombre.Location = new System.Drawing.Point(444, 250);
            this.txtClienteNombre.Name = "txtClienteNombre";
            this.txtClienteNombre.Size = new System.Drawing.Size(248, 26);
            this.txtClienteNombre.TabIndex = 48;
            this.txtClienteNombre.Visible = false;
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaActual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFechaActual.Location = new System.Drawing.Point(339, 296);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(68, 20);
            this.lblFechaActual.TabIndex = 50;
            this.lblFechaActual.Text = "FECHA:";
            this.lblFechaActual.Visible = false;
            // 
            // tmrFechaActual
            // 
            this.tmrFechaActual.Enabled = true;
            this.tmrFechaActual.Tick += new System.EventHandler(this.tmrFechaActual_Tick);
            // 
            // txtFechaActual
            // 
            this.txtFechaActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtFechaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaActual.ForeColor = System.Drawing.SystemColors.Window;
            this.txtFechaActual.Location = new System.Drawing.Point(444, 296);
            this.txtFechaActual.Name = "txtFechaActual";
            this.txtFechaActual.ReadOnly = true;
            this.txtFechaActual.Size = new System.Drawing.Size(248, 26);
            this.txtFechaActual.TabIndex = 51;
            this.txtFechaActual.Visible = false;
            // 
            // txtClienteID
            // 
            this.txtClienteID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtClienteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteID.ForeColor = System.Drawing.SystemColors.Window;
            this.txtClienteID.Location = new System.Drawing.Point(215, 44);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(41, 26);
            this.txtClienteID.TabIndex = 52;
            this.txtClienteID.Visible = false;
            // 
            // grvDetalles
            // 
            this.grvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grvDetalles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.grvDetalles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.grvDetalles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvDetalles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.grvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvDetalles.DefaultCellStyle = dataGridViewCellStyle6;
            this.grvDetalles.Location = new System.Drawing.Point(263, 453);
            this.grvDetalles.Name = "grvDetalles";
            this.grvDetalles.Size = new System.Drawing.Size(617, 162);
            this.grvDetalles.TabIndex = 53;
            this.grvDetalles.Visible = false;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDesde.Location = new System.Drawing.Point(294, 690);
            this.dtpFechaDesde.MaxDate = new System.DateTime(2038, 12, 31, 0, 0, 0, 0);
            this.dtpFechaDesde.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(217, 20);
            this.dtpFechaDesde.TabIndex = 56;
            this.dtpFechaDesde.Visible = false;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHasta.Location = new System.Drawing.Point(538, 690);
            this.dtpFechaHasta.MaxDate = new System.DateTime(2038, 12, 31, 0, 0, 0, 0);
            this.dtpFechaHasta.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(217, 20);
            this.dtpFechaHasta.TabIndex = 57;
            this.dtpFechaHasta.Visible = false;
            // 
            // btnFiltrarEntreFechas
            // 
            this.btnFiltrarEntreFechas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnFiltrarEntreFechas.FlatAppearance.BorderSize = 2;
            this.btnFiltrarEntreFechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarEntreFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarEntreFechas.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnFiltrarEntreFechas.Location = new System.Drawing.Point(776, 673);
            this.btnFiltrarEntreFechas.Name = "btnFiltrarEntreFechas";
            this.btnFiltrarEntreFechas.Size = new System.Drawing.Size(104, 53);
            this.btnFiltrarEntreFechas.TabIndex = 58;
            this.btnFiltrarEntreFechas.Text = "FILTRAR ENTRE FECHAS";
            this.btnFiltrarEntreFechas.UseVisualStyleBackColor = true;
            this.btnFiltrarEntreFechas.Visible = false;
            this.btnFiltrarEntreFechas.Click += new System.EventHandler(this.btnFiltrarEntreFechas_Click);
            // 
            // btnFiltrarPorCliente
            // 
            this.btnFiltrarPorCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnFiltrarPorCliente.FlatAppearance.BorderSize = 2;
            this.btnFiltrarPorCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarPorCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarPorCliente.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnFiltrarPorCliente.Location = new System.Drawing.Point(725, 191);
            this.btnFiltrarPorCliente.Name = "btnFiltrarPorCliente";
            this.btnFiltrarPorCliente.Size = new System.Drawing.Size(103, 53);
            this.btnFiltrarPorCliente.TabIndex = 59;
            this.btnFiltrarPorCliente.Text = "FILTRAR POR CLIENTE";
            this.btnFiltrarPorCliente.UseVisualStyleBackColor = true;
            this.btnFiltrarPorCliente.Visible = false;
            this.btnFiltrarPorCliente.Click += new System.EventHandler(this.btnFiltrarPorCliente_Click);
            // 
            // btnFiltrarCategoria
            // 
            this.btnFiltrarCategoria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnFiltrarCategoria.FlatAppearance.BorderSize = 2;
            this.btnFiltrarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarCategoria.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnFiltrarCategoria.Location = new System.Drawing.Point(725, 12);
            this.btnFiltrarCategoria.Name = "btnFiltrarCategoria";
            this.btnFiltrarCategoria.Size = new System.Drawing.Size(103, 53);
            this.btnFiltrarCategoria.TabIndex = 60;
            this.btnFiltrarCategoria.Text = "FILTRAR POR CATEGORÍA";
            this.btnFiltrarCategoria.UseVisualStyleBackColor = true;
            this.btnFiltrarCategoria.Visible = false;
            this.btnFiltrarCategoria.Click += new System.EventHandler(this.btnFiltrarCategoria_Click);
            // 
            // txtProdDescripcionDetalle
            // 
            this.txtProdDescripcionDetalle.AutoSize = true;
            this.txtProdDescripcionDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdDescripcionDetalle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtProdDescripcionDetalle.Location = new System.Drawing.Point(289, 123);
            this.txtProdDescripcionDetalle.Name = "txtProdDescripcionDetalle";
            this.txtProdDescripcionDetalle.Size = new System.Drawing.Size(124, 20);
            this.txtProdDescripcionDetalle.TabIndex = 61;
            this.txtProdDescripcionDetalle.Text = "DESCRIPCIÓN:";
            this.txtProdDescripcionDetalle.Visible = false;
            // 
            // btnFiltrarPorDescripcion
            // 
            this.btnFiltrarPorDescripcion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnFiltrarPorDescripcion.FlatAppearance.BorderSize = 2;
            this.btnFiltrarPorDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarPorDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarPorDescripcion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnFiltrarPorDescripcion.Location = new System.Drawing.Point(726, 107);
            this.btnFiltrarPorDescripcion.Name = "btnFiltrarPorDescripcion";
            this.btnFiltrarPorDescripcion.Size = new System.Drawing.Size(103, 53);
            this.btnFiltrarPorDescripcion.TabIndex = 62;
            this.btnFiltrarPorDescripcion.Text = "FILTRAR POR DESCRIPCIÓN";
            this.btnFiltrarPorDescripcion.UseVisualStyleBackColor = true;
            this.btnFiltrarPorDescripcion.Visible = false;
            this.btnFiltrarPorDescripcion.Click += new System.EventHandler(this.btnFiltrarPorDescripcion_Click);
            // 
            // btnFiltrarVenta
            // 
            this.btnFiltrarVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnFiltrarVenta.FlatAppearance.BorderSize = 2;
            this.btnFiltrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarVenta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnFiltrarVenta.Location = new System.Drawing.Point(725, 284);
            this.btnFiltrarVenta.Name = "btnFiltrarVenta";
            this.btnFiltrarVenta.Size = new System.Drawing.Size(103, 53);
            this.btnFiltrarVenta.TabIndex = 63;
            this.btnFiltrarVenta.Text = "FILTRAR NÚMERO VENTA";
            this.btnFiltrarVenta.UseVisualStyleBackColor = true;
            this.btnFiltrarVenta.Visible = false;
            this.btnFiltrarVenta.Click += new System.EventHandler(this.btnFiltrarVenta_Click);
            // 
            // cmbVentaIdentificador
            // 
            this.cmbVentaIdentificador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cmbVentaIdentificador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVentaIdentificador.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbVentaIdentificador.FormattingEnabled = true;
            this.cmbVentaIdentificador.Location = new System.Drawing.Point(444, 300);
            this.cmbVentaIdentificador.Name = "cmbVentaIdentificador";
            this.cmbVentaIdentificador.Size = new System.Drawing.Size(248, 28);
            this.cmbVentaIdentificador.TabIndex = 64;
            this.cmbVentaIdentificador.Visible = false;
            // 
            // txtVentaIdentificador
            // 
            this.txtVentaIdentificador.AutoSize = true;
            this.txtVentaIdentificador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVentaIdentificador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtVentaIdentificador.Location = new System.Drawing.Point(324, 301);
            this.txtVentaIdentificador.Name = "txtVentaIdentificador";
            this.txtVentaIdentificador.Size = new System.Drawing.Size(86, 20);
            this.txtVentaIdentificador.TabIndex = 65;
            this.txtVentaIdentificador.Text = "N° VENTA:";
            this.txtVentaIdentificador.Visible = false;
            // 
            // btnFiltrarVendedor
            // 
            this.btnFiltrarVendedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnFiltrarVendedor.FlatAppearance.BorderSize = 2;
            this.btnFiltrarVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarVendedor.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnFiltrarVendedor.Location = new System.Drawing.Point(725, 368);
            this.btnFiltrarVendedor.Name = "btnFiltrarVendedor";
            this.btnFiltrarVendedor.Size = new System.Drawing.Size(103, 53);
            this.btnFiltrarVendedor.TabIndex = 66;
            this.btnFiltrarVendedor.Text = "FILTRAR POR VENDEDOR";
            this.btnFiltrarVendedor.UseVisualStyleBackColor = true;
            this.btnFiltrarVendedor.Visible = false;
            this.btnFiltrarVendedor.Click += new System.EventHandler(this.btnFiltrarVendedor_Click);
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVendedor.Location = new System.Drawing.Point(308, 383);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(105, 20);
            this.lblVendedor.TabIndex = 67;
            this.lblVendedor.Text = "VENDEDOR:";
            this.lblVendedor.Visible = false;
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cmbVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVendedor.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(444, 380);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(248, 28);
            this.cmbVendedor.TabIndex = 68;
            this.cmbVendedor.Visible = false;
            // 
            // ptbInfoUsuario
            // 
            this.ptbInfoUsuario.Image = global::Vistas.Properties.Resources.estadisticasVenta;
            this.ptbInfoUsuario.Location = new System.Drawing.Point(261, 100);
            this.ptbInfoUsuario.Name = "ptbInfoUsuario";
            this.ptbInfoUsuario.Size = new System.Drawing.Size(76, 48);
            this.ptbInfoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbInfoUsuario.TabIndex = 70;
            this.ptbInfoUsuario.TabStop = false;
            this.ptbInfoUsuario.Visible = false;
            // 
            // btnConfirmarVenta
            // 
            this.btnConfirmarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirmarVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnConfirmarVenta.FlatAppearance.BorderSize = 2;
            this.btnConfirmarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarVenta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnConfirmarVenta.Image = global::Vistas.Properties.Resources.Confirmar1;
            this.btnConfirmarVenta.Location = new System.Drawing.Point(589, 663);
            this.btnConfirmarVenta.Name = "btnConfirmarVenta";
            this.btnConfirmarVenta.Size = new System.Drawing.Size(253, 75);
            this.btnConfirmarVenta.TabIndex = 49;
            this.btnConfirmarVenta.Text = "CONFIRMAR COMPRA";
            this.btnConfirmarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnConfirmarVenta.UseVisualStyleBackColor = true;
            this.btnConfirmarVenta.Visible = false;
            this.btnConfirmarVenta.Click += new System.EventHandler(this.btnConfirmarVenta_Click);
            // 
            // btnAñadirCarrito
            // 
            this.btnAñadirCarrito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAñadirCarrito.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnAñadirCarrito.FlatAppearance.BorderSize = 2;
            this.btnAñadirCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirCarrito.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAñadirCarrito.Image = global::Vistas.Properties.Resources.iconoCarritoBlanco;
            this.btnAñadirCarrito.Location = new System.Drawing.Point(725, 124);
            this.btnAñadirCarrito.Name = "btnAñadirCarrito";
            this.btnAñadirCarrito.Size = new System.Drawing.Size(105, 88);
            this.btnAñadirCarrito.TabIndex = 43;
            this.btnAñadirCarrito.Text = "AÑADIR AL CARRITO";
            this.btnAñadirCarrito.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAñadirCarrito.UseVisualStyleBackColor = true;
            this.btnAñadirCarrito.Visible = false;
            this.btnAñadirCarrito.Click += new System.EventHandler(this.btnAñadirCarrito_Click);
            // 
            // btnCancelarCompra
            // 
            this.btnCancelarCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelarCompra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCancelarCompra.FlatAppearance.BorderSize = 2;
            this.btnCancelarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCompra.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCancelarCompra.Image = global::Vistas.Properties.Resources.iconoCancelarSinFondo;
            this.btnCancelarCompra.Location = new System.Drawing.Point(278, 662);
            this.btnCancelarCompra.Name = "btnCancelarCompra";
            this.btnCancelarCompra.Size = new System.Drawing.Size(253, 75);
            this.btnCancelarCompra.TabIndex = 69;
            this.btnCancelarCompra.Text = "CANCELAR COMPRA";
            this.btnCancelarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCancelarCompra.UseVisualStyleBackColor = true;
            this.btnCancelarCompra.Visible = false;
            this.btnCancelarCompra.Click += new System.EventHandler(this.btnCancelarCompra_Click);
            // 
            // btnRecargar
            // 
            this.btnRecargar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnRecargar.FlatAppearance.BorderSize = 2;
            this.btnRecargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecargar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnRecargar.Location = new System.Drawing.Point(343, 471);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(90, 37);
            this.btnRecargar.TabIndex = 71;
            this.btnRecargar.Text = "RECARGAR";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // btnRecargarDetalles
            // 
            this.btnRecargarDetalles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnRecargarDetalles.FlatAppearance.BorderSize = 2;
            this.btnRecargarDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecargarDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecargarDetalles.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnRecargarDetalles.Location = new System.Drawing.Point(496, 630);
            this.btnRecargarDetalles.Name = "btnRecargarDetalles";
            this.btnRecargarDetalles.Size = new System.Drawing.Size(148, 37);
            this.btnRecargarDetalles.TabIndex = 72;
            this.btnRecargarDetalles.Text = "RECARGAR";
            this.btnRecargarDetalles.UseVisualStyleBackColor = true;
            this.btnRecargarDetalles.Click += new System.EventHandler(this.btnRecargarDetalles_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(950, 750);
            this.Controls.Add(this.btnRecargarDetalles);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.ptbInfoUsuario);
            this.Controls.Add(this.cmbVendedor);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.btnFiltrarVendedor);
            this.Controls.Add(this.txtVentaIdentificador);
            this.Controls.Add(this.cmbVentaIdentificador);
            this.Controls.Add(this.btnFiltrarVenta);
            this.Controls.Add(this.btnFiltrarPorDescripcion);
            this.Controls.Add(this.txtProdDescripcionDetalle);
            this.Controls.Add(this.btnFiltrarCategoria);
            this.Controls.Add(this.btnFiltrarPorCliente);
            this.Controls.Add(this.btnFiltrarEntreFechas);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.grvDetalles);
            this.Controls.Add(this.txtClienteID);
            this.Controls.Add(this.txtFechaActual);
            this.Controls.Add(this.lblFechaActual);
            this.Controls.Add(this.btnConfirmarVenta);
            this.Controls.Add(this.txtClienteNombre);
            this.Controls.Add(this.lblClienteNombre);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.lblClienteDNI);
            this.Controls.Add(this.btnAñadirCarrito);
            this.Controls.Add(this.grvCarrito);
            this.Controls.Add(this.btnProdBuscar);
            this.Controls.Add(this.txtProdBuscar);
            this.Controls.Add(this.cmbProdDescripcionDetalle);
            this.Controls.Add(this.txtProdID);
            this.Controls.Add(this.btnProdEliminar);
            this.Controls.Add(this.btnProdModificar);
            this.Controls.Add(this.btnProdAgregar);
            this.Controls.Add(this.btnProdLimpiar);
            this.Controls.Add(this.grvProductos);
            this.Controls.Add(this.txtProdPrecio);
            this.Controls.Add(this.txtProdStock);
            this.Controls.Add(this.txtProdDescripcion);
            this.Controls.Add(this.txtProdCategoria);
            this.Controls.Add(this.lblProdPrecio);
            this.Controls.Add(this.lblProdStock);
            this.Controls.Add(this.lblProdDescripcion);
            this.Controls.Add(this.lblProdCategoria);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pnlNavUsuario);
            this.Controls.Add(this.pnlMenuUsuario);
            this.Controls.Add(this.btnCancelarCompra);
            this.Controls.Add(this.cmbProdStock);
            this.Controls.Add(this.cmbProdCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.pnlMenuUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInfoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuUsuario;
        private System.Windows.Forms.Panel pnlLogoUsuario;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Panel pnlNavUsuario;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblProdCategoria;
        private System.Windows.Forms.Label lblProdDescripcion;
        private System.Windows.Forms.Label lblProdStock;
        private System.Windows.Forms.Label lblProdPrecio;
        private System.Windows.Forms.TextBox txtProdCategoria;
        private System.Windows.Forms.TextBox txtProdDescripcion;
        private System.Windows.Forms.TextBox txtProdStock;
        private System.Windows.Forms.TextBox txtProdPrecio;
        private System.Windows.Forms.DataGridView grvProductos;
        private System.Windows.Forms.Button btnProdLimpiar;
        private System.Windows.Forms.Button btnProdAgregar;
        private System.Windows.Forms.Button btnProdModificar;
        private System.Windows.Forms.Button btnProdEliminar;
        private System.Windows.Forms.TextBox txtProdID;
        private System.Windows.Forms.ComboBox cmbProdCategoria;
        private System.Windows.Forms.ComboBox cmbProdDescripcionDetalle;
        private System.Windows.Forms.TextBox txtProdBuscar;
        private System.Windows.Forms.Button btnProdBuscar;
        private System.Windows.Forms.DataGridView grvCarrito;
        private System.Windows.Forms.Button btnAñadirCarrito;
        private System.Windows.Forms.ComboBox cmbProdStock;
        private System.Windows.Forms.Label lblClienteDNI;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label lblClienteNombre;
        private System.Windows.Forms.TextBox txtClienteNombre;
        private System.Windows.Forms.Button btnConfirmarVenta;
        private System.Windows.Forms.Label lblFechaActual;
        private System.Windows.Forms.Timer tmrFechaActual;
        private System.Windows.Forms.TextBox txtFechaActual;
        private System.Windows.Forms.TextBox txtClienteID;
        private System.Windows.Forms.DataGridView grvDetalles;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Button btnFiltrarEntreFechas;
        private System.Windows.Forms.Button btnFiltrarPorCliente;
        private System.Windows.Forms.Button btnFiltrarCategoria;
        private System.Windows.Forms.Label txtProdDescripcionDetalle;
        private System.Windows.Forms.Button btnFiltrarPorDescripcion;
        private System.Windows.Forms.Button btnFiltrarVenta;
        private System.Windows.Forms.ComboBox cmbVentaIdentificador;
        private System.Windows.Forms.Label txtVentaIdentificador;
        private System.Windows.Forms.Button btnFiltrarVendedor;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.Button btnCancelarCompra;
        private System.Windows.Forms.Button btnInfoUsuario;
        private System.Windows.Forms.PictureBox ptbInfoUsuario;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Button btnRecargarDetalles;
    }
}
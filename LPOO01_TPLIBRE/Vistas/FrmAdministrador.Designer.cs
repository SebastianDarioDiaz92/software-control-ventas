namespace Vistas
{
    partial class FrmAdministrador
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.ptbUsuarios = new System.Windows.Forms.PictureBox();
            this.ptbInfoImage = new System.Windows.Forms.PictureBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInfoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlMenu.Controls.Add(this.pnlNav);
            this.pnlMenu.Controls.Add(this.btnInfo);
            this.pnlMenu.Controls.Add(this.btnUsuarios);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 750);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(211)))), ((int)(((byte)(48)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 200);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 80);
            this.pnlNav.TabIndex = 23;
            this.pnlNav.Visible = false;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.ptbLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 200);
            this.pnlLogo.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnSalir.Location = new System.Drawing.Point(918, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(20, 20);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ptbUsuarios
            // 
            this.ptbUsuarios.Image = global::Vistas.Properties.Resources.indumentariaFondo;
            this.ptbUsuarios.Location = new System.Drawing.Point(250, 279);
            this.ptbUsuarios.Name = "ptbUsuarios";
            this.ptbUsuarios.Size = new System.Drawing.Size(650, 300);
            this.ptbUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbUsuarios.TabIndex = 23;
            this.ptbUsuarios.TabStop = false;
            this.ptbUsuarios.Visible = false;
            // 
            // ptbInfoImage
            // 
            this.ptbInfoImage.Image = global::Vistas.Properties.Resources.windows10;
            this.ptbInfoImage.Location = new System.Drawing.Point(250, 175);
            this.ptbInfoImage.Name = "ptbInfoImage";
            this.ptbInfoImage.Size = new System.Drawing.Size(650, 416);
            this.ptbInfoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbInfoImage.TabIndex = 22;
            this.ptbInfoImage.TabStop = false;
            this.ptbInfoImage.Visible = false;
            // 
            // btnInfo
            // 
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnInfo.Image = global::Vistas.Properties.Resources.iconoInfo;
            this.btnInfo.Location = new System.Drawing.Point(0, 703);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(200, 47);
            this.btnInfo.TabIndex = 21;
            this.btnInfo.Text = "INFORMACIÓN";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            this.btnInfo.Leave += new System.EventHandler(this.btnInfo_Leave);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnUsuarios.Image = global::Vistas.Properties.Resources.iconoUsuarios;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 200);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(200, 50);
            this.btnUsuarios.TabIndex = 20;
            this.btnUsuarios.Text = "USUARIOS";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            this.btnUsuarios.Leave += new System.EventHandler(this.btnUsuarios_Leave);
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = global::Vistas.Properties.Resources.logoIndumentaria;
            this.ptbLogo.Location = new System.Drawing.Point(0, 0);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(200, 200);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 0;
            this.ptbLogo.TabStop = false;
            // 
            // FrmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(950, 750);
            this.Controls.Add(this.ptbUsuarios);
            this.Controls.Add(this.ptbInfoImage);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdministrador";
            this.Load += new System.EventHandler(this.FrmAdministrador_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInfoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.PictureBox ptbInfoImage;
        private System.Windows.Forms.PictureBox ptbUsuarios;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
using System.Runtime.InteropServices;

namespace Vistas
{
    public partial class FrmAdministrador : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        /// <summary>
        /// Constructor de Formulario Administrador, que recibe como Parámetro una Estructura <paramref name="nombreUsuarioActual"/> desde el Formulario Login.
        /// </summary>
        /// <param name="nombreUsuarioActual">Estructura.</param>
        public FrmAdministrador(FrmLogin.NombreUsuarioActual nombreUsuarioActual)
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            
        }

        /// <summary>
        /// Constructor de Formulario Administrador.
        /// </summary>
        public FrmAdministrador()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }

        private void FrmAdministrador_Load(object sender, EventArgs e)
        {
            ptbUsuarios.Visible = true;
            ptbInfoImage.Visible = false;
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                pnlNav.Visible = true;
                pnlNav.Height = btnUsuarios.Height;
                pnlNav.Top = btnUsuarios.Top;
                pnlNav.Left = btnUsuarios.Left;
                btnUsuarios.BackColor = Color.FromArgb(46, 51, 73);

                
                FrmABMUsuario frmABMUsuario = new FrmABMUsuario();
                frmABMUsuario.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUsuarios_Leave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = Color.FromArgb(24,30,54);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;
            pnlNav.Height = btnInfo.Height;
            pnlNav.Top = btnInfo.Top;
            pnlNav.Left = btnInfo.Left;
            btnInfo.BackColor = Color.FromArgb(46, 51, 73);
            ptbUsuarios.Visible = false;
            ptbInfoImage.Visible = true;
        }

        private void btnInfo_Leave(object sender, EventArgs e)
        {
            btnInfo.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}

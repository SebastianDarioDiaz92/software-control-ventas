using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class FrmLogin : Form
    {
        /// <summary>
        /// Constructor sin parámetros de Formulario Login.
        /// </summary>
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_MouseHover(object sender, EventArgs e)
        {
            //btnAceptar.BackColor = Color.LightSeaGreen;
            btnAceptar.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Desea salir de la Aplicación?", "SALIR DEL PROGRAMA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion.Equals(DialogResult.OK))
                {
                    Close();
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        /// <summary>
        /// Estructura utilizada para enviar datos a otro Formulario.
        /// </summary>        
        public struct NombreUsuarioActual {
            public string nombreUsuarioActual; 
        }

        /// <summary>
        /// Valida el formulario Login para iniciar sesión.
        /// </summary>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean usuarioValido = TrabajarLogin.validarUsuario(txtNombreUsuario.Text, txtContraseña.Text);
                if (usuarioValido)
                {
                    NombreUsuarioActual nombreUsuario;
                    nombreUsuario.nombreUsuarioActual = txtNombreUsuario.Text;
                    String rolDescripcion = TrabajarLogin.obtenerRolUsuario(txtNombreUsuario.Text, txtContraseña.Text);
                    MessageBox.Show("BIENVENIDO: " + txtNombreUsuario.Text + "\nRol :" + rolDescripcion);
                    switch (rolDescripcion)
                    {
                        case "ADMINISTRADOR": FrmAdministrador frmAdministrador = new FrmAdministrador(nombreUsuario);
                            frmAdministrador.Show();
                            this.Hide();
                            break;
                        case "USUARIO": FrmUsuario frmUsuario = new FrmUsuario(nombreUsuario);
                            frmUsuario.Show();
                            this.Hide();
                            break;
                        default: rolDescripcion = string.Empty;
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Parámetros Incorrectos! ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

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
using System.Text.RegularExpressions;

namespace Vistas
{
    public partial class FrmABMUsuario : Form
    {
        /// <summary>
        /// Constructor de el Formulario ABMUSARIO.
        /// </summary>
        public FrmABMUsuario()
        {
            InitializeComponent();
        }

        public static bool validarEmail(string pCorreo)
        {
            return pCorreo != null && Regex.IsMatch(pCorreo,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
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
        /// Carga los valores de la tabla Rol en el ComboBox de Roles.
        /// </summary>
        private void cargarRoles()
        {
            try
            {
                cmbRoles.DisplayMember = "Rol_Descripcion";
                cmbRoles.ValueMember = "Rol_ID";
                cmbRoles.DataSource = TrabajarUsuario.listarRoles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Carga Usuarios desde la tabla Usuario, en el DataGridView de Usuarios.
        /// </summary>
        private void cargarUsuarios()
        {
            try
            {
                grvUsuarios.DataSource = TrabajarUsuario.listarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Limpia el valor de las etiquetas de propiedades de Usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                txtIDUsuario.Clear();
                txtNombreUsuario.Clear();
                txtApellido.Clear();
                txtNombre.Clear();
                txtEmail.Clear();
                txtContraseña.Clear();
                txtNombre.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAdministrador frmAdmin = new FrmAdministrador();
                frmAdmin.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void mostrarCantidadUsuarios()
        {
            int cantidadAdmins = TrabajarUsuario.contarUsuariosPorRol(1);
            int cantidadUsers = TrabajarUsuario.contarUsuariosPorRol(2);
            txtAdministradores.Text = cantidadAdmins.ToString();
            txtUsuarios.Text = cantidadUsers.ToString();
        }
        private void FrmABMUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                cargarRoles();
                cargarUsuarios();
                mostrarCantidadUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        /// <summary>
        /// Carga las etiquetas de propiedad de Usuario, según el elemento seleccionado del DataGridView de Usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grvUsuarios_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (grvUsuarios.CurrentRow != null)
                {
                    cmbRoles.SelectedValue = grvUsuarios.CurrentRow.Cells["Rol_ID"].Value.ToString();
                    txtApellido.Text = grvUsuarios.CurrentRow.Cells["Apellido"].Value.ToString();
                    txtNombre.Text = grvUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
                    txtEmail.Text = grvUsuarios.CurrentRow.Cells["E-Mail"].Value.ToString();
                    txtNombreUsuario.Text = grvUsuarios.CurrentRow.Cells["NombreUsuario"].Value.ToString();
                    txtContraseña.Text = grvUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
                    txtIDUsuario.Text = grvUsuarios.CurrentRow.Cells["Usu_ID"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();
                usuario.Usu_NombreUsuario = txtNombreUsuario.Text;
                usuario.Usu_Contraseña = txtContraseña.Text;
                usuario.Usu_Apellido = txtApellido.Text;
                usuario.Usu_Nombre = txtNombre.Text;
                usuario.Usu_Email = txtEmail.Text;
                usuario.Rol_ID = (int)cmbRoles.SelectedValue;
                
                if (TrabajarUsuario.buscarNombreUsuario(txtNombreUsuario.ToString()))
                {
                    MessageBox.Show("El usuario ya existe!");
                }
                else
                {
                    TrabajarUsuario.agregarUsuario(usuario);
                    MessageBox.Show("Usuario agregado con éxito!");
                    cargarUsuarios();
                    mostrarCantidadUsuarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Asigna los valores de las etiquetas a un Usuario nuevo.
        /// </summary>
        /// <returns>Objeto de tipo Usuario.</returns>
        private Usuario asignarUsuario()
        {
            Usuario usuario = new Usuario();
            usuario.Usu_ID = Convert.ToInt32(txtIDUsuario.Text);
            usuario.Usu_NombreUsuario = txtNombreUsuario.Text;
            usuario.Usu_Contraseña = txtContraseña.Text;
            usuario.Usu_Apellido = txtApellido.Text;
            usuario.Usu_Nombre = txtNombre.Text;
            usuario.Usu_Email = txtEmail.Text;
            usuario.Rol_ID = (int)cmbRoles.SelectedValue;
            return usuario;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                TrabajarUsuario.modificarUsuario(asignarUsuario());
                MessageBox.Show("Usuario modificado con éxito!");
                cargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                TrabajarUsuario.eliminarUsuario(asignarUsuario());
                MessageBox.Show("Usuario eliminado con éxito!");
                cargarUsuarios();
                mostrarCantidadUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean encontrado = TrabajarUsuario.buscarUsuarioBool(txtBuscar.Text);
                if (txtBuscar.Text != "" && encontrado)
                {
                    grvUsuarios.DataSource = TrabajarUsuario.buscarUsuario(txtBuscar.Text);
                    txtBuscar.Clear();
                    txtBuscar.Focus();
                }
                else
                {
                    MessageBox.Show("No se encontraron coincidencias...");
                    txtBuscar.Clear();
                    txtBuscar.Focus();
                    cargarUsuarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            cargarUsuarios();
        }

        ErrorProvider errorP = new ErrorProvider();
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            /*if(!validarEmail(txtEmail.Text)){
                errorP.SetError(txtEmail,"Correo no válido!");
            }*/
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsLetter(e.KeyChar)){
                e.Handled = false;
            }
            else if(char.IsSeparator(e.KeyChar)){
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                errorP.SetError(txtNombre, "Solo se permiten letras!");
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
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
                errorP.SetError(txtApellido, "Solo se permiten letras!");
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

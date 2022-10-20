using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    /// <summary>
    /// Representa un Usuario del sistema.
    /// </summary>
    public class Usuario
    {
        private int usu_ID;

        public int Usu_ID
        {
            get { return usu_ID; }
            set { usu_ID = value; }
        }
        private string usu_NombreUsuario;

        public string Usu_NombreUsuario
        {
            get { return usu_NombreUsuario; }
            set { usu_NombreUsuario = value; }
        }
        private string usu_Contraseña;

        public string Usu_Contraseña
        {
            get { return usu_Contraseña; }
            set { usu_Contraseña = value; }
        }
        private string usu_Apellido;

        public string Usu_Apellido
        {
            get { return usu_Apellido; }
            set { usu_Apellido = value; }
        }
        private string usu_Nombre;

        public string Usu_Nombre
        {
            get { return usu_Nombre; }
            set { usu_Nombre = value; }
        }
        private string usu_Email;

        public string Usu_Email
        {
            get { return usu_Email; }
            set { usu_Email = value; }
        }

        private int rol_ID;

        public int Rol_ID
        {
            get { return rol_ID; }
            set { rol_ID = value; }
        }        
    }
}

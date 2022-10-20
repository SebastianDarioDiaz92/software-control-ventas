using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    /// <summary>
    /// Representa un Rol en el sistema.
    /// </summary>
    public class Roles
    {
        private int rol_ID;

        public int Rol_ID
        {
            get { return rol_ID; }
            set { rol_ID = value; }
        }
        private string rol_Descripcion;

        public string Rol_Descripcion
        {
            get { return rol_Descripcion; }
            set { rol_Descripcion = value; }
        }
        private List<Roles> listaRoles = new List<Roles>();

        public List<Roles> ListaRoles
        {
            get { return listaRoles; }
            set { listaRoles = value; }
        }

        public Roles()
        {
        }
        /*
        public Roles(int Codigo, string Descripcion)
        {
            this.Rol_Codigo = Codigo;
            this.Rol_Descripcion = Descripcion;
        }

        public int Rol_Codigo
        {
            get { return rol_ID; }
            set { rol_ID = value; }
        }

        public string Rol_Descripcion
        {
            get { return rol_Descripcion; }
            set { rol_Descripcion = value; }
        }*/

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    /// <summary>
    /// Representa un Cliente del sistema.
    /// </summary>
    public class Cliente
    {
        private int cliente_ID;

        public int Cliente_ID
        {
            get { return cliente_ID; }
            set { cliente_ID = value; }
        }
        private string cliente_DNI;

        public string Cliente_DNI
        {
            get { return cliente_DNI; }
            set { cliente_DNI = value; }
        }
        private string cliente_Apellido;

        public string Cliente_Apellido
        {
            get { return cliente_Apellido; }
            set { cliente_Apellido = value; }
        }
        private string cliente_Nombre;

        public string Cliente_Nombre
        {
            get { return cliente_Nombre; }
            set { cliente_Nombre = value; }
        }
        private string cliente_Direccion;

        public string Cliente_Direccion
        {
            get { return cliente_Direccion; }
            set { cliente_Direccion = value; }
        }
        private string cliente_Email;

        public string Cliente_Email
        {
            get { return cliente_Email; }
            set { cliente_Email = value; }
        }
        private string cliente_Telefono;

        public string Cliente_Telefono
        {
            get { return cliente_Telefono; }
            set { cliente_Telefono = value; }
        }
    }
}

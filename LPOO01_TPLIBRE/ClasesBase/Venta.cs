using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    /// <summary>
    /// Representa una Venta en el sistema.
    /// </summary>
    public class Venta
    {
        private int venta_ID;

        public int Venta_ID
        {
            get { return venta_ID; }
            set { venta_ID = value; }
        }
        private DateTime venta_Fecha;

        public DateTime Venta_Fecha
        {
            get { return venta_Fecha; }
            set { venta_Fecha = value; }
        }
        private int cliente_ID;

        public int Cliente_ID
        {
            get { return cliente_ID; }
            set { cliente_ID = value; }
        }

        private string venta_Identificador;

        public string Venta_Identificador
        {
            get { return venta_Identificador; }
            set { venta_Identificador = value; }
        }

        private int usu_ID;

        public int Usu_ID
        {
            get { return usu_ID; }
            set { usu_ID = value; }
        }

        /*private List<Carrito> listaItems = new List<Carrito>();

        public List<Carrito> ListaItems
        {
            get { return listaItems; }
            set { listaItems = value; }
        }*/
    }
}

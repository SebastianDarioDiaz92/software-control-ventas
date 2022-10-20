using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    /// <summary>
    /// Representa Detalles en el sistema. Enlaza valores de Producto, Cliente y Venta.
    /// </summary>
    public class Detalle
    {
        private int detalle_ID;

        public int Detalle_ID
        {
            get { return detalle_ID; }
            set { detalle_ID = value; }
        }
        private decimal prod_PrecioUnitario;

        public decimal Prod_PrecioUnitario
        {
            get { return prod_PrecioUnitario; }
            set { prod_PrecioUnitario = value; }
        }
        private int prod_Cantidad;

        public int Prod_Cantidad
        {
            get { return prod_Cantidad; }
            set { prod_Cantidad = value; }
        }
        private decimal detalle_Total;

        public decimal Detalle_Total
        {
            get { return detalle_Total; }
            set { detalle_Total = value; }
        }
        private int prod_ID;

        public int Prod_ID
        {
            get { return prod_ID; }
            set { prod_ID = value; }
        }
        private string venta_Identificador;

        public string Venta_Identificador
        {
            get { return venta_Identificador; }
            set { venta_Identificador = value; }
        }
        private int cliente_ID;

        public int Cliente_ID
        {
            get { return cliente_ID; }
            set { cliente_ID = value; }
        }
    }
}

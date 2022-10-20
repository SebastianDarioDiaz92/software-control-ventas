using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    /// <summary>
    /// Representa un Item de Carrito.
    /// </summary>
    public class Carrito
    {
        public Carrito()
        {
        }
        public Carrito(int prod_ID,int prod_Cantidad,decimal prod_PrecioUnitario, decimal carrito_Total)
        {
            this.Prod_ID = prod_ID;
            this.Prod_Cantidad = prod_Cantidad;
            this.Prod_PrecioUnitario = prod_PrecioUnitario;
            this.Carrito_Total = carrito_Total;
        }


        private int carrito_ID;

        public int Carrito_ID
        {
            get { return carrito_ID; }
            set { carrito_ID = value; }
        }
        private int prod_ID;

        public int Prod_ID
        {
            get { return prod_ID; }
            set { prod_ID = value; }
        }
        private int prod_Cantidad;

        public int Prod_Cantidad
        {
            get { return prod_Cantidad; }
            set { prod_Cantidad = value; }
        }
        private decimal prod_PrecioUnitario;

        public decimal Prod_PrecioUnitario
        {
            get { return prod_PrecioUnitario; }
            set { prod_PrecioUnitario = value; }
        }
        private decimal carrito_Total;

        public decimal Carrito_Total
        {
            get { return carrito_Total; }
            set { carrito_Total = value; }
        }

        private int cliente_ID;

        public int Cliente_ID
        {
            get { return cliente_ID; }
            set { cliente_ID = value; }
        }

        
    }
}

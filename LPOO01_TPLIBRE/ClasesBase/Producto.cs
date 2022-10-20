using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    /// <summary>
    /// Representa un Producto en el sistema.
    /// </summary>
    public class Producto
    {
        private int prod_ID;

        public int Prod_ID
        {
            get { return prod_ID; }
            set { prod_ID = value; }
        }
        private string prod_Descripcion;

        public string Prod_Descripcion
        {
            get { return prod_Descripcion; }
            set { prod_Descripcion = value; }
        }
        private decimal prod_Precio;

        public decimal Prod_Precio
        {
            get { return prod_Precio; }
            set { prod_Precio = value; }
        }
        private int prod_Stock;

        public int Prod_Stock
        {
            get { return prod_Stock; }
            set { prod_Stock = value; }
        }

        private string prod_Categoria;

        public string Prod_Categoria
        {
            get { return prod_Categoria; }
            set { prod_Categoria = value; }
        }
    }
}

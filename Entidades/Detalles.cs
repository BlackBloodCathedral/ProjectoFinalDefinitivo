using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Detalles
    {
        public Detalles() { }

        private int Cantidad;
        private decimal Subtotal;
        private decimal Impuestos;
        private decimal Total;
        private int ID_Producto;
        private int ID_Factura;

        public int cantidad { get => Cantidad; set => Cantidad = value; }
        public decimal subtotal { get => Subtotal; set => Subtotal = value; }
        public decimal impuestos { get => Impuestos; set => Impuestos = value; }
        public decimal total { get => Total; set => Total = value; }
        public int idproducto { get => ID_Producto; set => ID_Producto = value; }
        public int idfactura { get => ID_Factura; set => ID_Factura = value; }
    }
}

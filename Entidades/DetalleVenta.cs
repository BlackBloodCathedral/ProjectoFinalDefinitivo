using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleVenta
    {
        public DetalleVenta() { }

        private int ID;
        private string Nombre;
        private decimal Precio;
        private int Cantidad;
        private decimal Subtotal;
        private decimal Impuestos;
        private decimal Total;

        public int id { get => ID; set => ID = value; }
        public string nombre { get => Nombre; set => Nombre = value; }
        public decimal precio { get => Precio; set => Precio = value; }
        public int cantidad { get => Cantidad; set => Cantidad = value; }
        public decimal subtotal { get => Subtotal; set => Subtotal = value; }
        public decimal impuestos { get => Impuestos; set => Impuestos = value; }
        public decimal total { get => Total; set => Total = value; }
    }
}

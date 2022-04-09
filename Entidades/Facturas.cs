using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Facturas : Usuarios
    {
        public Facturas() { }

        private int ID;
        private DateTime Fecha;
        private decimal Subtotal;
        private decimal Impuestos;
        private decimal Total;
        private string MetodoPago;
        private int ID_Producto;

        public int id { get => ID; set => ID = value; }
        public DateTime fecha { get => Fecha; set => Fecha = value; }
        public decimal subtotal { get => Subtotal; set => Subtotal = value; }
        public decimal impuestos { get => Impuestos; set => Impuestos = value; }
        public decimal total { get => Total; set => Total = value; }
        public string metodoPago { get => MetodoPago; set => MetodoPago = value; }
        public int idproducto { get => ID_Producto; set => ID_Producto = value; }
    }
}

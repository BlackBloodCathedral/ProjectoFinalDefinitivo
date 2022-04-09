using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Productos
    {
        public Productos()
        {

        }

        private int ID_Producto;
        private string Nombre;
        private string Precio; 

        public int idproducto
        {
            get { return ID_Producto; }
            set { ID_Producto = value; }
        }

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public string precio
        {
            get { return Precio; }
            set { Precio = value; }
        }
    }
}

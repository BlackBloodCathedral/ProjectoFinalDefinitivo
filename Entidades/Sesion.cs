using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sesion
    {
        string Nombre;
        int ID_Rol;
        string Nombre_Rol;

        public string nombre { get => Nombre; set => Nombre = value; }
        public int idrol { get => ID_Rol; set => ID_Rol = value; }
        public string nombrerol { get => Nombre_Rol; set => Nombre_Rol = value; }
    }
}

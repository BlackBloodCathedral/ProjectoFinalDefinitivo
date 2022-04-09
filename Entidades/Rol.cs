using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class Rol
    {
        int ID_Rol;
        string Detalle_Rol;

        public int idrol { get => ID_Rol; set => ID_Rol = value; }
        public string detalle { get => Detalle_Rol; set => Detalle_Rol = value;}
    }
}

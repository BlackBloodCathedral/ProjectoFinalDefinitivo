using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios : Personas 
    {
        int ID_Usuario;
        string Email;
        string Contrasena;
        int Rol;
        string Descripcion_Rol;

        public int idusuario { get => ID_Usuario; set => ID_Usuario = value; }
        public string email { get => Email; set => Email = value; }
        public string contrasena { get => Contrasena; set => Contrasena = value; }
        public int rol { get => Rol; set => Rol = value; }
        public string descripcion_rol { get => Descripcion_Rol; set => Descripcion_Rol = value; } 
    }
}

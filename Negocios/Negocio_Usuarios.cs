using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocios
{
    public class Negocio_Usuarios
    {
        private Datos_Usuarios UserAc = new Datos_Usuarios();
        public bool AgregarUsuario(Usuarios vpUsuario)
        {
            bool insertar = UserAc.AgregarUser(vpUsuario);

            return insertar;
        }

        public Sesion Loguear(Usuarios vpUsuario)
        {
            Sesion sesion = UserAc.Loguear(vpUsuario);

            return sesion;
        }

        public bool ActualizarUsuario(Usuarios vpUsuario)
        {
            bool actualizar = UserAc.ActualizarUser(vpUsuario);

            return actualizar;
        }

        public bool EliminarUsuario()
        {
            return true;
        }

        public List<Usuarios> ListarUsuarios()
        {
            List<Usuarios> vloUsuarios = UserAc.ListUser();

            return vloUsuarios;
        }
        public Usuarios BuscarUsuario(int vpCedula)
        {
            Usuarios vloUsuario = new Usuarios();
            vloUsuario = UserAc.BuscarUser(vpCedula);
            return vloUsuario;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class Datos_Rol : Datos_Conexion
    {
        public List<Rol> ListRoles()
        {
            List<Rol> RolList = new List<Rol>();
            Rol rol = null;
            try
            {
                if (Open())
                {
                    vCmd = new SqlCommand("ListRoles", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader read = vCmd.ExecuteReader();
                    while (read.Read())
                    {
                        rol = new Rol();
                        rol.idrol = int.Parse(read["ID_Rol"].ToString());
                        rol.detalle = read["Detalle_Rol"].ToString();
                        RolList.Add(rol);
                    }
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                Close();
            }
            return RolList;

        }
    }
}

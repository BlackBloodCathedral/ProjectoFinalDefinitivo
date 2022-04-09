using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Datos_Detalles : Datos_Conexion
    {
        DataTable dtDetalle;

        #region Detalles 
        public DataTable GetTblDetalle()
        {
            try
            {
                if (Open())
                {
                    Adaptador = new SqlDataAdapter("SelectDetalles", vCnx);
                    dtDetalle = new DataTable();
                    Adaptador.Fill(dtDetalle);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                vCnx.Close();
            }
            return dtDetalle;
        }
        #endregion

    }
}

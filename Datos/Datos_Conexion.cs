using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class Datos_Conexion
    {
        public SqlConnection vCnx;
        public SqlCommand vCmd;
        public SqlDataAdapter Adaptador;

        private static string server = "FDK";
        private static string bd = "Animaland";

        private string StringConexion = "Data Source=" + server + ";Initial Catalog=" + bd + ";Integrated Security=True";
        public bool Open()
        {
            try
            {
                vCnx = new SqlConnection(this.StringConexion);
                vCnx.Open();    
                return true;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        public void Close()
        {
            try
            {
                vCnx.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

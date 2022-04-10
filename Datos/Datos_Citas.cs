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
    public  class Datos_Citas : Datos_Conexion 
    {
        #region Citas Consecutivas
        public int CitasConsecutivas()
        {
            int ciconse = 0;

            try
            {
                if(Open())
                {
                    SqlCommand cmd = new SqlCommand("CitasConsecutivas", vCnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader read = cmd.ExecuteReader(); 
                    read.Read();
                    ciconse = int.Parse(read[0].ToString());
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                Close();
            }
            return ciconse;
        }
        #endregion

        #region Citas Nuevas
        public bool CitaNueva(Citas cita)
        {
            bool insertar = true; 
            SqlCommand cmd = new SqlCommand("AgregarCita", vCnx);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Cita", cita.idcita);
                cmd.Parameters.AddWithValue("@Servicio", cita.servicio);
                cmd.Parameters.AddWithValue("@Fecha_Cita", cita.fechacita);
                cmd.Parameters.AddWithValue("@Cliente", cita.cliente);

                vCnx.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                insertar = false;
            }
            finally
            {
                vCnx.Close();
            }
            return insertar;
        }
        #endregion

        #region Listar Citas 
        public List<Citas> ListCitas()
        {
            List<Citas> ListCita = new List<Citas>();
            Citas cita = null;
            try
            {
                if(Open())
                {
                    vCmd = new SqlCommand("MostrarCita", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader read = vCmd.ExecuteReader();
                    while(read.Read())
                    {
                        cita = new Citas();
                        cita.idcita = Int64.Parse(read["Id_Cita"].ToString());
                        cita.servicio = read["Servicio"].ToString();
                        cita.fechacita = DateTime.Parse(read["Fecha_Cita"].ToString());
                        cita.cliente = Int64.Parse(read["Cliente"].ToString());
                        cita.nombre = read["Nombre"].ToString();
                        ListCita.Add(cita);
                    }
                }
            }
            catch(Exception)
            {

            }
            finally
            {
                Close();
            }
            return ListCita;
        }
        #endregion

        #region Buscar Cita 
        public List<Citas> BusCita(int ID_Cita)
        {
            List<Citas> ListCita = new List<Citas>();
            Citas cita = null;
            try
            {
                if(Open())
                {
                    vCmd = new SqlCommand("BuscarCita", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("@Cedula", SqlDbType.Int).Value = ID_Cita;
                    SqlDataReader read = vCmd.ExecuteReader();
                    while (read.Read())
                    {
                        cita = new Citas();
                        cita.idcita = Int64.Parse(read["ID_Cita"].ToString());
                        cita.servicio = read["Servicio"].ToString();
                        cita.fechacita = DateTime.Parse(read["Fecha_Cita"].ToString());
                        cita.cliente = Int64.Parse(read["Cliente"].ToString());
                        cita.nombre = read["Nombre"].ToString();
                        ListCita.Add(cita);
                    }
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                Close();
            }
            return ListCita;
        }
        #endregion
    }
}

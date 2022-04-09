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
    public class Datos_Mascotas : Datos_Conexion 
    {
        #region Nueva Mascota 
        public bool NuevaMascota(Mascotas mascota)
        {
            SqlCommand cmd = new SqlCommand("AgregarMascota", vCnx);
            bool insertar = true;

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre_Mascota", mascota.nombremascota);
                cmd.Parameters.AddWithValue("@Especie", mascota.especie);
                cmd.Parameters.AddWithValue("@Raza", mascota.raza);
                cmd.Parameters.AddWithValue("@Edad", mascota.edad);
                cmd.Parameters.AddWithValue("@Genero", mascota.genero);
                cmd.Parameters.AddWithValue("@Dueño", mascota.idusuario);

                vCnx.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
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

        #region Listar Mascotas 
        public List<Mascotas> ListMascotas()
        {
            List<Mascotas> mascotaList = new List<Mascotas>();
            Mascotas mascota = null;
            try
            {
                if (Open())
                {
                    vCmd = new SqlCommand("MostrarMascotas", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader read = vCmd.ExecuteReader();
                    while (read.Read())
                    {

                        mascota = new Mascotas();
                        mascota.idmascota = int.Parse(read["ID_Mascota"].ToString());
                        mascota.nombremascota = read["Nombre_Mascota"].ToString();
                        mascota.especie = read["Especie"].ToString();
                        mascota.raza = read["Raza"].ToString();
                        mascota.edad = int.Parse(read["Edad"].ToString());
                        mascota.genero = read["Genero"].ToString();
                        mascota.idusuario = int.Parse(read["Dueño"].ToString());
                        mascotaList.Add(mascota);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Close();
            }
            return mascotaList;
        }
        #endregion

        #region Buscar Mascota 
        public Mascotas BuscarMascota(int ID_Mascota)
        {
            Mascotas mascota = null;
            try
            {
                if (Open())
                {
                    vCmd = new SqlCommand("BuscarMascota", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("@ID_Mascota", SqlDbType.Int).Value = ID_Mascota;

                    SqlDataReader read = vCmd.ExecuteReader();

                    while (read.Read())
                    {
                        mascota = new Mascotas();
                        mascota.idmascota = int.Parse(read["ID_Mascota"].ToString());
                        mascota.nombremascota = read["Nombre_Mascota"].ToString();
                        mascota.especie = read["Especie"].ToString();
                        mascota.raza = read["Raza"].ToString();
                        mascota.edad = int.Parse(read["Edad"].ToString());
                        mascota.genero = read["Genero"].ToString();
                        mascota.idusuario = int.Parse(read["Dueño"].ToString());
                    }
                }
            }
            catch (Exception error)
            {
                throw error;
            }

            finally
            {
                Close();
            }
            return mascota;
        }
        #endregion

        #region Actualizar Mascota 
        public bool ActualizarMascota(Mascotas masc)
        {
            bool actualizar = false;
            try
            {
                if (Open())
                {
                    vCmd = new SqlCommand("ActualizarMascota", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;

                    vCmd.Parameters.Add("@ID_Mascota", SqlDbType.Int).Value = masc.idmascota;
                    vCmd.Parameters.Add("@Nombre_Mascota", SqlDbType.NVarChar).Value = masc.nombremascota;
                    vCmd.Parameters.Add("@Especie", SqlDbType.NVarChar).Value = masc.especie;
                    vCmd.Parameters.Add("@Raza", SqlDbType.NVarChar).Value = masc.raza;
                    vCmd.Parameters.Add("@Edad", SqlDbType.Int).Value = masc.edad;
                    vCmd.Parameters.Add("@Genero", SqlDbType.NVarChar).Value = masc.genero;
                    vCmd.Parameters.Add("@Dueño", SqlDbType.Int).Value = masc.idusuario;

                    vCmd.ExecuteNonQuery();

                    actualizar = true;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
            finally
            {
                Close();
            }
            return actualizar;
        }
        #endregion

        #region Eliminar Mascota 
        public bool EliminarMascota(Mascotas masc)
        {
            bool borrar = false;
            try
            {
                if (Open())
                {
                    vCmd = new SqlCommand("EliminarMascota", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;

                    vCmd.Parameters.Add("@ID_Mascota", SqlDbType.Int).Value = masc.idmascota;

                    vCmd.ExecuteNonQuery();

                    borrar = true;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
            finally
            {
                Close();
            }
            return borrar;
        }
        #endregion     
    }
}


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
    public  class Datos_Usuarios : Datos_Conexion 
    {
        #region Agregar Usuario 
        public bool AgregarUser(Usuarios vpUsuario)
        {
            bool insertar = false;
            try
            {
                if(Open())
                {
                    vCmd = new SqlCommand("AgregarUsuario", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("@Cedula", SqlDbType.VarChar).Value = vpUsuario.cedula;
                    vCmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = vpUsuario.nombre;
                    vCmd.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = vpUsuario.apellidos;
                    vCmd.Parameters.Add("@Contrasena", SqlDbType.VarChar).Value = vpUsuario.contrasena;
                    vCmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = vpUsuario.email;
                    vCmd.Parameters.Add("@Telefono", SqlDbType.Int).Value = vpUsuario.telefono;
                    vCmd.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = vpUsuario.direccion;
                    vCmd.Parameters.Add("@Rol", SqlDbType.Int).Value = vpUsuario.rol;

                    vCmd.ExecuteNonQuery();

                    insertar = true;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                Close();
            }
            return insertar;
        }
        #endregion

        #region Actualizar Usuario 
        public bool ActualizarUser(Usuarios vpUsuario)
        {
            bool actualizar = false;
            try
            {
                if (Open()) ;
                {
                    vCmd = new SqlCommand("ActualizarUsuario", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("@ID_Usuario", SqlDbType.VarChar).Value = vpUsuario.idusuario;
                    vCmd.Parameters.Add("@Cedula", SqlDbType.VarChar).Value = vpUsuario.cedula;
                    vCmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = vpUsuario.nombre;
                    vCmd.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = vpUsuario.contrasena;
                    vCmd.Parameters.Add("@Contrasena", SqlDbType.VarChar).Value = vpUsuario.apellidos;
                    vCmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = vpUsuario.email;
                    vCmd.Parameters.Add("@Telefono", SqlDbType.Int).Value = vpUsuario.telefono;
                    vCmd.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = vpUsuario.direccion;
                    vCmd.Parameters.Add("@Rol", SqlDbType.Int).Value = vpUsuario.rol;

                    vCmd.ExecuteNonQuery();

                    actualizar = true;
                }
            }
            catch(Exception e)
            {

            }
            finally
            {
                Close();
            }
            return actualizar;
        }
        #endregion

        #region Listar Usuarios
        public List<Usuarios> ListUser()
        {
            List<Usuarios> ListRol = new List<Usuarios>();
            Usuarios user = null;
            try
            {
                if(Open())
                {
                    vCmd = new SqlCommand("ListUsuarios", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader read = vCmd.ExecuteReader();
                    while(read.Read())
                    {
                        user = new Usuarios();
                        user.idusuario = int.Parse(read["ID_Usuario"].ToString());
                        user.cedula = int.Parse(read["Cedula"].ToString());
                        user.nombre = read["Nombre"].ToString();
                        user.contrasena = read["Apellidos"].ToString();
                        user.apellidos = read["Contrasena"].ToString();
                        user.email = read["Email"].ToString();
                        user.telefono = int.Parse(read["Telefono"].ToString());
                        user.direccion = read["Direccion"].ToString();
                        user.descripcion_rol = read["Detalle_Rol"].ToString();
                        user.rol = int.Parse(read["ID_Rol"].ToString());
                        ListRol.Add(user);
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
            return ListRol;
        }
        #endregion

        #region Login 
        public Sesion Loguear(Usuarios vpUsuario)
        {
            Sesion sesion;
            sesion = null;
            
            try
            {
                if(Open())
                {
                    vCmd = new SqlCommand("Ingresar", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = vpUsuario.email;
                    vCmd.Parameters.Add("@Contrasena", SqlDbType.VarChar).Value = vpUsuario.contrasena;

                    SqlDataReader read = vCmd.ExecuteReader();
                    while(read.Read())
                    {
                        sesion = new Sesion();
                        sesion.nombre = read["Nombre"].ToString() + " " + read["Apellidos"].ToString();
                        sesion.idrol = int.Parse(read["ID_Rol"].ToString());
                        sesion.nombrerol = read["Detalle_Rol"].ToString();
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
            return sesion;
        }
        #endregion

        #region Buscar Usuario
        public Usuarios BuscarUser(int cedula)
        {
            Usuarios usuario;
            usuario = null;

            try
            {
                if(Open())
                {
                    vCmd = new SqlCommand("ObtCedUsu", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("@Cedula", SqlDbType.Int).Value = cedula;

                    SqlDataReader read = vCmd.ExecuteReader();
                    while(read.Read())
                    {
                        usuario = new Usuarios();
                        usuario.idusuario = int.Parse(read["ID_Usuario"].ToString());
                        usuario.cedula = int.Parse(read["Cedula"].ToString());
                        usuario.nombre = read["Nombre"].ToString();
                        usuario.apellidos = read["Apellidos"].ToString();
                        usuario.direccion = read["Direccion"].ToString();
                        usuario.email = read["Email"].ToString();
                        usuario.telefono = int.Parse(read["Telefono"].ToString());
                        usuario.rol = int.Parse(read["Rol"].ToString());
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
            return usuario;
        }
        #endregion
    }
}

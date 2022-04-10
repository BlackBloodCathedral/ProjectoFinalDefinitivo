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
    public class Datos_Facturas : Datos_Conexion
    {
        DataTable dtFacturas;

        #region Metodos Factura
        public int ID_Factura()
        {
            int idFactura = 0;

            try
            {
                if(Open())
                {
                    vCmd = new SqlCommand("SelectNumFactu", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader read = vCmd.ExecuteReader();
                    read.Read();
                    idFactura = int.Parse(read[0].ToString());
                }
            }
            catch(Exception e)
            {

            }
            finally
            {
                Close();
            }
            return idFactura;
        }
        public int AgregarFactu(Facturas factura)
        {
            int num = 0;

            try
            {
                if(Open())
                {
                    vCmd = new SqlCommand("InsertarFactura", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;

                    vCmd.Parameters.Add("@ID_Factura", SqlDbType.Int).Value = factura.id;
                    vCmd.Parameters.Add("@Fecha_Facturacion", SqlDbType.DateTime).Value = factura.fecha;
                    vCmd.Parameters.Add("@Subtotal", SqlDbType.Decimal).Value = factura.subtotal;
                    vCmd.Parameters.Add("@Impuestos", SqlDbType.Decimal).Value = factura.impuestos;
                    vCmd.Parameters.Add("@Total", SqlDbType.Decimal).Value = factura.total;
                    vCmd.Parameters.Add("@MetodoPago", SqlDbType.VarChar).Value = factura.metodoPago;
                    vCmd.Parameters.Add("@Cliente", SqlDbType.Int).Value = factura.idusuario;
                    vCmd.ExecuteNonQuery();

                    Facturas fact = BuscarFactura(factura.id);
                    num = fact.id;
                }
            }
            catch(Exception e)
            {

            }
            finally
            {
                Close();
            }
            return num; 
        }
        public Facturas BuscarFactura(int Factnum)
        {
            Facturas fact = null;

            try
            {
                if(Open())
                {
                    vCmd = new SqlCommand("SelectIDFactu", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;

                    vCmd.Parameters.Add("@ID_Factura", SqlDbType.Int).Value = Factnum;
                    SqlDataReader read = vCmd.ExecuteReader();


                    while (read.Read())
                    {
                        fact = new Facturas();
                        fact.id = int.Parse(read["ID_Factura"].ToString());
                        fact.fecha = DateTime.Parse(read["Fecha_Facturacion"].ToString());
                        fact.subtotal = decimal.Parse(read["Subtotal"].ToString());
                        fact.impuestos = decimal.Parse(read["Impuestos"].ToString());
                        fact.total = decimal.Parse(read["Total"].ToString());
                        fact.metodoPago = read["MetodoPago"].ToString();
                        fact.idusuario = int.Parse(read["Cliente"].ToString());
                    }
                }
            }
            catch(Exception e)
            {

            }
            finally
            {
                Close();
            }
            return fact;
        }
        public DataTable GetTblFacturas()
        {
            try
            {
                if (Open())
                {
                    Adaptador = new SqlDataAdapter("SelectFactu", vCnx);
                    dtFacturas = new DataTable();
                    Adaptador.Fill(dtFacturas);
                }
            }
            catch(Exception e)
            {

            }
            finally
            {
                vCnx.Close();
            }
            return dtFacturas;
        }
        #endregion

        #region Metodos Detalle 
        public bool AgregarDetalle(Detalles detalle)
        {
            bool insertar = false;

            try
            {
                if (Open())
                {
                    vCmd = new SqlCommand("InsertarDetalle", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;

                    vCmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = detalle.cantidad;
                    vCmd.Parameters.Add("@Subtotal_Detalle", SqlDbType.Decimal).Value = detalle.subtotal;
                    vCmd.Parameters.Add("@Impuestos_Detalle", SqlDbType.Decimal).Value = detalle.impuestos;
                    vCmd.Parameters.Add("@Total_Detalle", SqlDbType.Decimal).Value = detalle.total;
                    vCmd.Parameters.Add("@Articulos", SqlDbType.Int).Value = detalle.idproducto;
                    vCmd.Parameters.Add("@Factura", SqlDbType.Int).Value = detalle.idfactura;
                    vCmd.ExecuteNonQuery();

                    insertar = true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Close();
            }
            return insertar;
        }
        #endregion
    }
}

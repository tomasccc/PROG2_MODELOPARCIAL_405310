using ModeloParcial405310.DOMINIO;
using ModeloParcial405310.INTERFACES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial405310.DATOS
{
    internal class OrdenDAO:IOrdenDAO
    {
        public OrdenDAO() { }

        public bool ConfirmarOrden(OrdenRetiro o)
        {
            bool resultado=true;
            SqlTransaction t = null;
            SqlConnection conn = DBHelper.GetInstance().ObtenerConexion();
            try
            {
                conn.Open();
                t=conn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_INSERTAR_ORDEN",conn,t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@responsable",o.Presponsable);
                cmd.Parameters.AddWithValue("@fecha",o.Pfecha);
                SqlParameter param=new SqlParameter("@nro",SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                int nroOrden=(int)param.Value;
                int i=1;
                foreach (DetalleOrden d in o.Plistadetalles)
                {
                    SqlCommand cmd2 = new SqlCommand("SP_INSERTAR_DETALLES", conn, t);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@nro_orden",nroOrden);
                    cmd2.Parameters.AddWithValue("@detalle",i);
                    cmd2.Parameters.AddWithValue("@codigo",d.material.codigo);
                    cmd2.Parameters.AddWithValue("@cantidad",d.cantidad);
                    cmd2.ExecuteNonQuery();
                    i++;
                }
                t.Commit();

            }catch (SqlException)
            {
                if (t != null)
                {
                    t.Rollback();
                    resultado=false;
                }
            }finally { 
                conn.Close();
                     }
            return resultado;
        }

        public DataTable TraerMateriales()
        {
            return DBHelper.GetInstance().Consultar("SP_CONSULTAR_MATERIALES");
        }

        public int TraerOrdenNro()
        {
            return DBHelper.GetInstance().ConsultarEscalar("SP_PROXIMA_ORDEN","@next");
        }


    }
}

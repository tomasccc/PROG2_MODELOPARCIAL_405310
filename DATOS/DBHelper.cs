using ModeloParcial405310.DOMINIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial405310.DATOS
{
    internal class DBHelper
    {
        public static DBHelper Instance { get; set; } 
        string conexion = "Data Source=DESKTOP-KFQ7MV9\\SQLEXPRESS;Initial Catalog=db_ordenes;Integrated Security=True";
        SqlConnection conn;
        private DBHelper() { 
            conn = new SqlConnection(conexion);
        }

        public static DBHelper GetInstance()
        {
            if (Instance == null)
            {
                Instance = new DBHelper();
            }
            return Instance;
        }

        public SqlConnection ObtenerConexion()
        {
            return conn;
        }

        public DataTable Consultar(string nombreSP)
        {
            conn.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conn.Close();
            return tabla;
        }

        public int ConsultarEscalar(string nombreSP,string nombreParam)
        {
            conn.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            SqlParameter param=new SqlParameter(nombreParam,SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            comando.Parameters.Add(param);
            comando.ExecuteNonQuery();
            int escalar = (int)param.Value;
            conn.Close();
            return escalar;
        }

        internal DataTable Consultar(string nombreSP, List<Parametro> parametros)
        {
            conn.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            foreach (Parametro p in parametros)
            {
                comando.Parameters.AddWithValue(p.nombre, p.valor);
            }
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conn.Close();
            return tabla;
        }

    }
}

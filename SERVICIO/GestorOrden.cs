using ModeloParcial405310.DATOS;
using ModeloParcial405310.DOMINIO;
using ModeloParcial405310.INTERFACES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial405310.SERVICIO
{
    public class GestorOrden : IGestorOrden
    {
        IOrdenDAO dao=null;

        public GestorOrden()
        {
            dao= new OrdenDAO();
        }
        public int TraerNroOrden()
        {
            return dao.TraerOrdenNro();
        }
        
        public List<Material> TraerListaMateriales()
        {
            List<Material> list = new List<Material>();
            DataTable dt= dao.TraerMateriales();
            foreach (DataRow fila in dt.Rows)
            {
                Material material = new Material();
                material.codigo = (int)fila["codigo"];
                material.nombre= fila["nombre"].ToString();
                material.stock = (int)fila["stock"];
                list.Add(material);
            }
            return list;
        }

        public bool ConfirmarOrden(OrdenRetiro o)
        {
            return dao.ConfirmarOrden(o);
        }
    }
}

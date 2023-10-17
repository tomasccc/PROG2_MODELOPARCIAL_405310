using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial405310.DOMINIO
{
    public class OrdenRetiro
    {
        List<DetalleOrden> listadetalles;
        int nroOrden;
        DateTime fecha;
        string responsable;

        public OrdenRetiro()
        {
            listadetalles = new List<DetalleOrden>();
        }
        public int PnroOrden { get { return nroOrden; } set { nroOrden = value; } }
        public List<DetalleOrden> Plistadetalles { get { return listadetalles; } set { listadetalles = value; } }
        public string Presponsable { get { return responsable; } set { responsable = value; } }
        public DateTime Pfecha { get { return fecha; } set {  fecha = value; } }

        public void QuitarDetalle(int detallenro)
        {
            listadetalles.RemoveAt(detallenro);
        }
    }
}

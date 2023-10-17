using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial405310.DOMINIO
{
    public class DetalleOrden
    {
        public Material material { get; set; }
        public int cantidad {  get; set; }
        public int ID {  get; set; }

        public DetalleOrden() { }
    }
}

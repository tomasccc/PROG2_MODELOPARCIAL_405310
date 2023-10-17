using ModeloParcial405310.SERVICIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial405310.FABRICA
{
    internal class FactoryGestorOrdenImp : FactoryGestorOrden
    {
        public override GestorOrden CrearServicio()
        {
            return new GestorOrden();
        }
    }
}

using ModeloParcial405310.SERVICIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial405310.FABRICA
{
    abstract class FactoryGestorOrden
    {
        public abstract GestorOrden CrearServicio();
    }
}

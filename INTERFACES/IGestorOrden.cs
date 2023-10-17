using ModeloParcial405310.DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial405310.INTERFACES
{
    internal interface IGestorOrden
    {
        int TraerNroOrden();
        bool ConfirmarOrden(OrdenRetiro o);
        List<Material> TraerListaMateriales();
    }
}

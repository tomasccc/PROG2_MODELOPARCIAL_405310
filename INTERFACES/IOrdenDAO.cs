using ModeloParcial405310.DOMINIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial405310.INTERFACES
{
    internal interface IOrdenDAO
    {
        int TraerOrdenNro();
        bool ConfirmarOrden(OrdenRetiro o);
        DataTable TraerMateriales();
    }
}

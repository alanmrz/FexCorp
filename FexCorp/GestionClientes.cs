using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FexCorp
{
    class GestionClientes
    {
        public void ObtenerTodosLosClientes(String nombreTabla, ref DataSet ds)
        {
            AccesoDatos ad = new AccesoDatos();
            ad.cargaTabla(nombreTabla, "select * from Cliente", ref ds);
        }
    }
}

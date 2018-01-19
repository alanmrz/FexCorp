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

        private DataTable ObtenerTabla(String nombre, String sql)
        {
            DataSet ds = new DataSet();
            AccesoDatos datos = new AccesoDatos();
            SqlDataAdapter adp = datos.ObtenerAdaptador(sql);
            adp.Fill(ds, nombre);
            return ds.Tables[nombre];
        }

        public DataTable ObtenerTodos()
        {
            return ObtenerTabla("Clientes", "Select * from Cliente");
        }

        public DataTable ObtenerDni(String dni)
        {
            return ObtenerTabla("Clientes", "Select * from CLiente where DNI=" + dni);
        }

    }
}

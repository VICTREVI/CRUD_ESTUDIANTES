using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CRUD_ESTUDIANTES
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER=DESKTOP-9PN24R3;DATABASE=Registro;integrated security=true;");
            cn.Open();
            return cn;

        }
    }
}

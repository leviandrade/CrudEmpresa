using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEmpresa.Infra.Data.Repositorios
{
    public class DbConnect
    {
        public static SqlConnection Connection => new SqlConnection(ConnectionString);

        public static string ConnectionString
        {
            get
            {
                return $@"Server=LAPTOP-MPDEFR5C\SQLEXPRESS; Database=CrudEmpresa; persist security info=True; Integrated Security=SSPI;";
            }
        }
    }
}

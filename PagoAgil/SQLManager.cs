using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil
{
    class SQLManager
    {
        public static SqlConnection SQLConnection()
        {
            var setting = ConfigurationManager.AppSettings["SQLSetting"].ToString();
            SqlConnection connection = new SqlConnection(setting);
            connection.Open();

            return connection;
        }

        public static String SchemaName()
        {
            return ConfigurationManager.AppSettings["SQLSchemaName"].ToString();
        }
    }
}

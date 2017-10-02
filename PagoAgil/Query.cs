using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil
{
    class Query
    {
        public static Boolean ValidateUser(String username, String password)
        {
            /* TODO: Encriptar password */

            SqlCommand userQuery = new SqlCommand();

            userQuery.Connection = PagoAgil.SQLManager.SQLConnection();
            userQuery.CommandType = CommandType.Text;
            userQuery.CommandText = "SELECT PASSWORD" +
                                    "FROM [SERVOMOTOR]" +
                                    "WHERE USERNAME = " + username;

            var dataReader = userQuery.ExecuteReader();

            if (dataReader.HasRows)
                return password.Equals(dataReader.GetString(0));

            return false;
        }
    }
}

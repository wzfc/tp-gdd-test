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
        private static SqlCommand InitSqlCommand(String commandText)
        {
            SqlCommand query = new SqlCommand();

            query.Connection = PagoAgil.SQLManager.SQLConnection();
            query.CommandType = CommandType.Text;
            query.CommandText = commandText;

            return query;
        }

        public static Boolean ValidateUser(String username, String password)
        {
            /* TODO: Encriptar password */

            var queryText = new QueryText().Select("PASSWORD, CANT_INT_FALL, HABILITADO")
                                           .From("USUARIOS")
                                           .Where("USERNAME = \'" + username + "\'");

            var userQuery = InitSqlCommand(queryText.Text);
            var dataReader = userQuery.ExecuteReader();

            if (dataReader.Read()
                && (bool)dataReader["HABILITADO"]
                && password.Equals(dataReader["PASSWORD"]))
                return true;

            if (dataReader.HasRows)
            {
                var failedAttempts = (byte)dataReader["CANT_INT_FALL"] + 1;

                queryText = new QueryText().Update("USUARIOS")
                                           .Append(" SET CANT_INT_FALL = " + failedAttempts);

                if (failedAttempts >= 3)
                    queryText.Append(", HABILITADO = 0 ");

                queryText.Where("USERNAME = \'" + username + "\'");

                InitSqlCommand(queryText.Text).ExecuteNonQuery();
            }

            return false;
        }
    }
}

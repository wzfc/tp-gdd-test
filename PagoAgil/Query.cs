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
            var cmd = new SqlCommand(commandText, SQLManager.SQLConnection());
            return cmd;
        }

        public static Boolean ValidateUser(String username, String password)
        {
            String passwordHash = Cryptography.getSHA256String(password);

            var userQuery = InitSqlCommand(
                "SELECT PASSWORD, CANT_INT_FALL, HABILITADO " +
                "FROM " + SQLManager.SchemaName + ".USUARIOS " +
                "WHERE USERNAME = @USERNAME"
            );

            userQuery.Parameters.Add("@USERNAME", SqlDbType.VarChar, 20).Value = username;

            var dataReader = userQuery.ExecuteReader();

            if (dataReader.Read()
                && (bool)dataReader["HABILITADO"]
                && passwordHash.Equals(dataReader["PASSWORD"]))
                return true;

            if (dataReader.HasRows)
            {
                var failedAttempts = (byte)dataReader["CANT_INT_FALL"] + 1;
                var habilitado = failedAttempts >= 3 ? 0 : 1;

                var updateQuery = InitSqlCommand(
                    "UPDATE " + SQLManager.SchemaName + ".USUARIOS " +
                    "SET CANT_INT_FALL = @CANT_INT_FALL, HABILITADO = @HABILITADO " +
                    "WHERE USERNAME = @USERNAME"
                );

                updateQuery.Parameters.Add("@CANT_INT_FALL", SqlDbType.TinyInt).Value = failedAttempts;
                updateQuery.Parameters.Add("@HABILITADO", SqlDbType.Bit).Value = habilitado;
                updateQuery.Parameters.Add("@USERNAME", SqlDbType.VarChar, 20).Value = username;

                updateQuery.ExecuteNonQuery();
            }

            return false;
        }
    }
}

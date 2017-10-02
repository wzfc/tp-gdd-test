using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserLogin());
        }

        static SqlConnection SQLConnection()
        {
            var setting = ConfigurationManager.AppSettings["SQLSetting"].ToString();
            SqlConnection connection = new SqlConnection(setting);
            connection.Open();

            return connection;
        }
    }
}

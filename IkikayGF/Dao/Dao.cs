using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Librairie MySQL
using MySql.Data.MySqlClient;

namespace IkikayGF.Dao
{
    class Dao
    {
        //Attributs
        protected static MySqlConnection conn = null;

        //Méthodes
        protected static void open()
        {
            string cs = @"server=localhost;userid=root;password=;database=IkikayGF";
            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                Console.WriteLine("MySQL version : {0}", conn.ServerVersion);

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
        }
        protected static void close()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}

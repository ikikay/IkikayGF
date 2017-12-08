using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Librairie MySQL
using MySql.Data.MySqlClient;
using System.Data;

// Classes du projets
using IkikayGF.Classes;


namespace IkikayGF.Dao
{
    class DaoMouvement : Dao
    {
        public static void create(Mouvement unMouvement)
        {
            try
            {
                open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO `mouvement`(`libelle`, `credit_debit`) VALUES (@libelle, @crediDebit)";

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@libelle", unMouvement.Libelle);
                cmd.Parameters.AddWithValue("@crediDebit", unMouvement.Credit_debit);

                cmd.ExecuteNonQuery();

                unMouvement.Id = (int)cmd.LastInsertedId;

                close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
        }

        public static Mouvement readOne(string id)
        {
            Mouvement leMouvement = null;

            try
            {
                open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM mouvement WHERE id=" + id;

                MySqlDataReader res = cmd.ExecuteReader();

                res.Read();
                leMouvement = new Mouvement(Convert.ToInt16(res["id"]), (string)res["libelle"], Convert.ToBoolean(res["credit_debit"]));

                close();

                return leMouvement;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

                return leMouvement;
            }
        }

        public static DataTable dtReadAll()
        {
            DataTable dtMouvement = new DataTable();

            try
            {
                open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM mouvement";

                MySqlDataReader res = cmd.ExecuteReader();

                dtMouvement.Load(res);

                close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

                return dtMouvement;
            }

            return dtMouvement;
        }

        public static Boolean update(Mouvement actuelMouvement, Mouvement nouveauMouvement)
        {
            try
            {
                open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE `mouvement` SET libelle=@libelle,credit_debit=@creditDebit  WHERE `id`=" + actuelMouvement.Id;

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@libelle", nouveauMouvement.Libelle);
                cmd.Parameters.AddWithValue("@creditDebit", nouveauMouvement.Credit_debit);

                cmd.ExecuteNonQuery();

                close();

                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                return false;
            }
        }

        public static void delete(string unId)
        {
            try
            {
                open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM `mouvement` WHERE id=" + unId;

                cmd.ExecuteNonQuery();

                close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
        }
    }
}

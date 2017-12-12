using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Librairie MySQL
using MySql.Data.MySqlClient;

// Classes du projets
using IkikayGF.Classes;
using System.Data;

namespace IkikayGF.Dao
{
    class DaoCategorie : Dao
    {
        public static void create(Categorie uneCategorie)
        {
            try
            {
                open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO `categorie`(`libelle`) VALUES (@libelle)";

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@libelle", uneCategorie.Libelle);

                cmd.ExecuteNonQuery();

                uneCategorie.Id = (int)cmd.LastInsertedId;

                close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
        }

        public static DataTable dtReadAll()
        {
            DataTable dtCategorie = new DataTable();

            try
            {
                open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM categorie";

                MySqlDataReader res = cmd.ExecuteReader();

                dtCategorie.Load(res);

                close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

                return dtCategorie;
            }

            return dtCategorie;
        }

        public static Boolean update(Categorie uneCategorie, String nouveauLibelle)
        {
            try
            {
                open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE `categorie` SET `libelle`=@libelle WHERE `id`=" + uneCategorie.Id;

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@libelle", nouveauLibelle);

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

        public static void delete(Categorie uneCategorie)
        {
            try
            {
                open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM `categorie` WHERE id=" + uneCategorie.Id;

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

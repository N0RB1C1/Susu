using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Zarodoga
{
    static class Adatbazis
    {
        private static MySqlConnection kapcsolodas;

        // Kapcsolódás
        public static void Kapcsolodas()
        {
            try
            {
                string kapcsolatString =
                        "SERVER=localhost;" +
                        "DATABASE=jatekhoz;" +
                        "UID=root;" +
                        "PASSWORD=;" +
                        "CHARSET=utf8;";
                kapcsolodas = new MySqlConnection(kapcsolatString);
                kapcsolodas.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Kapcsolat bontása
        public static void KapcsolatBontas()
        {
            if (kapcsolodas != null)
            {
                kapcsolodas.Close();
            }
        }

        // Adatbázis létrehozása (Players / Player)
        public static void Adatbazisletrehozas()
        {

            string kapcsolatString =
                    "SERVER=localhost;" +
                    "DATABASE=jatekhoz;" +
                    "UID=root;" +
                    "PASSWORD=;" +
                    "CHARSET=utf8;";
            try
            {
                MySqlConnection kapcsolodas = new MySqlConnection(kapcsolatString);
                MySqlCommand parancs = kapcsolodas.CreateCommand();
                kapcsolodas.Open();
                string sql = "CREATE DATABASE IF NOT EXISTS Players";
                MySqlCommand cmd = new MySqlCommand(sql, kapcsolodas);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
                kapcsolodas.Close();
            }
            catch (Exception e) { Console.WriteLine(e); }

            try
            {
                MySqlConnection kapcsolodas = new MySqlConnection(kapcsolatString);
                MySqlCommand parancs = kapcsolodas.CreateCommand();
                kapcsolodas.Open();
                string sql = "CREATE TABLE Players.Player (id INT NOT NULL AUTO_INCREMENT , username VARCHAR(128) NOT NULL , password VARCHAR(128) NOT NULL , PRIMARY KEY (id)) ENGINE = MyISAM; ";
                MySqlCommand cmd = new MySqlCommand(sql, kapcsolodas);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
                kapcsolodas.Close();
            }
            catch (Exception e) { Console.WriteLine(e); }

        }

        // Insert into (Username , Password)
        public static void InsertInto(string user,string pass)
        {
            string name = user;
            string password =pass;

            string kapcsolatString =
                    "SERVER=localhost;" +
                    "DATABASE=Players;" +
                    "UID=root;" +
                    "PASSWORD=;" +
                    "CHARSET=utf8;";

                MySqlConnection kapcsolodas = new MySqlConnection(kapcsolatString);
                MySqlCommand parancs = kapcsolodas.CreateCommand();
                kapcsolodas.Open();
                string sql = "INSERT INTO player(username,password)" +
                "VALUES(@param1,@param2)";
                MySqlCommand cmd = new MySqlCommand(sql, kapcsolodas);
                cmd.Parameters.Add("@param1", MySqlDbType.Text).Value = name;
                cmd.Parameters.Add("@param2", MySqlDbType.Text).Value = password;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
                kapcsolodas.Close();
                
        }

        // Select (Username & Password)
        public static int Select(string username, string password)
        {
            int i = 0;
            string kapcsolatString =
                    "SERVER=localhost;" +
                    "DATABASE=jatekhoz;" +
                    "UID=root;" +
                    "PASSWORD=;" +
                    "CHARSET=utf8;";
            MySqlConnection kapcsolodas = new MySqlConnection(kapcsolatString);
            MySqlCommand parancs = kapcsolodas.CreateCommand();
            kapcsolodas.Open();
            string sql = "SELECT * FROM jatekos WHERE user_name = " +
            "(@param1)" + 
            "and user_password = " +
            "(@param2)";
            MySqlCommand cmd = new MySqlCommand(sql, kapcsolodas);
            cmd.Parameters.Add("@param1", MySqlDbType.Text).Value = username;
            cmd.Parameters.Add("@param2", MySqlDbType.Text).Value = password;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                kapcsolodas.Close();
                return 0;
            }
            else
            {
                kapcsolodas.Close();
                return 1;
            }
        }

    }
}

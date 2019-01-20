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
        private static string homeServerWithout =
                "SERVER=localhost;" +
                "DATABASE=;" +
                "UID=root;" +
                "PASSWORD=;" +
                "CHARSET=utf8;";
        private static string homeServerWithin =
                "SERVER=localhost;" +
                "DATABASE=Players;" +
                "UID=root;" +
                "PASSWORD=;" +
                "CHARSET=utf8;";
        private static MySqlConnection kapcsolodasempty = new MySqlConnection(homeServerWithout);
        private static MySqlConnection kapcsolodas = new MySqlConnection(homeServerWithin);
        private static MySqlCommand command;


        // Adatbázis létrehozása (Players / Player)
        public static void Adatbazisletrehozas()
        {

            try
            {
                kapcsolodasempty.Open();
                command = kapcsolodasempty.CreateCommand();
                string create = "CREATE DATABASE IF NOT EXISTS Players";
                string tables = "CREATE TABLE Players.Player (id INT NOT NULL AUTO_INCREMENT , username VARCHAR(128) NOT NULL , password VARCHAR(128) NOT NULL , PRIMARY KEY (id)) ENGINE = MyISAM; ";
                command = new MySqlCommand(create, kapcsolodasempty);
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();
                command = new MySqlCommand(tables, kapcsolodasempty);
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();
                kapcsolodasempty.Close();
            }
            catch (Exception e) { Console.WriteLine(e); }
        }


        // Insert into (Username , Password)
        public static void InsertInto(string user, string pass)
        {
            string name = user;
            string password = pass;

            try
            {
                kapcsolodas.Open();
                command = kapcsolodas.CreateCommand();
                string sql = "INSERT INTO player(username,password)" +
                "VALUES(@param1,@param2)";
                MySqlCommand cmd = new MySqlCommand(sql, kapcsolodas);
                cmd.Parameters.Add("@param1", MySqlDbType.Text).Value = name;
                cmd.Parameters.Add("@param2", MySqlDbType.Text).Value = password;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
                kapcsolodas.Close();
            }
            catch (Exception e) { Console.WriteLine(e); }

        }

        // Select username for register ()
        public static int RegisterCheck(string username)
        {
            string i = null;
            try
            {
                kapcsolodas.Open();
                command = kapcsolodas.CreateCommand();
                string sql = "SELECT username FROM player WHERE username = " +
                "(@param1)";
                command = new MySqlCommand(sql, kapcsolodas);
                command.Parameters.Add("@param1", MySqlDbType.Text).Value = username;
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(command);
                da.Fill(dt);
                i = (dt.Rows.Count.ToString());
            }
            catch (Exception e) { Console.WriteLine(e); }
            if (i.Equals(null))
            {
                kapcsolodas.Close();
                return 1;
            }
            else
            {
                kapcsolodas.Close();
                return 0;
            }


        }


        // Select id for login (Username & Password)
        public static int Select2(string username, string password)
        {
            int i = 0;
            try
            {
                kapcsolodas.Open();
                command = kapcsolodas.CreateCommand();
                string sql = "SELECT id FROM player WHERE username = " +
                "(@param1)" +
                "and password = " +
                "(@param2)";
                command = new MySqlCommand(sql, kapcsolodas);
                command.Parameters.Add("@param1", MySqlDbType.Text).Value = username;
                command.Parameters.Add("@param2", MySqlDbType.Text).Value = password;
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(command);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
            }
            catch (Exception e) { Console.WriteLine(e); }
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


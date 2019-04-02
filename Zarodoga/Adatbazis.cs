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


        // Adatbázis létrehozása (Players / Player / Loot)
        public static void Adatbazisletrehozas()
        {

            try
            {
                kapcsolodasempty.Open();
                command = kapcsolodasempty.CreateCommand();
                string create = "CREATE DATABASE IF NOT EXISTS Players";
                string tables = "CREATE TABLE Players.Player (id INT NOT NULL AUTO_INCREMENT , username VARCHAR(128) NOT NULL , password VARCHAR(128) NOT NULL , PRIMARY KEY (id)) ENGINE = MyISAM; ";
                string tables_second = "CREATE TABLE players.loot (player_id INT NOT NULL AUTO_INCREMENT, arany INT NOT NULL, tapasztalati_pont INT NOT NULL, jogosultsag INT NOT NULL, palya INT NOT NULL, PRIMARY KEY(player_id)) ENGINE = MyISAM; ";
                command = new MySqlCommand(create, kapcsolodasempty);
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();
                command = new MySqlCommand(tables, kapcsolodasempty);
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();
                command = new MySqlCommand(tables_second, kapcsolodasempty);
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();
                kapcsolodasempty.Close();
            }
            catch (Exception e) { Console.WriteLine(e); }
        }

        // Insert into player (Username , Password)
        public static void InsertInto_Player(string user, string pass)
        {

            //Fő tábla kitöltése
            try
            {
                kapcsolodas.Open();
                command = kapcsolodas.CreateCommand();
                string sql = "INSERT INTO player(username,password)" +
                "VALUES(@param1,@param2)";
                MySqlCommand cmd = new MySqlCommand(sql, kapcsolodas);
                cmd.Parameters.Add("@param1", MySqlDbType.Text).Value = user;
                cmd.Parameters.Add("@param2", MySqlDbType.Text).Value = pass;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
                kapcsolodas.Close();
            }
            catch (Exception e) { Console.WriteLine(e); }
        }

        // Insert into loot (Username)
        public static void InsertInto_Loot(string user)
        {
            try
            {
                kapcsolodas.Open();
                command = kapcsolodas.CreateCommand();
                string sql = "INSERT INTO loot(arany,tapasztalati_pont,palya,jogosultsag)" +
                "VALUES(@param1,@param2,@param3,@param4)";
                MySqlCommand cmd = new MySqlCommand(sql, kapcsolodas);
                cmd.Parameters.Add("@param1", MySqlDbType.Text).Value = 100;
                cmd.Parameters.Add("@param2", MySqlDbType.Text).Value = 0;
                cmd.Parameters.Add("@param3", MySqlDbType.Text).Value = 0;
                cmd.Parameters.Add("@param4", MySqlDbType.Text).Value = 0;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
                kapcsolodas.Close();
            }
            catch (Exception e) { Console.WriteLine(e); }
        }

        // Select username for register ()
        public static int RegisterCheck(string username)
        {
            int i = 0;
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
                i = Convert.ToInt32((dt.Rows.Count.ToString()));               
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

        // Select id for login (Username & Password)
        public static int Select(string username, string password)
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

        //Select player id
        public static int Select_Player_Id(string username)
        {
            try
            {
                kapcsolodas.Open();
                command = kapcsolodas.CreateCommand();
                string sql = "SELECT id FROM player WHERE username = " +
                "(@param1)";
                command = new MySqlCommand(sql, kapcsolodas);
                command.Parameters.Add("@param1", MySqlDbType.Text).Value = username;
                int id = (int)command.ExecuteScalar();
                kapcsolodas.Close();
                return id;                
            }
            catch (Exception e) { throw e; }
        }

        //Select player arany
        public static int Select_Player_Arany(int id)
        {
            try
            {
                kapcsolodas.Open();
                command = kapcsolodas.CreateCommand();
                string sql = "SELECT arany FROM loot WHERE player_id = " +
                "(@param1)";
                command = new MySqlCommand(sql, kapcsolodas);
                command.Parameters.Add("@param1", MySqlDbType.Text).Value = id;
                int arany = (int)command.ExecuteScalar();
                kapcsolodas.Close();
                return arany;
            }
            catch (Exception e) { throw e; }
            
        }

        //Select player tapasztalati pont
        public static int Select_Player_Tapasztalati_Pont(int id)
        {
            try
            {
                kapcsolodas.Open();
                command = kapcsolodas.CreateCommand();
                string sql = "SELECT tapasztalati_pont FROM loot WHERE player_id = " +
                "(@param1)";
                command = new MySqlCommand(sql, kapcsolodas);
                command.Parameters.Add("@param1", MySqlDbType.Text).Value = id;
                int tapasztalatipont = (int)command.ExecuteScalar();
                kapcsolodas.Close();
                return tapasztalatipont;

            }
            catch (Exception e) { throw e; }
        }

        //Select player jogosultsag
        public static int Select_Player_Jogosultsag(int id)
        {
            try
            {
                kapcsolodas.Open();
                command = kapcsolodas.CreateCommand();
                string sql = "SELECT jogosultsag FROM loot WHERE player_id = " +
                "(@param1)";
                command = new MySqlCommand(sql, kapcsolodas);
                command.Parameters.Add("@param1", MySqlDbType.Text).Value = id;
                int jogosultsag = (int)command.ExecuteScalar();
                kapcsolodas.Close();
                return jogosultsag;

            }
            catch (Exception e) { throw e; }
        }

        //Select player palya
        public static int Select_Player_Palya(int id)
        {
            try
            {
                kapcsolodas.Open();
                command = kapcsolodas.CreateCommand();
                string sql = "SELECT palya FROM loot WHERE player_id = " +
                "(@param1)";
                command = new MySqlCommand(sql, kapcsolodas);
                command.Parameters.Add("@param1", MySqlDbType.Text).Value = id;
                int palya = (int)command.ExecuteScalar();
                kapcsolodas.Close();
                return palya;

            }
            catch (Exception e) { throw e; }
        }

        // Tapasztalati szint hozzáadása
        public static void Update_Tapasztalat(int id, int tapasztalat)
        {
            try
            {
                kapcsolodas.Open();
                command = kapcsolodas.CreateCommand();
                string sql = "UPDATE loot SET tapasztalati_pont = loot.tapasztalati_pont + @param1 WHERE loot.player_id = @param2; ";
                MySqlCommand cmd = new MySqlCommand(sql, kapcsolodas);
                cmd.Parameters.Add("@param1", MySqlDbType.Text).Value = tapasztalat;
                cmd.Parameters.Add("@param2", MySqlDbType.Text).Value = id;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
                kapcsolodas.Close();
            }
            catch (Exception e) { Console.WriteLine(e); }
        }

        // Arany hozzáadása
        public static void Update_Arany(int id, int arany)
        {
            try
            {
                kapcsolodas.Open();
                command = kapcsolodas.CreateCommand();
                string sql = "UPDATE loot SET arany = loot.arany + @param1 WHERE loot.player_id = @param2; ";
                MySqlCommand cmd = new MySqlCommand(sql, kapcsolodas);
                cmd.Parameters.Add("@param1", MySqlDbType.Text).Value = arany;
                cmd.Parameters.Add("@param2", MySqlDbType.Text).Value = id;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
                kapcsolodas.Close();
            }
            catch (Exception e) { Console.WriteLine(e); }
        }

        // Felhasznalo megváltoztatása 
        public static void Update_Felhasznalo(string felhasznalo, int id)
        {
            try
            {
                kapcsolodas.Open();
                command = kapcsolodas.CreateCommand();
                string sql = "UPDATE players.player SET username = @param1 WHERE player.id = @param2;";
                MySqlCommand cmd = new MySqlCommand(sql, kapcsolodas);
                cmd.Parameters.Add("@param1", MySqlDbType.Text).Value = felhasznalo;
                cmd.Parameters.Add("@param2", MySqlDbType.Text).Value = id;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
                kapcsolodas.Close();
            }
            catch (Exception e) { Console.WriteLine(e); }
        }

        // Felhasznalo megváltoztatása 
        public static void Update_Jelszo(string jelszo, int id)
        {
            try
            {
                kapcsolodas.Open();
                command = kapcsolodas.CreateCommand();
                string sql = "UPDATE players.player SET password = @param1 WHERE player.id = @param2;";
                MySqlCommand cmd = new MySqlCommand(sql, kapcsolodas);
                cmd.Parameters.Add("@param1", MySqlDbType.Text).Value = jelszo;
                cmd.Parameters.Add("@param2", MySqlDbType.Text).Value = id;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
                kapcsolodas.Close();
            }
            catch (Exception e) { Console.WriteLine(e); }
        }

        // Felhasznaló törlése
        public static void Delete_Jatekos(int id)
        {
            try
            {
                kapcsolodas.Open();
                command = kapcsolodas.CreateCommand();
                string sql = "DELETE FROM players.player WHERE player.id = @param1";
                MySqlCommand cmd = new MySqlCommand(sql, kapcsolodas);
                cmd.Parameters.Add("@param1", MySqlDbType.Text).Value = id;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
                kapcsolodas.Close();
            }
            catch (Exception e) { Console.WriteLine(e); }
        }
    }
}

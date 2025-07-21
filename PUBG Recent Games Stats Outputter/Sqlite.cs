using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace PUBG_Recent_Games_Stats_Outputter
{
    public class Sqlite
    {
        public static async Task SavePlayer(Player player)
        {
            string connString = "Data Source=playerdata.db;Version=3;";
            using (var conn = new SQLiteConnection(connString))
            {
                conn.Open();

                var createCmd = conn.CreateCommand();
                createCmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS Person (
                    name_ TEXT,
                    accountid_ TEXT PRIMARY KEY,
                    lowercasename_ TEXT
                );
            ";
                createCmd.ExecuteNonQuery();

                var insertCmd = conn.CreateCommand();
                insertCmd.CommandText = @"
            INSERT OR IGNORE INTO Person (name_, accountid_, lowercasename_)
            VALUES (@name_, @accountid_, @lowercasename_);
        ";

                // Use parameterized values
                insertCmd.Parameters.AddWithValue("@name_", player.name_);
                insertCmd.Parameters.AddWithValue("@accountid_", player.accountid_);
                insertCmd.Parameters.AddWithValue("@lowercasename_", player.name_.ToLowerInvariant());

                insertCmd.ExecuteNonQuery();

                Console.WriteLine("Insert complete.");
            }
        }

        public static async Task<List<Player>> LoadAllPlayers()
        {
            List<Player> players = new List<Player>();

            string connString = "Data Source=playerdata.db;Version=3;";
            using (var conn = new SQLiteConnection(connString))
            {
                conn.Open();

                var selectCmd = conn.CreateCommand();
                selectCmd.CommandText = "SELECT name_, accountid_ FROM Person;";

                using (var reader = selectCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var player = new Player
                        {
                            name_ = reader["name_"].ToString(),
                            accountid_ = reader["accountid_"].ToString()
                        };

                        players.Add(player);
                    }

                }
            }

            return players;
        }

        public static async Task<Player> GetAccountID(string name)
        {

            string connString = "Data Source=playerdata.db;Version=3;";
            using (var conn = new SQLiteConnection(connString))
            {
                await conn.OpenAsync();

                var selectCmd = conn.CreateCommand();
                selectCmd.CommandText = "SELECT name_, accountid_ FROM Person WHERE name_ = @name;";
                selectCmd.Parameters.AddWithValue("@name", name);

                using (var reader = await selectCmd.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        return new Player
                        {
                            name_ = reader["name_"].ToString(),
                            accountid_ = reader["accountid_"].ToString()
                        };
                    }
                }
            }

            // Return null or handle "not found" case as needed
            return null;
        }
    }
}
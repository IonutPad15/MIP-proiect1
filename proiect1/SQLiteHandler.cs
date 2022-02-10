using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;

namespace Lab3
{
    internal class SQLiteHandler
    {
        public static SQLiteConnection ConnectToDb()
        {
            SQLiteConnection conn = null;
            conn = new SQLiteConnection("Data Source=db.sqlite; Version = 3;");
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return conn;
        }
        public static void DisconnectFromDb(SQLiteConnection conn)
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
        public static void InsertKeyword(SQLiteConnection conn, string keyword)
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                SQLiteCommand cmd;
                cmd = conn.CreateCommand();
                cmd.CommandText = " INSERT INTO keywords (keyword) VALUES ('" + keyword + "')";
                cmd.ExecuteNonQuery();
            }
        }
        public static List<string> GetAllKeywords(SQLiteConnection conn)
        {
            List<string> keywords = new List<string>();
            SQLiteDataReader reader;
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = " SELECT keyword FROM keywords";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                keywords.Add(reader.GetString(0));
            }
            return keywords;
        }
    }
}

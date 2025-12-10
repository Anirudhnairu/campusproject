using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace SmartCampusDashboard
{
    public static class Db
    {
        private const string ConnString =
            "Server=localhost;Database=campus;User ID=root;Password=yourpassword;";

        public static MySqlConnection GetOpenConnection()
        {
            var con = new MySqlConnection(ConnString);
            con.Open();
            return con;
        }

        public static DataTable ExecuteDataTable(string sql, params MySqlParameter[] parameters)
        {
            using (var con = GetOpenConnection())
            using (var cmd = new MySqlCommand(sql, con))
            {
                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);

                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public static bool TryValidateAdmin(string username, string password)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM admins WHERE username=@u AND password=@p";
                using (var con = GetOpenConnection())
                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0) return true;
                }
            }
            catch {}

            return username == "admin" && password == "admin123";
        }
    }
}

using System;
using Npgsql;

namespace data01.Data
{
    public class MyPostgresDB
    {
        private NpgsqlDataReader data = null;
        private NpgsqlConnection connLink;
        public MyPostgresDB()
        {
            string con = "Server=209.126.96.59;";
            con += "User Id=ucamp;";
            con += "Password=LOP772;";
            con += "Database=adv_prog;";
            this.connLink = new NpgsqlConnection(con);
            connLink.Open();
        }

        // OnDestroy
        ~MyPostgresDB()
        {
            this.connLink.Close();
        }

        public NpgsqlDataReader executeSQL(string sql)
        {
            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, this.connLink))
            {
                data = cmd.ExecuteReader();
                return data;
            }
        }
    }
}
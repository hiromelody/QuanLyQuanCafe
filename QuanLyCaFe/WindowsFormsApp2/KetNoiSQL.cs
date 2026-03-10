using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ketnoisql
{
    public class KetNoiSQL
    {
        private static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(@"Data Source = localhost; Initial Catalog=QuanLyQuanCafe; Integrated Security=True");

        }

        private static SqlConnection cnn;

        public static void Openconnection()
        {
            cnn = GetSqlConnection();
            cnn.Open();

        }
        public static void Closeconnection()
        {
            if (cnn != null && cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }

        }

        public static DataTable ThucThiQuery(string sql)
        {
            Openconnection();

            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = sql;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Closeconnection();

            return dt;
        }

        public static DataTable ThucThiQuery(string sql, SqlParameter[] param)
        {
            Openconnection();

            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = sql;

            if (param != null)
                cmd.Parameters.AddRange(param);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Closeconnection();

            return dt;
        }

        public static string ThucThiNonQuery(string sql)
        {
            Openconnection();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            Closeconnection();
            return "Success";


        }
        public static bool ExcuteReader_bool(string sql)
        {
            Openconnection();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = sql;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                Closeconnection();
                return true;
            }
            else
            {
                dr.Close();
                Closeconnection();
                return false;
            }
        }
        public static string ExcuteScalar_string(string sql)
        {
            Openconnection();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = sql;
            return cmd.ExecuteScalar().ToString();

        }
    }
}

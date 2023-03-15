using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ToshoLibrary
{
    public class KashidashiTable
    {
        public DataTable GetKashidashiByGakuNo(string gakuNo)
        {
            DataTable table = new DataTable();
            string connnectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connnectionString))
            {
                string sql = "select Kashidashi.*,title from Kashidashi inner join Book on" +
                    " Kashidashi.Isbn = Book.Isbn where HenDate is null and GakuNo = @gakuno";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@gakuno", gakuNo);
                int cnt = adapter.Fill(table);

            }
            return table;
        }
        public int Insert(Kashidashi kashidashi)
        {
            int ret = 0;
            string connnectionString = Properties.Settings.Default.DBConnectionString;
            try {
                using (SqlConnection connection = new SqlConnection(connnectionString))
                {
                    string sql = "insert into kashidashi(GakuNo,Isbn,KashiDate,YoteiDate) values(@gakuno,@isbn,@kashidate,@yoteidate)";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@gakuno", kashidashi.GakuNo);
                    command.Parameters.AddWithValue("@isbn", kashidashi.Isbn);
                    command.Parameters.AddWithValue("@kashidate", kashidashi.KashiDate);
                    command.Parameters.AddWithValue("@yoteidate", kashidashi.YoteiDate);
                    connection.Open();
                    ret = command.ExecuteNonQuery();
                }
            } catch (Exception e)
            { 
            ret = 0;
            }
            return ret;
         }
        public int Henkyaku(string isbn)
        {
            int ret = 0;
            string con = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(con))
            {
                string sql = "update Kashidashi set HenDate = getdate() where Isbn = @isbn and HenDate is null";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@isbn", isbn);
                connection.Open();
                ret = command.ExecuteNonQuery();
            }
            return ret;
        }
        public bool IsKashidashi(string isbn)
        {
            bool ret = false;
            string connnectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connnectionString))
            {
                string sql = "select * from Kashidashi where Isbn = @isbn and HenDate is null";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@isbn", isbn);
                DataTable table = new DataTable();
                int cnt = adapter.Fill(table);
                if (cnt > 0)
                {
                    ret = true;
                }
                else
                {
                    ret = false;
                }
            }
            return ret;
        }
        public bool IsHenkyakui(string isbn)
        {
            bool ret = false;
            string connnectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connnectionString))
            {
                string sql = "select * from Kashidashi where Isbn = @isbn and HenDate is not null";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@isbn", isbn);
                DataTable table = new DataTable();
                int cnt = adapter.Fill(table);
                if (cnt > 0)
                {
                    ret = true;
                }
                else
                {
                    ret = false;
                }
            }
            return ret;
        }
    }
}


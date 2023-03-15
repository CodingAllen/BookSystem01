using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ToshoLibrary
{
    public class YoyakuTable
    {
      public int Insert(Yoyaku yoyaku)
        {
            int ret = 0;
            string connnectionString = Properties.Settings.Default.DBConnectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(connnectionString))
                {
                    string sql = "insert into yoyaku(Isbn,GakuNo,YoyakuDate) values(@isbn,@gakuno,@yoyakudate)";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@isbn", yoyaku.Isbn);
                    command.Parameters.AddWithValue("@gakuno", yoyaku.GakuNo);
                    command.Parameters.AddWithValue("@yoyakudate", yoyaku.YoyakuDate);
                    connection.Open();
                    ret = command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                ret = 0;
            }
            return ret;
        }
        public int Delete(Yoyaku yoyaku)
        {
            int ret = 0;
            string connnectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connnectionString))
            {
                string sql = "delete from Yoyaku where Isbn = @isbn and GakuNo = @gakuno";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@isbn", yoyaku.Isbn);
                command.Parameters.AddWithValue("@gakuno", yoyaku.GakuNo);
                connection.Open();
                ret = command.ExecuteNonQuery();
            }
            return ret;
        }
        public bool IsYoyaku(Yoyaku yoyaku)
        {
            bool ret = false;
            string connnectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connnectionString))
            {
                string sql = "select * from Yoyaku where Isbn = @isbn and GakuNo = @gakuno";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@isbn", yoyaku.Isbn);
                adapter.SelectCommand.Parameters.AddWithValue("@gakuno",yoyaku.GakuNo);
                DataTable table = new DataTable();
                int cnt = adapter.Fill(table);
                if(cnt > 0)
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
        public DataTable GetYoyakuByGakuNo(string gakuNo)
        {

            DataTable table = new DataTable();
            string connnectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connnectionString))
            {
                string sql = "select Yoyaku.*,title from Yoyaku inner join Book on Yoyaku.Isbn = Book.Isbn where GakuNo = @gakuno";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@gakuno", gakuNo);
                int cnt = adapter.Fill(table);

            }
            return table;
        }
        public int Delete(string isbn,string gakuNo)
        {
            int ret = 0;
            string connnectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connnectionString))
            {
                string sql = "delete from Yoyaku where isbn = @isbn and gakuno = @gakuno";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@isbn", isbn);
                command.Parameters.AddWithValue("@gakuno", gakuNo);
                connection.Open();
                ret = command.ExecuteNonQuery();
            }
            return ret;
        }
    }
}

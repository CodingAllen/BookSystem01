using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ToshoLibrary
{
    public class GakuseiTable
    {
        public Gakusei GetGakuseiByGakuNo(string gakuNo)
        {
            Gakusei gakusei = null;
            string connnectionString = Properties.Settings.Default.DBConnectionString;
            using(SqlConnection connection = new SqlConnection(connnectionString))
            {
                string sql = "select * from Gakusei where GakuNo = @gakuno ";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@gakuno", gakuNo);
                DataTable table = new DataTable();
                int cnt = adapter.Fill(table);
                if(cnt != 0)
                {
                    gakusei = new Gakusei();
                    gakusei.GakuNo = table.Rows[0]["gakuno"].ToString();
                    gakusei.GakuName = table.Rows[0]["gakuname"].ToString();
                    gakusei.MailAddress = table.Rows[0]["mailaddress"].ToString();
                    gakusei.Zaiseki = (bool)table.Rows[0]["zaiseki"];
                }
            }
            return gakusei;
        }
        public int Insert(Gakusei gakusei)
        {
            int ret = 0;
            string con = Properties.Settings.Default.DBConnectionString;
            using(SqlConnection connection = new SqlConnection(con))
            {
                string sql = "insert into Gakusei(GakuNo,GakuName,MailAddress,Zaiseki) values(@gakuno,@gakuname,@mailAddress,@zaiseki)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@gakuno", gakusei.GakuNo);
                command.Parameters.AddWithValue("@gakuname", gakusei.GakuName);
                command.Parameters.AddWithValue("@mailAddress", gakusei.MailAddress);
                command.Parameters.AddWithValue("@zaiseki", gakusei.Zaiseki);
                connection.Open();
                ret = command.ExecuteNonQuery();

            }
            return ret;
        }
        public int Update(Gakusei gakusei)
        {
            int ret = 0;
            string con = Properties.Settings.Default.DBConnectionString;
            using(SqlConnection connection = new SqlConnection(con))
            {
                string sql = "update Gakusei set GakuName = @gakuname, MailAddress = @mailaddress,Zaiseki = @zaiseki where GakuNo = @gakuno";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@gakuno", gakusei.GakuNo);
                command.Parameters.AddWithValue("@gakuname", gakusei.GakuName);
                command.Parameters.AddWithValue("@mailaddress", gakusei.MailAddress);
                command.Parameters.AddWithValue("@zaiseki", gakusei.Zaiseki);
                connection.Open();
                ret = command.ExecuteNonQuery();
            }
            return ret;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ToshoLibrary
{
    public class BookTable
    {
        public Book GetBookByIsbn(string isbn)
        {
            Book book = null;
            string connnectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connnectionString))
            {
                string sql = "select * from Book where Isbn = @isbn ";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@isbn", isbn);
                DataTable table = new DataTable();
                int cnt = adapter.Fill(table);
                if (cnt != 0)
                {
                   book = new Book();
                   // book.Isbn = table.Rows[0]["isbn"].ToString();
                    book.Title = table.Rows[0]["title"].ToString();
                   // book.Writer = table.Rows[0]["writer"].ToString();
                   // book.Publisher = table.Rows[0]["publosher"].ToString();
                }
            }
            return book;
        }
        public DataTable GetBookByTitle(string title)
        {
            DataTable table = new DataTable();
            string connnectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connnectionString))
            {
                string sql = "select * from Book where Title like @title";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@title", "%" + title + "%");
                int cnt = adapter.Fill(table);
            }
            return table;
        }
        public int Insert(Book book)
        {
            int ret = 0;
            string con = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(con))
            {
                string sql = "insert into Book(Isbn,Title,Writer,Publisher) values(@isbn,@title,@writer,@publisher)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@isbn", book.Isbn);
                command.Parameters.AddWithValue("@title", book.Title);
                command.Parameters.AddWithValue("@writer", book.Writer);
                command.Parameters.AddWithValue("@publisher", book.Publisher);
                connection.Open();
                ret = command.ExecuteNonQuery();

            }
            return ret;
        }
    }
}

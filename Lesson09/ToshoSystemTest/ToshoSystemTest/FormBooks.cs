using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToshoLibrary;

namespace ToshoSystemTest
{
    public partial class FormBooks : Form
    {
        public FormBooks()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if(txtIsbn.Text != "" && txtTitle.Text != "" && txtWriter.Text != "" && txtPublisher.Text != "")
            {
                BookTable bookTable = new BookTable();
                Book book = new Book();
                book.Isbn = txtIsbn.Text;
                book.Title = txtTitle.Text;
                book.Writer = txtWriter.Text;
                book.Publisher = txtPublisher.Text;
                int cnt = bookTable.Insert(book);

                if(cnt == 1)
                {
                    MessageBox.Show("図書情報を登録しました。", "登録完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("図書情報を補ってください", "登録エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

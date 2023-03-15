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
using System.IO;

namespace ToshoSystemTest
{
    public partial class FrmHenkyaku : Form
    {
        public FrmHenkyaku()
        {
            InitializeComponent();
        }

        private void btnBookConfirm_Click(object sender, EventArgs e)
        {
            BookTable bookTable = new BookTable();
            Book book = bookTable.GetBookByIsbn(txtReturnIsbn.Text);
            if (txtReturnIsbn.Text != "")
            {
                if (book != null)
                {
                    txtReturnTitle.Text = book.Title;
                }
                else
                {
                    MessageBox.Show("該当本がいない", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Isbnを入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtReturnIsbn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReturnIsbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnBookConfirm.PerformClick();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            KashidashiTable kashidashiTable = new KashidashiTable();
            int ret = kashidashiTable.Henkyaku(txtReturnIsbn.Text);
            if(ret == 1)
            {
                MessageBox.Show("返却済み", "返却", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            var message = new MimeKit.MimeMessage();
            message.From.Add(new MimeKit.MailboxAddress("日本電子専門学校", "22jn0119@jec.ac.jp"));
            message.To.Add(new MimeKit.MailboxAddress("蔣文誠さん", "wencheng198949@gmail.com"));
            message.Subject = "ご予約ありがとうございます。";
            var textPart = new MimeKit.TextPart(MimeKit.Text.TextFormat.Plain);
            textPart.Text = @"いつもご利用ありがとうございます。";
           message.Body = textPart;
            using(var clinet = new MailKit.Net.Smtp.SmtpClient())
            {
                clinet.Connect("smtp.gmail.com", 465);
               clinet.Authenticate("22jn0119@jec.ac.jp", "6DYkbVnmQgaF");
                clinet.Send(message);
           }
           MessageBox.Show("予約者に送信しました", "送信確認", MessageBoxButtons
                .OK, MessageBoxIcon.Information);
        }
    }
}

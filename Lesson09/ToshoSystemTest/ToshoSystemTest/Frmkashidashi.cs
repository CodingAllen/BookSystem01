using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToshoLibrary;

using System.Data.SqlClient;

namespace ToshoSystemTest
{
    public partial class Frmkashidashi : Form
    {
        public Frmkashidashi()
        {
            InitializeComponent();
        }

        private void btnKashi_Click(object sender, EventArgs e)
        {
           
            YoyakuTable yoyakuTable = new YoyakuTable();
            Yoyaku yoyaku = new Yoyaku();
            yoyaku.Isbn = txtISBn.Text;
            yoyaku.GakuNo = txtGakuNo.Text;
            bool ret =  yoyakuTable.IsYoyaku(yoyaku);

            KashidashiTable kashidashiTable = new KashidashiTable();
            Kashidashi kashidashi = new Kashidashi();
            bool ret1 = kashidashiTable.IsHenkyakui(txtISBn.Text);
            if (ret)
            {
                if(ret1)
                {
                    yoyakuTable.Delete(yoyaku);
                    test();
                }
                else
                {
                    FrmYoyakusare frmYoyakusare = new FrmYoyakusare();
                    frmYoyakusare.name = txtName.Text;
                    DialogResult result = frmYoyakusare.ShowDialog();
                }

            }
            else
            {
                test();
                
            }
         
        }

        private void bntStudentConfirm_Click(object sender, EventArgs e)
        {
            GakuseiTable gakuseiTable = new GakuseiTable();
            KashidashiTable kashidashiTable = new KashidashiTable();
            Gakusei gakusei = new Gakusei();
            gakusei = gakuseiTable.GetGakuseiByGakuNo(txtGakuNo.Text);
            DataTable table = kashidashiTable.GetKashidashiByGakuNo(txtGakuNo.Text);
            if (txtGakuNo.Text != "")
            {
                if (gakusei != null)
                {
                    txtName.Text = gakusei.GakuName;
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = table; 
                }
                else
                {
                    MessageBox.Show("該当学生がいない", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
            else
            {
                MessageBox.Show("学籍番号を入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = table;
            
           
        }

        private void btnBookConfirm_Click(object sender, EventArgs e)
        {
            BookTable bookTable = new BookTable();
            Book book = bookTable.GetBookByIsbn(txtISBn.Text);
            if(txtISBn.Text != "")
            {
                if(book != null)
                {
                    txtTitle.Text = book.Title;
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

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        private void txtISBn_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtISBn_KeyPress(object sender, KeyPressEventArgs e)
        {

           
            if (e.KeyChar == (char)Keys.Enter)
            {

                btnBookConfirm.PerformClick();
                            
            }
        }
        private void test()
        {
            KashidashiTable kashidashiTable = new KashidashiTable();
            Kashidashi kashidashi = new Kashidashi();
            kashidashi.GakuNo = txtGakuNo.Text;
            kashidashi.Isbn = txtISBn.Text;
            kashidashi.KashiDate = DateTime.Today;
            kashidashi.YoteiDate = DateTime.Today.AddDays(14);
            kashidashiTable.Insert(kashidashi);
            MessageBox.Show("貸出テーブルに登録済み", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bntStudentConfirm.PerformClick();
        }
    }
}

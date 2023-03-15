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
    public partial class frmYoyaku : Form
    {
        public frmYoyaku()
        {
            InitializeComponent();
        }

        private void frmYoyaku_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BookTable bookTable = new BookTable();
            DataTable table = bookTable.GetBookByTitle(txtsearch.Text);
            dgvData.AutoGenerateColumns = false;
            dgvData.DataSource = table;
            if(table.Rows.Count == 0)
            {
                MessageBox.Show("該当本はありません", "検索結果０件", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvData_DoubleClick(object sender, EventArgs e)
        {
            string wscode1 = dgvData.SelectedRows[0].Cells["isbn"].Value.ToString();
            string wscode2 = dgvData.SelectedRows[0].Cells["tittle"].Value.ToString();
            string wscode3 = dgvData.SelectedRows[0].Cells["writer"].Value.ToString();
            string wscode4 = dgvData.SelectedRows[0].Cells["publish"].Value.ToString();
            txtIsbn.Text = wscode1;
            txtTittle.Text = wscode2;
            txtWriter.Text = wscode3;
            txtPublish.Text = wscode4;
            KashidashiTable kashidashiTable = new KashidashiTable();
           bool ret =  kashidashiTable.IsKashidashi(wscode1);
            if (ret)
            {
                btnAppointment.Enabled = true;
                txtDisplay.Text = "貸出中なので予約できます。";
            }
            else
            {
                txtDisplay.Text = "貸出中でないので予約できません。";
                btnAppointment.Enabled = false;
            }
        }

        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

               btnSearch.PerformClick();

            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
             GakuseiTable gakuseiTable = new GakuseiTable();
             Gakusei gakusei =   gakuseiTable.GetGakuseiByGakuNo(txtNumber.Text);
            if (txtNumber.Text != "")
            {
                if (gakusei != null)
                {
                    txtName.Text = gakusei.GakuName;
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

        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            YoyakuTable yoyakuTable = new YoyakuTable();
            Yoyaku yoyaku = new Yoyaku();
            yoyaku.Isbn = txtIsbn.Text;
            yoyaku.GakuNo = txtNumber.Text;
            yoyaku.YoyakuDate = DateTime.Now;
            yoyakuTable.Insert(yoyaku);
            MessageBox.Show("予約テーブルに登録済み", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
     

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

               btnConfirm.PerformClick();

            }
        }
    }
}

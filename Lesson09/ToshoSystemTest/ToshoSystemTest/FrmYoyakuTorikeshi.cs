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
    public partial class FrmYoyakuTorikeshi : Form
    {
        public FrmYoyakuTorikeshi()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntStudentConfirm_Click(object sender, EventArgs e)
        {

            YoyakuTable yoyakuTable = new YoyakuTable();
            Yoyaku yoyaku = new Yoyaku();

            DataTable table = yoyakuTable.GetYoyakuByGakuNo(txtGakuNo.Text);
            if (txtGakuNo.Text != "")
            {
                if (table != null)
                {
                    
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = table;
                }
                else
                {
                    MessageBox.Show("該当予約がない", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("学籍番号を入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string wscode1 = dataGridView1.SelectedRows[0].Cells["Isbn"].Value.ToString();
            string wscode2 = dataGridView1.SelectedRows[0].Cells["Title"].Value.ToString();
            
            txtIsbn.Text = wscode1;
            txtTitle.Text = wscode2;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            YoyakuTable yoyakuTable = new YoyakuTable();
            int ret = yoyakuTable.Delete(txtIsbn.Text,txtGakuNo.Text);
            if(ret == 1)
            {
                MessageBox.Show("予約は削除しました", "削除完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

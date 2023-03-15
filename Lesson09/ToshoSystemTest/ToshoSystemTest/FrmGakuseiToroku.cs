using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ToshoLibrary;

namespace ToshoSystemTest
{
    public partial class FrmGakuseiToroku : Form
    {
        private string fileName ;
        public FrmGakuseiToroku()
        {
            InitializeComponent();
        }
        public FrmGakuseiToroku(string fileName):this()//引数なしのコンストラクタ実行
        {
            this.fileName = fileName;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void FrmGakuseiToroku_Load(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            dt.Columns.Add("学籍番号", typeof(String));
            dt.Columns.Add("学生氏名", typeof(String));
            dt.Columns.Add("メールアドレス", typeof(String));
            dt.Columns.Add("在籍", typeof(bool));
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string[] data = reader.ReadLine().Split(',');
                    DataRow dr = dt.NewRow();
                    dr[0] = data[0];
                    dr[1] = data[1];
                    dr[2] = data[2];
                    dr[3] = data[3];
                    dt.Rows.Add(dr);
                }
            }
            this.dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            GakuseiTable gakuseiTable = new GakuseiTable();
            Gakusei gakusei = new Gakusei();
            for(int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                gakusei.GakuNo = dataGridView1.Rows[i].Cells["学籍番号"].Value.ToString();
                gakusei.GakuName = dataGridView1.Rows[i].Cells["学生氏名"].Value.ToString();
                gakusei.MailAddress = dataGridView1.Rows[i].Cells["メールアドレス"].Value.ToString();
                gakusei.Zaiseki = (bool)dataGridView1.Rows[i].Cells["在籍"].Value;
                gakuseiTable.Insert(gakusei);
            }
           
            MessageBox.Show("学生を登録しました", "登録完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

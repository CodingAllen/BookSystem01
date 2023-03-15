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
    public partial class FrmGakuseiHenko : Form
    {
        public FrmGakuseiHenko()
        {
            InitializeComponent();
        }

        private void bntStudentConfirm_Click(object sender, EventArgs e)
        {
            GakuseiTable gakuseiTable = new GakuseiTable();
          
            Gakusei gakusei = gakuseiTable.GetGakuseiByGakuNo(txtGakuNo.Text);
            
           
            if (txtGakuNo.Text != "")
            {
                if (gakusei != null)
                {
                    txtGakuNo.Text = gakusei.GakuNo;
                    txtName.Text = gakusei.GakuName;
                    txtMail.Text = gakusei.MailAddress;
                    if (gakusei.Zaiseki)
                    {
                        checkBox1.Checked = true;
                    }
                    else
                    {
                        checkBox1.Checked = false;
                    }
                    
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

        private void btnUpset_Click(object sender, EventArgs e)
        {
            GakuseiTable gakuseiTable = new GakuseiTable();
            Gakusei gakusei = new Gakusei();
            gakusei.GakuNo = txtGakuNo.Text;
            gakusei.GakuName = txtName.Text;
            gakusei.MailAddress = txtMail.Text;
            if(checkBox1.CheckState == CheckState.Checked)
            {
                gakusei.Zaiseki = true;
            }
            else
            {
                gakusei.Zaiseki = false;
            }
            int cnt = gakuseiTable.Update(gakusei);
            if(cnt == 1)
            {
                MessageBox.Show("学生情報変更完了", "変更完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

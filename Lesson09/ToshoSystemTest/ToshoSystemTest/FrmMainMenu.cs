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

namespace ToshoSystemTest
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void btnKashidashi_Click(object sender, EventArgs e)
        {
            Frmkashidashi frmkashidashi = new Frmkashidashi();
            frmkashidashi.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmHenkyaku frmHenkyaku = new FrmHenkyaku();
            frmHenkyaku.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmYoyaku frmYoyaku = new frmYoyaku();
            frmYoyaku.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmYoyakuTorikeshi frmYoyakuTorikeshi = new FrmYoyakuTorikeshi();
            frmYoyakuTorikeshi.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult ret = openFileDialog1.ShowDialog();
            if(ret == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;

                FrmGakuseiToroku frmGakuseiToroku = new FrmGakuseiToroku(fileName);
                frmGakuseiToroku.ShowDialog();
            }
           
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGakuseiHenko frmGakuseiHenko = new FrmGakuseiHenko();
            frmGakuseiHenko.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormBooks formBooks = new FormBooks();
            formBooks.ShowDialog();
        }
    }
}

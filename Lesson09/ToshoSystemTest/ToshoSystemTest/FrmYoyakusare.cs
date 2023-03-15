using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToshoSystemTest
{
    public partial class FrmYoyakusare : Form
    {
        public string name;
        public FrmYoyakusare()
        {
            InitializeComponent();
        }

        private void txtReturnIsbn_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmYoyakusare_Load(object sender, EventArgs e)
        {
            txtName01.Text = name;
        }

        private void btnReturn1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

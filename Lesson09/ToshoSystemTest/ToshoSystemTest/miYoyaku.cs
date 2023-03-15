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
    public partial class miYoyaku : Form
    {
        public string name;
        public miYoyaku()
        {
            InitializeComponent();
        }

        private void miYoyaku_Load(object sender, EventArgs e)
        {
            txtName02.Text = name;
        }

        private void btnReturn1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

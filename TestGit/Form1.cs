using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1er bouton");
        }

        private void BT_MAJ_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Maj Annie bouton");
        }
    }
}

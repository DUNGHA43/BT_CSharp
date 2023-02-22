using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_BT
{
    public partial class B1_F1 : Form
    {
        public B1_F1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            B1_F2 f = new B1_F2(txtTuso.Text, txtMauso.Text,txtTuso2.Text, txtMauso2.Text);
            this.Hide();
            f.ShowDialog();
        }
    }
}

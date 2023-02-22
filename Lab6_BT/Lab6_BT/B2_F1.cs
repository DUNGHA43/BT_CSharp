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
    public partial class B2_F1 : Form
    {
        public B2_F1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Hanghoa hh = new Hanghoa();
            hh.maH = txtMH.Text;
            hh.tenH = txtTH.Text;
            hh.gia = Convert.ToDouble(txtGT.Text);


            B2_F2 f = new B2_F2(txtMH.Text,txtTH.Text,txtGT.Text);
            this.Hide();
            f.ShowDialog();
        }
    }
}

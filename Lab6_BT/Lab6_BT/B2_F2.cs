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
    public partial class B2_F2 : Form
    {
        string mahang;
        string tenhang;
        string giatien;
        public B2_F2()
        {
            InitializeComponent();
        }
        public B2_F2(string mahang, string tenhang, string giatien)
        {
            InitializeComponent();
            this.mahang = mahang;
            this.tenhang = tenhang;
            this.giatien = giatien;
        }

        private void B2_F2_Load(object sender, EventArgs e)
        {
            txtinMH.Text = mahang;
            txtinTH.Text = tenhang;
            txtinGT.Text = giatien;
        }
    }
}

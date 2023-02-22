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
    public partial class B1_F2 : Form
    {
        private string tuso;
        private string mauso;
        private string tuso1;
        private string mauso1;
        public B1_F2()
        {
            InitializeComponent();
        }
        public B1_F2(string tu, string mau, string tu1, string mau1)
        {
            InitializeComponent();
            this.tuso = tu;
            this.mauso = mau;
            this.tuso1 = tu1;
            this.mauso1 = mau1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtInTuso1.Text = tuso;
            txtInmauso1.Text = mauso;
            txtIntuso2.Text = tuso1;
            txtInmauso2.Text = mauso1;

            //
            Phanso ps1 = new Phanso();
            Phanso ps2 = new Phanso();
            Phanso psc = new Phanso();
            Phanso pst = new Phanso();
            Phanso psn = new Phanso();
            Phanso psch = new Phanso();

            ps1.tuso = Convert.ToInt32(txtInTuso1.Text);
            ps1.mauso = Convert.ToInt32(txtInmauso1.Text);
            ps2.tuso = Convert.ToInt32(txtIntuso2.Text);
            ps2.mauso = Convert.ToInt32(txtInmauso2.Text);

            psc = ps1.congPS(ps2);
            psc.rutgon();
            pst = ps1.truPS(ps2);
            pst.rutgon();
            psn = ps1.nhanPS(ps2);
            psn.rutgon();
            psch = ps1.chiaPS(ps2);
            psch.rutgon();

            txtCtu.Text = Convert.ToString(psc.tuso);
            txtCmau.Text = Convert.ToString(psc.mauso);
            txtTtu.Text = Convert.ToString(pst.tuso);
            txtTmau.Text = Convert.ToString(pst.mauso);
            txtNtu.Text = Convert.ToString(psn.tuso);
            txtNmau.Text = Convert.ToString(psn.mauso);
            txtCHtu.Text = Convert.ToString(psch.tuso);
            txtCHmau.Text = Convert.ToString(psch.mauso);

        }
    }
}

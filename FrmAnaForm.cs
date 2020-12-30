using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Satış
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmKategoriler fk = new FrmKategoriler();
            fk.Show();
        }

        private void BtnMusteri_Click(object sender, EventArgs e)
        {
            FrmMusteri fm = new FrmMusteri();
            fm.Show();
        }

        private void BtnUrun_Click(object sender, EventArgs e)
        {
            FrmUrun fu = new FrmUrun();
            fu.Show();
        }

        private void BtnSatis_Click(object sender, EventArgs e)
        {
            FrmSatis fs = new FrmSatis();
            fs.Show();
        }

        private void BtnIstatistikler_Click(object sender, EventArgs e)
        {
            FrmIstatistik fi = new FrmIstatistik();
            fi.Show();
        }
    }
}

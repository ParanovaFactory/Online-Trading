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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        İşletmeEntities db = new İşletmeEntities();
        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.tbladmin where x.KullanıcıAdı == TxtAd.Text && x.Şıfre == TxtSifre.Text select x;
            if (sorgu.Any())
            {
                FrmAnaForm fa = new FrmAnaForm();
                fa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı");
            }
        }
    }
}

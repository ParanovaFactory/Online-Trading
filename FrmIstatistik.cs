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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }
        İşletmeEntities db = new İşletmeEntities();
        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            label2.Text = db.tblkategori.Count().ToString();
            label3.Text = db.tblurun.Count().ToString();
            label5.Text = db.tblmusteri.Count(x => x.Durum == true).ToString();
            label11.Text = db.tblmusteri.Count(x => x.Durum == false).ToString();
            label21.Text = db.tblurun.Sum(x => x.Stok).ToString();
            label13.Text = db.tblsatis.Sum(x => x.Fiyat).ToString() + "TL";
            label7.Text = (from x in db.tblurun orderby x.Fiyat descending select x.UrunAd).FirstOrDefault();
            label17.Text = (from x in db.tblurun orderby x.Fiyat ascending select x.UrunAd).FirstOrDefault();
            label9.Text = db.tblurun.Count(x => x.Kategori == 1).ToString();
            label15.Text = (from x in db.tblmusteri select x.Sehir).Distinct().Count().ToString();
            label23.Text = db.MarkaGetir().FirstOrDefault();
            label19.Text = db.tblurun.Count(x => x.UrunAd == "Buzdolabı").ToString();
        }
    }
}

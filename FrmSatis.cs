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
    public partial class FrmSatis : Form
    {
        public FrmSatis()
        {
            InitializeComponent();
        }
        İşletmeEntities db = new İşletmeEntities();
        private void FrmSatis_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int sacilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView1.Rows[sacilen].Cells[0].Value.ToString();
            TxtUrun.Text = dataGridView1.Rows[sacilen].Cells[1].Value.ToString();
            TxtMusteri.Text = dataGridView1.Rows[sacilen].Cells[2].Value.ToString();
            TxtFyat.Text = dataGridView1.Rows[sacilen].Cells[3].Value.ToString();
            MskTarih.Text = dataGridView1.Rows[sacilen].Cells[4].Value.ToString();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.tblsatis
                                        select new
                                        {
                                            x.SatısId,
                                            x.tblurun.UrunAd,
                                            x.tblmusteri.MusteriAd,
                                            x.tblurun.Fiyat,
                                            x.Tarih,
                                        }).ToList();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            tblsatis s = new tblsatis();
            s.Urun = int.Parse(TxtUrun.Text);
            s.Musteri = int.Parse(TxtMusteri.Text);
            s.Tarih = DateTime.Parse(MskTarih.Text);
            db.tblsatis.Add(s);
            db.SaveChanges();
            MessageBox.Show("Satış Eklendi");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtId.Text);
            var ktg = db.tblsatis.Find(x);
            db.tblsatis.Remove(ktg);
            db.SaveChanges();
            MessageBox.Show("Satış silindi");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtId.Text);
            var ktg = db.tblsatis.Find(x);
            ktg.Urun = int.Parse(TxtUrun.Text);
            ktg.Musteri = int.Parse(TxtMusteri.Text);
            ktg.Tarih = DateTime.Parse(MskTarih.Text);
            db.SaveChanges();
            MessageBox.Show("Güncellendi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtId.Clear();
            TxtFyat.Clear();
            TxtMusteri.Clear();
            TxtUrun.Clear();
            MskTarih.Clear();
        }
    }
}

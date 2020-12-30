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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        İşletmeEntities db = new İşletmeEntities();
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sacilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView1.Rows[sacilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[sacilen].Cells[1].Value.ToString();
            TxtMarka.Text = dataGridView1.Rows[sacilen].Cells[2].Value.ToString();
            TxtStok.Text = dataGridView1.Rows[sacilen].Cells[3].Value.ToString();
            TxtFiyat.Text = dataGridView1.Rows[sacilen].Cells[4].Value.ToString();
            TxtDurum.Text = dataGridView1.Rows[sacilen].Cells[5].Value.ToString();
            CmbKategori.Text = dataGridView1.Rows[sacilen].Cells[6].Value.ToString();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.tblurun
                                        select new
                                        {
                                            x.UrunId,
                                            x.UrunAd,
                                            x.Marka,
                                            x.Stok,
                                            x.Fiyat,
                                            x.tblkategori.Ad,
                                            x.Durum
                                        }).ToList();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            tblurun u = new tblurun();
            u.UrunAd = TxtAd.Text;
            u.Marka = TxtMarka.Text;
            u.Stok = short.Parse(TxtStok.Text);
            u.Fiyat = int.Parse(TxtFiyat.Text);
            u.Durum = true;
            u.Kategori = int.Parse(CmbKategori.SelectedValue.ToString());
            db.tblurun.Add(u);
            db.SaveChanges();
            MessageBox.Show("Ürün Eklendi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtAd.Clear();
            TxtDurum.Clear();
            TxtFiyat.Clear();
            TxtId.Clear();
            TxtMarka.Clear();
            TxtStok.Clear();
            CmbKategori.Items.Clear();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtId.Text);
            var ktg = db.tblurun.Find(x);
            db.tblurun.Remove(ktg);
            db.SaveChanges();
            MessageBox.Show("Ürün silindi");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtId.Text);
            var ktg = db.tblurun.Find(x);
            ktg.UrunAd = TxtAd.Text;
            ktg.Stok = short.Parse(TxtStok.Text);
            ktg.Marka = TxtMarka.Text;
            db.SaveChanges();
            MessageBox.Show("Güncellendi");
        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.tblkategori
                               select new
                               {
                                   x.Id,
                                   x.Ad
                               }
                               ).ToList();
            CmbKategori.ValueMember = "Id";
            CmbKategori.DisplayMember = "Ad";
            CmbKategori.DataSource = kategoriler;
        }
    }
}

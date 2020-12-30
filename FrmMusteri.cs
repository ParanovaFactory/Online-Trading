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
    public partial class FrmMusteri : Form
    {
        public FrmMusteri()
        {
            InitializeComponent();
        }
        İşletmeEntities db = new İşletmeEntities();
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sacilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView1.Rows[sacilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[sacilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[sacilen].Cells[2].Value.ToString();
            TxtŞehir.Text = dataGridView1.Rows[sacilen].Cells[3].Value.ToString();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.tblmusteri
                                        select new
                                        {
                                            x.MusteriId,
                                            x.MusteriAd,
                                            x.MusteriSoyad,
                                            x.Sehir,
                                        }).ToList();
        }

        private void FrmMusteri_Load(object sender, EventArgs e)
        {

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            tblmusteri m = new tblmusteri();
            m.MusteriAd = TxtAd.Text;
            m.MusteriSoyad = TxtSoyad.Text;
            m.Sehir = TxtŞehir.Text;
            db.tblmusteri.Add(m);
            db.SaveChanges();
            MessageBox.Show("Müşteri Eklendi");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtId.Text);
            var ktg = db.tblmusteri.Find(x);
            ktg.MusteriAd = TxtAd.Text;
            ktg.MusteriSoyad = TxtSoyad.Text;
            ktg.Sehir = TxtŞehir.Text;
            db.SaveChanges();
            MessageBox.Show("Güncellendi");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtId.Text);
            var ktg = db.tblmusteri.Find(x);
            db.tblmusteri.Remove(ktg);
            db.SaveChanges();
            MessageBox.Show("Kayıt Silindi");
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAd.Clear();
            TxtId.Clear();
            TxtSoyad.Clear();
            TxtŞehir.Clear();
        }
    }
}

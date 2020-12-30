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
    public partial class FrmKategoriler : Form
    {
        public FrmKategoriler()
        {
            InitializeComponent();
        }
        İşletmeEntities db = new İşletmeEntities();

        private void BtnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.tblkategori
                                        select new
                                        {
                                            x.Id,
                                            x.Ad,
                                        }).ToList();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            tblkategori t = new tblkategori();
            t.Ad = CmbKategori.Text;
            db.tblkategori.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklendi");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtId.Text);
            var ktg = db.tblkategori.Find(x);
            db.tblkategori.Remove(ktg);
            db.SaveChanges();
            MessageBox.Show("Kategori silindi");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtId.Text);
            var ktg = db.tblkategori.Find(x);
            ktg.Ad = CmbKategori.Text;
            db.SaveChanges();
            MessageBox.Show("Güncellendi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sacilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView1.Rows[sacilen].Cells[0].Value.ToString();
            CmbKategori.Text = dataGridView1.Rows[sacilen].Cells[1].Value.ToString();
        }

        private void FrmKategoriler_Load(object sender, EventArgs e)
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

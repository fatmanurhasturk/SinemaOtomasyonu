using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu
{
    public partial class FilmGuncelleSil : Form
    {
        DataSinemaDataContext _db = new DataSinemaDataContext();
        public FilmGuncelleSil()
        {
            InitializeComponent();
        }

        private void FilmGuncelleSil_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            cbFilmler.Items.Clear();
            int i = 0;
            var lst = (from s in _db.Filmlers
                       select s.FAdi).ToList();

            foreach (var k in lst)
            {
                cbFilmler.Items.Add(k);
                i++;
            }
        }

        void Temizle()
        {
            foreach (Control ct in Controls)
            {
                if (ct is TextBox || ct is ComboBox)
                {
                    ct.Text = "";
                }
            }
        }

        void Guncelle()
        {
            Filmler f = _db.Filmlers.First(x => x.FAdi == cbFilmler.Text);
            f.FAdi = txtAd.Text;
            f.FTuru = txtTuru.Text;
            f.Ozet = txtOzet.Text;
            f.Sure = TimeSpan.Parse(txtSure.Text);
            f.VizyonT = DateTime.Parse(txtVizyon.Text.ToString());
            f.DublajT = txtDublaj.Text;
            f.Teknoloji = txtTeknoloji.Text;
            f.HamF = int.Parse(txtFiyat.Text);
            _db.SubmitChanges();
            MessageBox.Show("Film Düzeltildi.");
            Temizle();
            Listele();
        }
        
        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            _db.Filmlers.DeleteOnSubmit(_db.Filmlers.First(x => x.FAdi == cbFilmler.Text));
            _db.SubmitChanges();
            MessageBox.Show("Film Silindi.");
            Temizle();
            Listele();
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {           
                openFile.ShowDialog();
                pbResim.ImageLocation = openFile.FileName;
                txtResim.Text = openFile.FileName;            
        }

        private void cbFilmler_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var srg = (from s in _db.Filmlers
                       where s.FAdi == cbFilmler.Text
                       select s).First();
            txtAd.Text = srg.FAdi;
            txtTuru.Text = srg.FTuru;
            txtOzet.Text = srg.Ozet;
            txtSure.Text = srg.Sure.ToString();
            txtVizyon.Text = srg.VizyonT.ToString();
            txtDublaj.Text = srg.DublajT;
            txtTeknoloji.Text = srg.Teknoloji;
            txtFiyat.Text = srg.HamF.ToString();
            pbResim.ImageLocation = srg.Afis;
        }
    }
}

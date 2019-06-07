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
    public partial class filmEkle : Form
    {
        public filmEkle()
        {
            InitializeComponent();
        }
        DataSinemaDataContext _db = new DataSinemaDataContext();
        private void filmEkle_Load(object sender, EventArgs e)
        {

        }
        void YeniKaydet()
        {
            Filmler film = new Filmler()
            {
                FAdi = txtAd.Text,
                FTuru = cbFturu.Text,
                Ozet = txtOzet.Text,
                Sure = TimeSpan.Parse(txtSure.Text),
                //VizyonT = DateTime.Parse(txtVizyon.Text),
                VizyonT=dtpTarih.Value,
                DublajT = cbDturu.Text,
                Teknoloji = cbTeknoloji.Text,
                HamF = int.Parse(txtFiyat.Text),
                Afis = txtResim.Text

            };
            _db.Filmlers.InsertOnSubmit(film);
            _db.SubmitChanges();
            MessageBox.Show("Film Kaydı Oluşturulmuştur");

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKaydet();
        }

        private void btnAfis_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
            pbResim.ImageLocation = openFile.FileName;
            txtResim.Text = openFile.FileName;
        }

        private void filmEkle_Paint(object sender, PaintEventArgs e)
        {
            txtAd.BorderStyle = BorderStyle.None;
            Pen p = new Pen(Color.Red);
            Graphics g = e.Graphics;
            int variance = 1;
            g.DrawRectangle(p, new Rectangle(txtAd.Location.X - variance, txtAd.Location.Y - variance, txtAd.Width + variance, txtAd.Height + variance));
            variance = 2;
            g.DrawRectangle(p, new Rectangle(txtAd.Location.X - variance, txtAd.Location.Y - variance, txtAd.Width + variance + 1, txtAd.Height + variance + 1));

            //cbFturu. = BorderStyle.None;
            //Pen t = new Pen(Color.Red);
            //Graphics r = e.Graphics;
            //int variancee = 1;
            //r.DrawRectangle(t, new Rectangle(cbFturu.Location.X - variancee, cbFturu.Location.Y - variancee, cbFturu.Width + variancee, cbFturu.Height + variance));
            //variancee = 2;
            //r.DrawRectangle(t, new Rectangle(cbFturu.Location.X - variancee, cbFturu.Location.Y - variancee, cbFturu.Width + variancee + 1, cbFturu.Height + variancee + 1));

            txtFiyat.BorderStyle = BorderStyle.None;
            Pen z = new Pen(Color.Red);
            Graphics x = e.Graphics;
            int variance1 = 1;
            x.DrawRectangle(p, new Rectangle(txtFiyat.Location.X - variance1, txtFiyat.Location.Y - variance1, txtFiyat.Width + variance1, txtFiyat.Height + variance1));
            variance = 2;
            x.DrawRectangle(p, new Rectangle(txtFiyat.Location.X - variance1, txtFiyat.Location.Y - variance1, txtFiyat.Width + variance1 + 1, txtFiyat.Height + variance1 + 1));

            txtOzet.BorderStyle = BorderStyle.None;
            Pen s = new Pen(Color.Red);
            Graphics d = e.Graphics;
            int variance2 = 1;
            d.DrawRectangle(s, new Rectangle(txtOzet.Location.X - variance2, txtOzet.Location.Y - variance2, txtOzet.Width + variance2, txtOzet.Height + variance2));
            variance = 2;
            d.DrawRectangle(s, new Rectangle(txtOzet.Location.X - variance2, txtOzet.Location.Y - variance2, txtOzet.Width + variance2 + 1, txtOzet.Height + variance2 + 1));

            txtSure.BorderStyle = BorderStyle.None;
            Pen tt = new Pen(Color.Red);
            Graphics v = e.Graphics;
            int variance3 = 1;
            v.DrawRectangle(tt, new Rectangle(txtSure.Location.X - variance3, txtSure.Location.Y - variance3, txtSure.Width + variance3, txtSure.Height + variance3));
            variance = 2;
            v.DrawRectangle(tt, new Rectangle(txtSure.Location.X - variance3, txtSure.Location.Y - variance3, txtSure.Width + variance3 + 1, txtSure.Height + variance3 + 1));

            txtResim.BorderStyle = BorderStyle.None;
            Pen r = new Pen(Color.Red);
            Graphics rr = e.Graphics;
            int variancer = 1;
            rr.DrawRectangle(r, new Rectangle(txtResim.Location.X - variancer, txtResim.Location.Y - variancer, txtResim.Width + variancer, txtResim.Height + variancer));
            variance = 2;
            rr.DrawRectangle(r, new Rectangle(txtResim.Location.X - variancer, txtResim.Location.Y - variancer, txtResim.Width + variancer + 1, txtResim.Height + variancer + 1));

            //txtTeknoloji.BorderStyle = BorderStyle.None;
            //Pen yy = new Pen(Color.Red);
            //Graphics rr = e.Graphics;
            //int variance4 = 1;
            //v.DrawRectangle(tt, new Rectangle(txtTeknoloji.Location.X - variance4, txtTeknoloji.Location.Y - variance4, txtTeknoloji.Width + variance4, txtTeknoloji.Height + variance4));
            //variance = 2;
            //v.DrawRectangle(tt, new Rectangle(txtTeknoloji.Location.X - variance4, txtTeknoloji.Location.Y - variance4, txtTeknoloji.Width + variance4 + 1, txtTeknoloji.Height + variance4 + 1));

            //txtVizyon.BorderStyle = BorderStyle.None;
            //Pen zz = new Pen(Color.Red);
            //Graphics xx = e.Graphics;
            //int variance5 = 1;
            //xx.DrawRectangle(zz, new Rectangle(txtVizyon.Location.X - variance5, txtVizyon.Location.Y - variance5, txtVizyon.Width + variance5, txtVizyon.Height + variance5));
            //variance = 2;
            //xx.DrawRectangle(zz, new Rectangle(txtVizyon.Location.X - variance5, txtVizyon.Location.Y - variance5, txtVizyon.Width + variance5 + 1, txtVizyon.Height + variance5 + 1));

            //txtDublaj.BorderStyle = BorderStyle.None;
            //Pen zzz = new Pen(Color.Red);
            //Graphics xxx = e.Graphics;
            //int variance6 = 1;
            //xxx.DrawRectangle(zzz, new Rectangle(txtDublaj.Location.X - variance6, txtDublaj.Location.Y - variance6, txtDublaj.Width + variance6, txtDublaj.Height + variance5));
            //variance = 2;
            //xxx.DrawRectangle(zzz, new Rectangle(txtDublaj.Location.X - variance6, txtDublaj.Location.Y - variance6, txtDublaj.Width + variance6 + 1, txtDublaj.Height + variance6 + 1));
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Location = new Point(
            this.ClientSize.Width / 2 - panel1.Size.Width / 2,
            this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;
        }
        public static int Aktarma = -1;
        public static int Aktarma2 = -1;
        public static int Aktarma3 = -1;
        public static string Aktarma4;
        public static int Aktarma5 = -1;
        public static int ogrtek = 0;
        public static int ogrcift = 0;
        public static int ogryat = 0;
        public static int nortek = 0;
        public static int norcift = 0;
        public static int noryat = 0;
        public static string hangisi;
        //private void btnFilmEkle_Click_1(object sender, EventArgs e)
        //{
        //    filmEkle film = new filmEkle();
        //    film.Show();
        //}

        //private void btnGuncelleSil_Click(object sender, EventArgs e)
        //{
        //    FilmGuncelleSil fgs = new FilmGuncelleSil();
        //    fgs.Show();
        //}

        //private void btnSalonOlustur_Click(object sender, EventArgs e)
        //{
        //    SalonOlustur salon = new SalonOlustur();
        //    salon.Show();
        //}

        //private void btnSalonIslemleri_Click(object sender, EventArgs e)
        //{
        //    SalonGuncelleSil sags = new SalonGuncelleSil();
        //    sags.Show();
        //}

        //private void btnBiletSat_Click(object sender, EventArgs e)
        //{
        //    BiletGiris gir = new BiletGiris();
        //    gir.Show();
        //}

        //private void btnBiletIslemleri_Click(object sender, EventArgs e)
        //{
        //    BiletGuncelleSil bgs = new BiletGuncelleSil();
        //    bgs.Show();
        //}

        //private void btnSeansEkle_Click(object sender, EventArgs e)
        //{
        //    SeansEkle seans = new SeansEkle();
        //    seans.Show();
        //}

        //private void btnSeansİslemleri_Click(object sender, EventArgs e)
        //{
        //    SeansGuncelleSil sgs = new SeansGuncelleSil();
        //    sgs.Show();
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            filmEkle film = new filmEkle();
            film.Show();
        }

        private void btnSalonOlustur_Click_1(object sender, EventArgs e)
        {
            SalonOlustur salon = new SalonOlustur();
            salon.Show();
        }

        private void btnSeansEkle_Click_1(object sender, EventArgs e)
        {
            SeansEkle seans = new SeansEkle();
            seans.Show();
        }

        private void btnBiletSat_Click_1(object sender, EventArgs e)
        {
            BiletGiris gir = new BiletGiris();
            gir.Show();
        }

        private void btnGuncelleSil_Click_1(object sender, EventArgs e)
        {
            FilmGuncelleSil fgs = new FilmGuncelleSil();
            fgs.Show();
        }

        private void btnSalonIslemleri_Click_1(object sender, EventArgs e)
        {
            SalonGuncelleSil sags = new SalonGuncelleSil();
            sags.Show();
        }

        private void btnSeansİslemleri_Click_1(object sender, EventArgs e)
        {
            SeansGuncelleSil sgs = new SeansGuncelleSil();
            sgs.Show();
        }

        private void btnBiletIslemleri_Click_1(object sender, EventArgs e)
        {
            BiletGuncelleSil bgs = new BiletGuncelleSil();
            bgs.Show();
        }

        private void btnPromosyon_Click(object sender, EventArgs e)
        {
            promosyonIslemleri pro = new promosyonIslemleri();
            pro.Show();
        }
    }
}

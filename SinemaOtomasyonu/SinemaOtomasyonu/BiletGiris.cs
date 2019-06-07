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
    public partial class BiletGiris : Form
    {
        public int sec;
        public int sayac = 1;
        public BiletGiris()
        {
            InitializeComponent();
        }
        DataSinemaDataContext _db = new DataSinemaDataContext();
      


        private void BiletGiris_Load(object sender, EventArgs e)
        {
            ListeleBir();
        }

        void ListeleBir()
        {
            var lst = (from s in _db.Filmlers // Veritabanından filmleri çekiyoruz.
                       select s).ToList();
            int i = 0;
            foreach (var k in lst)
            {

                Button btn = new Button(); // Her film gelme adımında  ekranda bir buton oluşruruyoruz.

                btn.Text = k.Id.ToString();
                btn.Name = k.FAdi;
                btn.Size = new Size(200, 200);
                btn.BackgroundImage = Image.FromFile(k.Afis); // Oluşan resmine filmin resmini veriyoruz..
                btn.BackgroundImageLayout = ImageLayout.Stretch;

                if (1 <= sayac && sayac <= 6) // Her satıra  6 tane film yetiştiriyoruz. Burada film surasının 1 ile 6 olma durumunu kontrol ediyoruz.
                  {
                    btn.Location = new Point((220 * i) + 25, 25); // Fark ederseniz burda butonlarda y değişkeni sabit x değişkeni değişiyor. Filmleri 6 tane olmak üzere yanyana diziyoruz.


                }
                if (6 < sayac && sayac <= 12)// Film sırası 6 ile 12 arasında ise ..
                {
                    if (i > 5) { i = 0; }


                    btn.Location = new Point((220 * i) + 25, 225); // y koordinatını 200 piksel arttırdık.. Bu yüzden ikinci satıra geçiyor.. Film sırası 6 ile 12 arasında bu işlemi yapıypr..


                }
                if (12 < sayac && sayac <= 18)
                {
                    if (i > 5) { i = 0; }


                    btn.Location = new Point((220 * i) + 25, 450);// y koordinatı tekrardan 200 piksel arttırıldı..


                }



                panel1.Controls.Add(btn);
                btn.Click += new EventHandler(btn_Click);
                i++;
                sayac++;
            }
        }

        void btn_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender; // Butona tıklandığında filmin adı ve id si alınarak ona uygun seans tablosu sayfasına geçiliyor..

            Form1.Aktarma = int.Parse(((Button)sender).Text);
            Form1.Aktarma4 = (((Button)sender).Name);
            FilmSeans fs = new FilmSeans();
            fs.Show();



            //Listeleİki();
        }
        public string btnname;


        //void Listeleİki() /// Kullanılmayan fonksiyonn...
        //{
        //    int i = 0;
        //    var lst = (from s in _db.Seanslars
        //        where s.Filmler.FAdi == btnname
        //        select s).ToList();
        //    foreach (var k in lst)
        //    {
        //        Liste2.Rows.Add();
        //        Liste2.Rows[i].Cells[0].Value = k.Id;
        //        Liste2.Rows[i].Cells[1].Value = k.SalonId;
        //        Liste2.Rows[i].Cells[2].Value = btnname;
        //        Liste2.Rows[i].Cells[3].Value = _db.Salonlars.First(x => x.Id == k.SalonId).SalonNo.ToString();
        //        Liste2.Rows[i].Cells[4].Value = k.Seans;
        //        Liste2.Rows[i].Cells[5].Value = _db.Salonlars.First(x => x.Id == k.SalonId).Kapasite.ToString();
        //        i++;
        //    }
        //}

        //private void Liste2_DoubleClick(object sender, EventArgs e)
        //{
        //    Form1.Aktarma2 = int.Parse(Liste2.CurrentRow.Cells[1].Value.ToString());
        //    Form1.Aktarma3 = int.Parse(Liste2.CurrentRow.Cells[0].Value.ToString());
        //    Form1.Aktarma4 = Liste2.CurrentRow.Cells[2].Value.ToString();
        //    Form1.Aktarma5 = int.Parse(Liste2.CurrentRow.Cells[3].Value.ToString());
        //}

        //private void btnBiletKes_Click(object sender, EventArgs e)
        //{
        //    BiletKes kes = new BiletKes();
        //    kes.Show();
        //}
    }
}

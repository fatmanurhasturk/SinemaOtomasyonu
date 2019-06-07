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
    public partial class BiletKes : Form
    {
        public BiletKes()
        {
            InitializeComponent();
        }

        int filmId = Form1.Aktarma;
        int SeansId = Form1.Aktarma2;
        DataSinemaDataContext _db = new DataSinemaDataContext();
        public string sira;
        public int tik = 1;
        public int sayac = 0;
        public string isim = "";
        public string aktarma = "";
        public string salonturu = "";
        public bool tiklama = false;
        int bul = 0;

        int num = 0;
        int numplus = 0;
        char[] degerler;
        public bool rezervemi = false;
        int sayi1 = 0;
        string[] reserve = new string[120];
        string[] koltuk = new string[120];
        int[] aktardım = new int[120];


        int sid = -1;
        //void Aktar()
        //{
        //    for (int i = 0; i < numplus; i++)
        //    {
        //        switch (reserve[i])
        //        {
        //            case "A":
        //                aktardım[i] = 1;
        //                break;
        //            case "B":
        //                aktardım[i] = 2;
        //                break;
        //            case "C":
        //                aktardım[i] = 3;
        //                break;
        //            case "D":
        //                aktardım[i] = 4;
        //                break;
        //            case "E":
        //                aktardım[i] = 5;
        //                break;
        //            case "F":
        //                aktardım[i] = 6;
        //                break;
        //            case "G":
        //                aktardım[i] = 7;
        //                break;
        //            case "H":
        //                aktardım[i] = 8;
        //                break;
        //        }

        //    }

        //}     /// Fazlalık fonksiyon.. Kullanılmadı...

        void AktarmaBul()   
        {

            // Karışık salon oluşturduğumuzda ürettiğimiz koltuk sıralarını atadığımız string değişkeni burada parcalayıp dizinin içine atıyoruz..
            // Tekli Çiftli Yatak olarak oluşturulan salon bize (123) diye kodlanmmış bir string metinle geliyor. Burada o string metinleri sırasıyla 1-2-3 diye dizinin içerisini atıyoruz.

            Salonlar sal = _db.Salonlars.First(x => x.Id == Form1.Aktarma2);
            sira = sal.SiraNo.ToString();
            aktarma = sal.KoltukAktar.ToString();
            salonturu = sal.KoltukTuru;
            string sayilar1 = aktarma;
            degerler = sayilar1.ToCharArray();

        }

        void RezerveBul()

        {
            // Salonun rezerve durumunu kontrol ediyoruz.
            Seanslar seans = _db.Seanslars.First(x => x.Id == Form1.Aktarma3);
            sid = seans.Id;

            rezervemi = seans.SeansDurum.Value;

        }

        void KoltukBul()
        {
            //Rezerve salonda ki rezerve koltukları buluyoruz.. Ve bunları  iki farklı diziye atıyoruz.
          
            int i = 0;
            Seanslar seans = _db.Seanslars.First(x => x.Id == Form1.Aktarma3);
            var lst = (from s in _db.BiletKesims
                where s.SeansId == Form1.Aktarma3
                orderby s.KoltukNo ascending
                select s).ToList();
            string[] reservekoltuk = new string[lst.Capacity]; 
            // string[] reserve = new string[lst.Capacity];
            //string[] koltuk = new string[lst.Capacity];
            int[] reserve1 = new int[lst.Capacity];

            foreach (var k in lst)   // Rezerve koltuğu harf ve sayıya parçalayıp iki farklı diziye atıyoruz.
            {
                numplus++; 


                reservekoltuk[i] = k.KoltukNo; // Bu diziye rezerve koltuk koltuk sırasını ve numarasını atıyoruz. Örneğin A15
                reserve[i] = reservekoltuk[i].Substring(0, 1);// Bu diziye rezerve koltuğun Harf kısmını atıyoruz :::: A
                koltuk[i] = reservekoltuk[i].Substring(1);// Bu diziye rezerve koltuğun Sayı kısmını atıyoruz ::: 15
                i++;

            }

        }

        private void BiletKes_Load(object sender, EventArgs e)
        {
            AktarmaBul(); // Karışık salon varsa oluşturacağımız sıraya belirlemek için koltuk sırasını belirleyen string cümleyi aratıyoruz.
            RezerveBul();// Salonun rezerve olup olmadığını kontrol ediyoruz.


            if (rezervemi == true)
            {
                KoltukBul(); // Rezerve ise bilet kesilen koltukları buluyoruz.

             




                if (salonturu == "Tekli Koltuk") // Salon turunu aratıp o salon turune göre koltuklarımızı oluşturuyoruz.
               
                {


                    ReserveKoltukOlustur(); 

                }
                if (salonturu == "Çiftli Koltuk")
                {
                    ReserveCiftKoltukOlustur();
                }
                if (salonturu == "Yataklı Salon")
                {
                    ReserveYatakOlustur();
                }
                if (salonturu == "Karışık Salon")
                {
                    AktarmaBul();
                    ReserveKarısıkOlustur();
                }

            }

            if (rezervemi == false)
            {

                if (salonturu == "Tekli Koltuk")
                {
                    KoltukOlustur();
                }
                if (salonturu == "Çiftli Koltuk")
                {
                    CiftKoltukOlustur();
                }
                if (salonturu == "Yataklı Salon")
                {
                    YatakOlustur();
                }
                if (salonturu == "Karışık Salon")
                {
                    AktarmaBul();
                    KarısıkOlustur();
                }
            }
        }

        void ReserveKoltukOlustur()
        {
            Salonlar sal = _db.Salonlars.First(x => x.Id == Form1.Aktarma2);
            label1.Text = sal.SalonNo.ToString();
            sira = sal.SiraNo.ToString();

            for (int i = 1; i <= int.Parse(sira); i++)  // Veritabanından aldığımız sıra değişkeni kadar koltuk üretiyoruz..
            {

                for (int j = 1; j <= 15; j++) // bir sırada 15 tane normal koltuk geliyor..
                {

                    sayac++;
                    Button btn = new Button();
                    btn.Text = sayac.ToString();
                    switch (i)
                    {
                        case 1:
                            btn.Name = "A"; // Sıra durumuna göre koltuğa isim atıyoruz...
                            break;
                        case 2:
                            btn.Name = "B";
                            break;
                        case 3:
                            btn.Name = "C";
                            break;
                        case 4:
                            btn.Name = "D";
                            break;
                        case 5:
                            btn.Name = "E";
                            break;
                        case 6:
                            btn.Name = "F";
                            break;
                        case 7:
                            btn.Name = "G";
                            break;
                        case 8:
                            btn.Name = "H";
                            break;
                    }
                    btn.Size = new Size(50, 50);
                    btn.BackgroundImage = Image.FromFile("koltuktekli.png"); // tekli koltuk imagesini burda atıyoruz..



                    btn.BackColor = Color.White;
                    btn.TextAlign = ContentAlignment.BottomCenter;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.Location = new Point(60 * j, 60 * tik);
                    for (int l = 0; l < numplus; l++)
                    {




                        if (btn.Name == reserve[l] && btn.Text == koltuk[l]) // Reserve olan koltuk harfi ve numarası aynı ise tıklanma ve renk özelliklerini değiştiriyoruz.
                        {
                            btn.BackColor = Color.Black;
                            btn.Enabled = false;

                        }



                    }
                    bul++;

                    splitContainer1.Panel1.Controls.Add(btn);
                    btn.Click += new EventHandler(btn_Click); //btn.Click diyerek tıklama özelliğine bir event tanımladıma.
                }
                sayac = 0;
                Label lab = new Label();
                lab.Location = new Point(25, 60 * tik);
                splitContainer1.Panel1.Controls.Add(lab);

                switch (tik)
                {
                    case 1:
                        lab.Text = "A";
                        break;
                    case 2:
                        lab.Text = "B";
                        break;
                    case 3:
                        lab.Text = "C";
                        break;
                    case 4:
                        lab.Text = "D";
                        break;
                    case 5:
                        lab.Text = "E";
                        break;
                    case 6:
                        lab.Text = "F";
                        break;
                    case 7:
                        lab.Text = "G";
                        break;
                    case 8:
                        lab.Text = "H";
                        break;
                }
                tik++;
                sayi1++;
            }

        }
        void ReserveCiftKoltukOlustur() // Yukarıda ki fonksiyondan tek farkı koltuk resmi değişiyor.
        {
            Salonlar sal = _db.Salonlars.First(x => x.Id == Form1.Aktarma2);
            label1.Text = sal.SalonNo.ToString();
            sira = sal.SiraNo.ToString();
            for (int i = 1; i <= int.Parse(sira); i++)
            {
                for (int j = 1; j <= 15; j++)
                {
                    sayac++;
                    Button btn = new Button();
                    btn.Text = sayac.ToString();
                    switch (i)
                    {
                        case 1:
                            btn.Name = "A";

                            break;
                        case 2:
                            btn.Name = "B";
                            break;
                        case 3:
                            btn.Name = "C";
                            break;
                        case 4:
                            btn.Name = "D";
                            break;
                        case 5:
                            btn.Name = "E";
                            break;
                        case 6:
                            btn.Name = "F";
                            break;
                        case 7:
                            btn.Name = "G";
                            break;
                        case 8:
                            btn.Name = "H";
                            break;

                    }

                    btn.Size = new Size(50, 50);
                    btn.BackgroundImage = Image.FromFile("koltuk.png");
                    btn.BackColor = Color.White;
                    btn.TextAlign = ContentAlignment.BottomCenter;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.Location = new Point(60 * j, 60 * tik);
                    switch (i)
                    {
                        case 1:
                            isim = "A";
                            break;
                        case 2:
                            isim = "B";
                            break;
                        case 3:
                            isim = "C";
                            break;
                        case 4:
                            isim = "D";
                            break;
                        case 5:
                            isim = "E";
                            break;
                        case 6:
                            isim = "F";
                            break;
                        case 7:
                            isim = "G";
                            break;
                        case 8:
                            isim = "H";
                            break;
                    }
                    for (int l = 0; l < numplus; l++)
                    {




                        if (btn.Name == reserve[l] && btn.Text == koltuk[l])
                        {            // Reserve olan koltuk harfi ve numarası aynı ise tıklanma ve renk özelliklerini değiştiriyoruz.
                            btn.BackColor = Color.Black;
                            btn.Enabled = false;

                        }



                    }
                    bul++;
                    splitContainer1.Panel1.Controls.Add(btn);
                    btn.Click += new EventHandler(btn_Click);

                }
                sayac = 0;
                Label lab = new Label();
                lab.Location = new Point(25, 62 * tik);
                splitContainer1.Panel1.Controls.Add(lab);

                switch (tik)
                {
                    case 1:
                        lab.Text = "A";
                        break;
                    case 2:
                        lab.Text = "B";
                        break;
                    case 3:
                        lab.Text = "C";
                        break;
                    case 4:
                        lab.Text = "D";
                        break;
                    case 5:
                        lab.Text = "E";
                        break;
                    case 6:
                        lab.Text = "F";
                        break;
                    case 7:
                        lab.Text = "G";
                        break;
                    case 8:
                        lab.Text = "H";
                        break;
                }
                tik++;
            }

        }


        void ReserveYatakOlustur() // Bu da reserve yatak oluşturma fonksiyonu.
        {
            Salonlar sal = _db.Salonlars.First(x => x.Id == Form1.Aktarma2);
            label1.Text = sal.SalonNo.ToString();
            sira = sal.SiraNo.ToString();
            for (int i = 1; i <= int.Parse(sira); i++)
            {
                for (int j = 1; j <= 15; j++)
                {
                    sayac++;
                    Button btn = new Button();
                    btn.Text = sayac.ToString();
                    switch (i)
                    {
                        case 1:
                            btn.Name = "A";
                            break;
                        case 2:
                            btn.Name = "B";
                            break;
                        case 3:
                            btn.Name = "C";
                            break;
                        case 4:
                            btn.Name = "D";
                            break;
                        case 5:
                            btn.Name = "E";
                            break;
                        case 6:
                            btn.Name = "F";
                            break;
                        case 7:
                            btn.Name = "G";
                            break;
                        case 8:
                            btn.Name = "H";
                            break;
                    }
                    btn.Size = new Size(50, 50);
                    btn.BackgroundImage = Image.FromFile("yatak.png");
                    btn.BackColor = Color.White;
                    btn.TextAlign = ContentAlignment.BottomCenter;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.Location = new Point(60 * j, 60 * tik);
                    switch (i)
                    {
                        case 1:
                            isim = "A";
                            break;
                        case 2:
                            isim = "B";
                            break;
                        case 3:
                            isim = "C";
                            break;
                        case 4:
                            isim = "D";
                            break;
                        case 5:
                            isim = "E";
                            break;
                        case 6:
                            isim = "F";
                            break;
                        case 7:
                            isim = "G";
                            break;
                        case 8:
                            isim = "H";
                            break;
                    }



                    for (int l = 0; l < numplus; l++)
                    {




                        if (btn.Name == reserve[l] && btn.Text == koltuk[l])
                        {
                            btn.BackColor = Color.Black;
                            btn.Enabled = false;

                        }



                    }
                    bul++;
                    splitContainer1.Panel1.Controls.Add(btn);
                    if (btn.Name == reserve[sayi1] && btn.Text == koltuk[sayac])
                    {
                        btn.BackColor = Color.LimeGreen;
                        btn.Enabled = false;

                    }
                    btn.Click += new EventHandler(btn_Click);
                }
                sayac = 0;
                Label lab = new Label();
                lab.Location = new Point(25, 62 * tik);
                splitContainer1.Panel1.Controls.Add(lab);

                switch (tik)
                {
                    case 1:
                        lab.Text = "A";
                        break;
                    case 2:
                        lab.Text = "B";
                        break;
                    case 3:
                        lab.Text = "C";
                        break;
                    case 4:
                        lab.Text = "D";
                        break;
                    case 5:
                        lab.Text = "E";
                        break;
                    case 6:
                        lab.Text = "F";
                        break;
                    case 7:
                        lab.Text = "G";
                        break;
                    case 8:
                        lab.Text = "H";
                        break;
                }
                tik++;
            }

        }
        void ReserveKarısıkOlustur()
        {
            Salonlar sal = _db.Salonlars.First(x => x.Id == Form1.Aktarma2);
            label1.Text = sal.SalonNo.ToString();
            sira = sal.SiraNo.ToString();
            for (int i = 0; i < int.Parse(sira); i++)
            {
                num++;
                if (degerler[i] == '1')  
                {
                    for (int a = 1; a <= 15; a++)
                    {
                        sayac++;
                        Button btn = new Button();
                        btn.Text = sayac.ToString();
                        switch (num)
                        {
                            case 1:
                                btn.Name = "A";
                                break;
                            case 2:
                                btn.Name = "B";
                                break;
                            case 3:
                                btn.Name = "C";
                                break;
                            case 4:
                                btn.Name = "D";
                                break;
                            case 5:
                                btn.Name = "E";
                                break;
                            case 6:
                                btn.Name = "F";
                                break;
                            case 7:
                                btn.Name = "G";
                                break;
                            case 8:
                                btn.Name = "H";
                                break;
                        }

                        btn.Size = new Size(50, 50);
                        btn.BackgroundImage = Image.FromFile("koltuktekli.png");
                        btn.BackColor = Color.White;
                        btn.TextAlign = ContentAlignment.BottomCenter;
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        btn.Location = new Point(60 * a, 60 * num);
                        for (int l = 0; l < numplus; l++)
                        {




                            if (btn.Name == reserve[l] && btn.Text == koltuk[l])
                            {
                                btn.BackColor = Color.Black;
                                btn.Enabled = false;

                            }



                        }
                        bul++;

                        splitContainer1.Panel1.Controls.Add(btn);
                        btn.Click += new EventHandler(btn_Click);
                        Label lab = new Label();
                        lab.Location = new Point(25, 62 * num);
                        splitContainer1.Panel1.Controls.Add(lab);
                        switch (num)
                        {
                            case 1:
                                lab.Text = "A";
                                break;
                            case 2:
                                lab.Text = "B";
                                break;
                            case 3:
                                lab.Text = "C";
                                break;
                            case 4:
                                lab.Text = "D";
                                break;
                            case 5:
                                lab.Text = "E";
                                break;
                            case 6:
                                lab.Text = "F";
                                break;
                            case 7:
                                lab.Text = "G";
                                break;
                            case 8:
                                lab.Text = "H";
                                break;
                        }
                    }
                    sayac = 0;

                }
                if (degerler[i] == '2')
                {
                    for (int a = 1; a <= 15; a++)
                    {
                        sayac++;
                        Button btn = new Button();
                        btn.Text = sayac.ToString();
                        switch (num)
                        {
                            case 1:
                                btn.Name = "A";
                                break;
                            case 2:
                                btn.Name = "B";
                                break;
                            case 3:
                                btn.Name = "C";
                                break;
                            case 4:
                                btn.Name = "D";
                                break;
                            case 5:
                                btn.Name = "E";
                                break;
                            case 6:
                                btn.Name = "F";
                                break;
                            case 7:
                                btn.Name = "G";
                                break;
                            case 8:
                                btn.Name = "H";
                                break;
                        }
                        btn.Size = new Size(50, 50);
                        btn.BackgroundImage = Image.FromFile("koltuk.png");
                        btn.BackColor = Color.White;
                        btn.TextAlign = ContentAlignment.BottomCenter;
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        btn.Location = new Point(60 * a, 60 * num);
                        for (int l = 0; l < numplus; l++)
                        {




                            if (btn.Name == reserve[l] && btn.Text == koltuk[l])
                            {
                                btn.BackColor = Color.Black;
                                btn.Enabled = false;

                            }



                        }
                        bul++;
                        splitContainer1.Panel1.Controls.Add(btn);
                        btn.Click += new EventHandler(btn_Click);
                        Label lab = new Label();
                        lab.Location = new Point(25, 62 * num);
                        splitContainer1.Panel1.Controls.Add(lab);
                        switch (num)
                        {
                            case 1:
                                lab.Text = "A";
                                break;
                            case 2:
                                lab.Text = "B";
                                break;
                            case 3:
                                lab.Text = "C";
                                break;
                            case 4:
                                lab.Text = "D";
                                break;
                            case 5:
                                lab.Text = "E";
                                break;
                            case 6:
                                lab.Text = "F";
                                break;
                            case 7:
                                lab.Text = "G";
                                break;
                            case 8:
                                lab.Text = "H";
                                break;
                        }
                    }
                    sayac = 0;
                }
                if (degerler[i] == '3')
                {
                    for (int a = 1; a <= 15; a++)
                    {
                        sayac++;
                        Button btn = new Button();
                        btn.Text = sayac.ToString();
                        switch (num)
                        {
                            case 1:
                                btn.Name = "A";
                                break;
                            case 2:
                                btn.Name = "B";
                                break;
                            case 3:
                                btn.Name = "C";
                                break;
                            case 4:
                                btn.Name = "D";
                                break;
                            case 5:
                                btn.Name = "E";
                                break;
                            case 6:
                                btn.Name = "F";
                                break;
                            case 7:
                                btn.Name = "G";
                                break;
                            case 8:
                                btn.Name = "H";
                                break;
                        }
                        btn.Size = new Size(50, 50);
                        btn.BackgroundImage = Image.FromFile("yatak.png");
                        btn.BackColor = Color.White;
                        btn.TextAlign = ContentAlignment.BottomCenter;
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        btn.Location = new Point(60 * a, 60 * num);
                        for (int l = 0; l < numplus; l++)
                        {




                            if (btn.Name == reserve[l] && btn.Text == koltuk[l])
                            {
                                btn.BackColor = Color.Black;
                                btn.Enabled = false;

                            }



                        }
                        bul++;
                        splitContainer1.Panel1.Controls.Add(btn);
                        btn.Click += new EventHandler(btn_Click);
                        Label lab = new Label();
                        lab.Location = new Point(25, 62 * num);
                        splitContainer1.Panel1.Controls.Add(lab);
                        switch (num)
                        {
                            case 1:
                                lab.Text = "A";
                                break;
                            case 2:
                                lab.Text = "B";
                                break;
                            case 3:
                                lab.Text = "C";
                                break;
                            case 4:
                                lab.Text = "D";
                                break;
                            case 5:
                                lab.Text = "E";
                                break;
                            case 6:
                                lab.Text = "F";
                                break;
                            case 7:
                                lab.Text = "G";
                                break;
                            case 8:
                                lab.Text = "H";
                                break;
                        }
                    }
                    sayac = 0;
                }

            }
        }



        void KoltukOlustur()
        {
            Salonlar sal = _db.Salonlars.First(x => x.Id == Form1.Aktarma2);
            label1.Text = sal.SalonNo.ToString();
            sira = sal.SiraNo.ToString();
            for (int i = 1; i <= int.Parse(sira); i++)
            {

                for (int j = 1; j <= 15; j++)
                {

                    sayac++;
                    Button btn = new Button();
                    btn.Text = sayac.ToString();
                    switch (i)
                    {
                        case 1:
                            btn.Name = "A";
                            break;
                        case 2:
                            btn.Name = "B";
                            break;
                        case 3:
                            btn.Name = "C";
                            break;
                        case 4:
                            btn.Name = "D";
                            break;
                        case 5:
                            btn.Name = "E";
                            break;
                        case 6:
                            btn.Name = "F";
                            break;
                        case 7:
                            btn.Name = "G";
                            break;
                        case 8:
                            btn.Name = "H";
                            break;
                    }
                    btn.Size = new Size(50, 50);
                    btn.BackgroundImage = Image.FromFile("koltuktekli.png");
                    //if (reserve1[sayi1])
                    //{

                    //}


                    btn.BackColor = Color.White;
                    btn.TextAlign = ContentAlignment.BottomCenter;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.Location = new Point(60 * j, 60 * tik);
                    splitContainer1.Panel1.Controls.Add(btn);
                    btn.Click += new EventHandler(btn_Click); //btn.Click diyerek tıklama özelliğine bir event tanımladıma.
                }
                sayac = 0;
                Label lab = new Label();
                lab.Location = new Point(25, 60 * tik);
                splitContainer1.Panel1.Controls.Add(lab);

                switch (tik)
                {
                    case 1:
                        lab.Text = "A";
                        break;
                    case 2:
                        lab.Text = "B";
                        break;
                    case 3:
                        lab.Text = "C";
                        break;
                    case 4:
                        lab.Text = "D";
                        break;
                    case 5:
                        lab.Text = "E";
                        break;
                    case 6:
                        lab.Text = "F";
                        break;
                    case 7:
                        lab.Text = "G";
                        break;
                    case 8:
                        lab.Text = "H";
                        break;
                }
                tik++;
            }
        }
        void SalonTuruBul()
        {
            Salonlar sal = _db.Salonlars.First(x => x.Id == Form1.Aktarma2);
            label1.Text = sal.SalonNo.ToString();
            salonturu = sal.KoltukTuru;
        }
        void CiftKoltukOlustur()
        {
            Salonlar sal = _db.Salonlars.First(x => x.Id == Form1.Aktarma2);
            label1.Text = sal.SalonNo.ToString();
            sira = sal.SiraNo.ToString();
            for (int i = 1; i <= int.Parse(sira); i++)
            {
                for (int j = 1; j <= 15; j++)
                {
                    sayac++;
                    Button btn = new Button();
                    btn.Text = sayac.ToString();
                    switch (i)
                    {
                        case 1:
                            btn.Name = "A";

                            break;
                        case 2:
                            btn.Name = "B";
                            break;
                        case 3:
                            btn.Name = "C";
                            break;
                        case 4:
                            btn.Name = "D";
                            break;
                        case 5:
                            btn.Name = "E";
                            break;
                        case 6:
                            btn.Name = "F";
                            break;
                        case 7:
                            btn.Name = "G";
                            break;
                        case 8:
                            btn.Name = "H";
                            break;

                    }

                    btn.Size = new Size(50, 50);
                    btn.BackgroundImage = Image.FromFile("koltuk.png");
                    btn.BackColor = Color.White;
                    btn.TextAlign = ContentAlignment.BottomCenter;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.Location = new Point(60 * j, 60 * tik);
                    switch (i)
                    {
                        case 1:
                            isim = "A";
                            break;
                        case 2:
                            isim = "B";
                            break;
                        case 3:
                            isim = "C";
                            break;
                        case 4:
                            isim = "D";
                            break;
                        case 5:
                            isim = "E";
                            break;
                        case 6:
                            isim = "F";
                            break;
                        case 7:
                            isim = "G";
                            break;
                        case 8:
                            isim = "H";
                            break;
                    }
                    splitContainer1.Panel1.Controls.Add(btn);
                    btn.Click += new EventHandler(btn_Click);

                }
                sayac = 0;
                Label lab = new Label();
                lab.Location = new Point(25, 62 * tik);
                splitContainer1.Panel1.Controls.Add(lab);

                switch (tik)
                {
                    case 1:
                        lab.Text = "A";
                        break;
                    case 2:
                        lab.Text = "B";
                        break;
                    case 3:
                        lab.Text = "C";
                        break;
                    case 4:
                        lab.Text = "D";
                        break;
                    case 5:
                        lab.Text = "E";
                        break;
                    case 6:
                        lab.Text = "F";
                        break;
                    case 7:
                        lab.Text = "G";
                        break;
                    case 8:
                        lab.Text = "H";
                        break;
                }
                tik++;
            }

        }

        void YatakOlustur()
        {
            Salonlar sal = _db.Salonlars.First(x => x.Id == Form1.Aktarma2);
            label1.Text = sal.SalonNo.ToString();
            sira = sal.SiraNo.ToString();
            for (int i = 1; i <= int.Parse(sira); i++)
            {
                for (int j = 1; j <= 15; j++)
                {
                    sayac++;
                    Button btn = new Button();
                    btn.Text = sayac.ToString();
                    switch (i)
                    {
                        case 1:
                            btn.Name = "A";
                            break;
                        case 2:
                            btn.Name = "B";
                            break;
                        case 3:
                            btn.Name = "C";
                            break;
                        case 4:
                            btn.Name = "D";
                            break;
                        case 5:
                            btn.Name = "E";
                            break;
                        case 6:
                            btn.Name = "F";
                            break;
                        case 7:
                            btn.Name = "G";
                            break;
                        case 8:
                            btn.Name = "H";
                            break;
                    }
                    btn.Size = new Size(50, 50);
                    btn.BackgroundImage = Image.FromFile("yatak.png");
                    btn.BackColor = Color.White;
                    btn.TextAlign = ContentAlignment.BottomCenter;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.Location = new Point(60 * j, 60 * tik);
                    switch (i)
                    {
                        case 1:
                            isim = "A";
                            break;
                        case 2:
                            isim = "B";
                            break;
                        case 3:
                            isim = "C";
                            break;
                        case 4:
                            isim = "D";
                            break;
                        case 5:
                            isim = "E";
                            break;
                        case 6:
                            isim = "F";
                            break;
                        case 7:
                            isim = "G";
                            break;
                        case 8:
                            isim = "H";
                            break;
                    }
                    splitContainer1.Panel1.Controls.Add(btn);
                    btn.Click += new EventHandler(btn_Click);
                }
                sayac = 0;
                Label lab = new Label();
                lab.Location = new Point(25, 62 * tik);
                splitContainer1.Panel1.Controls.Add(lab);

                switch (tik)
                {
                    case 1:
                        lab.Text = "A";
                        break;
                    case 2:
                        lab.Text = "B";
                        break;
                    case 3:
                        lab.Text = "C";
                        break;
                    case 4:
                        lab.Text = "D";
                        break;
                    case 5:
                        lab.Text = "E";
                        break;
                    case 6:
                        lab.Text = "F";
                        break;
                    case 7:
                        lab.Text = "G";
                        break;
                    case 8:
                        lab.Text = "H";
                        break;
                }
                tik++;
            }

        }
        void KarısıkOlustur()
        {
            Salonlar sal = _db.Salonlars.First(x => x.Id == Form1.Aktarma2);
            label1.Text = sal.SalonNo.ToString();
            sira = sal.SiraNo.ToString();
            for (int i = 0; i < int.Parse(sira); i++)
            {
                num++;
                if (degerler[i] == '1')
                {
                    for (int a = 1; a <= 15; a++)
                    {
                        sayac++;
                        Button btn = new Button();
                        btn.Text = sayac.ToString();
                        switch (num)
                        {
                            case 1:
                                btn.Name = "A";
                                break;
                            case 2:
                                btn.Name = "B";
                                break;
                            case 3:
                                btn.Name = "C";
                                break;
                            case 4:
                                btn.Name = "D";
                                break;
                            case 5:
                                btn.Name = "E";
                                break;
                            case 6:
                                btn.Name = "F";
                                break;
                            case 7:
                                btn.Name = "G";
                                break;
                            case 8:
                                btn.Name = "H";
                                break;
                        }

                        btn.Size = new Size(50, 50);
                        btn.BackgroundImage = Image.FromFile("koltuktekli.png");
                        btn.BackColor = Color.White;
                        btn.TextAlign = ContentAlignment.BottomCenter;
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        btn.Location = new Point(60 * a, 60 * num);
                        splitContainer1.Panel1.Controls.Add(btn);
                        btn.Click += new EventHandler(btn_Click);
                        Label lab = new Label();
                        lab.Location = new Point(25, 62 * num);
                        splitContainer1.Panel1.Controls.Add(lab);
                        switch (num)
                        {
                            case 1:
                                lab.Text = "A";
                                break;
                            case 2:
                                lab.Text = "B";
                                break;
                            case 3:
                                lab.Text = "C";
                                break;
                            case 4:
                                lab.Text = "D";
                                break;
                            case 5:
                                lab.Text = "E";
                                break;
                            case 6:
                                lab.Text = "F";
                                break;
                            case 7:
                                lab.Text = "G";
                                break;
                            case 8:
                                lab.Text = "H";
                                break;
                        }
                    }
                    sayac = 0;

                }
                if (degerler[i] == '2')
                {
                    for (int a = 1; a <= 15; a++)
                    {
                        sayac++;
                        Button btn = new Button();
                        btn.Text = sayac.ToString();
                        switch (num)
                        {
                            case 1:
                                btn.Name = "A";
                                break;
                            case 2:
                                btn.Name = "B";
                                break;
                            case 3:
                                btn.Name = "C";
                                break;
                            case 4:
                                btn.Name = "D";
                                break;
                            case 5:
                                btn.Name = "E";
                                break;
                            case 6:
                                btn.Name = "F";
                                break;
                            case 7:
                                btn.Name = "G";
                                break;
                            case 8:
                                btn.Name = "H";
                                break;
                        }
                        btn.Size = new Size(50, 50);
                        btn.BackgroundImage = Image.FromFile("koltuk.png");
                        btn.BackColor = Color.White;
                        btn.TextAlign = ContentAlignment.BottomCenter;
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        btn.Location = new Point(60 * a, 60 * num);
                        splitContainer1.Panel1.Controls.Add(btn);
                        btn.Click += new EventHandler(btn_Click);
                        Label lab = new Label();
                        lab.Location = new Point(25, 62 * num);
                        splitContainer1.Panel1.Controls.Add(lab);
                        switch (num)
                        {
                            case 1:
                                lab.Text = "A";
                                break;
                            case 2:
                                lab.Text = "B";
                                break;
                            case 3:
                                lab.Text = "C";
                                break;
                            case 4:
                                lab.Text = "D";
                                break;
                            case 5:
                                lab.Text = "E";
                                break;
                            case 6:
                                lab.Text = "F";
                                break;
                            case 7:
                                lab.Text = "G";
                                break;
                            case 8:
                                lab.Text = "H";
                                break;
                        }
                    }
                    sayac = 0;
                }
                if (degerler[i] == '3')
                {
                    for (int a = 1; a <= 15; a++)
                    {
                        sayac++;
                        Button btn = new Button();
                        btn.Text = sayac.ToString();
                        switch (num)
                        {
                            case 1:
                                btn.Name = "A";
                                break;
                            case 2:
                                btn.Name = "B";
                                break;
                            case 3:
                                btn.Name = "C";
                                break;
                            case 4:
                                btn.Name = "D";
                                break;
                            case 5:
                                btn.Name = "E";
                                break;
                            case 6:
                                btn.Name = "F";
                                break;
                            case 7:
                                btn.Name = "G";
                                break;
                            case 8:
                                btn.Name = "H";
                                break;
                        }
                        btn.Size = new Size(50, 50);
                        btn.BackgroundImage = Image.FromFile("yatak.png");
                        btn.BackColor = Color.White;
                        btn.TextAlign = ContentAlignment.BottomCenter;
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        btn.Location = new Point(60 * a, 60 * num);
                        splitContainer1.Panel1.Controls.Add(btn);
                        btn.Click += new EventHandler(btn_Click);
                        Label lab = new Label();
                        lab.Location = new Point(25, 62 * num);
                        splitContainer1.Panel1.Controls.Add(lab);
                        switch (num)
                        {
                            case 1:
                                lab.Text = "A";
                                break;
                            case 2:
                                lab.Text = "B";
                                break;
                            case 3:
                                lab.Text = "C";
                                break;
                            case 4:
                                lab.Text = "D";
                                break;
                            case 5:
                                lab.Text = "E";
                                break;
                            case 6:
                                lab.Text = "F";
                                break;
                            case 7:
                                lab.Text = "G";
                                break;
                            case 8:
                                lab.Text = "H";
                                break;
                        }
                    }
                    sayac = 0;
                }

            }
        }

        private void btn_Click(object sender, EventArgs e) // Button click eventi. Koltuklara tıklandığında oluşan olaylar burada...
        {

            Button btn = (Button)sender;

            string kod = ((Button)sender).Name; //Koltuğun name kısmını burada alıyoruz.. (A,B,C,D,E,F,G,H) olma durumunu.
            string yaz = ((Button)sender).Text; // Koltuğun sayısını burada alıyoruz...(1,2,3.....15) olma durumunu..
            string cumle = kod + yaz;// Burada ikisini birleştiriyoruz...

            if (btn.BackColor == Color.White)
            {
                MessageBox.Show(((Button)sender).Name + " - " + ((Button)sender).Text + " alındı ");  //  İlk Tıklandığında ekrana çıktı veriyoruz..
                btn.BackColor = Color.Red;
                listBox1.Items.Add(cumle);
                //lst.Add(cumle);
            }

            else
            {
                MessageBox.Show(((Button)sender).Name + " - " + ((Button)sender).Text + " iptal edildi "); // İkinci tıklandığında ekrana çıktı veriyoruz.
                btn.BackColor = Color.White;
                listBox1.Items.Remove(cumle);
                //lst.Remove(cumle);
            }

            //  isim = "";
        }
        void GuncelleSeans()
        {
            Seanslar seans = _db.Seanslars.First(x => x.Id == Form1.Aktarma3); // Rezerve durumunu true yapan fonksiyon..
            seans.SeansDurum = true;
            _db.SubmitChanges();
        }

        void YeniKaydet()
        {
            for (int i = 0; i < int.Parse(txtBilSay.Text); i++)
            {
                GuncelleSeans();


                BiletKesim bk = new BiletKesim();

                bk.SeansId = Form1.Aktarma3;
                bk.FilmAdi = Form1.Aktarma4;
                bk.SalonNo = Form1.Aktarma5;
                bk.KoltukNo = listBox1.Items[i].ToString();

                if (txtOgrTekSay.Text != "0")
                {
                    bk.BiletTipi = "Tek Öğrenci";
                    bk.Tutar = decimal.Parse(txtOgrTekTfiyat.Text);
                    txtOgrTekSay.Text = "0";
                }
                else if (txtOgrCiftSay.Text != "0")
                {
                    bk.BiletTipi = "Çift Öğrenci";
                    bk.Tutar = decimal.Parse(txtOgrCiftTfiyat.Text);
                    txtOgrCiftSay.Text = "0";
                }
                else if (txtOgrYatSay.Text != "0")
                {
                    bk.BiletTipi = "Yataklı Öğrenci";
                    bk.Tutar = decimal.Parse(txtOgrYatTfiyat.Text);
                    txtOgrYatSay.Text = "0";
                }

                else if (txtNorTekSay.Text != "0")
                {
                    bk.BiletTipi = "Tek Normal";
                    bk.Tutar = decimal.Parse(txtNorTekTfiyat.Text);
                    txtNorTekSay.Text = "0";
                }
                else if (txtNorCiftSay.Text != "0")
                {
                    bk.BiletTipi = "Çift Normal";
                    bk.Tutar = decimal.Parse(txtNorCiftTfiyat.Text);
                    txtNorCiftSay.Text = "0";
                }
                else if (txtNorYatSay.Text != "0")
                {
                    bk.BiletTipi = "Tek Normal";
                    bk.Tutar = decimal.Parse(txtNorYatTfiyat.Text);
                    txtNorYatSay.Text = "0";
                }

                _db.BiletKesims.InsertOnSubmit(bk);
                _db.SubmitChanges();
            }
            MessageBox.Show("Yeni Kayıt Oluşturuldu!");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
    {
        YeniKaydet();
        listBox1.Items.Clear();
    }



        private void button1_Click_1(object sender, EventArgs e)
        {
            BiletGuncelleSil bgs = new BiletGuncelleSil();//Butona basınca bilet güncelle sayfasına git..
            bgs.Show();
        }

        private void btnOgrTekAz_Click(object sender, EventArgs e)
        {
            int sayi2 = int.Parse(txtOgrTekSay.Text);
            if (sayi2 > 0)
            {
                sayi2 = Convert.ToInt32(txtOgrTekSay.Text);
                sayi2 -= 1;
                txtOgrTekSay.Text = sayi2.ToString();
            }
            else
            {
                MessageBox.Show("Bu İşlem Yapılamaz.");
            }
        }

        private void btnOgrTekArt_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtOgrTekSay.Text);
            sayi1 += 1;
            txtOgrTekSay.Text = sayi1.ToString();
        }

        private void btnOgrCiftAz_Click(object sender, EventArgs e)
        {
            int sayi2 = int.Parse(txtOgrCiftSay.Text);
            if (sayi2 > 0)
            {
                sayi2 = Convert.ToInt32(txtOgrCiftSay.Text);
                sayi2 -= 1;
                txtOgrCiftSay.Text = sayi2.ToString();
            }
            else
            {
                MessageBox.Show("Bu İşlem Yapılamaz.");
            }
        }

        private void btnOgrCiftArt_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtOgrCiftSay.Text);
            sayi1 += 1;
            txtOgrCiftSay.Text = sayi1.ToString();
        }

        private void btnOgrYatAz_Click(object sender, EventArgs e)
        {
            int sayi2 = int.Parse(txtOgrYatSay.Text);
            if (sayi2 > 0)
            {
                sayi2 = Convert.ToInt32(txtOgrYatSay.Text);
                sayi2 -= 1;
                txtOgrYatSay.Text = sayi2.ToString();
            }
            else
            {
                MessageBox.Show("Bu İşlem Yapılamaz.");
            }
        }

        private void btnOgrYatArt_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtOgrYatSay.Text);
            sayi1 += 1;
            txtOgrYatSay.Text = sayi1.ToString();
        }

        private void btnNormalTekAz_Click(object sender, EventArgs e)
        {
            int sayi2 = int.Parse(txtNorTekSay.Text);
            if (sayi2 > 0)
            {
                sayi2 = Convert.ToInt32(txtNorTekSay.Text);
                sayi2 -= 1;
                txtNorTekSay.Text = sayi2.ToString();
            }
            else
            {
                MessageBox.Show("Bu İşlem Yapılamaz.");
            }
        }

        private void btnNormalTekArt_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtNorTekSay.Text);
            sayi1 += 1;
            txtNorTekSay.Text = sayi1.ToString();
        }

        private void btnNormalCiftAz_Click(object sender, EventArgs e)
        {
            int sayi2 = int.Parse(txtNorCiftSay.Text);
            if (sayi2 > 0)
            {
                sayi2 = Convert.ToInt32(txtNorCiftSay.Text);
                sayi2 -= 1;
                txtNorCiftSay.Text = sayi2.ToString();
            }
            else
            {
                MessageBox.Show("Bu İşlem Yapılamaz.");
            }
        }

        private void btnNormalCiftArt_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtNorCiftSay.Text);
            sayi1 += 1;
            txtNorCiftSay.Text = sayi1.ToString();
        }

        private void btnNormalYatAz_Click(object sender, EventArgs e)
        {
            int sayi2 = int.Parse(txtNorYatSay.Text);
            if (sayi2 > 0)
            {
                sayi2 = Convert.ToInt32(txtNorYatSay.Text);
                sayi2 -= 1;
                txtNorYatSay.Text = sayi2.ToString();
            }
            else
            {
                MessageBox.Show("Bu İşlem Yapılamaz.");
            }
        }

        private void btnNormalYatArt_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtNorYatSay.Text);
            sayi1 += 1;
            txtNorYatSay.Text = sayi1.ToString();
        }

        private void btnTutar_Click(object sender, EventArgs e)
    {
            int ogrtek = 8;
        decimal ogrcift = 8;
        decimal ogryat = 8;
        decimal nrmtek = 10;
        decimal nrmcift = 10;
        decimal nrmyat = 10;
        if (txtOgrTekSay.Text != "0")
        {
            txtOgrTekTfiyat.Text = ((int.Parse(txtOgrTekSay.Text) * ogrtek)+Form1.ogrtek).ToString();
        }
        if (txtOgrCiftSay.Text != "0")
        {
            txtOgrCiftTfiyat.Text = ((int.Parse(txtOgrCiftSay.Text) * ogrcift)+Form1.ogrcift).ToString();
        }
        if (txtOgrYatSay.Text != "0")
        {
            txtOgrYatTfiyat.Text = ((int.Parse(txtOgrYatSay.Text) * ogryat)+Form1.ogryat).ToString();
        }
        if (txtNorTekSay.Text != "0")
        {
            txtNorTekTfiyat.Text = ((int.Parse(txtNorTekSay.Text) * nrmtek)+Form1.nortek).ToString();
        }
        if (txtNorCiftSay.Text != "0")
        {
            txtNorCiftTfiyat.Text = ((int.Parse(txtNorCiftSay.Text) * nrmcift)+Form1.norcift).ToString();
        }
        if (txtNorYatSay.Text != "0")
        {
            txtNorYatTfiyat.Text = ((int.Parse(txtNorYatSay.Text) * nrmyat)+Form1.ogryat).ToString();
        }
        int toplam = int.Parse(txtOgrTekTfiyat.Text) + int.Parse(txtOgrCiftTfiyat.Text) + int.Parse(txtOgrYatTfiyat.Text) +
                     int.Parse(txtNorTekTfiyat.Text) +
                     int.Parse(txtNorCiftTfiyat.Text) +
                     int.Parse(txtNorYatTfiyat.Text);
        txtFiyat.Text = toplam.ToString();
        txtBilSay.Text = (int.Parse(txtOgrTekSay.Text) + int.Parse(txtOgrCiftSay.Text) + int.Parse(txtOgrYatSay.Text) + int.Parse(txtNorTekSay.Text) + int.Parse(txtNorCiftSay.Text) + int.Parse(txtNorYatSay.Text)).ToString();
        Form1.ogrtek = 0;
        Form1.ogrcift = 0;
        Form1.ogryat = 0;
        Form1.nortek = 0;
        Form1.norcift = 0;
        Form1.noryat = 0;
        Form1.hangisi="";
    }

        private void btnPromosyon_Click(object sender, EventArgs e)
        {
            Form1.hangisi = "ogrtek";
            Liste1 ls = new Liste1();
            ls.Show();
        }

        private void btnOgrciftPro_Click(object sender, EventArgs e)
        {
            Form1.hangisi = "ogrcift";
            Liste1 ls = new Liste1();
            ls.Show();
        }

        private void btnOgryatPro_Click(object sender, EventArgs e)
        {
            Form1.hangisi = "ogryat";
            Liste1 ls = new Liste1();
            ls.Show();
        }

        private void btnNorTekPro_Click(object sender, EventArgs e)
        {
            Form1.hangisi = "nortek";
            Liste1 ls = new Liste1();
            ls.Show();
        }

        private void btnNorCiftPro_Click(object sender, EventArgs e)
        {
            Form1.hangisi = "norcift";
            Liste1 ls = new Liste1();
            ls.Show();
        }

        private void btnNoryatPro_Click(object sender, EventArgs e)
        {
            Form1.hangisi = "noryat";
            Liste1 ls = new Liste1();
            ls.Show();
        }
    }
}

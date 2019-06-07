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
    public partial class SalonGuncelleSil : Form
    {
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
        public SalonGuncelleSil()
        {
            InitializeComponent();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _db.Salonlars.DeleteOnSubmit(_db.Salonlars.First(x => x.SalonNo == int.Parse(cbSalon.Text)));
            _db.SubmitChanges();
            MessageBox.Show("Salon Silindi.");

            cbSalon.Text = "";

            splitContainer1.Panel1.Controls.Clear();
            Close();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SalonGuncelleSil_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            cbSalon.Items.Clear();
            int i = 0;
            var lst = (from s in _db.Salonlars
                select s.SalonNo).ToList();

            foreach (var k in lst)
            {
                cbSalon.Items.Add(k);
                i++;
            }
        }

        void KoltukOlustur()
        {
            Salonlar sal = _db.Salonlars.First(x => x.Id == Form1.Aktarma2);

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
                    //btn.Click diyerek tıklama özelliğine bir event tanımladıma.
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
        //void SalonTuruBul()
        //{
        //    Salonlar sal = _db.Salonlars.First(x => x.Id == Form1.Aktarma2);
        //    label1.Text = sal.SalonNo.ToString();
        //    salonturu = sal.KoltukTuru;
        //}
        void CiftKoltukOlustur()
        {
            Salonlar sal = _db.Salonlars.First(x => x.Id == Form1.Aktarma2);

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

        private void cbSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            var srg = (from s in _db.Salonlars
                where s.SalonNo == int.Parse(cbSalon.Text)
                select s).First();
            Form1.Aktarma2 = srg.Id;
            AktarmaBul();
            if (srg.SalonTuru == "Tekli Koltuk")
            {
                KoltukOlustur();
            }
            if (srg.SalonTuru == "Çiftli Koltuk")
            {
                CiftKoltukOlustur();
            }
            if (srg.SalonTuru == "Yataklı Salon")
            {
                YatakOlustur();
            }
            if (srg.SalonTuru == "Karışık Salon")
            {
                KarısıkOlustur();
            }
        }

        void AktarmaBul()
        {
            Salonlar sal = _db.Salonlars.First(x => x.Id == Form1.Aktarma2);
            sira = sal.SiraNo.ToString();
            aktarma = sal.KoltukAktar.ToString();
            salonturu = sal.KoltukTuru;
            string sayilar1 = aktarma;
            degerler = sayilar1.ToCharArray();

        }
    }
}

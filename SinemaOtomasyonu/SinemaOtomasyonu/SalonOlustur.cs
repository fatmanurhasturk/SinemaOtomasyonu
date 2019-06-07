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
    public partial class SalonOlustur : Form
    {
        public SalonOlustur()
        {
            InitializeComponent();
        }

        private void SalonOlustur_Load(object sender, EventArgs e)
        {
            btnKoltukEkle.Visible = false;  // Sayfa ilk açıldığında koltuk oluşturma butonları görünmeden geliyor.
            btnCiftKoltuk.Visible = false;
            btnYatak.Visible = false;
        }
        DataSinemaDataContext _db = new DataSinemaDataContext();


        int sayac = 0;
        int sayac1 = 0;
        int tik = 1;
        int koltukturu = -1;
        string koltukaktar = "";
        string teklikoltukaktar = "1";
        string ciftlikoltukaktar = "2";
        string yatakaktar = "3";
        string salonturu = "";
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          

            if (comboBox1.SelectedIndex == 0) // Combobax ta seçilen duruma göre o salona ait koltuk oluşturma butonları geliyor.
            {
                koltukturu = comboBox1.SelectedIndex;
                salonturu = "Tekli Koltuk";
                btnKoltukEkle.Visible = true;
                btnCiftKoltuk.Visible = false;
                btnYatak.Visible = false;

            }
            if (comboBox1.SelectedIndex == 1)
            {
                koltukturu = comboBox1.SelectedIndex;
                salonturu = "Çiftli Koltuk";
                btnCiftKoltuk.Visible = true;
                btnYatak.Visible = false;
                btnKoltukEkle.Visible = false;

            }
            if (comboBox1.SelectedIndex == 2)
            {
                koltukturu = comboBox1.SelectedIndex;
                salonturu = "Yataklı Salon";
                btnYatak.Visible = true;
                btnKoltukEkle.Visible = false;
                btnCiftKoltuk.Visible = false;


            }
            if (comboBox1.SelectedIndex == 3)
            {
                koltukturu = comboBox1.SelectedIndex;
                salonturu = "Karışık Salon";
                btnKoltukEkle.Visible = true;
                btnCiftKoltuk.Visible = true;
                btnYatak.Visible = true;

            }

        }
        void KoltukOlustur()
        {
            for (int i = 1; i <= 15; i++) // Bir sıraya 15 tane koltuk oluşturan fonksiyon .. 
            {
                sayac++;


                Button btn = new Button();
                btn.Text = sayac.ToString();
                btn.Size = new Size(60, 60);
                btn.BackColor = System.Drawing.Color.White;
                btn.ForeColor = System.Drawing.Color.Black;
                btn.BackgroundImage = Image.FromFile("koltuktekli.png"); // Butonun resmini veren kod.

                btn.TextAlign = ContentAlignment.BottomCenter; // Butonun textini ortalayan kod.

                btn.BackgroundImageLayout = ImageLayout.Stretch; // Butonun imagesini stretch yapan kod.
                btn.Location = new Point(60 * i, 60 * tik); // Butonun x ve y ekseninde lokasyonunu belirleyen kod.
                splitContainer1.Panel1.Controls.Add(btn);

            }

            Label lab = new Label();
            lab.Location = new Point(25, 63 * tik);
            splitContainer1.Panel1.Controls.Add(lab);

            switch (tik)   // Koltuk numarasına göre koltuk adını çıkan label ı hazırlayan kod..
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
            sayac = 0;
            sayac1++;

        }
        void CiftKoltukOlustur() // Koltuk olustur fonksiyonunu incelerseniz , tek farkın sadece resim olduğunu anlayacaksınız.
        {
            for (int i = 1; i <= 15; i++)
            {
                sayac++;


                Button btn = new Button();
                btn.Text = sayac.ToString();
                btn.Size = new Size(60, 60);
                btn.BackColor = System.Drawing.Color.White;
                btn.ForeColor = System.Drawing.Color.Black;
                btn.BackgroundImage = Image.FromFile("koltuk.png");

                btn.TextAlign = ContentAlignment.BottomCenter;

                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.Location = new Point(60 * i, 60 * tik);
                splitContainer1.Panel1.Controls.Add(btn);

            }

            Label lab = new Label();
            lab.Location = new Point(25, 63 * tik);
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
            sayac = 0;
            sayac1++;

        }
        void YatakOlustur() // Bunda da tek fark resim..
        {
            for (int i = 1; i <= 15; i++)
            {
                sayac++;


                Button btn = new Button();
                btn.Text = sayac.ToString();
                btn.Size = new Size(60, 60);
                btn.BackColor = System.Drawing.Color.White;
                btn.ForeColor = System.Drawing.Color.Black;
                btn.BackgroundImage = Image.FromFile("yatak.png");

                btn.TextAlign = ContentAlignment.BottomCenter;

                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.Location = new Point(60 * i, 60 * tik);
                splitContainer1.Panel1.Controls.Add(btn);

            }

            Label lab = new Label();
            lab.Location = new Point(25, 63 * tik);
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
            sayac = 0;
            sayac1++;

        }
        private void btnKoltukEkle_Click(object sender, EventArgs e)
        {
          
        }

        //private void btnKaydet_Click(object sender, EventArgs e)
        //{
        //    Salonlar sal = new Salonlar()
        //    {

        //        SalonNo=int.Parse(textBox1.Text),
        //        Kapasite=15*tik,
        //        SiraNo=sayac1,
        //        SalonTuru=salonturu
             



        //    };
        //    _db.Salonlars.InsertOnSubmit(sal);
        //    _db.SubmitChanges();
        //    MessageBox.Show("Salon Kaydı Oluşturulmuştur");
        //    Form1 f1 = new Form1();
        //    f1.Show();
        //    Close();
        //}

        //private void btnKoltukEkle_Click_1(object sender, EventArgs e)
        //{
        //    if (tik > 8)
        //    {
        //        MessageBox.Show("Daha Fazla Koltuk ya da Yatak  Ekleyemezsiniz");

        //    }
        //    else
        //    {
        //        if (koltukturu==3)
        //        {
        //            KoltukOlustur();
        //            tik++;
        //            koltukaktar = koltukaktar + teklikoltukaktar;
        //        }
        //        else
        //        {
        //            KoltukOlustur();
        //            tik++;
        //        }
               

        //    }
        //}
        
        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            Salonlar sal = new Salonlar()
            {
                
                SalonNo = int.Parse(textBox1.Text), // Salon numarasını 
                Kapasite = 15 * sayac1, // Salonun kaç kişilik olduğunu
                SiraNo = sayac1, // Salonun kaç adet 15 koltukluk sıradan oluştuğunu
                KoltukAktar = koltukaktar, // Eğer karışık salonsa tekli çiftli yatak  olma durumunun sırasını kaydeden string cümlemiz
                KoltukTuru = salonturu, // Salon türünü
                
                // Veritabanına kaydeden kod.

                




            };
            _db.Salonlars.InsertOnSubmit(sal);
            _db.SubmitChanges();
            MessageBox.Show("Salon Kaydı Oluşturulmuştur");
            Form1 f1 = new Form1();
            f1.Show();
            Close();

        }

        //private void btnCiftKoltuk_Click(object sender, EventArgs e)
        //{
        //    if (tik > 8)
        //    {
        //        MessageBox.Show("Daha Fazla Koltuk ya da Yatak  Ekleyemezsiniz");

        //    }
        //    else
        //    {
        //        if (koltukturu == 3)
        //        {
        //            CiftKoltukOlustur();
        //            tik++;
        //            koltukaktar = koltukaktar + ciftlikoltukaktar;
        //        }
        //        else
        //        {
        //            CiftKoltukOlustur();
        //            tik++;
        //        }

        //    }
        //}

        //private void btnYatak_Click(object sender, EventArgs e)
        //{
        //    if (tik > 8)
        //    {
        //        MessageBox.Show("Daha Fazla Koltuk ya da Yatak  Ekleyemezsiniz");

        //    }
        //    else
        //    {
        //        if (koltukturu == 3)
        //        {
        //            YatakOlustur();
        //            tik++;
        //            koltukaktar = koltukaktar + yatakaktar;
        //        }
        //        else
        //        {
        //            YatakOlustur();
        //            tik++;
        //        }

        //    }
        //}

        //private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        //{
        //    if (comboBox1.SelectedIndex == 0)
        //    {
        //        koltukturu = comboBox1.SelectedIndex;
        //        salonturu = "Tekli Koltuk";
        //        btnKoltukEkle.Visible = true;
        //        btnCiftKoltuk.Visible = false;
        //        btnYatak.Visible = false;

        //    }
        //    if (comboBox1.SelectedIndex == 1)
        //    {
        //        koltukturu = comboBox1.SelectedIndex;
        //        salonturu = "Çiftli Koltuk";
        //        btnCiftKoltuk.Visible = true;
        //        btnYatak.Visible = false;
        //        btnKoltukEkle.Visible = false;

        //    }
        //    if (comboBox1.SelectedIndex == 2)
        //    {
        //        koltukturu = comboBox1.SelectedIndex;
        //        salonturu = "Yataklı Salon";
        //        btnYatak.Visible = true;
        //        btnKoltukEkle.Visible = false;
        //        btnCiftKoltuk.Visible = false;


        //    }
        //    if (comboBox1.SelectedIndex == 3)
        //    {
        //        koltukturu = comboBox1.SelectedIndex;
        //        salonturu = "Karışık Salon";
        //        btnKoltukEkle.Visible = true;
        //        btnCiftKoltuk.Visible = true;
        //        btnYatak.Visible = true;

        //    }
        //}

        //private void btnKoltukEkle_Click_2(object sender, EventArgs e)
        //{
        //    if (tik > 8)
        //    {
        //        MessageBox.Show("Daha Fazla Koltuk ya da Yatak  Ekleyemezsiniz");

        //    }
        //    else
        //    {
        //        if (koltukturu == 3)
        //        {
        //            KoltukOlustur();
        //            tik++;
        //            koltukaktar = koltukaktar + teklikoltukaktar;
        //        }
        //        else
        //        {
        //            KoltukOlustur();
        //            tik++;
        //        }


        //    }
        //}

        //private void btnCiftKoltuk_Click_2(object sender, EventArgs e)
        //{
        //    if (tik > 8)
        //    {
        //        MessageBox.Show("Daha Fazla Koltuk ya da Yatak  Ekleyemezsiniz");

        //    }
        //    else
        //    {
        //        if (koltukturu == 3)
        //        {
        //            CiftKoltukOlustur();
        //            tik++;
        //            koltukaktar = koltukaktar + ciftlikoltukaktar;
        //        }
        //        else
        //        {
        //            CiftKoltukOlustur();
        //            tik++;
        //        }

        //    }
        //}

        //private void btnYatak_Click_1(object sender, EventArgs e)
        //{
        //    if (tik > 8)
        //    {
        //        MessageBox.Show("Daha Fazla Koltuk ya da Yatak  Ekleyemezsiniz");

        //    }
        //    else
        //    {
        //        if (koltukturu == 3)
        //        {
        //            YatakOlustur();
        //            tik++;
        //            koltukaktar = koltukaktar + yatakaktar;
        //        }
        //        else
        //        {
        //            YatakOlustur();
        //            tik++;
        //        }

        //    }
        //}

        //private void btnKaydet_Click_2(object sender, EventArgs e)
        //{
          





        //    Salonlar sal = new Salonlar()
        //    {

        //        SalonNo = int.Parse(textBox1.Text),
        //        Kapasite = 15 * sayac1,
        //        SiraNo = sayac1,
        //        KoltukAktar = koltukaktar,
        //        SalonTuru = salonturu,
        //        KoltukTuru = salonturu,
        //        DurumBir=0,
        //        Durumİki=0,
        //        DurumUc=0,
        //        DurumDort=0,
        //        DurumBes=0






        //    };
          
        //    _db.Salonlars.InsertOnSubmit(sal);
        //    _db.SubmitChanges();
        //    MessageBox.Show("Salon Kaydı Oluşturulmuştur");
        //    Form1 f1 = new Form1();
        //    f1.Show();
        //    Close();
        //}

        private void btnKoltukEkle_Click_3(object sender, EventArgs e)
        {
            if (tik > 8) // 8 sıradan fazla koltuk eklememeyi kontrol eden kod.
            {
                MessageBox.Show("Daha Fazla Koltuk ya da Yatak  Ekleyemezsiniz");

            }
            else
            {
                if (koltukturu == 3) // Karışık salon olma durumunda koltuk aktarma cümlemizi hazırlayan  kod.
                {
                    KoltukOlustur();
                    tik++;
                    koltukaktar = koltukaktar + teklikoltukaktar;
                }
                else
                {
                    KoltukOlustur();
                    tik++;
                }


            }
        }

        private void btnKaydet_Click_3(object sender, EventArgs e)
        {


            Salonlar sal = new Salonlar()
            {

                SalonNo = int.Parse(textBox1.Text), 
                Kapasite = 15 * sayac1,
                SiraNo = sayac1,
                KoltukAktar = koltukaktar,
                SalonTuru = salonturu,
                KoltukTuru = salonturu,
                DurumBir = 0,
                Durumİki = 0,
                DurumUc = 0,
                DurumDort = 0,
                DurumBes = 0

                
            };

            _db.Salonlars.InsertOnSubmit(sal);
            _db.SubmitChanges();
            MessageBox.Show("Salon Kaydı Oluşturulmuştur");
            Form1 f1 = new Form1();
            f1.Show();
            Close();
        }

        private void btnYatak_Click_2(object sender, EventArgs e)
        {
            if (tik > 8)
            {
                MessageBox.Show("Daha Fazla Koltuk ya da Yatak  Ekleyemezsiniz");

            }
            else
            {
                if (koltukturu == 3)
                {
                    YatakOlustur();
                    tik++;
                    koltukaktar = koltukaktar + yatakaktar;
                }
                else
                {
                    YatakOlustur();
                    tik++;
                }

            }
        }

        private void btnCiftKoltuk_Click_1(object sender, EventArgs e)
        {
            if (tik > 8)
            {
                MessageBox.Show("Daha Fazla Koltuk ya da Yatak  Ekleyemezsiniz");

            }
            else
            {
                if (koltukturu == 3)
                {
                    CiftKoltukOlustur();
                    tik++;
                    koltukaktar = koltukaktar + ciftlikoltukaktar;
                }
                else
                {
                    CiftKoltukOlustur();
                    tik++;
                }

            }
        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                koltukturu = comboBox1.SelectedIndex;
                salonturu = "Tekli Koltuk";
                btnKoltukEkle.Visible = true;
                btnCiftKoltuk.Visible = false;
                btnYatak.Visible = false;

            }
            if (comboBox1.SelectedIndex == 1)
            {
                koltukturu = comboBox1.SelectedIndex;
                salonturu = "Çiftli Koltuk";
                btnCiftKoltuk.Visible = true;
                btnYatak.Visible = false;
                btnKoltukEkle.Visible = false;

            }
            if (comboBox1.SelectedIndex == 2)
            {
                koltukturu = comboBox1.SelectedIndex;
                salonturu = "Yataklı Salon";
                btnYatak.Visible = true;
                btnKoltukEkle.Visible = false;
                btnCiftKoltuk.Visible = false;


            }
            if (comboBox1.SelectedIndex == 3)
            {
                koltukturu = comboBox1.SelectedIndex;
                salonturu = "Karışık Salon";
                btnKoltukEkle.Visible = true;
                btnCiftKoltuk.Visible = true;
                btnYatak.Visible = true;

            }
        }
    }
}

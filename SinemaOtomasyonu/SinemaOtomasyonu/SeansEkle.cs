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
    public partial class SeansEkle : Form
    {
        public SeansEkle()
        {
            InitializeComponent();
        }

        int _secimId = -1;
        int tipi = -1;

        DataSinemaDataContext _db = new DataSinemaDataContext();
       
        void ListeleFlm()//Comboxın içine filmler tablosundan film adını ekliyor..
        {
            int i = 0;
            var lst = (from s in _db.Filmlers
                       select s.FAdi).ToList();
            foreach (var k in lst)
            {
                cbFilmler.Items.Add(k);
                i++;
            }
        }
        

        private void SeansEkle_Load(object sender, EventArgs e)
        {
            //ListeleSln();
            ListeleFlm();
            //ListeleGrid();
        }
        void GuncelleSıfır()
        {
            Salonlar sal = _db.Salonlars.First(x => x.Id ==_secimId);
            sal.DurumBir = 1;
            _db.SubmitChanges();

        }
        void GuncelleBir() {
            Salonlar sal = _db.Salonlars.First(x => x.Id == _secimId);
            sal.Durumİki = 1;
            _db.SubmitChanges();
        }
        void Guncelleİki() {
            Salonlar sal = _db.Salonlars.First(x => x.Id == _secimId);
            sal.DurumUc = 1;
            _db.SubmitChanges();
        }
        void GuncelleUc() {
            Salonlar sal = _db.Salonlars.First(x => x.Id == _secimId);
            sal.DurumDort = 1;
            _db.SubmitChanges();
        }
        void GuncelleDort() {
            Salonlar sal = _db.Salonlars.First(x => x.Id == _secimId);
            sal.DurumBes = 1;
            _db.SubmitChanges();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            Seanslar seans = new Seanslar()
            {
                FilmId = _db.Filmlers.First(x => x.FAdi == cbFilmler.Text).Id,
                SalonId=_secimId,
                Seans = cbSaat.Text,
                SeansDurum = true
                
            };
            switch (tipi)
            {
                case 0: GuncelleSıfır();
                    break;
                case 1:
                    GuncelleBir();
                    break;
                case 2:
                    Guncelleİki();
                    break;
                case 3:
                    GuncelleUc();
                    break;
                case 4:
                    GuncelleDort();
                    break;
            }
            _db.Seanslars.InsertOnSubmit(seans);
            _db.SubmitChanges();
            MessageBox.Show("Seans Kaydı Oluşturulmuştur");
            Liste.Rows.Clear();


        }

        private void cbFilmler_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ListeleGrid();
        }

        private void cbSalonlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ListeleGrid();
            //ListeleCheck();
        }

        private void cbSaat_SelectedIndexChanged(object sender, EventArgs e)
        {
            Liste.Rows.Clear();
            if (cbSaat.SelectedIndex==0)
            {
                tipi = 0;
                int i = 0;

                var lst = (from s in _db.Salonlars
                           where s.DurumBir==0


                           select s).ToList();
                foreach (var k in lst)
                {
                    Liste.Rows.Add();
                    Liste.Rows[i].Cells[0].Value = k.Id;
                    Liste.Rows[i].Cells[1].Value = k.SalonNo;
                    Liste.Rows[i].Cells[2].Value = k.KoltukTuru;
                    Liste.Rows[i].Cells[3].Value = k.Kapasite;

                    i++;

                }
            }
            if (cbSaat.SelectedIndex == 1)
            {
                Liste.Rows.Clear();
                tipi = 1;
                int i = 0;

                var lst = (from s in _db.Salonlars
                           where s.Durumİki == 0


                           select s).ToList();
                foreach (var k in lst)
                {
                    Liste.Rows.Add();
                    Liste.Rows[i].Cells[0].Value = k.Id;
                    Liste.Rows[i].Cells[1].Value = k.SalonNo;
                    Liste.Rows[i].Cells[2].Value = k.KoltukTuru;
                    Liste.Rows[i].Cells[3].Value = k.Kapasite;

                    i++;

                }
            }
            if (cbSaat.SelectedIndex == 2)
            {
                Liste.Rows.Clear();
                tipi = 2;
                int i = 0;

                var lst = (from s in _db.Salonlars
                           where s.DurumUc == 0


                           select s).ToList();
                foreach (var k in lst)
                {
                    Liste.Rows.Add();
                    Liste.Rows[i].Cells[0].Value = k.Id;
                    Liste.Rows[i].Cells[1].Value = k.SalonNo;
                    Liste.Rows[i].Cells[2].Value = k.KoltukTuru;
                    Liste.Rows[i].Cells[3].Value = k.Kapasite;

                    i++;

                }
            }
            if (cbSaat.SelectedIndex == 3)
            {
                Liste.Rows.Clear();
                tipi = 3;
                int i = 0;

                var lst = (from s in _db.Salonlars
                           where s.DurumDort == 0


                           select s).ToList();
                foreach (var k in lst)
                {
                    Liste.Rows.Add();
                    Liste.Rows[i].Cells[0].Value = k.Id;
                    Liste.Rows[i].Cells[1].Value = k.SalonNo;
                    Liste.Rows[i].Cells[2].Value = k.KoltukTuru;
                    Liste.Rows[i].Cells[3].Value = k.Kapasite;

                    i++;

                }
            }
            if (cbSaat.SelectedIndex == 4)
            {
                Liste.Rows.Clear();
                tipi = 4;
                int i = 0;

                var lst = (from s in _db.Salonlars
                           where s.DurumBes == 0


                           select s).ToList();
                foreach (var k in lst)
                {
                    Liste.Rows.Add();
                    Liste.Rows[i].Cells[0].Value = k.Id;
                    Liste.Rows[i].Cells[1].Value = k.SalonNo;
                    Liste.Rows[i].Cells[2].Value = k.KoltukTuru;
                    Liste.Rows[i].Cells[3].Value = k.Kapasite;

                    i++;

                }

            }
        }

        private void Liste_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _secimId= int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());

        }



        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
    }
}

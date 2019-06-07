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
    public partial class BiletGuncelleSil : Form
    {
        DataSinemaDataContext _db = new DataSinemaDataContext();

        public bool Secim = false;
        int _secimId = -1;


        public BiletGuncelleSil()
        {
            InitializeComponent();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            Yaz();
        }

        void Yaz()
        {
            Print.frmPrint prn = new Print.frmPrint();
            prn.HangiListe = "BD";
            prn.Show();
        }

        private void BiletGuncelleSil_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var lst = (from c in _db.vwBiletDuzenles
                       where c.SeansId == Form1.Aktarma3


                       select c).ToList();

            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.FilmAdi;
                Liste.Rows[i].Cells[2].Value = k.FTuru;
                Liste.Rows[i].Cells[3].Value = k.DublajT;
                Liste.Rows[i].Cells[4].Value = k.Seans;
                Liste.Rows[i].Cells[5].Value = k.SalonNo;
                Liste.Rows[i].Cells[6].Value = k.KoltukNo;
                Liste.Rows[i].Cells[7].Value = k.Teknoloji;
                Liste.Rows[i].Cells[8].Value = k.Sure;
                Liste.Rows[i].Cells[9].Value = k.BiletTipi;
                Liste.Rows[i].Cells[10].Value = k.Tutar;

                i++;
            }
            Liste.AllowUserToAddRows = false;
        }

        //void Sec()
        //{
        //    try
        //    {
        //        if (Liste.CurrentRow != null) _secimId = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());
        //    }
        //    catch (Exception)
        //    {
        //        _secimId = -1;
        //    }
        //}

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            _secimId = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());
        }

        void Sil()
        {
            _db.BiletKesims.DeleteOnSubmit(_db.BiletKesims.First(x => x.Id == _secimId));
            _db.SubmitChanges();
            MessageBox.Show("Seçilen Bilet  Silindi.");

            Listele();
            //for (int i = 0; i < Liste.RowCount; i++)
            //{
            //    var lst = _db.vwBiletDuzenles.First(x => x.Id == int.Parse(Liste.Rows[i].Cells[0].Value.ToString()));

            //    _db.SubmitChanges();

            //}

            //BiletGuncelleSil gns = new BiletGuncelleSil();
            //var bgs = (from c in _db.BiletKesims

            //           select c).ToList();


            //_db.BiletKesims.DeleteAllOnSubmit(bgs);//Deleteallonsubmit hepsini sil komutudur..
            //_db.SubmitChanges();


            //MessageBox.Show("Silme işlemi başarılı!");
            //Close();

        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }

    }
   
}


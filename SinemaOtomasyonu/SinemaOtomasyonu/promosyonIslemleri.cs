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
    public partial class promosyonIslemleri : Form
    {
        DataSinemaDataContext _db = new DataSinemaDataContext();
        public promosyonIslemleri()
        {
            InitializeComponent();
        }

        private void btnİslemler_Click(object sender, EventArgs e)
        {
            Liste1 pro = new Liste1();

            pro.Show();
        }

        void YeniKaydet()
        {
            Promosyon pro = new Promosyon
            {
                PromosyonAdi = txtAd.Text,
                Aciklama = txtProİcerik.Text,
                PTutar = int.Parse(txtFiyat.Text),




            };
            _db.Promosyons.InsertOnSubmit(pro);
            _db.SubmitChanges();
            MessageBox.Show("Promosyon Kaydı Oluşturulmuştur");

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKaydet();
        }
    }
}

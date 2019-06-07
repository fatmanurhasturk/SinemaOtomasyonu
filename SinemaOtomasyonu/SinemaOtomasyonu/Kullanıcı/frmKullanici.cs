using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu.Kullanıcı
{
    public partial class frmKullanici : Form
    {
        public frmKullanici()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string sifre, sifre2;
            sifre = txtSifre.Text;
            sifre2 = txtSifre.Text;

            if (cbKulAdi.SelectedIndex == 0 && sifre == "123")
            {
                this.Hide();
                Form1 frmyönet = new Form1();
                frmyönet.Show();
            }

            else if (cbKulAdi.SelectedIndex == 1 && sifre2 == "345")
            {
                this.Hide();
                frmAdmin frmadmin = new frmAdmin();
                frmadmin.Show();
            }
            else
            {
                MessageBox.Show("Hatalı şifre");
            }
        }

        private void frmKullanici_Load(object sender, EventArgs e)
        {

        }

       
    }
}

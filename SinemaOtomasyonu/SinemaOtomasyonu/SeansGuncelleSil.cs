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
    public partial class SeansGuncelleSil : Form
    {
        DataSinemaDataContext _db = new DataSinemaDataContext();
        public SeansGuncelleSil()
        {
            InitializeComponent();
        }

        private void SeansGuncelleSil_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            int i = 0;

            var lst = (from s in _db.Seanslars


                       select s).ToList();
            foreach (var k in lst)
            {
                Liste1.Rows.Add();
                Liste1.Rows[i].Cells[0].Value = k.Id;
                Liste1.Rows[i].Cells[1].Value = k.FilmId;
                //Liste1.Rows[i].Cells[2].Value = k.Seans;
                Liste1.Rows[i].Cells[3].Value = k.SalonId;
                i++;

            }

            cbFilmId.Items.Clear();
            i = 0;
            var lst1 = (from s in _db.Filmlers
                        select s.Id).ToList();

            foreach (var k in lst1)
            {
                cbFilmId.Items.Add(k);
                i++;
            }

            cbSalonId.Items.Clear();
            i = 0;
            var lst2 = (from s in _db.Salonlars
                        select s.Id).ToList();

            foreach (var k in lst2)
            {
                cbSalonId.Items.Add(k);
                i++;
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        void Guncelle()
        {
            Seanslar s = _db.Seanslars.First(x => x.Id == int.Parse(Liste1.CurrentRow.Cells[0].Value.ToString()));
            s.FilmId = int.Parse(cbFilmId.Text);
            //s.Seans = txtSeans.Text;
            s.SalonId = int.Parse(cbSalonId.Text);

            _db.SubmitChanges();
            MessageBox.Show("seans Düzeltildi.");
            Temizle();
            Listele();
        }

        void Temizle()
        {
            foreach (Control ct in Controls)
            {
                if (ct is TextBox || ct is ComboBox)
                {
                    ct.Text = "";
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _db.Seanslars.DeleteOnSubmit(_db.Seanslars.First(x => x.Id == int.Parse(Liste1.SelectedCells[0].ToString())));
            _db.SubmitChanges();
            MessageBox.Show("seans Silindi.");
            Temizle();
            Listele();
        }

        private void Liste1_DoubleClick(object sender, EventArgs e)
        {
            cbFilmId.Text = Liste1.CurrentRow.Cells[1].Value.ToString();
            txtSeans.Text = Liste1.CurrentRow.Cells[2].Value.ToString();
            cbSalonId.Text = Liste1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}

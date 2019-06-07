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
    public partial class FilmSeans : Form
    {
        DataSinemaDataContext _db = new DataSinemaDataContext();
        public FilmSeans()
        {
            InitializeComponent();
        }

        private void FilmSeans_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Form1.Aktarma2 = int.Parse(Liste.CurrentRow.Cells[1].Value.ToString());
            Form1.Aktarma3 = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());

            Form1.Aktarma5 = int.Parse(Liste.CurrentRow.Cells[4].Value.ToString());
            BiletKes bk = new BiletKes();
            bk.Show();
        }

        void Listele()
        {
            int i = 0;
            var lst = (from s in _db.Seanslars
                       where s.FilmId == Form1.Aktarma
                       select s).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.SalonId;

                Liste.Rows[i].Cells[2].Value = _db.Salonlars.First(x => x.Id == k.SalonId).SalonNo.ToString();
                Liste.Rows[i].Cells[3].Value = k.Seans;
                Liste.Rows[i].Cells[4].Value = _db.Salonlars.First(x => x.Id == k.SalonId).Kapasite.ToString();
                i++;
            }
        }
    }
}

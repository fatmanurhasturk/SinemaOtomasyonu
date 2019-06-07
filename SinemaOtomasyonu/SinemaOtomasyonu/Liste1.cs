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
    public partial class Liste1 : Form
    {
        DataSinemaDataContext _db = new DataSinemaDataContext();
        public Liste1()
        {
            InitializeComponent();
        }

        private void Liste1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            int i = 0;
            var lst = (from s in _db.Promosyons
                select s).ToList();

            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.PromosyonAdi;
                Liste.Rows[i].Cells[2].Value = k.PTutar;
                i++;
            }

        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            if (Form1.hangisi=="ogrtek")
            {
                Form1.ogrtek = int.Parse(Liste.CurrentRow.Cells[2].Value.ToString())*int.Parse(nmAdet.Value.ToString());
            }
            else if(Form1.hangisi=="ogrcift")
            {
                Form1.ogrcift = int.Parse(Liste.CurrentRow.Cells[2].Value.ToString()) * int.Parse(nmAdet.Value.ToString());
            }
            else if (Form1.hangisi == "ogryat")
            {
                Form1.ogryat = int.Parse(Liste.CurrentRow.Cells[2].Value.ToString()) * int.Parse(nmAdet.Value.ToString());
            }
            else if (Form1.hangisi == "nortek")
            {
                Form1.nortek = int.Parse(Liste.CurrentRow.Cells[2].Value.ToString()) * int.Parse(nmAdet.Value.ToString());
            }
            else if (Form1.hangisi == "norcift")
            {
                Form1.norcift = int.Parse(Liste.CurrentRow.Cells[2].Value.ToString()) * int.Parse(nmAdet.Value.ToString());
            }
            else if (Form1.hangisi == "noryat")
            {
                Form1.noryat = int.Parse(Liste.CurrentRow.Cells[2].Value.ToString()) * int.Parse(nmAdet.Value.ToString());
            }

            Form1.hangisi = "";
            Close();
        }
    }
}

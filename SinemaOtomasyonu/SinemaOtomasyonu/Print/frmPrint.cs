using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu.Print
{
    public partial class frmPrint : Form
    {
        DataSinemaDataContext _db = new DataSinemaDataContext();
        public string HangiListe;
        private readonly object crvPrint;

        public frmPrint()
        {
            InitializeComponent();
        }

        private void Print_Load(object sender, EventArgs e)
        {
            switch (HangiListe)
            {
                case "BD"://Bilet Düzenle'nin kısaltması
                    biletduzenle();
                    break;

                default:
                    break;
            }
        }

        private void biletduzenle()
        {
            int id = Form1.Aktarma;
            BiletGuncelleSil bgs = Application.OpenForms["BiletGuncelleSil"] as BiletGuncelleSil;

            Print.BiletDuzenle cr = new BiletDuzenle();

            var srg = (from s in _db.vwBiletDuzenles
                       where s.Id == id
                       select s).ToList();
            if (srg != null)
            {
                PrintYardım ch = new PrintYardım();//printyardımı yeni baştan oluşturuyoruz her geldiğinde sıfırlansın..
                DataTable dt = ch.ConvertTo(srg);
                //cr.SetDataSource(dt);
                //crvPrint.ReportSource = cr;

            }
            Form1.Aktarma = -1;

        }
    }
}

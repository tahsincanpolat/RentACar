using RentACar.ORM.Context;
using RentACar.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class frmAracDetayVeKirala : Form
    {
        public string kid;
        public int id;
        public string base64Image;

        ProjectContext db = new ProjectContext();
        public frmAracDetayVeKirala()
        {
            InitializeComponent();
        }

        private void frmAracDetayVeKirala_Load(object sender, EventArgs e)
        {
            List<Arabalar> arabalars = new List<Arabalar>();
            arabalars = db.Arabalars.Where(a => a.ID == id).ToList();

            foreach (var araba in arabalars)
            {
                lbl_aractipi.Text = araba.AracTipi.ToString();
                lbl_gunlukfiyat.Text = araba.Fiyat.ToString();
                lbl_marka.Text = araba.Marka.ToString();
                lbl_model.Text = araba.Model.ToString();
                lbl_plaka.Text = araba.Plaka.ToString();
                lbl_vites.Text = araba.Vites.ToString();
                lbl_yakittipi.Text = araba.YakitTipi.ToString();
            }
        }

        private void dtp_alistarihi_ValueChanged(object sender, EventArgs e)
        {
            dtp_teslimtarihi.Enabled = true;
        }

        private void dtp_teslimtarihi_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan GunFarki = dtp_teslimtarihi.Value.Subtract(dtp_alistarihi.Value);
            int gun = GunFarki.Days;

            if (gun < 1)
            {
                MessageBox.Show("Teslim Tarihi Alış Tarihinden önce ve aynı gün olamaz!");
                lbl_gunsayisi.Text = null;
                lbl_faturatutar.Text = null;
            }
            else
            {
                lbl_gunsayisi.Text = gun.ToString();
                double FaturaTutari = gun * Convert.ToDouble(lbl_gunlukfiyat.Text);
                lbl_faturatutar.Text = FaturaTutari.ToString();
            }
        }
    }
}

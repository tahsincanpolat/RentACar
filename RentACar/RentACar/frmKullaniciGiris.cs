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
    public partial class frmKullaniciGiris : Form
    {
        ProjectContext db = new ProjectContext();
        string TC = "";
        string sifre = "";
        int id;
        public frmKullaniciGiris()
        {
            InitializeComponent();
        }

        private void frmKullaniciGiris_Load(object sender, EventArgs e)
        {

        }

        private void lnklb_kayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKullaniciKayit kullaniciKayit = new frmKullaniciKayit();
            kullaniciKayit.Show();
            
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            List<Yoneticiler> ynt = new List<Yoneticiler>();
            ynt = db.Yoneticilers.Where(y => y.TC == txt_TC.Text).ToList();

            foreach (Yoneticiler yonetici in ynt)
            {
                TC = yonetici.TC.ToString();
                sifre = yonetici.Sifre.ToString();
                id = yonetici.ID;
            }

            if(TC == txt_TC.Text)
            {
                if(sifre == txt_sifre.Text)
                {
                    MessageBox.Show("Hoşgeldiniz");
                    frmYoneticiPanel yoneticiPanel = new frmYoneticiPanel();
                    yoneticiPanel.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Şifre Hatalı");
                }
            }
            else
            {
                MessageBox.Show("TC Hatalı");
            }
        }
    }
}

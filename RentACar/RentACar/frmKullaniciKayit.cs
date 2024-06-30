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
    public partial class frmKullaniciKayit : Form
    {
        ProjectContext db = new ProjectContext();
        public frmKullaniciKayit()
        {
            InitializeComponent();
        }

        private void btn_kayitol_Click(object sender, EventArgs e)
        {
            List<Yoneticiler> ynt = new List<Yoneticiler>();
            ynt = db.Yoneticilers.ToList();
            bool kullaniciVar = false;

            foreach (var yonetici in ynt)
            {
                if(yonetici.TC == txt_tc.Text)
                {
                    kullaniciVar = true;
                }
            }


            if(kullaniciVar)
            {
                MessageBox.Show("Bu TC ile daha önce kayıtlı bir kullanıcı mevcut!!");
            }
            else
            {
                // ORM => Object Relational Mapping
                Yoneticiler yonetici = new Yoneticiler()
                {
                    Adi = txt_ad.Text,
                    Soyadi = txt_soyad.Text,
                    EhliyetNo = txt_ehliyetno.Text,
                    Email = txt_email.Text,
                    TC = txt_tc.Text,
                    Sifre = txt_sifre.Text,
                    Adres = txt_adres.Text,
                    Telefon = txt_telefon.Text,
                    AktifMi = true,
                };


                db.Yoneticilers.Add(yonetici);
                db.SaveChanges();
                MessageBox.Show("Kayıt oluşturuldu.");
                this.Hide();
            }
        }
    }
}

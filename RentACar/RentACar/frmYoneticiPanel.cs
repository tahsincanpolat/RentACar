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
    public partial class frmYoneticiPanel : Form
    {
        public string kid;
        public frmYoneticiPanel()
        {
            InitializeComponent();
        }

        private void ts_btn_kiralamalar_MouseHover(object sender, EventArgs e)
        {
            ts_lbl_kiralamalar.Visible = true;
        }

        private void ts_btn_kiralamalar_MouseLeave(object sender, EventArgs e)
        {
            ts_lbl_kiralamalar.Visible = false;
        }

        private void ts_btn_aracekle_MouseHover(object sender, EventArgs e)
        {
            ts_lbl_aracekle.Visible = true;
        }

        private void ts_btn_aracekle_MouseLeave(object sender, EventArgs e)
        {
            ts_lbl_aracekle.Visible = false;
        }

        private void ts_btn_araclistesi_MouseHover(object sender, EventArgs e)
        {
            ts_lbl_araclistesi.Visible = true;
        }

        private void ts_btn_araclistesi_MouseLeave(object sender, EventArgs e)
        {
            ts_lbl_araclistesi.Visible = false;
        }

        private void ts_btn_aracekle_Click(object sender, EventArgs e)
        {
            frmAracEkle aracEkle = new frmAracEkle();
            aracEkle.Show();
        }

        private void ts_btn_araclistesi_Click(object sender, EventArgs e)
        {
            frmAracListesi aracListesi = new frmAracListesi();
            aracListesi.kid = kid;
            aracListesi.Show();
        }

        
    }
}

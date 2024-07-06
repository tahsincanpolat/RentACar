using RentACar.ORM.Context;
using RentACar.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class frmAracEkle : Form
    {

        ProjectContext db = new ProjectContext();
        public frmAracEkle()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_fileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.gif;*.bmp) | *.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if(open.ShowDialog() == DialogResult.OK)
            {
                pb_aracResim.Image = new Bitmap(open.FileName);
                fileName.Text = open.FileName;
            }
        }

        private void btn_aracekle_Click(object sender, EventArgs e)
        {
            // ORM

            string base64;
            using (Image image = pb_aracResim.Image.Clone() as Image)
            {
                base64 = ConvertImageToBase64(image);
            }

            Arabalar araba = new Arabalar()
            {
                Plaka = txt_plaka.Text,
                AracTipi = cb_aractipi.Text,
                Fiyat = Convert.ToDouble(txt_fiyat.Text),
                Marka = txt_marka.Text,
                YakitTipi = cb_yakittipi.Text,
                Vites = cb_vites.Text,
                Model = txt_model.Text,
                AktifMi = false,
                ImageUrl = base64
            };

            db.Arabalars.Add(araba);
            db.SaveChanges();
            MessageBox.Show("Araç Başarıyla Eklendi.");
            this.Hide();
        }

        private string ConvertImageToBase64(Image image)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream,image.RawFormat);
                byte[] imageBytes = memoryStream.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }
    }
}

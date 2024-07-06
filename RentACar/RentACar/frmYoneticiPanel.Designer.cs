namespace RentACar
{
    partial class frmYoneticiPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYoneticiPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ts_btn_kiralamalar = new System.Windows.Forms.ToolStripButton();
            this.ts_lbl_kiralamalar = new System.Windows.Forms.ToolStripLabel();
            this.ts_btn_aracekle = new System.Windows.Forms.ToolStripButton();
            this.ts_lbl_aracekle = new System.Windows.Forms.ToolStripLabel();
            this.ts_btn_araclistesi = new System.Windows.Forms.ToolStripButton();
            this.ts_lbl_araclistesi = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(203, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "UBY RENT A CAR";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_btn_kiralamalar,
            this.ts_lbl_kiralamalar,
            this.ts_btn_aracekle,
            this.ts_lbl_aracekle,
            this.ts_btn_araclistesi,
            this.ts_lbl_araclistesi});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(794, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ts_btn_kiralamalar
            // 
            this.ts_btn_kiralamalar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_btn_kiralamalar.Image = ((System.Drawing.Image)(resources.GetObject("ts_btn_kiralamalar.Image")));
            this.ts_btn_kiralamalar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_kiralamalar.Name = "ts_btn_kiralamalar";
            this.ts_btn_kiralamalar.Size = new System.Drawing.Size(23, 22);
            this.ts_btn_kiralamalar.Text = "Kiralama Listesi";
            this.ts_btn_kiralamalar.MouseLeave += new System.EventHandler(this.ts_btn_kiralamalar_MouseLeave);
            this.ts_btn_kiralamalar.MouseHover += new System.EventHandler(this.ts_btn_kiralamalar_MouseHover);
            // 
            // ts_lbl_kiralamalar
            // 
            this.ts_lbl_kiralamalar.Name = "ts_lbl_kiralamalar";
            this.ts_lbl_kiralamalar.Size = new System.Drawing.Size(89, 22);
            this.ts_lbl_kiralamalar.Text = "Kiralamalar";
            this.ts_lbl_kiralamalar.Visible = false;
            // 
            // ts_btn_aracekle
            // 
            this.ts_btn_aracekle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_btn_aracekle.Image = ((System.Drawing.Image)(resources.GetObject("ts_btn_aracekle.Image")));
            this.ts_btn_aracekle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_aracekle.Name = "ts_btn_aracekle";
            this.ts_btn_aracekle.Size = new System.Drawing.Size(23, 22);
            this.ts_btn_aracekle.Text = "Araç Ekleme";
            this.ts_btn_aracekle.Click += new System.EventHandler(this.ts_btn_aracekle_Click);
            this.ts_btn_aracekle.MouseLeave += new System.EventHandler(this.ts_btn_aracekle_MouseLeave);
            this.ts_btn_aracekle.MouseHover += new System.EventHandler(this.ts_btn_aracekle_MouseHover);
            // 
            // ts_lbl_aracekle
            // 
            this.ts_lbl_aracekle.Name = "ts_lbl_aracekle";
            this.ts_lbl_aracekle.Size = new System.Drawing.Size(73, 22);
            this.ts_lbl_aracekle.Text = "Araç Ekle";
            this.ts_lbl_aracekle.Visible = false;
            // 
            // ts_btn_araclistesi
            // 
            this.ts_btn_araclistesi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_btn_araclistesi.Image = ((System.Drawing.Image)(resources.GetObject("ts_btn_araclistesi.Image")));
            this.ts_btn_araclistesi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_araclistesi.Name = "ts_btn_araclistesi";
            this.ts_btn_araclistesi.Size = new System.Drawing.Size(23, 22);
            this.ts_btn_araclistesi.Text = "Araç Listesi";
            this.ts_btn_araclistesi.Click += new System.EventHandler(this.ts_btn_araclistesi_Click);
            this.ts_btn_araclistesi.MouseLeave += new System.EventHandler(this.ts_btn_araclistesi_MouseLeave);
            this.ts_btn_araclistesi.MouseHover += new System.EventHandler(this.ts_btn_araclistesi_MouseHover);
            // 
            // ts_lbl_araclistesi
            // 
            this.ts_lbl_araclistesi.Name = "ts_lbl_araclistesi";
            this.ts_lbl_araclistesi.Size = new System.Drawing.Size(88, 22);
            this.ts_lbl_araclistesi.Text = "Araç Listesi";
            this.ts_lbl_araclistesi.Visible = false;
            // 
            // frmYoneticiPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(794, 319);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "frmYoneticiPanel";
            this.Text = "Yönetici Paneli";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ts_btn_kiralamalar;
        private System.Windows.Forms.ToolStripLabel ts_lbl_kiralamalar;
        private System.Windows.Forms.ToolStripButton ts_btn_aracekle;
        private System.Windows.Forms.ToolStripLabel ts_lbl_aracekle;
        private System.Windows.Forms.ToolStripButton ts_btn_araclistesi;
        private System.Windows.Forms.ToolStripLabel ts_lbl_araclistesi;
    }
}
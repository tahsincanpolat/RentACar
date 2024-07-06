namespace RentACar
{
    partial class frmAracListesi
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
            this.dgv_AracListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AracListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_AracListesi
            // 
            this.dgv_AracListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AracListesi.Location = new System.Drawing.Point(2, 1);
            this.dgv_AracListesi.Name = "dgv_AracListesi";
            this.dgv_AracListesi.Size = new System.Drawing.Size(724, 277);
            this.dgv_AracListesi.TabIndex = 0;
            this.dgv_AracListesi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_AracListesi_CellMouseClick);
            // 
            // frmAracListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 279);
            this.Controls.Add(this.dgv_AracListesi);
            this.Name = "frmAracListesi";
            this.Text = "Araç Listesi";
            this.Load += new System.EventHandler(this.frmAracListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AracListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_AracListesi;
    }
}
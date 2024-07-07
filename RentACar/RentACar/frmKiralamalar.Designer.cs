namespace RentACar
{
    partial class frmKiralamalar
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
            this.components = new System.ComponentModel.Container();
            this.dgv_kiralamalistesi = new System.Windows.Forms.DataGridView();
            this.rentACarDataSet1 = new RentACar.RentACarDataSet1();
            this.kiralamalarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kiralamalarsTableAdapter = new RentACar.RentACarDataSet1TableAdapters.KiralamalarsTableAdapter();
            this.arabaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teslimTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiralamaSuresiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaTutariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktifMiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kiralamalistesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiralamalarsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_kiralamalistesi
            // 
            this.dgv_kiralamalistesi.AutoGenerateColumns = false;
            this.dgv_kiralamalistesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kiralamalistesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.arabaIDDataGridViewTextBoxColumn,
            this.yoneticiIDDataGridViewTextBoxColumn,
            this.alisTarihiDataGridViewTextBoxColumn,
            this.teslimTarihiDataGridViewTextBoxColumn,
            this.kiralamaSuresiDataGridViewTextBoxColumn,
            this.faturaTutariDataGridViewTextBoxColumn,
            this.aktifMiDataGridViewCheckBoxColumn});
            this.dgv_kiralamalistesi.DataSource = this.kiralamalarsBindingSource;
            this.dgv_kiralamalistesi.Location = new System.Drawing.Point(1, 1);
            this.dgv_kiralamalistesi.Name = "dgv_kiralamalistesi";
            this.dgv_kiralamalistesi.Size = new System.Drawing.Size(744, 274);
            this.dgv_kiralamalistesi.TabIndex = 0;
            // 
            // rentACarDataSet1
            // 
            this.rentACarDataSet1.DataSetName = "RentACarDataSet1";
            this.rentACarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kiralamalarsBindingSource
            // 
            this.kiralamalarsBindingSource.DataMember = "Kiralamalars";
            this.kiralamalarsBindingSource.DataSource = this.rentACarDataSet1;
            // 
            // kiralamalarsTableAdapter
            // 
            this.kiralamalarsTableAdapter.ClearBeforeFill = true;
            // 
            // arabaIDDataGridViewTextBoxColumn
            // 
            this.arabaIDDataGridViewTextBoxColumn.DataPropertyName = "ArabaID";
            this.arabaIDDataGridViewTextBoxColumn.HeaderText = "ArabaID";
            this.arabaIDDataGridViewTextBoxColumn.Name = "arabaIDDataGridViewTextBoxColumn";
            // 
            // yoneticiIDDataGridViewTextBoxColumn
            // 
            this.yoneticiIDDataGridViewTextBoxColumn.DataPropertyName = "YoneticiID";
            this.yoneticiIDDataGridViewTextBoxColumn.HeaderText = "YoneticiID";
            this.yoneticiIDDataGridViewTextBoxColumn.Name = "yoneticiIDDataGridViewTextBoxColumn";
            // 
            // alisTarihiDataGridViewTextBoxColumn
            // 
            this.alisTarihiDataGridViewTextBoxColumn.DataPropertyName = "AlisTarihi";
            this.alisTarihiDataGridViewTextBoxColumn.HeaderText = "AlisTarihi";
            this.alisTarihiDataGridViewTextBoxColumn.Name = "alisTarihiDataGridViewTextBoxColumn";
            // 
            // teslimTarihiDataGridViewTextBoxColumn
            // 
            this.teslimTarihiDataGridViewTextBoxColumn.DataPropertyName = "TeslimTarihi";
            this.teslimTarihiDataGridViewTextBoxColumn.HeaderText = "TeslimTarihi";
            this.teslimTarihiDataGridViewTextBoxColumn.Name = "teslimTarihiDataGridViewTextBoxColumn";
            // 
            // kiralamaSuresiDataGridViewTextBoxColumn
            // 
            this.kiralamaSuresiDataGridViewTextBoxColumn.DataPropertyName = "KiralamaSuresi";
            this.kiralamaSuresiDataGridViewTextBoxColumn.HeaderText = "KiralamaSuresi";
            this.kiralamaSuresiDataGridViewTextBoxColumn.Name = "kiralamaSuresiDataGridViewTextBoxColumn";
            // 
            // faturaTutariDataGridViewTextBoxColumn
            // 
            this.faturaTutariDataGridViewTextBoxColumn.DataPropertyName = "FaturaTutari";
            this.faturaTutariDataGridViewTextBoxColumn.HeaderText = "FaturaTutari";
            this.faturaTutariDataGridViewTextBoxColumn.Name = "faturaTutariDataGridViewTextBoxColumn";
            // 
            // aktifMiDataGridViewCheckBoxColumn
            // 
            this.aktifMiDataGridViewCheckBoxColumn.DataPropertyName = "AktifMi";
            this.aktifMiDataGridViewCheckBoxColumn.HeaderText = "AktifMi";
            this.aktifMiDataGridViewCheckBoxColumn.Name = "aktifMiDataGridViewCheckBoxColumn";
            // 
            // frmKiralamalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 179);
            this.Controls.Add(this.dgv_kiralamalistesi);
            this.Name = "frmKiralamalar";
            this.Text = "Kiralamalar";
            this.Load += new System.EventHandler(this.frmKiralamalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kiralamalistesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiralamalarsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_kiralamalistesi;
        private RentACarDataSet1 rentACarDataSet1;
        private System.Windows.Forms.BindingSource kiralamalarsBindingSource;
        private RentACarDataSet1TableAdapters.KiralamalarsTableAdapter kiralamalarsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn arabaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teslimTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiralamaSuresiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaTutariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktifMiDataGridViewCheckBoxColumn;
    }
}
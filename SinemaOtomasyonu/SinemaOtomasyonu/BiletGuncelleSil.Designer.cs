namespace SinemaOtomasyonu
{
    partial class BiletGuncelleSil
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
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilmAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DublajT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalonNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KoltukNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teknoloji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BiletTipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FilmAdi,
            this.FTuru,
            this.DublajT,
            this.Seans,
            this.SalonNo,
            this.KoltukNo,
            this.Teknoloji,
            this.Sure,
            this.BiletTipi,
            this.Tutar});
            this.Liste.Location = new System.Drawing.Point(12, 82);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(776, 150);
            this.Liste.TabIndex = 0;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // FilmAdi
            // 
            this.FilmAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FilmAdi.HeaderText = "Film Adı";
            this.FilmAdi.Name = "FilmAdi";
            // 
            // FTuru
            // 
            this.FTuru.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FTuru.HeaderText = "Film Türü";
            this.FTuru.Name = "FTuru";
            this.FTuru.Width = 75;
            // 
            // DublajT
            // 
            this.DublajT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DublajT.HeaderText = "Dublaj Türü";
            this.DublajT.Name = "DublajT";
            this.DublajT.Width = 87;
            // 
            // Seans
            // 
            this.Seans.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Seans.HeaderText = "Seans";
            this.Seans.Name = "Seans";
            this.Seans.Width = 62;
            // 
            // SalonNo
            // 
            this.SalonNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SalonNo.HeaderText = "Salon No";
            this.SalonNo.Name = "SalonNo";
            this.SalonNo.Width = 76;
            // 
            // KoltukNo
            // 
            this.KoltukNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.KoltukNo.HeaderText = "Koltuk No";
            this.KoltukNo.Name = "KoltukNo";
            this.KoltukNo.Width = 79;
            // 
            // Teknoloji
            // 
            this.Teknoloji.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Teknoloji.HeaderText = "Teknoloji";
            this.Teknoloji.Name = "Teknoloji";
            this.Teknoloji.Width = 75;
            // 
            // Sure
            // 
            this.Sure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sure.HeaderText = "Süre";
            this.Sure.Name = "Sure";
            this.Sure.Width = 54;
            // 
            // BiletTipi
            // 
            this.BiletTipi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.BiletTipi.HeaderText = "Bilet Tipi";
            this.BiletTipi.Name = "BiletTipi";
            this.BiletTipi.Width = 67;
            // 
            // Tutar
            // 
            this.Tutar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Tutar.HeaderText = "Tutar";
            this.Tutar.Name = "Tutar";
            this.Tutar.Width = 57;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(284, 281);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(75, 56);
            this.btnYazdir.TabIndex = 1;
            this.btnYazdir.Text = "YAZDIR";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(420, 281);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 56);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // BiletGuncelleSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.Liste);
            this.Name = "BiletGuncelleSil";
            this.Text = "BiletGuncelleSil";
            this.Load += new System.EventHandler(this.BiletGuncelleSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn FTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn DublajT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seans;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalonNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn KoltukNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teknoloji;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sure;
        private System.Windows.Forms.DataGridViewTextBoxColumn BiletTipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutar;
        private System.Windows.Forms.Button btnSil;
    }
}
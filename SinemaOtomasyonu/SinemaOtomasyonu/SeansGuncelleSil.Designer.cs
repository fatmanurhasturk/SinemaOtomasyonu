namespace SinemaOtomasyonu
{
    partial class SeansGuncelleSil
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
            this.Liste1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbSalonId = new System.Windows.Forms.ComboBox();
            this.cbFilmId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeans = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Liste1)).BeginInit();
            this.SuspendLayout();
            // 
            // Liste1
            // 
            this.Liste1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FilmId,
            this.Seans,
            this.SalonId});
            this.Liste1.Location = new System.Drawing.Point(116, 63);
            this.Liste1.Name = "Liste1";
            this.Liste1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Liste1.Size = new System.Drawing.Size(553, 198);
            this.Liste1.TabIndex = 54;
            this.Liste1.DoubleClick += new System.EventHandler(this.Liste1_DoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // FilmId
            // 
            this.FilmId.HeaderText = "FılmId";
            this.FilmId.Name = "FilmId";
            // 
            // Seans
            // 
            this.Seans.HeaderText = "Seansı";
            this.Seans.Name = "Seans";
            // 
            // SalonId
            // 
            this.SalonId.HeaderText = "SalonId";
            this.SalonId.Name = "SalonId";
            // 
            // cbSalonId
            // 
            this.cbSalonId.FormattingEnabled = true;
            this.cbSalonId.Location = new System.Drawing.Point(272, 366);
            this.cbSalonId.Name = "cbSalonId";
            this.cbSalonId.Size = new System.Drawing.Size(121, 21);
            this.cbSalonId.TabIndex = 62;
            // 
            // cbFilmId
            // 
            this.cbFilmId.FormattingEnabled = true;
            this.cbFilmId.Location = new System.Drawing.Point(272, 306);
            this.cbFilmId.Name = "cbFilmId";
            this.cbFilmId.Size = new System.Drawing.Size(121, 21);
            this.cbFilmId.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(178, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Film Id :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSeans
            // 
            this.txtSeans.Location = new System.Drawing.Point(272, 338);
            this.txtSeans.Name = "txtSeans";
            this.txtSeans.Size = new System.Drawing.Size(121, 20);
            this.txtSeans.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(169, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Salon Id :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(178, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Seansı :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(585, 339);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 43);
            this.btnSil.TabIndex = 56;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(454, 339);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(102, 43);
            this.btnGuncelle.TabIndex = 55;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // SeansGuncelleSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Liste1);
            this.Controls.Add(this.cbSalonId);
            this.Controls.Add(this.cbFilmId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSeans);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Name = "SeansGuncelleSil";
            this.Text = "SeansGuncelleSil";
            this.Load += new System.EventHandler(this.SeansGuncelleSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Liste1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seans;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalonId;
        private System.Windows.Forms.ComboBox cbSalonId;
        private System.Windows.Forms.ComboBox cbFilmId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
    }
}
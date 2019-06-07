namespace SinemaOtomasyonu
{
    partial class SeansEkle
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
            this.label4 = new System.Windows.Forms.Label();
            this.cbFilmler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salonno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kapasite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbSaat = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(75, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 38;
            this.label4.Text = "Film Adı :";
            // 
            // cbFilmler
            // 
            this.cbFilmler.BackColor = System.Drawing.Color.Navy;
            this.cbFilmler.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbFilmler.ForeColor = System.Drawing.Color.White;
            this.cbFilmler.FormattingEnabled = true;
            this.cbFilmler.Location = new System.Drawing.Point(178, 212);
            this.cbFilmler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFilmler.Name = "cbFilmler";
            this.cbFilmler.Size = new System.Drawing.Size(208, 29);
            this.cbFilmler.TabIndex = 37;
            this.cbFilmler.SelectedIndexChanged += new System.EventHandler(this.cbFilmler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(75, 276);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Saat :";
            // 
            // Liste
            // 
            this.Liste.BackgroundColor = System.Drawing.Color.Navy;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.salonno,
            this.kTuru,
            this.Kapasite});
            this.Liste.GridColor = System.Drawing.Color.CornflowerBlue;
            this.Liste.Location = new System.Drawing.Point(491, 128);
            this.Liste.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(623, 468);
            this.Liste.TabIndex = 49;
            this.Liste.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Liste_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // salonno
            // 
            this.salonno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.salonno.HeaderText = "Salon No";
            this.salonno.Name = "salonno";
            this.salonno.Width = 95;
            // 
            // kTuru
            // 
            this.kTuru.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kTuru.HeaderText = "Koltuk Turu";
            this.kTuru.Name = "kTuru";
            // 
            // Kapasite
            // 
            this.Kapasite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Kapasite.HeaderText = "Kapasite";
            this.Kapasite.Name = "Kapasite";
            this.Kapasite.Width = 92;
            // 
            // cbSaat
            // 
            this.cbSaat.BackColor = System.Drawing.Color.Navy;
            this.cbSaat.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSaat.ForeColor = System.Drawing.Color.White;
            this.cbSaat.FormattingEnabled = true;
            this.cbSaat.Items.AddRange(new object[] {
            "09:00",
            "12:00",
            "15:00",
            "18:00",
            "21:00"});
            this.cbSaat.Location = new System.Drawing.Point(178, 273);
            this.cbSaat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSaat.Name = "cbSaat";
            this.cbSaat.Size = new System.Drawing.Size(208, 29);
            this.cbSaat.TabIndex = 50;
            this.cbSaat.SelectedIndexChanged += new System.EventHandler(this.cbSaat_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 100);
            this.panel1.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(484, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "SEANS EKLE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SinemaOtomasyonu.Properties.Resources.stopwatch__4_;
            this.pictureBox1.Location = new System.Drawing.Point(245, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.button1.FlatAppearance.BorderSize = 8;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = global::SinemaOtomasyonu.Properties.Resources.icon__2_;
            this.button1.Location = new System.Drawing.Point(196, 349);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 118);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SeansEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1164, 609);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbSaat);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbFilmler);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SeansEkle";
            this.Text = "SeansEkle";
            this.Load += new System.EventHandler(this.SeansEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFilmler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.ComboBox cbSaat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn salonno;
        private System.Windows.Forms.DataGridViewTextBoxColumn kTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kapasite;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}
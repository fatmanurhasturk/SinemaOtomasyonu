namespace SinemaOtomasyonu
{
    partial class SalonOlustur
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnYatak = new System.Windows.Forms.Button();
            this.btnCiftKoltuk = new System.Windows.Forms.Button();
            this.btnKoltukEkle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1422, 100);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 195);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Thistle;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Thistle;
            this.splitContainer1.Panel2.Controls.Add(this.btnKaydet);
            this.splitContainer1.Panel2.Controls.Add(this.btnYatak);
            this.splitContainer1.Panel2.Controls.Add(this.btnCiftKoltuk);
            this.splitContainer1.Panel2.Controls.Add(this.btnKoltukEkle);
            this.splitContainer1.Size = new System.Drawing.Size(1422, 554);
            this.splitContainer1.SplitterDistance = 1251;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 5;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Goldenrod;
            this.btnKaydet.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(0, 551);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(166, 103);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click_3);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Thistle;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1422, 95);
            this.panel2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tekli Koltuk",
            "Çiftli Koltuk",
            "Yataklı Salon",
            "Karışık Salon"});
            this.comboBox1.Location = new System.Drawing.Point(533, 47);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_2);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(533, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(300, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salon Tipi Seçiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(300, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salon Numarası Giriniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(512, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 42);
            this.label3.TabIndex = 1;
            this.label3.Text = "YÖNETİCİ PANEL";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnYatak
            // 
            this.btnYatak.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnYatak.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnYatak.Font = new System.Drawing.Font("Franklin Gothic Heavy", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYatak.Image = global::SinemaOtomasyonu.Properties.Resources.bed;
            this.btnYatak.Location = new System.Drawing.Point(0, 186);
            this.btnYatak.Margin = new System.Windows.Forms.Padding(4);
            this.btnYatak.Name = "btnYatak";
            this.btnYatak.Size = new System.Drawing.Size(166, 93);
            this.btnYatak.TabIndex = 0;
            this.btnYatak.Text = "Yatak Ekle";
            this.btnYatak.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnYatak.UseVisualStyleBackColor = false;
            this.btnYatak.Click += new System.EventHandler(this.btnYatak_Click_2);
            // 
            // btnCiftKoltuk
            // 
            this.btnCiftKoltuk.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnCiftKoltuk.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCiftKoltuk.Font = new System.Drawing.Font("Franklin Gothic Heavy", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCiftKoltuk.Image = global::SinemaOtomasyonu.Properties.Resources.sofa__1_;
            this.btnCiftKoltuk.Location = new System.Drawing.Point(0, 93);
            this.btnCiftKoltuk.Margin = new System.Windows.Forms.Padding(4);
            this.btnCiftKoltuk.Name = "btnCiftKoltuk";
            this.btnCiftKoltuk.Size = new System.Drawing.Size(166, 93);
            this.btnCiftKoltuk.TabIndex = 0;
            this.btnCiftKoltuk.Text = "Çiftli Koltuk Ekle";
            this.btnCiftKoltuk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCiftKoltuk.UseVisualStyleBackColor = false;
            this.btnCiftKoltuk.Click += new System.EventHandler(this.btnCiftKoltuk_Click_1);
            // 
            // btnKoltukEkle
            // 
            this.btnKoltukEkle.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnKoltukEkle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKoltukEkle.Font = new System.Drawing.Font("Franklin Gothic Heavy", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKoltukEkle.Image = global::SinemaOtomasyonu.Properties.Resources.armchair__1_;
            this.btnKoltukEkle.Location = new System.Drawing.Point(0, 0);
            this.btnKoltukEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnKoltukEkle.Name = "btnKoltukEkle";
            this.btnKoltukEkle.Size = new System.Drawing.Size(166, 93);
            this.btnKoltukEkle.TabIndex = 0;
            this.btnKoltukEkle.Text = "Tekli Koltuk Ekle";
            this.btnKoltukEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKoltukEkle.UseVisualStyleBackColor = false;
            this.btnKoltukEkle.Click += new System.EventHandler(this.btnKoltukEkle_Click_3);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pictureBox1.Image = global::SinemaOtomasyonu.Properties.Resources.armchair__2_;
            this.pictureBox1.Location = new System.Drawing.Point(329, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // SalonOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 749);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SalonOlustur";
            this.Text = "SalonOlustur";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SalonOlustur_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYatak;
        private System.Windows.Forms.Button btnCiftKoltuk;
        private System.Windows.Forms.Button btnKoltukEkle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}
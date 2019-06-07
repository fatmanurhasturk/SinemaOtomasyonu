namespace SinemaOtomasyonu
{
    partial class AdminPaneli
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
            this.btbKullanıcı = new System.Windows.Forms.Button();
            this.btnistatistik = new System.Windows.Forms.Button();
            this.btnPromosyon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btbKullanıcı
            // 
            this.btbKullanıcı.Location = new System.Drawing.Point(517, 182);
            this.btbKullanıcı.Name = "btbKullanıcı";
            this.btbKullanıcı.Size = new System.Drawing.Size(159, 86);
            this.btbKullanıcı.TabIndex = 1;
            this.btbKullanıcı.Text = "Kullanıcı İşlemleri";
            this.btbKullanıcı.UseVisualStyleBackColor = true;
            // 
            // btnistatistik
            // 
            this.btnistatistik.Location = new System.Drawing.Point(319, 182);
            this.btnistatistik.Name = "btnistatistik";
            this.btnistatistik.Size = new System.Drawing.Size(159, 86);
            this.btnistatistik.TabIndex = 2;
            this.btnistatistik.Text = "İstatistikİşlemleri";
            this.btnistatistik.UseVisualStyleBackColor = true;
            // 
            // btnPromosyon
            // 
            this.btnPromosyon.Location = new System.Drawing.Point(124, 182);
            this.btnPromosyon.Name = "btnPromosyon";
            this.btnPromosyon.Size = new System.Drawing.Size(159, 86);
            this.btnPromosyon.TabIndex = 3;
            this.btnPromosyon.Text = "Promosyon İşlemleri";
            this.btnPromosyon.UseVisualStyleBackColor = true;
            this.btnPromosyon.Click += new System.EventHandler(this.btnPromosyon_Click);
            // 
            // AdminPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btbKullanıcı);
            this.Controls.Add(this.btnistatistik);
            this.Controls.Add(this.btnPromosyon);
            this.Name = "AdminPaneli";
            this.Text = "AdminPaneli";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btbKullanıcı;
        private System.Windows.Forms.Button btnistatistik;
        private System.Windows.Forms.Button btnPromosyon;
    }
}
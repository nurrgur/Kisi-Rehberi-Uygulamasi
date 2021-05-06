namespace KisiRehber
{
    partial class frmGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtKullanici = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChckSifreyiGoster = new System.Windows.Forms.CheckBox();
            this.BtnSifremiUnuttum = new System.Windows.Forms.Button();
            this.BtnYeniKayit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtKullanici
            // 
            this.TxtKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKullanici.Location = new System.Drawing.Point(119, 98);
            this.TxtKullanici.Name = "TxtKullanici";
            this.TxtKullanici.Size = new System.Drawing.Size(136, 26);
            this.TxtKullanici.TabIndex = 0;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.Location = new System.Drawing.Point(119, 146);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(136, 26);
            this.TxtSifre.TabIndex = 1;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(2, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(61, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // BtnGiris
            // 
            this.BtnGiris.Location = new System.Drawing.Point(81, 205);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(90, 29);
            this.BtnGiris.TabIndex = 4;
            this.BtnGiris.Text = "GİRİŞ";
            this.BtnGiris.UseVisualStyleBackColor = true;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KisiRehber.Properties.Resources.kilit;
            this.pictureBox1.Location = new System.Drawing.Point(380, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ChckSifreyiGoster
            // 
            this.ChckSifreyiGoster.AutoSize = true;
            this.ChckSifreyiGoster.Location = new System.Drawing.Point(261, 146);
            this.ChckSifreyiGoster.Name = "ChckSifreyiGoster";
            this.ChckSifreyiGoster.Size = new System.Drawing.Size(88, 17);
            this.ChckSifreyiGoster.TabIndex = 6;
            this.ChckSifreyiGoster.Text = "Şifreyi Göster";
            this.ChckSifreyiGoster.UseVisualStyleBackColor = true;
            this.ChckSifreyiGoster.CheckedChanged += new System.EventHandler(this.ChckSifreyiGoster_CheckedChanged);
            // 
            // BtnSifremiUnuttum
            // 
            this.BtnSifremiUnuttum.Location = new System.Drawing.Point(261, 166);
            this.BtnSifremiUnuttum.Name = "BtnSifremiUnuttum";
            this.BtnSifremiUnuttum.Size = new System.Drawing.Size(98, 23);
            this.BtnSifremiUnuttum.TabIndex = 7;
            this.BtnSifremiUnuttum.Text = "Şifremi Unuttum";
            this.BtnSifremiUnuttum.UseVisualStyleBackColor = true;
            this.BtnSifremiUnuttum.Click += new System.EventHandler(this.BtnSifremiUnuttum_Click);
            // 
            // BtnYeniKayit
            // 
            this.BtnYeniKayit.Location = new System.Drawing.Point(195, 205);
            this.BtnYeniKayit.Name = "BtnYeniKayit";
            this.BtnYeniKayit.Size = new System.Drawing.Size(96, 29);
            this.BtnYeniKayit.TabIndex = 8;
            this.BtnYeniKayit.Text = "YENİ KAYIT";
            this.BtnYeniKayit.UseVisualStyleBackColor = true;
            this.BtnYeniKayit.Click += new System.EventHandler(this.BtnYeniKayit_Click);
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(498, 310);
            this.Controls.Add(this.BtnYeniKayit);
            this.Controls.Add(this.BtnSifremiUnuttum);
            this.Controls.Add(this.ChckSifreyiGoster);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtKullanici);
            this.Name = "frmGiris";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtKullanici;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox ChckSifreyiGoster;
        private System.Windows.Forms.Button BtnSifremiUnuttum;
        private System.Windows.Forms.Button BtnYeniKayit;
    }
}


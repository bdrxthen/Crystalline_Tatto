namespace CrystallineDesign
{
    partial class GirisSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisSayfa));
            this.Giris = new System.Windows.Forms.Button();
            this.Nick = new System.Windows.Forms.TextBox();
            this.Sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SifreKarsi = new System.Windows.Forms.Label();
            this.NickKarsi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Sifre2 = new System.Windows.Forms.TextBox();
            this.Nick2 = new System.Windows.Forms.TextBox();
            this.Giris2 = new System.Windows.Forms.Button();
            this.SifreKarsi2 = new System.Windows.Forms.Label();
            this.NickKarsi2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Giris
            // 
            this.Giris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Giris.BackColor = System.Drawing.Color.Transparent;
            this.Giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Giris.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Giris.ForeColor = System.Drawing.Color.White;
            this.Giris.Location = new System.Drawing.Point(155, 389);
            this.Giris.Name = "Giris";
            this.Giris.Size = new System.Drawing.Size(143, 50);
            this.Giris.TabIndex = 3;
            this.Giris.Text = "Giriş";
            this.Giris.UseVisualStyleBackColor = false;
            this.Giris.Click += new System.EventHandler(this.Giris_Click);
            // 
            // Nick
            // 
            this.Nick.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Nick.BackColor = System.Drawing.Color.Black;
            this.Nick.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Nick.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Nick.ForeColor = System.Drawing.Color.Transparent;
            this.Nick.Location = new System.Drawing.Point(147, 291);
            this.Nick.Name = "Nick";
            this.Nick.Size = new System.Drawing.Size(160, 31);
            this.Nick.TabIndex = 1;
            this.Nick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nick.Click += new System.EventHandler(this.Nick_Click);
            // 
            // Sifre
            // 
            this.Sifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sifre.BackColor = System.Drawing.Color.Black;
            this.Sifre.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Sifre.ForeColor = System.Drawing.Color.Transparent;
            this.Sifre.Location = new System.Drawing.Point(147, 338);
            this.Sifre.Name = "Sifre";
            this.Sifre.PasswordChar = '*';
            this.Sifre.Size = new System.Drawing.Size(160, 31);
            this.Sifre.TabIndex = 2;
            this.Sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sifre.Click += new System.EventHandler(this.Sifre_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(146, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 54);
            this.label1.TabIndex = 10;
            this.label1.Text = "CRYSTALLINE DESIGN";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 36.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(137, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 58);
            this.label3.TabIndex = 26;
            this.label3.Text = "Yönetici";
            // 
            // SifreKarsi
            // 
            this.SifreKarsi.AutoSize = true;
            this.SifreKarsi.BackColor = System.Drawing.Color.Transparent;
            this.SifreKarsi.Location = new System.Drawing.Point(769, 9);
            this.SifreKarsi.Name = "SifreKarsi";
            this.SifreKarsi.Size = new System.Drawing.Size(0, 13);
            this.SifreKarsi.TabIndex = 27;
            this.SifreKarsi.Visible = false;
            // 
            // NickKarsi
            // 
            this.NickKarsi.AutoSize = true;
            this.NickKarsi.BackColor = System.Drawing.Color.Transparent;
            this.NickKarsi.Location = new System.Drawing.Point(728, 9);
            this.NickKarsi.Name = "NickKarsi";
            this.NickKarsi.Size = new System.Drawing.Size(0, 13);
            this.NickKarsi.TabIndex = 28;
            this.NickKarsi.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Playbill", 25.25F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 34);
            this.label2.TabIndex = 41;
            this.label2.Text = "Ad Soyad";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Playbill", 25.25F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 34);
            this.label4.TabIndex = 42;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Playbill", 25.25F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(417, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 34);
            this.label5.TabIndex = 47;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Playbill", 25.25F, System.Drawing.FontStyle.Italic);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(415, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 34);
            this.label6.TabIndex = 46;
            this.label6.Text = "Ad Soyad";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 36.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(521, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 58);
            this.label7.TabIndex = 45;
            this.label7.Text = "Personel";
            // 
            // Sifre2
            // 
            this.Sifre2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sifre2.BackColor = System.Drawing.Color.Black;
            this.Sifre2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Sifre2.ForeColor = System.Drawing.Color.Transparent;
            this.Sifre2.Location = new System.Drawing.Point(531, 338);
            this.Sifre2.Name = "Sifre2";
            this.Sifre2.PasswordChar = '*';
            this.Sifre2.Size = new System.Drawing.Size(160, 31);
            this.Sifre2.TabIndex = 44;
            this.Sifre2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Nick2
            // 
            this.Nick2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Nick2.BackColor = System.Drawing.Color.Black;
            this.Nick2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Nick2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Nick2.ForeColor = System.Drawing.Color.Transparent;
            this.Nick2.Location = new System.Drawing.Point(531, 291);
            this.Nick2.Name = "Nick2";
            this.Nick2.Size = new System.Drawing.Size(160, 31);
            this.Nick2.TabIndex = 43;
            this.Nick2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Giris2
            // 
            this.Giris2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Giris2.BackColor = System.Drawing.Color.Transparent;
            this.Giris2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Giris2.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Giris2.ForeColor = System.Drawing.Color.White;
            this.Giris2.Location = new System.Drawing.Point(539, 389);
            this.Giris2.Name = "Giris2";
            this.Giris2.Size = new System.Drawing.Size(143, 50);
            this.Giris2.TabIndex = 48;
            this.Giris2.Text = "Giriş";
            this.Giris2.UseVisualStyleBackColor = false;
            this.Giris2.Click += new System.EventHandler(this.Giris2_Click);
            // 
            // SifreKarsi2
            // 
            this.SifreKarsi2.AutoSize = true;
            this.SifreKarsi2.BackColor = System.Drawing.Color.Transparent;
            this.SifreKarsi2.Location = new System.Drawing.Point(635, 9);
            this.SifreKarsi2.Name = "SifreKarsi2";
            this.SifreKarsi2.Size = new System.Drawing.Size(0, 13);
            this.SifreKarsi2.TabIndex = 50;
            this.SifreKarsi2.Visible = false;
            // 
            // NickKarsi2
            // 
            this.NickKarsi2.AutoSize = true;
            this.NickKarsi2.BackColor = System.Drawing.Color.Transparent;
            this.NickKarsi2.Location = new System.Drawing.Point(676, 9);
            this.NickKarsi2.Name = "NickKarsi2";
            this.NickKarsi2.Size = new System.Drawing.Size(0, 13);
            this.NickKarsi2.TabIndex = 49;
            this.NickKarsi2.Visible = false;
            // 
            // GirisSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.SifreKarsi2);
            this.Controls.Add(this.NickKarsi2);
            this.Controls.Add(this.Giris2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Sifre2);
            this.Controls.Add(this.Nick2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NickKarsi);
            this.Controls.Add(this.SifreKarsi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.Nick);
            this.Controls.Add(this.Giris);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "GirisSayfa";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Giriş_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Giris;
        private System.Windows.Forms.TextBox Nick;
        private System.Windows.Forms.TextBox Sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SifreKarsi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Sifre2;
        private System.Windows.Forms.TextBox Nick2;
        private System.Windows.Forms.Button Giris2;
        private System.Windows.Forms.Label SifreKarsi2;
        public System.Windows.Forms.Label NickKarsi;
        public System.Windows.Forms.Label NickKarsi2;
    }
}


namespace CrystallineDesign
{
    partial class AltinPiercP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltinPiercP));
            this.Secenek = new System.Windows.Forms.Button();
            this.ResimTxt = new System.Windows.Forms.Label();
            this.Resim = new System.Windows.Forms.TextBox();
            this.Geri = new System.Windows.Forms.Button();
            this.ResimList = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.AdTxt = new System.Windows.Forms.Label();
            this.Ad = new System.Windows.Forms.TextBox();
            this.IdTxt = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.TurTxt = new System.Windows.Forms.Label();
            this.Tur = new System.Windows.Forms.TextBox();
            this.Karsilastir = new System.Windows.Forms.Label();
            this.Listele = new System.Windows.Forms.Button();
            this.Ekle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResimList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Secenek
            // 
            this.Secenek.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Secenek.BackColor = System.Drawing.Color.Transparent;
            this.Secenek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Secenek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Secenek.Font = new System.Drawing.Font("Playbill", 15.15F, System.Drawing.FontStyle.Italic);
            this.Secenek.ForeColor = System.Drawing.Color.White;
            this.Secenek.Location = new System.Drawing.Point(403, 209);
            this.Secenek.Name = "Secenek";
            this.Secenek.Size = new System.Drawing.Size(30, 39);
            this.Secenek.TabIndex = 182;
            this.Secenek.Text = "...";
            this.Secenek.UseVisualStyleBackColor = false;
            this.Secenek.Click += new System.EventHandler(this.Secenek_Click);
            // 
            // ResimTxt
            // 
            this.ResimTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResimTxt.BackColor = System.Drawing.Color.Transparent;
            this.ResimTxt.Font = new System.Drawing.Font("Playbill", 30.25F, System.Drawing.FontStyle.Italic);
            this.ResimTxt.ForeColor = System.Drawing.Color.White;
            this.ResimTxt.Location = new System.Drawing.Point(14, 206);
            this.ResimTxt.Name = "ResimTxt";
            this.ResimTxt.Size = new System.Drawing.Size(167, 42);
            this.ResimTxt.TabIndex = 181;
            this.ResimTxt.Text = "Resim";
            this.ResimTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Resim
            // 
            this.Resim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Resim.BackColor = System.Drawing.Color.Silver;
            this.Resim.Font = new System.Drawing.Font("Monotype Corsiva", 20.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Resim.ForeColor = System.Drawing.Color.White;
            this.Resim.Location = new System.Drawing.Point(187, 209);
            this.Resim.Name = "Resim";
            this.Resim.Size = new System.Drawing.Size(210, 39);
            this.Resim.TabIndex = 180;
            this.Resim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Resim.TextChanged += new System.EventHandler(this.Resim_TextChanged);
            // 
            // Geri
            // 
            this.Geri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Geri.BackColor = System.Drawing.Color.Transparent;
            this.Geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Geri.Font = new System.Drawing.Font("Playbill", 30.25F, System.Drawing.FontStyle.Italic);
            this.Geri.ForeColor = System.Drawing.Color.Azure;
            this.Geri.Location = new System.Drawing.Point(679, 198);
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(112, 54);
            this.Geri.TabIndex = 179;
            this.Geri.Text = "Geri";
            this.Geri.UseVisualStyleBackColor = false;
            this.Geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // ResimList
            // 
            this.ResimList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResimList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResimList.Location = new System.Drawing.Point(15, 258);
            this.ResimList.Name = "ResimList";
            this.ResimList.Size = new System.Drawing.Size(431, 182);
            this.ResimList.TabIndex = 178;
            this.ResimList.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ResimList_CellEnter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(452, 258);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(339, 182);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 183;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.WaitOnLoad = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AdTxt
            // 
            this.AdTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdTxt.BackColor = System.Drawing.Color.Transparent;
            this.AdTxt.Font = new System.Drawing.Font("Playbill", 30.25F, System.Drawing.FontStyle.Italic);
            this.AdTxt.ForeColor = System.Drawing.Color.White;
            this.AdTxt.Location = new System.Drawing.Point(14, 116);
            this.AdTxt.Name = "AdTxt";
            this.AdTxt.Size = new System.Drawing.Size(167, 42);
            this.AdTxt.TabIndex = 192;
            this.AdTxt.Text = "Ad";
            this.AdTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ad
            // 
            this.Ad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ad.BackColor = System.Drawing.Color.Silver;
            this.Ad.Font = new System.Drawing.Font("Monotype Corsiva", 20.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Ad.ForeColor = System.Drawing.Color.White;
            this.Ad.Location = new System.Drawing.Point(187, 119);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(210, 39);
            this.Ad.TabIndex = 191;
            this.Ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IdTxt
            // 
            this.IdTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IdTxt.BackColor = System.Drawing.Color.Transparent;
            this.IdTxt.Font = new System.Drawing.Font("Playbill", 30.25F, System.Drawing.FontStyle.Italic);
            this.IdTxt.ForeColor = System.Drawing.Color.White;
            this.IdTxt.Location = new System.Drawing.Point(15, 71);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(167, 42);
            this.IdTxt.TabIndex = 190;
            this.IdTxt.Text = "Id";
            this.IdTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Id
            // 
            this.Id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Id.BackColor = System.Drawing.Color.Silver;
            this.Id.Font = new System.Drawing.Font("Monotype Corsiva", 20.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Id.ForeColor = System.Drawing.Color.White;
            this.Id.Location = new System.Drawing.Point(187, 74);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(210, 39);
            this.Id.TabIndex = 189;
            this.Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TurTxt
            // 
            this.TurTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TurTxt.BackColor = System.Drawing.Color.Transparent;
            this.TurTxt.Font = new System.Drawing.Font("Playbill", 30.25F, System.Drawing.FontStyle.Italic);
            this.TurTxt.ForeColor = System.Drawing.Color.White;
            this.TurTxt.Location = new System.Drawing.Point(14, 161);
            this.TurTxt.Name = "TurTxt";
            this.TurTxt.Size = new System.Drawing.Size(167, 42);
            this.TurTxt.TabIndex = 188;
            this.TurTxt.Text = "Tür";
            this.TurTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tur
            // 
            this.Tur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tur.BackColor = System.Drawing.Color.Silver;
            this.Tur.Font = new System.Drawing.Font("Monotype Corsiva", 20.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Tur.ForeColor = System.Drawing.Color.White;
            this.Tur.Location = new System.Drawing.Point(187, 164);
            this.Tur.Name = "Tur";
            this.Tur.Size = new System.Drawing.Size(210, 39);
            this.Tur.TabIndex = 187;
            this.Tur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Karsilastir
            // 
            this.Karsilastir.AutoSize = true;
            this.Karsilastir.BackColor = System.Drawing.Color.Transparent;
            this.Karsilastir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Karsilastir.Location = new System.Drawing.Point(748, 11);
            this.Karsilastir.Name = "Karsilastir";
            this.Karsilastir.Size = new System.Drawing.Size(13, 13);
            this.Karsilastir.TabIndex = 186;
            this.Karsilastir.Text = "0";
            this.Karsilastir.Visible = false;
            // 
            // Listele
            // 
            this.Listele.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Listele.BackColor = System.Drawing.Color.Transparent;
            this.Listele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Listele.Font = new System.Drawing.Font("Playbill", 30.25F, System.Drawing.FontStyle.Italic);
            this.Listele.ForeColor = System.Drawing.Color.Azure;
            this.Listele.Location = new System.Drawing.Point(679, 78);
            this.Listele.Name = "Listele";
            this.Listele.Size = new System.Drawing.Size(112, 54);
            this.Listele.TabIndex = 185;
            this.Listele.Text = "Listele";
            this.Listele.UseVisualStyleBackColor = false;
            this.Listele.Click += new System.EventHandler(this.Listele_Click);
            // 
            // Ekle
            // 
            this.Ekle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ekle.BackColor = System.Drawing.Color.Transparent;
            this.Ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ekle.Font = new System.Drawing.Font("Playbill", 30.25F, System.Drawing.FontStyle.Italic);
            this.Ekle.ForeColor = System.Drawing.Color.Azure;
            this.Ekle.Location = new System.Drawing.Point(679, 138);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(112, 54);
            this.Ekle.TabIndex = 184;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = false;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // AltinPiercP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.Secenek);
            this.Controls.Add(this.ResimTxt);
            this.Controls.Add(this.Resim);
            this.Controls.Add(this.Geri);
            this.Controls.Add(this.ResimList);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.AdTxt);
            this.Controls.Add(this.Ad);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.TurTxt);
            this.Controls.Add(this.Tur);
            this.Controls.Add(this.Karsilastir);
            this.Controls.Add(this.Listele);
            this.Controls.Add(this.Ekle);
            this.Name = "AltinPiercP";
            this.Text = "AltinPiercP";
            this.Load += new System.EventHandler(this.AltinPiercP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResimList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Secenek;
        private System.Windows.Forms.Label ResimTxt;
        private System.Windows.Forms.TextBox Resim;
        private System.Windows.Forms.Button Geri;
        private System.Windows.Forms.DataGridView ResimList;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label AdTxt;
        private System.Windows.Forms.TextBox Ad;
        private System.Windows.Forms.Label IdTxt;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label TurTxt;
        private System.Windows.Forms.TextBox Tur;
        private System.Windows.Forms.Label Karsilastir;
        private System.Windows.Forms.Button Listele;
        private System.Windows.Forms.Button Ekle;
    }
}
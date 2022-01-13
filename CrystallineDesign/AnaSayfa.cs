using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrystallineDesign
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void Ayarlar_Click(object sender, EventArgs e)
        {
            if (Hesap.Visible== true)
            {
                Hesap.Visible = false;
                Personel.Visible = false;
                PersonelKayit.Visible = false;
                Musteri.Visible = false;
                Pierc.Visible = false;
                Dovme.Visible = false;
                Cover.Visible = false;
                Renkli.Visible = false;
                Renksiz.Visible = false;
                Kina.Visible = false;
                Altin.Visible = false;
                Gumus.Visible = false;
                Celik.Visible = false;
                Titanyum.Visible = false;
            }
            else
            {
                Hesap.Visible = true;
                Personel.Visible = true;
                PersonelKayit.Visible = true;
                Musteri.Visible = true;
                Pierc.Visible = false;
                Dovme.Visible = false;
                Cover.Visible = false;
                Renkli.Visible = false;
                Renksiz.Visible = false;
                Kina.Visible = false;
                Altin.Visible = false;
                Gumus.Visible = false;
                Celik.Visible = false;
                Titanyum.Visible = false;
            }
        }

        private void Market_Click(object sender, EventArgs e)
        {
            if (Dovme.Visible == true)
            {
                Hesap.Visible = false;
                Personel.Visible = false;
                PersonelKayit.Visible = false;
                Musteri.Visible = false;
                Pierc.Visible = false;
                Dovme.Visible = false;
                Cover.Visible = false;
                Renkli.Visible = false;
                Renksiz.Visible = false;
                Kina.Visible = false;
                Altin.Visible = false;
                Gumus.Visible = false;
                Celik.Visible = false;
                Titanyum.Visible = false;
            }
            else
            {
                Hesap.Visible = false;
                Personel.Visible = false;
                PersonelKayit.Visible = false;
                Musteri.Visible = false;
                Pierc.Visible = true;
                Dovme.Visible = true;
                Cover.Visible = true;
                Renkli.Visible = false;
                Renksiz.Visible = false;
                Kina.Visible = false;
            }
        }

        private void Dovme_Click(object sender, EventArgs e)
        {
            if (Renkli.Visible == true)
            {
                Renkli.Visible = false;
                Renksiz.Visible = false;
                Kina.Visible = false;
            }
            else
            {
                Renkli.Visible = true;
                Renksiz.Visible = true;
                Kina.Visible = true;
            }
        }
        
        private void Pierc_Click(object sender, EventArgs e)
        {
            if (Altin.Visible == true)
            {
                Altin.Visible = false;
                Gumus.Visible = false;
                Celik.Visible = false;
                Titanyum.Visible = false;
            }
            else
            {
                Altin.Visible = true;
                Gumus.Visible = true;
                Celik.Visible = true;
                Titanyum.Visible = true;
            }
        }
        
        private void Cover_Click(object sender, EventArgs e)
        {
            Cover C = new Cover();
            C.Show();
            this.Hide();
        }

        private void Müsteri_Click(object sender, EventArgs e)
        {
            MusteriAyarları MA = new MusteriAyarları();
            MA.Show();
            this.Hide();
        }

        private void Personel_Click(object sender, EventArgs e)
        {
            PersonelAyarlar PA = new PersonelAyarlar();
            PA.Show();
            this.Hide();
        }
        
        private void PersonelKayit_Click(object sender, EventArgs e)
        {
            PersonelKayid Pk = new PersonelKayid();
            Pk.Show();
            this.Hide();
        }

        private void Hesap_Click(object sender, EventArgs e)
        {
            AdminHesapAyarları AHP = new AdminHesapAyarları();
            AHP.Show();
            this.Hide();
        }

        private void Altin_Click(object sender, EventArgs e)
        {
            AltinPierc AP = new AltinPierc();
            AP.Show();
            this.Hide();
        }

        private void Gumus_Click(object sender, EventArgs e)
        {
            GumusPierc GP = new GumusPierc();
            GP.Show();
            this.Hide();
        }

        private void Celik_Click(object sender, EventArgs e)
        {
            CelikPierc CP = new CelikPierc();
            CP.Show();
            this.Hide();
        }

        private void Titanyum_Click(object sender, EventArgs e)
        {
            TitanyumPier TP = new TitanyumPier();
            TP.Show();
            this.Hide();
        }

        private void Randevu_Click(object sender, EventArgs e)
        {
            Randevu RND = new Randevu();
            RND.Show();
            this.Hide();
        }

        private void Kina_Click(object sender, EventArgs e)
        {
            Kina K = new Kina();
            K.Show();
            this.Hide();
        }

        private void Renksiz_Click(object sender, EventArgs e)
        {
            Dovme D = new Dovme();
            D.Show();
            this.Hide();
        }

        private void Renkli_Click(object sender, EventArgs e)
        {
            RenkliDovme RD = new RenkliDovme();
            RD.Show();
            this.Hide();
        }
    }
}

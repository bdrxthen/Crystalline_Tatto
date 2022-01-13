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
    public partial class AnaSayfaP : Form
    {
        public AnaSayfaP()
        {
            InitializeComponent();
        }

        private void AnaSayfaP_Load(object sender, EventArgs e)
        {

        }

        private void Ayarlar_Click(object sender, EventArgs e)
        {
            if (Hesap.Visible == true)
            {
                Hesap.Visible = false;
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
                Musteri.Visible = false;
                Pierc.Visible = true;
                Dovme.Visible = true;
                Cover.Visible = true;
                Renkli.Visible = false;
                Renksiz.Visible = false;
                Kina.Visible = false;
            }
        }

        private void Randevu_Click(object sender, EventArgs e)
        {
            RandevuP RP = new RandevuP();
            RP.Show();
            this.Hide();
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

        private void Cover_Click(object sender, EventArgs e)
        {
            CoverP CP = new CoverP();
            CP.Show();
            this.Hide();
        }
        
        private void Hesap_Click(object sender, EventArgs e)
        {
            PersonelAyarlarP PHA = new PersonelAyarlarP();
            PHA.Show();
            this.Hide();
        }

        private void Musteri_Click(object sender, EventArgs e)
        {
            MusteriAyarlarıP MAP = new MusteriAyarlarıP();
            MAP.Show();
            this.Hide();
        }

        private void Kina_Click(object sender, EventArgs e)
        {
            KinaP KP = new KinaP();
            KP.Show();
            this.Hide();
        }

        private void Celik_Click(object sender, EventArgs e)
        {
            CelikPiercP CPP = new CelikPiercP();
            CPP.Show();
            this.Hide();
        }

        private void Altin_Click(object sender, EventArgs e)
        {
            AltinPiercP APP = new AltinPiercP();
            APP.Show();
            this.Hide();
        }

        private void Gumus_Click(object sender, EventArgs e)
        {
            GumusPiercP GPP = new GumusPiercP();
            GPP.Show();
            this.Hide();
        }

        private void Titanyum_Click(object sender, EventArgs e)
        {
            TitanyumPierP TPP = new TitanyumPierP();
            TPP.Show();
            this.Hide();
        }

        private void Renksiz_Click(object sender, EventArgs e)
        {
            DovmeP DP = new DovmeP();
            DP.Show();
            this.Hide();
        }

        private void Renkli_Click(object sender, EventArgs e)
        {
            RenkliDovmeP RDP = new RenkliDovmeP();
            RDP.Show();
            this.Hide();
        }
    }
}

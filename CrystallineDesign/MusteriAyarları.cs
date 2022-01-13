using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace CrystallineDesign
{
    public partial class MusteriAyarları : Form
    {
        public MusteriAyarları()
        {
            InitializeComponent();
        }
        
        IFirebaseConfig Fcon = new FirebaseConfig()
        {
            AuthSecret = "",
            BasePath = ""
        };
        private FirebaseClient client;

        private void MusteriAyarları_Load(object sender, EventArgs e)
        {

        }

        private void Degistir_Click(object sender, EventArgs e)
        {
            if (Nick.Text == null || Nick.Text == "" ||
                Sifre.Text == null || Sifre.Text == "" ||
                Ad.Text == null || Ad.Text == "" ||
                Posta.Text == null || Posta.Text == "" ||
                Tel.Text == null || Tel.Text == "")
            {
                MessageBox.Show("Gerekli Bilgileri doldurunuz.");
            }
            else
            {
                Musteri mstr1 = new Musteri()
                {
                    Ad = Ad.Text,
                    Nick = Nick.Text,
                    Posta = Posta.Text,
                    Tel = Tel.Text,
                    Sifre = Sifre.Text,
                };
                var setter = client.Set("Kullaniciler/" + Nick.Text, mstr1);
                MessageBox.Show("Başarılı :)");
            }
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }

        string AraNick = "";
        private void Ara_Click(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(Fcon);
            }
            catch
            {
                MessageBox.Show("Hatalı Bağlantı!!!");
            }

            if (NickAra.Text == null || NickAra.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Bilgileri Tamamlayın.");
            }
            else
            {
                AraNick = NickAra.Text;
                var NickKarsi = client.Get("Kullaniciler/" + AraNick);
                Musteri admn = NickKarsi.ResultAs<Musteri>();
                Nick.Text = admn.Nick;
                Ad.Text = admn.Ad;
                Posta.Text = admn.Posta;
                Tel.Text = admn.Tel;
                Sifre.Text = admn.Sifre;                
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace CrystallineDesign
{
    public partial class PersonelAyarlarP : Form
    {
        public PersonelAyarlarP()
        {
            InitializeComponent();
        }

        IFirebaseConfig Fcon = new FirebaseConfig()
        {
            AuthSecret = "55Ru09LDH3I8wmXgniDS1E9DTTYU75bpDCPIv6nd",
            BasePath = "https://crystallinedesign-d790c-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        IFirebaseClient client;

        string AyarNick = "";
        private void PersonelHesapAyar_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(Fcon);
            }
            catch
            {
                MessageBox.Show("Hatalı Bağlantı!!!");
            }

            GirisSayfa sfr = (GirisSayfa)Application.OpenForms["GirisSayfa"];
            AyarNick = sfr.NickKarsi2.Text;
            var NickKarsi2 = client.Get("Personel/" + AyarNick);
            Musteri admn = NickKarsi2.ResultAs<Musteri>();
            Nick.Text = admn.Nick;
            Ad.Text = admn.Ad;
            Posta.Text = admn.Posta;
            Tel.Text = admn.Tel;
            Sifre.Text = admn.Sifre;
        }

        private void Degistir_Click(object sender, EventArgs e)
        {
            string eskisifre = "";
            var NickKarsi = client.Get("Admin/" + AyarNick);
            Musteri admn2 = NickKarsi.ResultAs<Musteri>();
            eskisifre = admn2.Sifre;

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
                if (Sifre.Text == Sifre2.Text)
                {
                    if (eskisifre == EskiSifre.Text)
                    {
                        Musteri mstr1 = new Musteri()
                        {
                            Ad = Ad.Text,
                            Nick = Nick.Text,
                            Posta = Posta.Text,
                            Tel = Tel.Text,
                            Sifre = Sifre.Text,
                        };
                        var setter = client.Set("Personel/" + Nick.Text, mstr1);

                    }
                    else
                    {
                        MessageBox.Show("Sifreler uyuşmamaktadır.");
                    }
                }
                else
                {
                    MessageBox.Show("eski şifreyi yanlış yazdınız.");
                }
            }
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            AnaSayfaP ana = new AnaSayfaP();
            ana.Show();
            this.Hide();
        }

       
    }
}

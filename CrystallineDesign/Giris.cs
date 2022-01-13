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
    public partial class GirisSayfa : Form
    {
        public GirisSayfa()
        {
            InitializeComponent();
        }

        IFirebaseConfig Fcon = new FirebaseConfig()
        {
            AuthSecret = "",
            BasePath = ""
        };
        IFirebaseClient client;

        private void Giriş_Load(object sender, EventArgs e)
        {            
            try
            {
                client = new FireSharp.FirebaseClient(Fcon);
            }
            catch
            {
                MessageBox.Show("Hatalı Bağlantı!!!");
            }
        }

        private void Nick_Click(object sender, EventArgs e)
        {
            Nick.Text = null;
        }

        private void Sifre_Click(object sender, EventArgs e)
        {
            Sifre.Text = null;
        }

        private void Giris_Click(object sender, EventArgs e)
        {
            while(true)
            {
                if (Nick.Text == null || Sifre.Text == null || Nick.Text == "" || Sifre.Text == "")
                {
                    MessageBox.Show("Lütfen Gerekli Bilgileri Tamamlayın.");
                    break;
                }
                else
                {
                    var Giriskarsi = client.Get("Admin/" + Nick.Text);
                    Musteri mstr = Giriskarsi.ResultAs<Musteri>();
                    NickKarsi.Text = mstr.Nick;
                    SifreKarsi.Text = mstr.Sifre;

                    if (Nick.Text == NickKarsi.Text && Sifre.Text == SifreKarsi.Text)
                    {
                        AnaSayfa AS = new AnaSayfa();
                        AS.Show();
                        this.Hide();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış.");
                        break;
                    }
                }
            }
        }

        private void Giris2_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if (Nick2.Text == null || Sifre2.Text == null || Nick2.Text == "" || Sifre2.Text == "")
                {
                    MessageBox.Show("Lütfen Gerekli Bilgileri Tamamlayın.");
                    break;
                }
                else
                {
                    var Giriskarsi = client.Get("Personel/" + Nick2.Text);
                    Musteri mstr = Giriskarsi.ResultAs<Musteri>();
                    NickKarsi2.Text = mstr.Nick;
                    SifreKarsi2.Text = mstr.Sifre;

                    if (Nick2.Text == NickKarsi2.Text && Sifre2.Text == SifreKarsi2.Text)
                    {
                        AnaSayfaP ASP = new AnaSayfaP();
                        ASP.Show();
                        this.Hide();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış.");
                        break;
                    }
                }
            }

        }
    }
}

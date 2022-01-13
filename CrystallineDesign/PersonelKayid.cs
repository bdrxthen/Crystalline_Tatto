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
    public partial class PersonelKayid : Form
    {
        public PersonelKayid()
        {
            InitializeComponent();
        }

        IFirebaseConfig Fcon = new FirebaseConfig()
        {
            AuthSecret = "55Ru09LDH3I8wmXgniDS1E9DTTYU75bpDCPIv6nd",
            BasePath = "https://crystallinedesign-d790c-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        IFirebaseClient client;

        private void PersonelKayid_Load(object sender, EventArgs e)
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
                
        private void KayitButton_Click(object sender, EventArgs e)
        {
            if (KayitAd.Text == null || KayitNick.Text == null || KayitPosta.Text == null || KayitTel.Text == null || KayitSifre.Text == null || KayitSifre2.Text == null || KayitAd.Text == "" || KayitNick.Text == "" || KayitPosta.Text == "" || KayitTel.Text == "" || KayitSifre.Text == "" || KayitSifre2.Text == "")
            {
                MessageBox.Show("Boş Kutuları doldurunuz.");
            }
            else
            {
                if (KayitSifre.Text == KayitSifre2.Text)
                {
                    try
                    {
                        var nickkarsi = client.Get("Personel/" + KayitNick.Text);
                        Musteri mstr = nickkarsi.ResultAs<Musteri>();
                        KayitKarsilastir.Text = mstr.Nick;
                        MessageBox.Show("Bu Kullanıcı adı alınmıştır.");
                    }
                    catch
                    {
                        if (KayitNick.Text != KayitKarsilastir.Text)
                        {
                            Musteri mstr1 = new Musteri()
                            {
                                Ad = KayitAd.Text,
                                Nick = KayitNick.Text,
                                Posta = KayitPosta.Text,
                                Tel = KayitTel.Text,
                                Sifre = KayitSifre.Text,
                            };
                            var setter = client.Set("Personel/" + KayitNick.Text, mstr1);

                            AnaSayfa ana = new AnaSayfa();
                            ana.Show();
                            this.Hide();
                            MessageBox.Show("Başarılı :)");
                        }
                        else
                        {
                            MessageBox.Show("Bu kullanıcı adı alınmıştır.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Şifreniz uyumlu değil.");
                }
            }
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }
    }
}

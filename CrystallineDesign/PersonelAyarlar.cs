﻿using System;
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
    public partial class PersonelAyarlar : Form
    {
        public PersonelAyarlar()
        {
            InitializeComponent();
        }
        
        IFirebaseConfig Fcon = new FirebaseConfig()
        {
            AuthSecret = "55Ru09LDH3I8wmXgniDS1E9DTTYU75bpDCPIv6nd",
            BasePath = "https://crystallinedesign-d790c-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        private FirebaseClient client;
                              
        private void PersonelAyarlar_Load(object sender, EventArgs e)
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
             var setter = client.Set("Personel/" + Nick.Text, mstr1);
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
            
            if (NickAra.Text == null || NickAra.Text == "" )
            {
                MessageBox.Show("Lütfen Gerekli Bilgileri Tamamlayın.");                    
            }
            else
            {
                 AraNick = NickAra.Text;
                 var NickKarsi = client.Get("Personel/" + AraNick);
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

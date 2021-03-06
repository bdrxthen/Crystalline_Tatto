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
    public partial class Randevu : Form
    {
        public Randevu()
        {
            InitializeComponent();
        }

        IFirebaseConfig Fcon = new FirebaseConfig()
        {
            AuthSecret = "",
            BasePath = ""
        };
        IFirebaseClient client1;
        DataTable dt = new DataTable();

        private void Randevu_Load(object sender, EventArgs e)
        {
            client1 = new FirebaseClient(Fcon);

            if (client1==null)
            {
                MessageBox.Show("Bağlantı Hatası !!!");
            }

            dt.Columns.Add("Id");
            dt.Columns.Add("Ad");
            dt.Columns.Add("Mail");
            dt.Columns.Add("Saat");
            dt.Columns.Add("Tarih");
            dt.Columns.Add("TelNo");

            RandevuList.DataSource = dt;
        }               
                
        private async void Listele_Click_1(object sender, EventArgs e)
        {
            try
            {
                client1 = new FireSharp.FirebaseClient(Fcon);
            }
            catch
            {
                MessageBox.Show("Hatalı Bağlantı!!!");
            }
                        
            var Sayi = client1.Get("RandevuSayac/Rsayac");
            RandevuClass syc = Sayi.ResultAs<RandevuClass>();        
            Sayac1.Text = syc.Sayac;
            int i = 0;

            while (true)
            {
                if (i == Convert.ToInt32(syc.Sayac))
                {
                    break;
                }
                i++;
                try
                {
                    var Sayi1 = await client1.GetAsync("Randevular/" + i);
                    RandevuClass syc1 = Sayi1.ResultAs<RandevuClass>();

                    DataRow row = dt.NewRow();
                    row["Id"] = syc1.Id;
                    row["Ad"] = syc1.AdSoyad;
                    row["Mail"] = syc1.EMail;
                    row["Saat"] = syc1.Saat;
                    row["Tarih"] = syc1.Tarih;
                    row["TelNo"] = syc1.TelNo;

                    dt.Rows.Add(row);                    
                }
                catch
                {
                    MessageBox.Show("Hata!");
                }
            }
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }

        private void RandevuList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Id.Text = RandevuList.CurrentRow.Cells[0].Value.ToString();
            Ad.Text = RandevuList.CurrentRow.Cells[1].Value.ToString();
            Mail.Text = RandevuList.CurrentRow.Cells[2].Value.ToString();
            Saat.Text = RandevuList.CurrentRow.Cells[3].Value.ToString();
            Tarih.Text = RandevuList.CurrentRow.Cells[4].Value.ToString();
            TelNo.Text = RandevuList.CurrentRow.Cells[5].Value.ToString();
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {             
            RandevuClass rande = new RandevuClass()
            {
                Id = Id.Text,
                AdSoyad = Ad.Text,
                EMail = Mail.Text,
                Saat = Saat.Text,
                Tarih = Tarih.Text,
                TelNo = TelNo.Text,
            };
            var setter = client1.Set("Randevular/" + Id.Text, rande);
        }
    }
}

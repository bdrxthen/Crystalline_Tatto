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
using Firebase.Storage;
using FireSharp;

namespace CrystallineDesign
{
    public partial class Cover : Form
    {
        public Cover()
        {
            InitializeComponent();
        }

        IFirebaseConfig Fcon = new FirebaseConfig()
        {
            AuthSecret = "55Ru09LDH3I8wmXgniDS1E9DTTYU75bpDCPIv6nd",
            BasePath = "https://crystallinedesign-d790c-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        private FirebaseClient client1;
        DataTable dt = new DataTable();

        private void Cover_Load(object sender, EventArgs e)
        {
            client1 = new FirebaseClient(Fcon);

            if (client1 == null)
            {
                MessageBox.Show("Bağlantı Hatası !!!");
            }

            dt.Columns.Add("Id");
            dt.Columns.Add("Ad");
            dt.Columns.Add("Tur");
            dt.Columns.Add("Resim");

            ResimList.DataSource = dt;
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            if (Id.Text == null || Id.Text == "" || Ad.Text == null || Ad.Text == "" ||
                   Tur.Text == null || Tur.Text == "" || Resim.Text == null || Resim.Text == "")
            {
                MessageBox.Show("Boş Kutuları doldurunuz.");
            }
            else
            {
                try
                {
                    var nickkarsi = client1.Get("DovmeCover/" + Id.Text);
                    Resim Rsm = nickkarsi.ResultAs<Resim>();
                    Karsilastir.Text = Rsm.Id;
                    MessageBox.Show("Bu Kullanıcı adı alınmıştır.");
                }
                catch
                {
                    if (Id.Text != Karsilastir.Text)
                    {
                        Resim Rsm1 = new Resim()
                        {
                            Ad = Ad.Text,
                            Id = Id.Text,
                            Tur = Tur.Text,
                            Resimm = Resim.Text,
                        };
                        var setter = client1.Set("DovmeCover/" + Id.Text, Rsm1);
                    }
                    else
                    {
                        MessageBox.Show("!!!BU ID KAYITLI!!!");
                    }
                }
            }
        }

        private async void Listele_Click(object sender, EventArgs e)
        {
            try
            {
                client1 = new FireSharp.FirebaseClient(Fcon);
            }
            catch
            {
                MessageBox.Show("Hatalı Bağlantı!!!");
            }
            int i = 1;
            while (true)
            {
                try
                {
                    var Res = await client1.GetAsync("DovmeCover/" + i);
                    Resim Res1 = Res.ResultAs<Resim>();

                    DataRow row = dt.NewRow();
                    row["Id"] = Res1.Id;
                    row["Ad"] = Res1.Ad;
                    row["Tur"] = Res1.Tur;
                    row["Resim"] = Res1.Resimm;

                    dt.Rows.Add(row);
                }
                catch
                {
                    MessageBox.Show(i.ToString() + "Adet ürün bulundu.");
                    break;
                }
                i++;
            }
        }

        private void Secenek_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName;
            Resim.Text = openFileDialog1.FileName;
        }

        private void ResimList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Id.Text = ResimList.CurrentRow.Cells[0].Value.ToString();
            Ad.Text = ResimList.CurrentRow.Cells[1].Value.ToString();
            Tur.Text = ResimList.CurrentRow.Cells[2].Value.ToString();
            Resim.Text = ResimList.CurrentRow.Cells[3].Value.ToString();
        }

        private void Resim_TextChanged(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = Resim.Text;
        }
    }
}

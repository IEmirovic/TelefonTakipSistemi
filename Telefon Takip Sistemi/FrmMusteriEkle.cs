using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefon_Takip_Sistemi
{
    public partial class FrmMusteriEkle : Form
    {
        public FrmMusteriEkle()
        {
            InitializeComponent();
        }

        BaglantiSinif bgl = new BaglantiSinif();

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad,gsm;
            ad = TxtMusteriAd.Text;
            soyad = TxtMusteriSoyad.Text;
            gsm = MskTelefon.Text;
            bool adbool = String.IsNullOrEmpty(ad);
            bool soyadbool = String.IsNullOrEmpty(soyad);
            bool gsmbool = String.IsNullOrEmpty(gsm);

            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand kontrol = new SqlCommand("Select MusteriGSM From Musteri where MusteriGSM='" + MskTelefon.Text + "'", baglanti);
            SqlDataReader kontrolrd = kontrol.ExecuteReader();


            if (kontrolrd.Read())
            {
                MessageBox.Show("Bu markaya ait kayıt bulunmaktadır. Lütfen başka marka giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
                TxtMusteriAd.Text = "";
                TxtMusteriSoyad.Text = "";
                MskTelefon.Text = "";
            }


            else if (adbool == true || soyadbool == true || gsmbool == true)
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
                TxtMusteriAd.Text = "";
                TxtMusteriSoyad.Text = "";
                MskTelefon.Text = "";
            }


            else
            {
                baglanti.Close();
                baglanti.Open();
                SqlCommand kaydet = new SqlCommand("insert into Musteri (MusteriAd,MusteriSoyad,MusteriGSM) values (@ad, @soyad,@gsm )", baglanti);
                kaydet.Parameters.AddWithValue("@ad", TxtMusteriAd.Text);
                kaydet.Parameters.AddWithValue("@soyad", TxtMusteriSoyad.Text);
                kaydet.Parameters.AddWithValue("@gsm", MskTelefon.Text);
                kaydet.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kaydedildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtMusteriAd.Text = "";
                TxtMusteriSoyad.Text = "";
                MskTelefon.Text = "";
            }
        }

        private void TxtMusteriAd_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(TxtMusteriAd.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("Bu alan sadece alfabetik karakterleri kabul eder.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtMusteriAd.Text = "";
            }
        }

        private void TxtMusteriSoyad_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(TxtMusteriSoyad.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("Bu alan sadece alfabetik karakterleri kabul eder.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtMusteriSoyad.Text = "";
            }
        }
    }
}

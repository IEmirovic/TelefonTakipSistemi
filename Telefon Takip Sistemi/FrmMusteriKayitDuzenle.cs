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
    public partial class FrmMusteriKayitDuzenle : Form
    {
        public FrmMusteriKayitDuzenle()
        {
            InitializeComponent();
        }

        BaglantiSinif bgl = new BaglantiSinif();

        private void telefonStokOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTelefonStokOlustur frm = new FrmTelefonStokOlustur();
            frm.Show();
            this.Hide();
        }

        private void telefonStokSorgulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTelefonSorgu frm = new FrmTelefonSorgu();
            frm.Show();
            this.Hide();
        }

        private void telefonStokDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTelefonStokDuzenle frm = new FrmTelefonStokDuzenle();
            frm.Show();
            this.Hide();
        }

        private void parcaStokOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYedekParcaStokOlustur frm = new FrmYedekParcaStokOlustur();
            frm.Show();
            this.Hide();
        }

        private void parcaStokSorgulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYedekParcaStokSorgula frm = new FrmYedekParcaStokSorgula();
            frm.Show();
            this.Hide();
        }

        private void parcaStokDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYedekParcaStokDuzenle frm = new FrmYedekParcaStokDuzenle();
            frm.Show();
            this.Hide();
        }

        private void servisKaydiOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmServisKaydiOlustur frm = new FrmServisKaydiOlustur();
            frm.Show();
            this.Hide();
        }

        private void servisKayitSorgulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmServisKaydiSorgula frm = new FrmServisKaydiSorgula();
            frm.Show();
            this.Hide();
        }

        private void servisKayitDuzenleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmServisKaydiDuzenleme frm = new FrmServisKaydiDuzenleme();
            frm.Show();
            this.Hide();
        }

        

        private void musteriSorgulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMusteriSorgulama frm = new FrmMusteriSorgulama();
            frm.Show();
            this.Hide();
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void anaEkranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAnaMenu frm = new FrmAnaMenu();
            frm.Show();
            this.Hide();
        }

        private void satisYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSatisYap frm = new FrmSatisYap();
            frm.Show();
            this.Hide();
        }

        private void satisKayitSorgulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSatisKaydiSorgula frm = new FrmSatisKaydiSorgula();
            frm.Show();
            this.Hide();
        }


        private void FrmMusteriKayitDuzenle_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmAnaMenu frm = new FrmAnaMenu();
            frm.Show();
            this.Hide();
        }

        void musteriidgetir()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand musteriid = new SqlCommand("select MusteriID from Musteri where MusteriGSM='" + MskTelefon.Text + "'", baglanti);
            SqlDataReader musteriidrd = musteriid.ExecuteReader();
            while (musteriidrd.Read())
            {
                LblMusteriID.Text = musteriidrd["MusteriID"].ToString();
            }
            baglanti.Close();
        }

        private void MskTelefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            musteriidgetir();
        }

        void verigetir()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("select MusteriID, MusteriAd, MusteriSoyad, MusteriGSM From Musteri where not MusteriID=0", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sorgu);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Müşteri Adı";
            dataGridView1.Columns[2].HeaderText = "Müşteri Soyadı";
            dataGridView1.Columns[3].HeaderText = "Müşteri GSM";

            baglanti.Close();
        }

        private void FrmMusteriKayitDuzenle_Load(object sender, EventArgs e)
        {
            verigetir();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            LblMusteriID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtMusteriAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtMusteriSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MskTelefon.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            musteriidgetir();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            ad = TxtMusteriAd.Text;
            soyad = TxtMusteriSoyad.Text;
            bool adst = string.IsNullOrEmpty(ad);
            bool soyadst = string.IsNullOrEmpty(soyad);

            if (!MskTelefon.MaskCompleted || LblMusteriID.Text == "0" || adst==true || soyadst==true)
            {
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                MessageBox.Show("Kayıt güncellemek için geçerli bir telefon numarası giriniz ve boş alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }

            else
            {
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                baglanti.Open();
                SqlCommand guncelle = new SqlCommand("UPDATE Musteri set MusteriAd=@ad,MusteriSoyad=@soyad,MusteriGSM=@gsm where MusteriID=@musteri ", baglanti);
                guncelle.Parameters.AddWithValue("@ad", TxtMusteriAd.Text);
                guncelle.Parameters.AddWithValue("@soyad", TxtMusteriSoyad.Text);
                guncelle.Parameters.AddWithValue("@gsm", MskTelefon.Text);
                guncelle.Parameters.AddWithValue("@musteri", LblMusteriID.Text);
                guncelle.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Güncelleme başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verigetir();
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (LblMusteriID.Text == "0")
            {
                MessageBox.Show("Kayıt silmek için müşteriye ait telefon numarası giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verigetir();
            }

            else
            {
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                baglanti.Open();
                SqlCommand sil = new SqlCommand("Delete From Musteri where MusteriID=@id", baglanti);
                sil.Parameters.AddWithValue("@id", LblMusteriID.Text);
                sil.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kayıt başarıyla silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verigetir();
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

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            verigetir();
            TxtMusteriAd.Text = "";
            TxtMusteriSoyad.Text = "";
            MskTelefon.Text = "";
        }
    }
}

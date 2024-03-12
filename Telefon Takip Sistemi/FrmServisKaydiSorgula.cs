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
    public partial class FrmServisKaydiSorgula : Form
    {
        public FrmServisKaydiSorgula()
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

        

        private void servisKayitDuzenleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmServisKaydiDuzenleme frm = new FrmServisKaydiDuzenleme();
            frm.Show();
            this.Hide();
        }

        private void musteriDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMusteriKayitDuzenle frm = new FrmMusteriKayitDuzenle();
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


        private void FrmServisKaydiSorgula_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmAnaMenu frm = new FrmAnaMenu();
            frm.Show();
            this.Hide();
        }

        void verigetir()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("select Musteri.MusteriAd, Musteri.MusteriSoyad, Musteri.MusteriGSM,YedekParcaStok.ParcaTur,ServisDurum.ServisDurumAd,Servis.ServisSurec,Servis.ServisUcret,Servis.TeslimTarihi from Servis inner join ServisDurum on ServisDurum.ServisDurumID=Servis.ServisDurumID inner join Musteri on Servis.MusteriID=Musteri.MusteriID inner join YedekParcaStok on YedekParcaStok.ParcaID=Servis.ParcaID", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sorgu);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Müşteri Adı";
            dataGridView1.Columns[1].HeaderText = "Müşteri Soyadı";
            dataGridView1.Columns[2].HeaderText = "Müşteri GSM";
            dataGridView1.Columns[3].HeaderText = "Telefon Modeli";
            dataGridView1.Columns[4].HeaderText = "Parça Türü";
            dataGridView1.Columns[5].HeaderText = "Servis Durumu";
            dataGridView1.Columns[6].HeaderText = "Servis Süreci";
            dataGridView1.Columns[7].HeaderText = "Teslim Tarihi";
            
            baglanti.Close();
        }
        private void FrmServisKaydiSorgula_Load(object sender, EventArgs e)
        {
            verigetir();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("select Musteri.MusteriAd, Musteri.MusteriSoyad, Musteri.MusteriGSM,YedekParcaStok.ParcaTur,ServisDurum.ServisDurumAd,Servis.ServisSurec,Servis.ServisUcret,Servis.TeslimTarihi from Servis inner join ServisDurum on ServisDurum.ServisDurumID=Servis.ServisDurumID inner join Musteri on Servis.MusteriID=Musteri.MusteriID inner join YedekParcaStok on YedekParcaStok.ParcaID=Servis.ParcaID", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sorgu);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Müşteri Adı";
            dataGridView1.Columns[1].HeaderText = "Müşteri Soyadı";
            dataGridView1.Columns[2].HeaderText = "Müşteri GSM";
            dataGridView1.Columns[3].HeaderText = "Telefon Modeli";
            dataGridView1.Columns[4].HeaderText = "Parça Türü";
            dataGridView1.Columns[5].HeaderText = "Servis Durumu";
            dataGridView1.Columns[6].HeaderText = "Servis Süreci";
            dataGridView1.Columns[7].HeaderText = "Teslim Tarihi";
            baglanti.Close();
            baglanti.Open();
            SqlCommand gsmkontrol = new SqlCommand("Select MusteriGSM From Musteri where MusteriGSM='"+MskTelefon.Text+"'", baglanti);
            SqlDataReader gsmkontrolrd = gsmkontrol.ExecuteReader();
            while (gsmkontrolrd.Read())
            {
                LblGsm.Text = gsmkontrolrd[0].ToString();
            }
            if (!MskTelefon.MaskCompleted || LblGsm.Text=="0")
            {
                baglanti.Close();
                MessageBox.Show("Lütfen geçerli bir telefon numarası giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LblGsm.Text = "0";
            }
            else
            {
                //dt.DefaultView.RowFilter = "TlfMarkaAd LIKE '" + CmbMarka.Text + "%'";
                dt.DefaultView.RowFilter = "MusteriGSM LIKE '" + MskTelefon.Text + "%'";
                MessageBox.Show("Arama Tamamlandı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MskTelefon.Text = "5";

            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Close();
            verigetir();
            MskTelefon.Text = "";
            LblGsm.Text = "0";
        }
    }
}

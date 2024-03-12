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
    public partial class FrmSatisKaydiSorgula : Form
    {
        public FrmSatisKaydiSorgula()
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

        

        

        private void FrmSatisKaydiSorgula_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmAnaMenu frm = new FrmAnaMenu();
            frm.Show();
            this.Hide();
        }

        

        void musteriadgetir()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Close();
            baglanti.Open();

            SqlCommand musteriad = new SqlCommand("SELECT distinct MusteriAd FROM Musteri", baglanti);
            SqlDataReader musteriadrd = musteriad.ExecuteReader();
            while (musteriadrd.Read())
            {
                CmbMusteriAd.Items.Add(musteriadrd["MusteriAd"].ToString());
                CmbMusteriAd.Items.Remove("Belirsiz");
            }
            baglanti.Close();
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



        void verigetir()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("Select Musteri.MusteriAd,Musteri.MusteriSoyad,Musteri.MusteriGSM,TelefonStok.TlfID,Satis.SatisTarih,Satis.SatisUcret from Satis inner join Musteri on Musteri.MusteriID=Satis.MusteriID  inner join TelefonStok on Satis.TlfID=TelefonStok.TlfID", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sorgu);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Müşteri Adı";
            dataGridView1.Columns[1].HeaderText = "Müşteri Soyadı";
            dataGridView1.Columns[2].HeaderText = "Müşteri GSM";
            dataGridView1.Columns[3].HeaderText = "Telefon ID";
            dataGridView1.Columns[4].HeaderText = "Satış Tarihi";
            dataGridView1.Columns[5].HeaderText = "Ücret";
            baglanti.Close();
        }

        private void FrmSatisKaydiSorgula_Load(object sender, EventArgs e)
        {
            musteriadgetir();
            verigetir();
        }

        private void MskTelefon_TextChanged(object sender, EventArgs e)
        {
            musteriidgetir();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("Select Musteri.MusteriAd,Musteri.MusteriSoyad,Musteri.MusteriGSM,TelefonStok.TlfID,Satis.SatisTarih,Satis.SatisUcret from Satis inner join Musteri on Musteri.MusteriID=Satis.MusteriID  inner join TelefonStok on Satis.TlfID=TelefonStok.TlfID", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sorgu);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Müşteri Adı";
            dataGridView1.Columns[1].HeaderText = "Müşteri Soyadı";
            dataGridView1.Columns[2].HeaderText = "Müşteri GSM";
            dataGridView1.Columns[3].HeaderText = "Telefon ID";
            dataGridView1.Columns[4].HeaderText = "Satış Tarihi";
            dataGridView1.Columns[5].HeaderText = "Ücret";
            baglanti.Close();

            dt.DefaultView.RowFilter = "MusteriAd LIKE '" + CmbMusteriAd.Text + "%'";
            dt.DefaultView.RowFilter = "MusteriSoyad LIKE '" + CmbMusteriSoyad.Text + "%'";
            dt.DefaultView.RowFilter = "MusteriGSM LIKE '" + MskTelefon.Text + "%'";
            MessageBox.Show("Arama Tamamlandı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CmbMusteriAd.Items.Clear();
            musteriadgetir();
            MskTelefon.Text = "";


            if (!MskTelefon.MaskCompleted)
            {
                MessageBox.Show("Lütfen geçerli bir telefon numarası giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dt.DefaultView.RowFilter = "MusteriAd LIKE '" + CmbMusteriAd.Text + "%'";
                dt.DefaultView.RowFilter = "MusteriSoyad LIKE '" + CmbMusteriSoyad.Text + "%'";
                dt.DefaultView.RowFilter = "MusteriGSM LIKE '" + MskTelefon.Text + "%'";
                MessageBox.Show("Arama Tamamlandı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbMusteriAd.Items.Clear();
                musteriadgetir();
                MskTelefon.Text = "";
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            CmbMusteriAd.Items.Clear();
            musteriadgetir();
            MskTelefon.Text = "";
            verigetir();
        }
    }
}

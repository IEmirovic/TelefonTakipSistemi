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
    public partial class FrmMusteriSorgulama : Form
    {
        public FrmMusteriSorgulama()
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


        private void FrmMusteriSorgulama_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmAnaMenu frm = new FrmAnaMenu();
            frm.Show();
            this.Hide();
        }

        void verigetir()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("select * from Musteri where not MusteriID=0", baglanti);
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

        void adagoresoyad()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            CmbMusteriSoyad.Items.Clear();

            baglanti.Open();
            SqlCommand ad = new SqlCommand("select MusteriID,MusteriAd from Musteri where MusteriAd='" + CmbMusteriAd.Text + "'", baglanti);
            SqlDataReader adrd = ad.ExecuteReader();
            while (adrd.Read())
            {
                LblAd.Text = adrd["MusteriID"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand soyad = new SqlCommand("select distinct MusteriSoyad from Musteri where MusteriID='" + LblAd.Text + "'", baglanti);
            SqlDataReader soyadrd = soyad.ExecuteReader();
            while (soyadrd.Read())
            {
                LblSoyad.Text = soyadrd[0].ToString();
                CmbMusteriSoyad.Items.Add(LblSoyad.Text);
            }
            baglanti.Close();
        }

        private void FrmMusteriSorgulama_Load(object sender, EventArgs e)
        {
            verigetir();
            musteriadgetir();
        }

        private void CmbMusteriAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            adagoresoyad();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("select * from Musteri where not MusteriID=0 ", baglanti);
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
            baglanti.Open();
            SqlCommand musterikontrol = new SqlCommand("Select MusteriGSM From Musteri where MusteriGSM='" + MskTelefon.Text + "'", baglanti);
            SqlDataReader musterikonrollrd = musterikontrol.ExecuteReader();
            while (musterikonrollrd.Read())
            {
                LblGsm.Text = musterikonrollrd[0].ToString();
            }
            if (!MskTelefon.MaskCompleted || LblGsm.Text == "0")
            {
                baglanti.Close();
                MessageBox.Show("Lütfen geçerli bir telefon numarası giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LblGsm.Text = "0";
                MskTelefon.Text = "";
                CmbMusteriAd.Text = "";
                CmbMusteriAd.Items.Clear();
                CmbMusteriSoyad.Text = "";
                musteriadgetir();
            }
            else
            {
                //dt.DefaultView.RowFilter = "TlfMarkaAd LIKE '" + CmbMarka.Text + "%'";
                dt.DefaultView.RowFilter = "MusteriAd LIKE '" + CmbMusteriAd.Text + "%'";
                dt.DefaultView.RowFilter = "MusteriSoyad LIKE '" + CmbMusteriSoyad.Text + "%'";
                dt.DefaultView.RowFilter = "MusteriGSM LIKE '" + MskTelefon.Text + "%'";
                MessageBox.Show("Arama Tamamlandı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbMusteriAd.Items.Clear();
                musteriadgetir();
                LblGsm.Text = "0";
                MskTelefon.Text = "";
                CmbMusteriAd.Text = "";
                CmbMusteriAd.Items.Clear();
                CmbMusteriSoyad.Text = "";
                musteriadgetir();
            }


        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            LblGsm.Text = "0";
            CmbMusteriAd.Text = "";
            CmbMusteriAd.Items.Clear();
            CmbMusteriSoyad.Text = "";
            CmbMusteriSoyad.Items.Clear();
            musteriadgetir();
            adagoresoyad();
        }
    }
}

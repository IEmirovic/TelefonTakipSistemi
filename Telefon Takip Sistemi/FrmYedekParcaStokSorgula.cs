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
    public partial class FrmYedekParcaStokSorgula : Form
    {
        public FrmYedekParcaStokSorgula()
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

        private void satisKayitSorgulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSatisKaydiSorgula frm = new FrmSatisKaydiSorgula();
            frm.Show();
            this.Hide();
        }

        private void FrmYedekParcaStokSorgula_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmAnaMenu frm = new FrmAnaMenu();
            frm.Show();
            this.Hide();
        }

        void markaAdGetir()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Close();
            baglanti.Open();

            SqlCommand marka = new SqlCommand("SELECT TlfMarkaAd FROM TelefonMarka", baglanti);
            SqlDataReader markard = marka.ExecuteReader();
            while (markard.Read())
            {
                CmbMarka.Items.Add(markard["TlfMarkaAd"].ToString());
                CmbMarka.Items.Remove("Belirsiz");
            }
            baglanti.Close();

        }

        void modelGetir()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Close();
            baglanti.Open();
            SqlCommand model = new SqlCommand("Select TlfModel from TelefonOzellikler", baglanti);
            SqlDataReader modelrd = model.ExecuteReader();
            while (modelrd.Read())
            {
                CmbModel.Items.Add(modelrd["TlfModel"].ToString());
                CmbModel.Items.Remove("Belirsiz");
            }
            baglanti.Close();
        }

        void yedekparcaturgetir()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Close();
            baglanti.Open();
            SqlCommand parcatur = new SqlCommand("Select ParcaTur From YedekParcaStok ", baglanti);
            SqlDataReader parcaturrd = parcatur.ExecuteReader();
            while (parcaturrd.Read())
            {
                CmbYedekParcaTur.Items.Add(parcaturrd["ParcaTur"].ToString() );
                CmbYedekParcaTur.Items.Remove("Belirsiz");
            }
            baglanti.Close() ;
        }
        void markayagoremodel()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            CmbModel.Items.Clear();

            baglanti.Open();
            SqlCommand marka = new SqlCommand("select TlfMarkaID,TlfMarkaAd from TelefonMarka where TlfMarkaAd='" + CmbMarka.Text + "'", baglanti);
            SqlDataReader markard = marka.ExecuteReader();
            while (markard.Read())
            {
                LblMarka.Text = markard["TlfMarkaID"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand marka2 = new SqlCommand("select TlfModel from TelefonOzellikler where TlfMarkaID='" + LblMarka.Text + "'", baglanti);
            SqlDataReader markard2 = marka2.ExecuteReader();
            while (markard2.Read())
            {
                LblMarka2.Text = markard2[0].ToString();
                CmbModel.Items.Add(LblMarka2.Text);
            }
            baglanti.Close();
        }

        void modelegoreparca()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            CmbYedekParcaTur.Items.Clear();

            baglanti.Open();
            SqlCommand model = new SqlCommand("select TlfModelID,TlfModel from TelefonOzellikler where TlfModel='" + CmbModel.Text + "'", baglanti);
            SqlDataReader modelrd = model.ExecuteReader();
            while (modelrd.Read())
            {
                LblModel.Text = modelrd["TlfModelID"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand parcatur = new SqlCommand("select ParcaTur from YedekParcaStok where TlfModelID='" + LblModel.Text + "'", baglanti);
            SqlDataReader parcaturrd = parcatur.ExecuteReader();
            while (parcaturrd.Read())
            {
                LblModel2.Text = parcaturrd[0].ToString();
                CmbYedekParcaTur.Items.Add(LblModel2.Text);
            }
            baglanti.Close();
        }
        void verigetir()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("select  TelefonOzellikler.TlfModel,YedekParcaStok.ParcaTur,YedekParcaStok.ParcaAdet,YedekParcaStok.ParcaAdetFiyat from YedekParcaStok inner join TelefonOzellikler on YedekParcaStok.TlfModelID=TelefonOzellikler.TlfModelID where not ParcaID=0", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sorgu);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Model";
            dataGridView1.Columns[1].HeaderText = "Parça Türü";
            dataGridView1.Columns[2].HeaderText = "Parça Adeti";
            dataGridView1.Columns[3].HeaderText = "Adet Fiyatı";
            baglanti.Close();
        }
        private void FrmYedekParcaStokSorgula_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            markaAdGetir();
            verigetir();
            baglanti.Close();
        }

        private void CmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            markayagoremodel();
        }

        private void CmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelegoreparca();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("select  TelefonOzellikler.TlfModel,YedekParcaStok.ParcaTur,YedekParcaStok.ParcaAdet,YedekParcaStok.ParcaAdetFiyat from YedekParcaStok inner join TelefonOzellikler on YedekParcaStok.TlfModelID=TelefonOzellikler.TlfModelID where not ParcaID=0", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sorgu);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Model";
            dataGridView1.Columns[1].HeaderText = "Parça Türü";
            dataGridView1.Columns[2].HeaderText = "Parça Adeti";
            dataGridView1.Columns[3].HeaderText = "Adet Fiyatı";
            baglanti.Close();
            if (CmbMarka.Text == "" || CmbModel.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //dt.DefaultView.RowFilter = "TlfMarkaAd LIKE '" + CmbMarka.Text + "%'";
                dt.DefaultView.RowFilter = "TlfModel LIKE '" + CmbModel.Text + "%'";
                dt.DefaultView.RowFilter = "ParcaTur LIKE '" + CmbYedekParcaTur.Text + "%'";
                MessageBox.Show("Arama Tamamlandı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbMarka.Items.Clear();
                CmbModel.Items.Clear();
                CmbYedekParcaTur.Items.Clear();
                markaAdGetir();
                
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            CmbMarka.Items.Clear();
            CmbModel.Items.Clear();
            CmbYedekParcaTur.Items.Clear();
            markaAdGetir();
            verigetir();
        }
    }
}

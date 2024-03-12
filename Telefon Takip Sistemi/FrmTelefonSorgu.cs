using Microsoft.SqlServer.Server;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Telefon_Takip_Sistemi
{
    public partial class FrmTelefonSorgu : Form
    {
        public FrmTelefonSorgu()
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

        private void satisKayitSorgulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSatisKaydiSorgula frm = new FrmSatisKaydiSorgula();
            frm.Show();
            this.Hide();
        }


        private void FrmTelefonSorgu_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmAnaMenu frm = new FrmAnaMenu();
            frm.Show();
            this.Hide();
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


        void verigetir()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("select TelefonMarka.TlfMarkaAd, TelefonOzellikler.TlfModel,TelefonOzellikler.TlfRam,TelefonOzellikler.TlfHafiza,TelefonStok.TlfSifir,TelefonStok.TlfAdet,TelefonStok.TlfAdetFiyat,TelefonStok.TlfGaranti,TelefonStok.TlfGarantiTarih from TelefonStok inner join TelefonOzellikler on TelefonStok.TlfModelID=TelefonOzellikler.TlfModelID inner join TelefonMarka on TelefonMarka.TlfMarkaID=TelefonOzellikler.TlfMarkaID where not TlfID=0", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sorgu);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Marka";
            dataGridView1.Columns[1].HeaderText = "Model";
            dataGridView1.Columns[2].HeaderText = "RAM";
            dataGridView1.Columns[3].HeaderText = "Hafıza";
            dataGridView1.Columns[4].HeaderText = "Sıfır";
            dataGridView1.Columns[5].HeaderText = "Adet";
            dataGridView1.Columns[6].HeaderText = "Adet Fiyatı";
            dataGridView1.Columns[7].HeaderText = "Garantili";
            dataGridView1.Columns[8].HeaderText = "Garanti Süresi";
            baglanti.Close();            
        }

        private void FrmTelefonSorgu_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            verigetir();
            baglanti.Close();
            modelGetir();
            markaAdGetir();
        }

        private void CmbMarka_SelectedIndexChanged(object sender, EventArgs e)
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

        private void BtnAra_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("select TelefonMarka.TlfMarkaAd, TelefonOzellikler.TlfModel,TelefonOzellikler.TlfRam,TelefonOzellikler.TlfHafiza,TelefonStok.TlfSifir,TelefonStok.TlfAdet,TelefonStok.TlfAdetFiyat,TelefonStok.TlfGaranti,TelefonStok.TlfGarantiTarih from TelefonStok inner join TelefonOzellikler on TelefonStok.TlfModelID=TelefonOzellikler.TlfModelID inner join TelefonMarka on TelefonMarka.TlfMarkaID=TelefonOzellikler.TlfMarkaID where not TlfID=0", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sorgu);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Marka";
            dataGridView1.Columns[1].HeaderText = "Model";
            dataGridView1.Columns[2].HeaderText = "RAM";
            dataGridView1.Columns[3].HeaderText = "Hafıza";
            dataGridView1.Columns[4].HeaderText = "Sıfır";
            dataGridView1.Columns[5].HeaderText = "Adet";
            dataGridView1.Columns[6].HeaderText = "Adet Fiyatı";
            dataGridView1.Columns[7].HeaderText = "Garantili";
            dataGridView1.Columns[8].HeaderText = "Garanti Süresi";
            baglanti.Close();
            if (CmbMarka.Text=="" || CmbModel.Text =="")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dt.DefaultView.RowFilter = "TlfMarkaAd LIKE '" + CmbMarka.Text + "%'";
                dt.DefaultView.RowFilter = "TlfModel LIKE '" + CmbModel.Text + "%'";
                MessageBox.Show("Arama Tamamlandı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbMarka.Items.Clear();
                CmbModel.Items.Clear();
                markaAdGetir();
                modelGetir();
            }
            //DataView dv = dt.DefaultView;
            //dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "TlfMarkaAd", CmbMarka.Text);
            
            //dv.RowFilter = "TlfMarkaAd LIKE '" + CmbMarka.Text + "%'";
            //dataGridView1.DataSource = dv;

            
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            CmbMarka.Items.Clear();
            CmbModel.Items.Clear();
            markaAdGetir();
            verigetir();
            
        }
    }
}

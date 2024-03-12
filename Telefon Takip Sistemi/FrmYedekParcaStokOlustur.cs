using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace Telefon_Takip_Sistemi
{
    public partial class FrmYedekParcaStokOlustur : Form
    {
        public FrmYedekParcaStokOlustur()
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

        private void anaEkranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAnaMenu frm = new FrmAnaMenu();
            frm.Show();
            this.Hide();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FrmServisKaydiOlustur frm = new FrmServisKaydiOlustur();
            frm.Show();
            this.Hide();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            FrmServisKaydiSorgula frm = new FrmServisKaydiSorgula();
            frm.Show();
            this.Hide();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            FrmServisKaydiDuzenleme frm = new FrmServisKaydiDuzenleme();
            frm.Show(); 
            this.Hide();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            FrmMusteriKayitDuzenle frm = new FrmMusteriKayitDuzenle();
            frm.Show();
            this.Hide();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            FrmMusteriSorgulama frm = new FrmMusteriSorgulama();
            frm.Show();
            this.Hide();
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            FrmSatisYap frm = new FrmSatisYap();
            frm.Show();
            this.Hide();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            FrmSatisKaydiSorgula frm = new FrmSatisKaydiSorgula();
            frm.Show();
            this.Hide();
        }

        private void FrmYedekParcaStokOlustur_FormClosed(object sender, FormClosedEventArgs e)
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

        void modelidgetir()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand modelid = new SqlCommand("select TlfModelID,TlfModel from TelefonOzellikler where TlfModel='" + CmbModel.Text + "'", baglanti);
            SqlDataReader modelidrd = modelid.ExecuteReader();
            while (modelidrd.Read())
            {
                LblModelID.Text = modelidrd["TlfModelID"].ToString();
            }
            baglanti.Close();
        }

        void temizle()
        {
            TxtParcaTur.Text = "";
            TxtAdet.Text = "";
            TxtFiyat.Text = "";
            CmbMarka.Items.Clear();
            CmbModel.Items.Clear();
            markaAdGetir();
        }
        
        private void FrmYedekParcaStokOlustur_Load(object sender, EventArgs e)
        {
            markaAdGetir();
        }

        private void CmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            markayagoremodel();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            string markast, modelst, parcaturst, adetst, fiyatst;
            markast = CmbMarka.Text;
            modelst = CmbModel.Text;
            parcaturst = TxtParcaTur.Text;
            adetst = TxtAdet.Text;
            fiyatst = TxtFiyat.Text;

            bool markastbool = string.IsNullOrEmpty(markast);
            bool modelstbool = string.IsNullOrEmpty(modelst);
            bool parcaturstbool = string.IsNullOrEmpty(parcaturst);
            bool adetstbool = string.IsNullOrEmpty(adetst);
            bool fiyatstbool = string.IsNullOrEmpty(fiyatst);
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            modelidgetir();
            baglanti.Open();
            SqlCommand kontrol = new SqlCommand("select ParcaTur,TlfModelID from YedekParcaStok where ParcaTur='"+TxtParcaTur.Text+"' and TlfModelID='" + LblModelID.Text + "'", baglanti);
            SqlDataReader kontrolrd = kontrol.ExecuteReader();
            
            if (kontrolrd.Read())
            {
                MessageBox.Show("Bu telefon modeline ait " + kontrolrd["ParcaTur"] + " stoğu bulunmaktadır. Lütfen başka parça stoğu ekleyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

                baglanti.Close();
                temizle();
                
            }
            
            else if (markastbool == true || modelstbool == true || adetstbool == true || fiyatstbool == true || parcaturstbool == true)
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
                temizle();

            }


            else
            {
                baglanti.Close();
                baglanti.Open();
                SqlCommand kaydet = new SqlCommand("insert into YedekParcaStok(ParcaTur,TlfModelID,ParcaAdet,ParcaAdetFiyat) values (@parcatur,@tlfmodelid,@parcaadet,@parcaadetfiyat)", baglanti);

                SqlCommand modelrd = new SqlCommand("select TlfModelID,TlfModel from TelefonOzellikler where TlfModel='" + CmbModel.Text + "'", baglanti);
                SqlDataReader modelrd2 = modelrd.ExecuteReader();
                while (modelrd2.Read())
                {
                    kaydet.Parameters.AddWithValue("@tlfmodelid", modelrd2["TlfModelID"]);
                }
                baglanti.Close();

                baglanti.Open();
                kaydet.Parameters.AddWithValue("@parcatur", TxtParcaTur.Text);
                kaydet.Parameters.AddWithValue("@parcaadet", TxtAdet.Text);
                kaydet.Parameters.AddWithValue("@parcaadetfiyat", TxtFiyat.Text);
                kaydet.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kaydedildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                temizle();
            }
        }

        private void TxtAdet_KeyPress(object sender, KeyPressEventArgs e)
        {


            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);


        }

        private void TxtParcaTur_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(TxtParcaTur.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("Bu alan sadece alfabetik karakterleri kabul eder.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtParcaTur.Text = "";
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}

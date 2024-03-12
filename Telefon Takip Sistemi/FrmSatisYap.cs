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
    public partial class FrmSatisYap : Form
    {
        public FrmSatisYap()
        {
            InitializeComponent();
        }

        BaglantiSinif bgl = new BaglantiSinif();

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

        private void toolStripMenuItem16_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            FrmSatisKaydiSorgula frm = new FrmSatisKaydiSorgula();
            frm.Show();
            this.Hide();
        }

        
       

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void anaEkranToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmAnaMenu frm = new FrmAnaMenu();
            frm.Show();
            this.Hide();
        }

        private void telefonStokOlusturToolStripMenuItem_Click_1(object sender, EventArgs e)
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
            frm.Show(); this.Hide();
        }

        private void parcaStokSorgulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYedekParcaStokSorgula frm = new FrmYedekParcaStokSorgula();
            frm.Show(); this.Hide();
        }

        private void parcaStokDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYedekParcaStokDuzenle frm = new FrmYedekParcaStokDuzenle();
            frm.Show(); this.Hide();
        }

        private void FrmSatisYap_FormClosed(object sender, FormClosedEventArgs e)
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

        void telefonstokidgetir()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Close();
            baglanti.Open();
            SqlCommand telefonmodelid = new SqlCommand("select TelefonStok.TlfID,TelefonOzellikler.TlfModel, TelefonOzellikler.TlfModelID,TelefonStok.TlfAdetFiyat from TelefonStok inner join TelefonOzellikler on TelefonStok.TlfModelID=TelefonOzellikler.TlfModelID where TlfModel='" + CmbModel.Text + "'", baglanti);
            SqlDataReader telefonmodelidrd = telefonmodelid.ExecuteReader();
            while (telefonmodelidrd.Read())
            {
                LblTelefonID2.Text = telefonmodelidrd["TlfID"].ToString();
                TxtFiyat.Text = telefonmodelidrd["TlfAdetFiyat"].ToString();
            }
            baglanti.Close();

            /*baglanti.Close();
            baglanti.Open();
            SqlCommand telefonmodelid = new SqlCommand("select TlfModelID from TelefonOzellikler where TlfModel='" + CmbModel.Text + "'", baglanti);
            SqlDataReader telefonmodelidrd = telefonmodelid.ExecuteReader();
            while (telefonmodelidrd.Read())
            {
                LblTelefonID.Text = telefonmodelidrd["TlfModelID"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand telefonstokid = new SqlCommand("select TlfID from TelefonStok where TlfModelID='" + LblTelefonID.Text + "'", baglanti);
            SqlDataReader telefonstokidrd = telefonstokid.ExecuteReader();
            while (telefonstokidrd.Read())
            {
                 LblTelefonID2.Text = telefonstokidrd["TlfID"].ToString();
                
            }*/
        }

        void markayagoremodel()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            CmbModel.Items.Clear();
            baglanti.Close();
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

        void temizle()
        {
            CmbMusteriAd.Text = "";
            CmbMusteriAd.Items.Clear();
            CmbMusteriSoyad.Text = "";
            CmbMusteriSoyad.Items.Clear();
            MskTelefon.Text = "";
            CmbMarka.Text = "";
            CmbMarka.Items.Clear();
            CmbModel.Text = "";
            CmbModel.Items.Clear();
            
            TxtFiyat.Text = "";
            LblMusteriID.Text = "0";
            markaAdGetir();
            musteriadgetir();
            musteriidgetir();

        }

        private void FrmSatisYap_Load(object sender, EventArgs e)
        {
            markaAdGetir();
            musteriadgetir();
        }

        private void CmbMusteriAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            adagoresoyad();
        }

        private void CmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            markayagoremodel();
        }

        private void CmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            telefonstokidgetir();
            
        }

        private void MskTelefon_TextChanged(object sender, EventArgs e)
        {
            musteriidgetir();
        }



        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            string adst, soyadst, markast, modelst, fiyatst;
            adst = CmbMusteriAd.Text;
            soyadst = CmbMusteriSoyad.Text;
            markast = CmbMarka.Text;
            modelst = CmbModel.Text;
            fiyatst = TxtFiyat.Text;
     

            bool adstbool = string.IsNullOrEmpty(adst);
            bool soyadstbool = string.IsNullOrEmpty(soyadst);
            bool markastbool = string.IsNullOrEmpty(markast);
            bool modelstbool = string.IsNullOrEmpty(modelst);
            bool fiyatstbool = string.IsNullOrEmpty(fiyatst);
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand kontrol = new SqlCommand("select TlfID from TelefonStok where TlfID='" + LblTelefonID2.Text + "'", baglanti);
            SqlDataReader kontrolrd = kontrol.ExecuteReader();

            if (!kontrolrd.Read() || LblTelefonID2.Text=="0")
            {
                MessageBox.Show("Bu telefona ait stok bulunamamıştır. Lütfen başka telefon seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
                temizle();
            }

            else if (markastbool == true || modelstbool == true  || fiyatstbool == true  || adstbool == true || soyadstbool == true  || !MskTelefon.MaskCompleted)
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
                temizle();

            }

            else
            {

                baglanti.Close();
                baglanti.Open();
                SqlCommand kaydet = new SqlCommand("insert into Satis(TlfID,MusteriID,SatisTarih,SatisUcret) values (@tlfid,@musteri,@satistarih,@satisucret)", baglanti);

                kaydet.Parameters.AddWithValue("@tlfid", LblTelefonID2.Text);
                kaydet.Parameters.AddWithValue("@musteri", LblMusteriID.Text);
                kaydet.Parameters.AddWithValue("@satistarih", DateTime.Now);
                kaydet.Parameters.AddWithValue("@satisucret", TxtFiyat.Text);
                
                SqlCommand guncelle = new SqlCommand("UPDATE TelefonStok set TlfAdet=TlfAdet - 1 where TlfID='" + LblTelefonID2.Text + "'", baglanti);
                guncelle.ExecuteNonQuery();

                kaydet.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kaydedildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();

            }
        }

        private void BtnMusteri_Click(object sender, EventArgs e)
        {
            FrmMusteriEkle frm = new FrmMusteriEkle();
            frm.ShowDialog();
        }

        private void TxtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}

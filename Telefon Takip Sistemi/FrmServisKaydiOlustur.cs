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
    public partial class FrmServisKaydiOlustur : Form
    {
        
        public FrmServisKaydiOlustur()
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

        

        private void FrmServisKaydiOlustur_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmAnaMenu frm = new FrmAnaMenu();
            frm.Show();
            this.Hide();
        }

        private void BtnMusteri_Click(object sender, EventArgs e)
        {
            FrmMusteriEkle frm = new FrmMusteriEkle();
            frm.ShowDialog();
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

       

        void servisdurumgetir()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Close();
            baglanti.Open();

            SqlCommand servistur = new SqlCommand("SELECT ServisDurumAd FROM ServisDurum", baglanti);
            SqlDataReader servisturrd = servistur.ExecuteReader();
            while (servisturrd.Read())
            {
                CmbServisDurum.Items.Add(servisturrd["ServisDurumAd"].ToString());
                CmbServisDurum.Items.Remove("Belirsiz");
            }
            baglanti.Close();
        }

        void servisdurumidgetir()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Close();
            baglanti.Open();

            SqlCommand servisturid = new SqlCommand("SELECT ServisDurumID FROM ServisDurum where ServisDurumAd='" + CmbServisDurum.Text + "'", baglanti);
            SqlDataReader servisturidrd = servisturid.ExecuteReader();
            while (servisturidrd.Read())
            {
                LblServisDurumID.Text = servisturidrd[0].ToString();
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


        void parcaidgetir()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand parcaid = new SqlCommand("select ParcaID from YedekParcaStok where TlfModelID='" + LblParca.Text + "' and ParcaTur='" + CmbYedekParcaTur.Text + "'", baglanti);
            SqlDataReader parcaidrd = parcaid.ExecuteReader();
            while (parcaidrd.Read())
            {
                LblParcaID.Text = parcaidrd[0].ToString();
            }
            baglanti.Close();
        }

        void markayagoremodel()
        {
            CmbModel.Items.Clear();
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
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
            CmbYedekParcaTur.Items.Clear();
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand parca = new SqlCommand("select TlfModelID,TlfModel from TelefonOzellikler where TlfModel='" + CmbModel.Text + "'", baglanti);
            SqlDataReader parcard = parca.ExecuteReader();
            while (parcard.Read())
            {
                LblParca.Text = parcard["TlfModelID"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand parca2 = new SqlCommand("select ParcaTur from YedekParcaStok where TlfModelID=0 or TlfModelID='" + LblParca.Text + "'", baglanti);
            SqlDataReader parcard2 = parca2.ExecuteReader();
            while (parcard2.Read())
            {
                LblParca2.Text = parcard2[0].ToString();
                CmbYedekParcaTur.Items.Add(LblParca2.Text);
                CmbYedekParcaTur.Items.Remove("Stok Yok");
                
            }
            baglanti.Close();
        }
        

        void adagoresoyad()
        {
            CmbMusteriSoyad.Items.Clear();
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
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
            CmbYedekParcaTur.Text = "";
            CmbYedekParcaTur.Items.Clear();
            CmbServisDurum.Text = "";
            CmbServisDurum.Items.Clear();
            dateTimePicker1.CustomFormat = " ";
            TxtFiyat.Text = "";
            richTextBox1.Text = "";
            LblMusteriID.Text = "0";
            markaAdGetir();
            musteriadgetir();
            servisdurumgetir();
            musteriidgetir();
            servisdurumidgetir();

        }


        private void FrmServisKaydiOlustur_Load(object sender, EventArgs e)
        {

            markaAdGetir();
            musteriadgetir();
            servisdurumgetir();
            musteriidgetir();
            servisdurumidgetir();
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
            modelegoreparca();
        }

        private void CmbServisDurum_SelectedIndexChanged(object sender, EventArgs e)
        {
            servisdurumidgetir();
        }

        private void MskTelefon_TextChanged(object sender, EventArgs e)
        {
            musteriidgetir();
        }

        private void CmbYedekParcaTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            parcaidgetir();
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            if (dateTimePicker1.Value < DateTime.Today)
            {
                MessageBox.Show("Lütfen ileri bir tarih seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker1.Value = DateTime.Today;
            }
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                dateTimePicker1.CustomFormat = " ";
            }
        }



        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            string adst, soyadst, markast, modelst, parcaturst, fiyatst, durumst,aciklamast;
            adst = CmbMusteriAd.Text;
            soyadst = CmbMusteriSoyad.Text;
            markast = CmbMarka.Text;
            modelst = CmbModel.Text;
            parcaturst = CmbYedekParcaTur.Text;
            durumst = CmbServisDurum.Text;
            fiyatst = TxtFiyat.Text;
            aciklamast = richTextBox1.Text;
            

            bool adstbool = string.IsNullOrEmpty(adst);
            bool soyadstbool = string.IsNullOrEmpty(soyadst);
            bool markastbool = string.IsNullOrEmpty(markast);
            bool modelstbool = string.IsNullOrEmpty(modelst);
            bool parcaturstbool = string.IsNullOrEmpty(parcaturst);
            bool durumstbool = string.IsNullOrEmpty(durumst);
            bool fiyatstbool = string.IsNullOrEmpty(fiyatst);
            bool aciklamastbool = string.IsNullOrEmpty (aciklamast);

            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand kontrol = new SqlCommand("select MusteriID from Servis where MusteriID='" + LblMusteriID.Text + "' and not MusteriID=0", baglanti);
            SqlDataReader kontrolrd = kontrol.ExecuteReader();

            if (kontrolrd.Read())
            {
                MessageBox.Show("Bilgileri girilen müşteri adına servis kaydı bulunmaktadır. Servis işlemleri tamamlandıktan sonra kaydı silip tekrar deneyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
                temizle();
            }

            

            else if (markastbool == true || modelstbool == true || durumstbool == true || fiyatstbool == true || parcaturstbool == true || adstbool == true || soyadstbool == true || aciklamastbool==true || !MskTelefon.MaskCompleted || dateTimePicker1.CustomFormat ==" " )
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
                temizle();
                
            }

            else 
            {
                baglanti.Close();
                baglanti.Open();
                SqlCommand kaydet = new SqlCommand("insert into Servis(MusteriID,ParcaID,ServisDurumID,ServisSurec,ServisUcret,TeslimTarihi) values (@musteri,@parca,@servisdurum,@servissurec,@servisucret,@teslimtarihi)", baglanti);
                kaydet.Parameters.AddWithValue("@parca",LblParcaID.Text);
                kaydet.Parameters.AddWithValue("@musteri", LblMusteriID.Text);
                kaydet.Parameters.AddWithValue("@servissurec",richTextBox1.Text);
                kaydet.Parameters.AddWithValue("@servisucret",TxtFiyat.Text);
                kaydet.Parameters.AddWithValue("@teslimtarihi", dateTimePicker1.Value.Date);
                kaydet.Parameters.AddWithValue("@servisdurum", LblParcaID.Text);
              
                SqlCommand guncelle = new SqlCommand("UPDATE YedekParcaStok set ParcaAdet=ParcaAdet - 1 where ParcaID='" + LblParcaID.Text + "'", baglanti);
                guncelle.ExecuteNonQuery();
                    
                kaydet.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kaydedildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();

            }

           
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnServisDurum_Click(object sender, EventArgs e)
        {
            FrmServisDurumuTablosuDuzenle frm = new FrmServisDurumuTablosuDuzenle();
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

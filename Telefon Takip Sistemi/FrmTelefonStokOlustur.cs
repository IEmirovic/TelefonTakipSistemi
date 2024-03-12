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

namespace Telefon_Takip_Sistemi
{
    public partial class FrmTelefonStokOlustur : Form
    {
        BaglantiSinif bgl = new BaglantiSinif();

        
        public FrmTelefonStokOlustur()
        {
            InitializeComponent();
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

        private void satisKayitSorgulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSatisKaydiSorgula frm = new FrmSatisKaydiSorgula();
            frm.Show();
            this.Hide();
        }


        private void FrmTelefonStokOlustur_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmAnaMenu frm = new FrmAnaMenu();
            frm.Show();
            this.Hide();
        }

        private void BtnMarka_Click(object sender, EventArgs e)
        {
            FrmTelefonMarkaDuzenleEkle frm = new FrmTelefonMarkaDuzenleEkle();
            frm.ShowDialog();
        }

        private void BtnModel_Click(object sender, EventArgs e)
        {
            FrmTelefonModelDuzenleEkle frm = new FrmTelefonModelDuzenleEkle();
            frm.ShowDialog();
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

        void modelkontrol()
        {
            string markast, modelst;
            markast = CmbMarka.Text;
            modelst = CmbModel.Text;

            bool markastbool = string.IsNullOrEmpty(markast);
            bool modelstbool = string.IsNullOrEmpty(modelst);

            if (markastbool == true || modelstbool == true)
            {
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                MessageBox.Show("Lütfen marka ve model seçimi yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }

            else
            {
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                baglanti.Open();
                SqlCommand kontrol = new SqlCommand("select TlfModel,TlfModelID from TelefonOzellikler where TlfModel='" + CmbModel.Text + "'", baglanti);
                SqlDataReader kontrolrd = kontrol.ExecuteReader();

                while (kontrolrd.Read())
                {
                    LblModel.Text = kontrolrd["TlfModelID"].ToString();
                }
                baglanti.Close();

                baglanti.Open();
                SqlCommand kontrol2 = new SqlCommand("select TlfModelID from TelefonStok where TlfModelID='" + LblModel.Text + "'", baglanti);
                SqlDataReader kontrolrd2 = kontrol2.ExecuteReader();
                while (kontrolrd2.Read())
                {
                    LblKontol.Text = kontrolrd2[0].ToString();
                }

                baglanti.Close();
            }

        }

        private void FrmTelefonStokOlustur_Load(object sender, EventArgs e)
        {
            markaAdGetir();
            

        }


        private void CmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbModel.Items.Clear();
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand marka = new SqlCommand("select TlfMarkaID,TlfMarkaAd from TelefonMarka where TlfMarkaAd='" + CmbMarka.Text + "'",baglanti);
            SqlDataReader markard = marka.ExecuteReader();
            while (markard.Read())
            {
                LblMarka.Text = markard["TlfMarkaID"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand marka2 = new SqlCommand("select TlfModel from TelefonOzellikler where TlfMarkaID='" + LblMarka.Text + "'", baglanti);
            SqlDataReader markard2=marka2.ExecuteReader();
            while (markard2.Read())
            {
                LblMarka2.Text = markard2[0].ToString();
                CmbModel.Items.Add(LblMarka2.Text);
            }
            baglanti.Close();

        }

        private void radioSifir_CheckedChanged(object sender, EventArgs e)
        {
            LblDurum.Text = "1";
        }

        private void radioikinciEl_CheckedChanged(object sender, EventArgs e)
        {
            LblDurum.Text = "0";
        }

        private void radioVar_CheckedChanged(object sender, EventArgs e)
        {
            LblGaranti.Text = "1";
            TxtGarantiSure.Enabled = true;
            TxtGarantiSure.Text = "";
        }

        private void radioYok_CheckedChanged(object sender, EventArgs e)
        {
            LblGaranti.Text = "0";
            TxtGarantiSure.Enabled=false;
            
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {


            string markast, modelst, garantist,adetst,fiyatst;
            markast = CmbMarka.Text;
            modelst = CmbModel.Text;          
            adetst = TxtAdet.Text;
            fiyatst = TxtFiyat.Text;

            garantist = TxtGarantiSure.Text;
            

            bool markastbool = string.IsNullOrEmpty(markast);
            bool modelstbool = string.IsNullOrEmpty(modelst);
            bool adetstbool = string.IsNullOrEmpty(adetst);
            bool fiyatstbool = string.IsNullOrEmpty(fiyatst);
            bool garantistbool = string.IsNullOrEmpty(garantist);



            modelkontrol();


            if (LblKontol.Text == LblModel.Text)
            {
                MessageBox.Show("Bu modele ait stok bulunmaktadır. Lütfen başka model seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else if (markastbool == true || modelstbool == true || adetstbool == true || fiyatstbool == true || LblDurum.Text=="2" || LblGaranti.Text == "2")
            {
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                MessageBox.Show("Lütfen boş alan bırakmayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close() ;

            }


            else
            {
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                baglanti.Open();
                SqlCommand kaydet = new SqlCommand("insert into TelefonStok(TlfModelID,TlfSifir,TlfAdet,TlfAdetFiyat,TlfGaranti,TlfGarantiTarih) values (@mdl,@sifir,@adet,@adetfiyat,@garanti,@garantitarih)", baglanti);

                SqlCommand modelrd = new SqlCommand("select TlfModelID,TlfModel from TelefonOzellikler where TlfModel='" + CmbModel.Text + "'", baglanti);
                SqlDataReader modelrd2 = modelrd.ExecuteReader();
                while (modelrd2.Read())
                {
                    kaydet.Parameters.AddWithValue("@mdl", modelrd2["TlfModelID"]);
                }
                baglanti.Close();

                baglanti.Open();
                kaydet.Parameters.AddWithValue("@sifir", LblDurum.Text);
                kaydet.Parameters.AddWithValue("@adet", TxtAdet.Text);
                kaydet.Parameters.AddWithValue("@adetfiyat", TxtFiyat.Text);
                kaydet.Parameters.AddWithValue("@garanti", LblGaranti.Text);
                
                if (garantistbool==true)
                {
                    kaydet.Parameters.AddWithValue("@garantitarih", DBNull.Value);
                }

                else
                {
                    kaydet.Parameters.AddWithValue("@garantitarih", TxtGarantiSure.Text);
                }

                kaydet.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kaydedildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);


                radioSifir.Checked = false;
                radioikinciEl.Checked = false;
                radioVar.Checked = false;
                radioYok.Checked = false;
                TxtGarantiSure.Text = "";
                TxtAdet.Text = "";
                TxtFiyat.Text = "";
                
                CmbMarka.Items.Clear();
                CmbModel.Items.Clear();
                markaAdGetir();
            }

            

        }

        private void TxtGarantiSure_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtAdet_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            radioSifir.Checked = false;
            radioikinciEl.Checked = false;
            radioVar.Checked = false;
            radioYok.Checked = false;
            TxtGarantiSure.Text = "";
            TxtAdet.Text = "";
            TxtFiyat.Text = "";

            CmbMarka.Items.Clear();
            CmbModel.Items.Clear();
            markaAdGetir();
        }
    }
}

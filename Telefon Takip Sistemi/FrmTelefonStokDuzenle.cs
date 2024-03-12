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
    public partial class FrmTelefonStokDuzenle : Form
    {
        BaglantiSinif bgl = new BaglantiSinif();

        public FrmTelefonStokDuzenle()
        {
            InitializeComponent();
        }

        

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


        private void FrmTelefonStokDuzenle_FormClosed(object sender, FormClosedEventArgs e)
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

        

        
        void verigetir()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("select TelefonStok.TlfID,TelefonMarka.TlfMarkaAd, TelefonOzellikler.TlfModel,TelefonStok.TlfSifir,TelefonStok.TlfAdet,TelefonStok.TlfAdetFiyat,TelefonStok.TlfGaranti,TelefonStok.TlfGarantiTarih from TelefonStok inner join TelefonOzellikler on TelefonStok.TlfModelID=TelefonOzellikler.TlfModelID inner join TelefonMarka on TelefonMarka.TlfMarkaID=TelefonOzellikler.TlfMarkaID", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sorgu);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Marka";
            dataGridView1.Columns[2].HeaderText = "Model";
            dataGridView1.Columns[3].HeaderText = "Sıfır";
            dataGridView1.Columns[4].HeaderText = "Adet";
            dataGridView1.Columns[5].HeaderText = "Adet Fiyatı";
            dataGridView1.Columns[6].HeaderText = "Garantili";
            dataGridView1.Columns[7].HeaderText = "Garanti Süresi";
            baglanti.Close();
        }

        private void FrmTelefonStokDuzenle_Load(object sender, EventArgs e)
        {
            verigetir();
            modelGetir();
            
        }

        private void radioSifir_CheckedChanged(object sender, EventArgs e)
        {
            LblDurum.Text = "True";
        }

        private void radioikinciEl_CheckedChanged(object sender, EventArgs e)
        {
            LblDurum.Text = "False";
        }

        private void radioVar_CheckedChanged(object sender, EventArgs e)
        {
            LblGaranti.Text = "True";
            
        }

        private void radioYok_CheckedChanged(object sender, EventArgs e)
        {
            LblGaranti.Text = "False";
            TxtGarantiSure.Text = "";

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            CmbModel.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            LblDurum.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            if (LblDurum.Text == "True")
            {
                radioSifir.Checked = true;
                radioikinciEl.Checked = false;
            }
            else if (LblDurum.Text == "False")
            {
                radioikinciEl.Checked = true;
                radioSifir.Checked = false;
            }
            else
            {
                radioikinciEl.Checked = false;
                radioSifir.Checked = false;
            }

            TxtAdet.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtFiyat.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            LblGaranti.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            if (LblGaranti.Text == "True")
            {
                radioVar.Checked = true;
                radioYok.Checked = false;
            }
            else if (LblGaranti.Text == "False")
            {
                radioVar.Checked = false;
                radioYok.Checked = true;
            }
            else
            {
                radioVar.Checked = false;
                radioYok.Checked = false;
            }
            TxtGarantiSure.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            string modelst;
            modelst = CmbModel.Text;

            bool modelstbool = string.IsNullOrEmpty(modelst);

            if (modelstbool == true)
            {
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                MessageBox.Show("Kayıt güncellemek için listeden seçim yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }

            else 
            {
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                baglanti.Open();
                SqlCommand guncelle = new SqlCommand("UPDATE TelefonStok set TlfModelID=@model,TlfSifir=@sifir,TlfAdet=@adet,TlfAdetFiyat=@adetfiyat,TlfGaranti=@garanti,TlfGarantiTarih=@garantitarih where TlfID=@id ", baglanti);
                SqlCommand model = new SqlCommand("select TlfModelID,TlfModel from TelefonOzellikler where TlfModel='" + CmbModel.Text + "'", baglanti);
                SqlDataReader reader = model.ExecuteReader();
                while (reader.Read())
                {

                    guncelle.Parameters.AddWithValue("@model", reader["TlfModelID"]);
                }
                baglanti.Close();

                baglanti.Open();
                guncelle.Parameters.AddWithValue("@sifir", LblDurum.Text);
                guncelle.Parameters.AddWithValue("@adet", TxtAdet.Text);
                guncelle.Parameters.AddWithValue("@adetfiyat", TxtFiyat.Text);
                guncelle.Parameters.AddWithValue("@garanti", LblGaranti.Text);
                guncelle.Parameters.AddWithValue("@garantitarih", TxtGarantiSure.Text);
                guncelle.Parameters.AddWithValue("@id", lblid.Text);
                guncelle.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Güncelleme başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verigetir();
            }
            


        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (lblid.Text=="id")
            {
                MessageBox.Show("Kayıt silmek için listeden seçim yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verigetir();
            }

            else
            {
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                baglanti.Open();
                SqlCommand sil = new SqlCommand("Delete From TelefonStok where TlfID=@id", baglanti);
                sil.Parameters.AddWithValue("@id", lblid.Text);
                sil.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kayıt başarıyla silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verigetir();
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
            CmbModel.Items.Clear();
            CmbModel.Text = "";
            modelGetir();
            radioSifir.Checked = false;
            radioikinciEl.Checked = false;
            radioVar.Checked = false;
            radioYok.Checked = false;
            TxtGarantiSure.Text = "";
            TxtAdet.Text = "";
            TxtFiyat.Text = "";
        }
    }
}

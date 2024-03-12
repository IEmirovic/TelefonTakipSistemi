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
    public partial class FrmYedekParcaStokDuzenle : Form
    {
        public FrmYedekParcaStokDuzenle()
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


        private void FrmYedekParcaStokDuzenle_FormClosed(object sender, FormClosedEventArgs e)
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

        void yedekparcaturgetir()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Close();
            baglanti.Open();
            SqlCommand parcatur = new SqlCommand("Select ParcaTur From YedekParcaStok ", baglanti);
            SqlDataReader parcaturrd = parcatur.ExecuteReader();
            while (parcaturrd.Read())
            {
                CmbYedekParcaTur.Items.Add(parcaturrd["ParcaTur"].ToString());
                CmbYedekParcaTur.Items.Remove("Belirsiz");
            }
            baglanti.Close();
        }


        void verigetir()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("select YedekParcaStok.ParcaID,TelefonOzellikler.TlfModel,YedekParcaStok.ParcaTur,YedekParcaStok.ParcaAdet,YedekParcaStok.ParcaAdetFiyat from YedekParcaStok inner join TelefonOzellikler on YedekParcaStok.TlfModelID=TelefonOzellikler.TlfModelID where not ParcaID=0", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sorgu);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Model";
            dataGridView1.Columns[2].HeaderText = "Parça Türü";
            dataGridView1.Columns[3].HeaderText = "Parça Adeti";
            dataGridView1.Columns[4].HeaderText = "Adet Fiyatı";
            baglanti.Close();
        }
        private void FrmYedekParcaStokDuzenle_Load(object sender, EventArgs e)
        {
            modelGetir();
            yedekparcaturgetir();
            verigetir();
        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            CmbModel.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            CmbYedekParcaTur.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtAdet.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtFiyat.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            string parcaturst;
            parcaturst = CmbYedekParcaTur.Text;

            bool parcaturstbool = string.IsNullOrEmpty(parcaturst);

            if (parcaturstbool == true || lblid.Text=="id")
            {
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                MessageBox.Show("Kayıt güncellemek için listeden seçim yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }

            else
            {
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                baglanti.Open();
                SqlCommand guncelle = new SqlCommand("UPDATE YedekParcaStok set TlfModelID=@model,ParcaTur=@parcatur,ParcaAdet=@adet,ParcaAdetFiyat=@adetfiyat where ParcaID=@id ", baglanti);
                SqlCommand model = new SqlCommand("select TlfModelID,TlfModel from TelefonOzellikler where TlfModel='" + CmbModel.Text + "'", baglanti);
                SqlDataReader reader = model.ExecuteReader();
                while (reader.Read())
                {
                    guncelle.Parameters.AddWithValue("@model", reader["TlfModelID"]);
                }
                baglanti.Close();

                baglanti.Open();
                guncelle.Parameters.AddWithValue("@parcatur", CmbYedekParcaTur.Text);
                guncelle.Parameters.AddWithValue("@adet", TxtAdet.Text);
                guncelle.Parameters.AddWithValue("@adetfiyat", TxtFiyat.Text);
                guncelle.Parameters.AddWithValue("@id", lblid.Text);
                guncelle.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Güncelleme başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verigetir();
            }
        }


        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (lblid.Text == "id")
            {
                MessageBox.Show("Kayıt silmek için listeden seçim yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verigetir();
            }

            else
            {
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                baglanti.Open();
                SqlCommand sil = new SqlCommand("Delete From YedekParcaStok where ParcaID=@id", baglanti);
                sil.Parameters.AddWithValue("@id", lblid.Text);
                sil.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kayıt başarıyla silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verigetir();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            CmbModel.Items.Clear();
            CmbYedekParcaTur.Items.Clear();
            TxtAdet.Text = "";
            TxtFiyat.Text = "";
            modelGetir();
            CmbModel.Text = "";
            yedekparcaturgetir();
            CmbYedekParcaTur.Text = "";
            verigetir();
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
    }
}

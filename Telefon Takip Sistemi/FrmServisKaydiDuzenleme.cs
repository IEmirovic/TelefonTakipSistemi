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
    public partial class FrmServisKaydiDuzenleme : Form
    {
        public FrmServisKaydiDuzenleme()
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

        

        private void FrmServisKaydiDuzenleme_FormClosed(object sender, FormClosedEventArgs e)
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

        void modelegoreparca()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            CmbYedekParcaTur.Items.Clear();

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
            SqlCommand sorgu = new SqlCommand("select Servis.ServisID,Musteri.MusteriAd, Musteri.MusteriSoyad, Musteri.MusteriGSM,YedekParcaStok.ParcaTur,ServisDurum.ServisDurumAd,Servis.ServisSurec,Servis.ServisUcret,Servis.TeslimTarihi from Servis inner join ServisDurum on ServisDurum.ServisDurumID=Servis.ServisDurumID inner join Musteri on Servis.MusteriID=Musteri.MusteriID inner join YedekParcaStok on YedekParcaStok.ParcaID=Servis.ParcaID", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sorgu);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Müşteri Adı";
            dataGridView1.Columns[2].HeaderText = "Müşteri Soyadı";
            dataGridView1.Columns[3].HeaderText = "Müşteri GSM";
            dataGridView1.Columns[4].HeaderText = "Parça Türü";
            dataGridView1.Columns[5].HeaderText = "Servis Durumu";
            dataGridView1.Columns[6].HeaderText = "Servis Süreci";
            dataGridView1.Columns[7].HeaderText = "Ücret";
            dataGridView1.Columns[8].HeaderText = "Teslim Tarihi";

            baglanti.Close();
        }

        void temizle()
        {
            MskTelefon.Text = "";
            CmbModel.Text = "";
            CmbYedekParcaTur.Text = "";
            CmbServisDurum.Items.Clear();
            CmbServisDurum.Text = "";
            servisdurumgetir();
            dateTimePicker1.Text="";
            TxtUcret.Text = "";
            richTextBox1.Text = "";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            if (dateTimePicker1.Value < DateTime.Today)
            {
                MessageBox.Show("Lütfen ileri bir tarih seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker1.Value= DateTime.Today;  
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            MskTelefon.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            CmbYedekParcaTur.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString(); 
            CmbServisDurum.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            richTextBox1.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            TxtUcret.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            servisdurumidgetir();
            musteriidgetir();
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                dateTimePicker1.CustomFormat = " ";
            }
        }

       

        private void CmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelegoreparca();
        }

        private void CmbServisDurum_SelectedIndexChanged(object sender, EventArgs e)
        {
            servisdurumidgetir();
        }

        private void CmbYedekParcaTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            parcaidgetir();
        }

        private void MskTelefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            musteriidgetir();
        }

        
        private void FrmServisKaydiDuzenleme_Load(object sender, EventArgs e)
        {
            modelGetir();
            servisdurumgetir();
            verigetir();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

            if (!MskTelefon.MaskCompleted || LblParcaID.Text=="0")
            {
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                MessageBox.Show("Kayıt güncellemek için listeden seçim yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }

            else
            {
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                baglanti.Open();
                SqlCommand guncelle = new SqlCommand("UPDATE Servis set ParcaID=@parca,ServisDurumID=@servisdurum,ServisSurec=@servissurec,ServisUcret=@ucret where MusteriID=@musteri ", baglanti);

                SqlCommand servisdurumid = new SqlCommand("select ServisDurumID from ServisDurum where ServisDurumAd='" + CmbServisDurum.Text + "'", baglanti);
                SqlDataReader servisdurumidrd = servisdurumid.ExecuteReader();
                while (servisdurumidrd.Read())
                {
                    guncelle.Parameters.AddWithValue("@servisdurum", servisdurumidrd["ServisDurumID"]);
                }
                baglanti.Close();

                baglanti.Open();
                guncelle.Parameters.AddWithValue("@parca", LblParcaID.Text);
                guncelle.Parameters.AddWithValue("@servissurec", richTextBox1.Text);
                guncelle.Parameters.AddWithValue("@ucret", TxtUcret.Text);
                guncelle.Parameters.AddWithValue("@musteri", LblMusteriID.Text);
                guncelle.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Güncelleme başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verigetir();

                
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (LblMusteriID.Text == "0")
            {
                MessageBox.Show("Kayıt silmek için listeden seçim yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verigetir();
            }

            else
            {
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                baglanti.Open();
                SqlCommand sil = new SqlCommand("Delete From Servis where MusteriID=@id", baglanti);
                sil.Parameters.AddWithValue("@id", LblMusteriID.Text);
                sil.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kayıt başarıyla silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verigetir();
            }
        }

        private void TxtUcret_KeyPress(object sender, KeyPressEventArgs e)
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

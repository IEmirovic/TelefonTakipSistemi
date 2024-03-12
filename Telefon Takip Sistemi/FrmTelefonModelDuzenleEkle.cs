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
    public partial class FrmTelefonModelDuzenleEkle : Form
    {
        public FrmTelefonModelDuzenleEkle()
        {
            InitializeComponent();
        }

        BaglantiSinif bgl = new BaglantiSinif();

        void markaAdGetir()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Close();
            baglanti.Open();

            SqlCommand deneme = new SqlCommand("SELECT TlfMarkaAd FROM TelefonMarka", baglanti);
            SqlDataReader reader = deneme.ExecuteReader();
            while (reader.Read())
            {
                CmbMarka.Items.Add(reader["TlfMarkaAd"].ToString());
                CmbMarka.Items.Remove("Belirsiz");
            }
            baglanti.Close();

        }

        void markaAdGetir2()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Close();
            baglanti.Open();

            SqlCommand deneme2 = new SqlCommand("SELECT TlfMarkaAd FROM TelefonMarka", baglanti);
            SqlDataReader reader2 = deneme2.ExecuteReader();
            while (reader2.Read())
            {
                CmbMarka2.Items.Add(reader2["TlfMarkaAd"].ToString());
                CmbMarka2.Items.Remove("Belirsiz");
            }
            baglanti.Close();

        }

        private void FrmTelefonModelEkle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'telefonTakipSistemiDataSet.TelefonOzellikler' table. You can move, or remove it, as needed.
            this.telefonOzelliklerTableAdapter.Fill(this.telefonTakipSistemiDataSet.TelefonOzellikler); 
            // TODO: This line of code loads data into the 'telefonTakipSistemiDataSet1.TelefonOzellikler' table. You can move, or remove it, as needed.


            
            
            markaAdGetir();
            markaAdGetir2();

        }

        private void CmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtModel.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string markaa, model, ram, batarya, hafiza, mp;
            markaa = CmbMarka.Text;
            model = TxtModel.Text;
            ram = TxtRam.Text;
            batarya = TxtBatarya.Text;
            hafiza = TxtHafiza.Text;
            mp = TxtKamera.Text;

            bool markaabool = string.IsNullOrEmpty(markaa);
            bool modelabool = string.IsNullOrEmpty(model);
            bool rambool = string.IsNullOrEmpty(ram);
            bool bataryabool = string.IsNullOrEmpty(batarya);
            bool hafizabool = string.IsNullOrEmpty(hafiza);
            bool mpbool = string.IsNullOrEmpty(mp);
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand kontrol = new SqlCommand("Select TlfModel From TelefonOzellikler where TlfModel='" + TxtModel.Text + "'", baglanti);
            SqlDataReader kontrolrd = kontrol.ExecuteReader();


            if (kontrolrd.Read())
            {
                MessageBox.Show("Bu modele ait kayıt bulunmaktadır. Lütfen başka model ismi giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
                CmbMarka.Text = "";
                TxtModel.Text = "";
                TxtRam.Text = "";
                TxtBatarya.Text = "";
                TxtHafiza.Text = "";
                TxtKamera.Text = "";
                CmbMarka.Items.Clear();
                markaAdGetir();
            }

            else if (markaabool==true || modelabool==true || rambool ==true || bataryabool == true || hafizabool == true || mpbool == true)
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close ();
                CmbMarka.Items.Clear();
                markaAdGetir() ;

            }

            else
            {
                baglanti.Close();
                baglanti.Open();
                SqlCommand kaydet = new SqlCommand("insert into TelefonOzellikler(TlfMarkaID,TlfModel,TlfRam,TlfBatarya,TlfHafiza,TlfMP) values (@marka,@model,@ram,@batarya,@hafiza,@mp)", baglanti);

                SqlCommand marka = new SqlCommand("select TlfMarkaID,TlfMarkaAD from TelefonMarka where TlfMarkaAd='" + CmbMarka.Text + "'", baglanti);
                SqlDataReader reader = marka.ExecuteReader();
                while (reader.Read())
                {
                    kaydet.Parameters.AddWithValue("@marka", reader["TlfMarkaID"]);
                }
                baglanti.Close();

                baglanti.Open();
                kaydet.Parameters.AddWithValue("@model", TxtModel.Text);
                kaydet.Parameters.AddWithValue("@ram", TxtRam.Text);
                kaydet.Parameters.AddWithValue("@batarya", TxtBatarya.Text);
                kaydet.Parameters.AddWithValue("@hafiza", TxtHafiza.Text);
                kaydet.Parameters.AddWithValue("@mp", TxtKamera.Text);
                kaydet.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kaydedildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.telefonOzelliklerTableAdapter.Fill(this.telefonTakipSistemiDataSet.TelefonOzellikler);

                CmbMarka.Items.Clear();
                markaAdGetir();
                TxtModel.Text = "";
                TxtRam.Text = "";
                TxtBatarya.Text = "";
                TxtHafiza.Text = "";
                TxtKamera.Text = "";

            }
            
        }

        private void CmbMarka2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

       

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            lblmarka.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            baglanti.Open();
            SqlCommand marka = new SqlCommand("select TlfMarkaID,TlfMarkaAD from TelefonMarka where TlfMarkaID='" + lblmarka.Text + "'", baglanti);
            SqlDataReader reader = marka.ExecuteReader();
            while (reader.Read())
            {

                CmbMarka2.Text = reader["TlfMarkaAd"].ToString();

            }
            baglanti.Close();
            TxtModel2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtKamera2.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtRam2.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtBatarya2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtHafiza2.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            string markaa, model, ram, batarya, hafiza, mp;
            markaa = CmbMarka.Text;
            model = TxtModel.Text;
            ram = TxtRam.Text;
            batarya = TxtBatarya.Text;
            hafiza = TxtHafiza.Text;
            mp = TxtKamera.Text;

            bool markaabool = string.IsNullOrEmpty(markaa);
            bool modelabool = string.IsNullOrEmpty(model);
            bool rambool = string.IsNullOrEmpty(ram);
            bool bataryabool = string.IsNullOrEmpty(batarya);
            bool hafizabool = string.IsNullOrEmpty(hafiza);
            bool mpbool = string.IsNullOrEmpty(mp);

            if (markaabool == true || modelabool == true || rambool == true || bataryabool == true || hafizabool == true || mpbool == true)
            {
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                MessageBox.Show("Lütfen boş alan bırakmayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
                CmbMarka.Items.Clear();
                markaAdGetir();

            }

            else
            {
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                baglanti.Close();
                baglanti.Open();
                SqlCommand guncelle = new SqlCommand("UPDATE TelefonOzellikler set TlfMarkaID=@marka2,TlfModel=@model2,TlfRam=@ram2,TlfBatarya=@batarya2,TlfHafiza=@hafiza2,TlfMP=@mp2 where TlfModelID=@id ", baglanti);

                SqlCommand marka = new SqlCommand("select TlfMarkaID,TlfMarkaAD from TelefonMarka where TlfMarkaAd='" + CmbMarka2.Text + "'", baglanti);
                SqlDataReader reader = marka.ExecuteReader();
                while (reader.Read())
                {
                    guncelle.Parameters.AddWithValue("@marka2", reader["TlfMarkaID"]);
                }
                baglanti.Close();

                baglanti.Open();
                guncelle.Parameters.AddWithValue("@model2", TxtModel2.Text);
                guncelle.Parameters.AddWithValue("@ram2", TxtRam2.Text);
                guncelle.Parameters.AddWithValue("@batarya2", TxtBatarya2.Text);
                guncelle.Parameters.AddWithValue("@hafiza2", TxtHafiza2.Text);
                guncelle.Parameters.AddWithValue("@mp2", TxtKamera2.Text);
                guncelle.Parameters.AddWithValue("@id", lblid.Text);
                guncelle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.telefonOzelliklerTableAdapter.Fill(this.telefonTakipSistemiDataSet.TelefonOzellikler);
                CmbMarka2.Items.Clear();
                markaAdGetir2();
                TxtModel2.Text = "";
                TxtRam2.Text = "";
                TxtBatarya2.Text = "";
                TxtHafiza2.Text = "";
                TxtKamera2.Text = "";
            }

            
        }

        private void TxtKamera_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtRam_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtBatarya_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtHafiza_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtKamera2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtRam2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtBatarya2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtHafiza2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtModel_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(TxtModel.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("Bu alan sadece alfabetik karakterleri kabul eder.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtModel.Text = "";
            }
        }

        private void TxtModel2_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(TxtModel2.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("Bu alan sadece alfabetik karakterleri kabul eder.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtModel2.Text = "";
            }
        }
    }
}

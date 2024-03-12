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
    public partial class FrmTelefonMarkaDuzenleEkle : Form
    {
        public FrmTelefonMarkaDuzenleEkle()
        {
            InitializeComponent();
        }

        BaglantiSinif bgl = new BaglantiSinif();

        void osGetir()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Close();
            baglanti.Open();
            SqlCommand os = new SqlCommand("select distinct TlfOS from TelefonMarka", baglanti);

            SqlDataReader osrd = os.ExecuteReader();
            while (osrd.Read())
            {
                CmbOS.Items.Add(osrd["TlfOS"].ToString());
                CmbOS.Items.Remove("Belirsiz");
            }
            baglanti.Close();
        }


        private void FrmTelefonMarkaEkle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'telefonTakipSistemiDataSet.TelefonMarka' table. You can move, or remove it, as needed.
            this.telefonMarkaTableAdapter.Fill(this.telefonTakipSistemiDataSet.TelefonMarka);

            osGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string marka, os;
            marka = TxtMarka.Text;
            os = CmbOS.Text;
            bool markabool = String.IsNullOrEmpty(marka);
            bool osbool = String.IsNullOrEmpty(os);

            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand kontrol = new SqlCommand("Select TlfMarkaAd From TelefonMarka where TlfMarkaAd='" + TxtMarka.Text + "'", baglanti);
            SqlDataReader kontrolrd = kontrol.ExecuteReader();
            

            if (kontrolrd.Read())
            {
                MessageBox.Show("Bu markaya ait kayıt bulunmaktadır. Lütfen başka marka giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
                TxtMarka.Text = "";
                CmbOS.Text = "";
                CmbOS.Items.Clear();
                osGetir();
            }


            else if (markabool==true || osbool ==true)
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
                TxtMarka.Text = "";
                CmbOS.Text = "";
                CmbOS.Items.Clear();
                osGetir();
            }


            else
            {
                baglanti.Close();
                baglanti.Open();
                SqlCommand kaydet = new SqlCommand("insert into TelefonMarka (TlfMarkaAd,TlfOS) values (@marka, @os )", baglanti);
                kaydet.Parameters.AddWithValue("@marka", TxtMarka.Text);
                kaydet.Parameters.AddWithValue("@os", CmbOS.Text);
                kaydet.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kaydedildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtMarka.Text = "";
                CmbOS.Text = "";

                CmbOS.Items.Clear();
                osGetir();
            }
            
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtMarka2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            CmbOS2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            string marka, os;
            marka = TxtMarka.Text;
            os = CmbOS.Text;
            bool markabool = String.IsNullOrEmpty(marka);
            bool osbool = String.IsNullOrEmpty(os);

            if (markabool == true || osbool == true)
            {
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                MessageBox.Show("Lütfen boş alan bırakmayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
                TxtMarka.Text = "";
                CmbOS.Text = "";
                CmbOS.Items.Clear();
                osGetir();
            }

            else
            {
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                baglanti.Close();
                baglanti.Open();
                SqlCommand guncelle = new SqlCommand("UPDATE TelefonMarka set TlfMarkaAd=@marka2,TlfOS=@os2 where TlfMarkaID=@id ", baglanti);
                guncelle.Parameters.AddWithValue("@marka2", TxtMarka2.Text);
                guncelle.Parameters.AddWithValue("@os2", CmbOS2.Text);
                guncelle.Parameters.AddWithValue("@id", lblid.Text);
                guncelle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncellenme başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.telefonMarkaTableAdapter.Fill(this.telefonTakipSistemiDataSet.TelefonMarka);
                CmbOS2.Items.Clear();
                osGetir();
                TxtMarka2.Text = "";
            }
            
            
        }

        private void TxtMarka_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(TxtMarka.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("Bu alan sadece alfabetik karakterleri kabul eder.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtMarka.Text = "";
            }
        }

        private void TxtMarka2_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(TxtMarka2.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("Bu alan sadece alfabetik karakterleri kabul eder.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtMarka2.Text = "";
            }
        }
    }
}

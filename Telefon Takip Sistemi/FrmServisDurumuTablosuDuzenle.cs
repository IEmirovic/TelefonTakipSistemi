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
    public partial class FrmServisDurumuTablosuDuzenle : Form
    {
        public FrmServisDurumuTablosuDuzenle()
        {
            InitializeComponent();
        }

        BaglantiSinif bgl = new BaglantiSinif();

        void verigetir()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("select ServisDurumID,ServisDurumAd from ServisDurum where not ServisDurumID=0", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sorgu);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Servis Durumu";
            baglanti.Close();
        }

        private void FrmServisDurumuTablosuDuzenle_Load(object sender, EventArgs e)
        {
            verigetir();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtServisDurum2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            string durum;
            durum = TxtServisDurum.Text;
            bool durumst=string.IsNullOrEmpty(durum);
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("select ServisDurumAd From ServisDurum where ServisDurumAd= '" + TxtServisDurum.Text+"'", baglanti);
            SqlDataReader sorgurd = sorgu.ExecuteReader();
            

            if (durumst == true)
            {
                baglanti.Close();
                MessageBox.Show("Lütfen boş alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (sorgurd.Read())
            {
               
                MessageBox.Show("Lütfen farklı bir değer giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
               baglanti.Close();
                verigetir();
            }

            else
            {
                baglanti.Close();
                baglanti.Open();
                SqlCommand kaydet = new SqlCommand("insert into ServisDurum(ServisDurumAd) values (@durum)", baglanti);
                kaydet.Parameters.AddWithValue("@durum", TxtServisDurum.Text);
                kaydet.ExecuteNonQuery();
                baglanti.Close();
                verigetir();
                MessageBox.Show("Kayıt yapıldı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtServisDurum.Text = "";
                TxtServisDurum2.Text = "";
               
            }
            

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            string durum;
            durum = TxtServisDurum2.Text;
            bool durumst = string.IsNullOrEmpty(durum);

            if (lblid.Text=="lblid")
            {
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                MessageBox.Show("Kayıt güncellemek için listeden seçim yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }


            else
            {
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                baglanti.Open();
                SqlCommand guncelle = new SqlCommand("UPDATE ServisDurum set ServisDurumAd=@durum where ServisDurumID=@id ", baglanti);
                guncelle.Parameters.AddWithValue("@durum", TxtServisDurum2.Text);
                guncelle.Parameters.AddWithValue("@id", lblid.Text);
                guncelle.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Güncelleme başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtServisDurum.Text = "";
                TxtServisDurum2.Text = "";
                verigetir();
            }
            

        }

        private void TxtServisDurum_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(TxtServisDurum.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("Bu alan sadece alfabetik karakterleri kabul eder.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtServisDurum.Text = "";
            }
        }

        private void TxtServisDurum2_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(TxtServisDurum2.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("Bu alan sadece alfabetik karakterleri kabul eder.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtServisDurum2.Text = "";
            }
        }
    }
}

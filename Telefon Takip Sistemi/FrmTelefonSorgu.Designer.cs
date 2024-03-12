namespace Telefon_Takip_Sistemi
{
    partial class FrmTelefonSorgu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelefonSorgu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaEkranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telefonStokIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telefonStokOlusturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telefonStokSorgulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telefonStokDuzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yedekParcaStokIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parcaStokOlusturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parcaStokSorgulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parcaStokDuzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servisIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servisKaydiOlusturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servisKayitSorgulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servisKayitDuzenleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.satisIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satisYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satisKayitSorgulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriDuzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriSorgulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CmbModel = new System.Windows.Forms.ComboBox();
            this.CmbMarka = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblMarka2 = new System.Windows.Forms.Label();
            this.LblMarka = new System.Windows.Forms.Label();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.BtnAra = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaEkranToolStripMenuItem,
            this.telefonStokIslemleriToolStripMenuItem,
            this.yedekParcaStokIslemleriToolStripMenuItem,
            this.servisIslemleriToolStripMenuItem,
            this.satisIslemleriToolStripMenuItem,
            this.musteriIslemleriToolStripMenuItem,
            this.cikisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1050, 31);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anaEkranToolStripMenuItem
            // 
            this.anaEkranToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("anaEkranToolStripMenuItem.Image")));
            this.anaEkranToolStripMenuItem.Name = "anaEkranToolStripMenuItem";
            this.anaEkranToolStripMenuItem.Size = new System.Drawing.Size(108, 25);
            this.anaEkranToolStripMenuItem.Text = "Ana Ekran";
            this.anaEkranToolStripMenuItem.Click += new System.EventHandler(this.anaEkranToolStripMenuItem_Click);
            // 
            // telefonStokIslemleriToolStripMenuItem
            // 
            this.telefonStokIslemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telefonStokOlusturToolStripMenuItem,
            this.telefonStokSorgulaToolStripMenuItem,
            this.telefonStokDuzenleToolStripMenuItem});
            this.telefonStokIslemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("telefonStokIslemleriToolStripMenuItem.Image")));
            this.telefonStokIslemleriToolStripMenuItem.Name = "telefonStokIslemleriToolStripMenuItem";
            this.telefonStokIslemleriToolStripMenuItem.Size = new System.Drawing.Size(184, 25);
            this.telefonStokIslemleriToolStripMenuItem.Text = "Telefon Stok İşlemleri";
            // 
            // telefonStokOlusturToolStripMenuItem
            // 
            this.telefonStokOlusturToolStripMenuItem.Name = "telefonStokOlusturToolStripMenuItem";
            this.telefonStokOlusturToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.telefonStokOlusturToolStripMenuItem.Text = "Stok Oluştur";
            this.telefonStokOlusturToolStripMenuItem.Click += new System.EventHandler(this.telefonStokOlusturToolStripMenuItem_Click);
            // 
            // telefonStokSorgulaToolStripMenuItem
            // 
            this.telefonStokSorgulaToolStripMenuItem.Name = "telefonStokSorgulaToolStripMenuItem";
            this.telefonStokSorgulaToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.telefonStokSorgulaToolStripMenuItem.Text = "Stok Sorgula";
            // 
            // telefonStokDuzenleToolStripMenuItem
            // 
            this.telefonStokDuzenleToolStripMenuItem.Name = "telefonStokDuzenleToolStripMenuItem";
            this.telefonStokDuzenleToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.telefonStokDuzenleToolStripMenuItem.Text = "Stok Düzenle";
            this.telefonStokDuzenleToolStripMenuItem.Click += new System.EventHandler(this.telefonStokDuzenleToolStripMenuItem_Click);
            // 
            // yedekParcaStokIslemleriToolStripMenuItem
            // 
            this.yedekParcaStokIslemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parcaStokOlusturToolStripMenuItem,
            this.parcaStokSorgulaToolStripMenuItem,
            this.parcaStokDuzenleToolStripMenuItem});
            this.yedekParcaStokIslemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yedekParcaStokIslemleriToolStripMenuItem.Image")));
            this.yedekParcaStokIslemleriToolStripMenuItem.Name = "yedekParcaStokIslemleriToolStripMenuItem";
            this.yedekParcaStokIslemleriToolStripMenuItem.Size = new System.Drawing.Size(217, 25);
            this.yedekParcaStokIslemleriToolStripMenuItem.Text = "Yedek Parça Stok İşlemleri";
            // 
            // parcaStokOlusturToolStripMenuItem
            // 
            this.parcaStokOlusturToolStripMenuItem.Name = "parcaStokOlusturToolStripMenuItem";
            this.parcaStokOlusturToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.parcaStokOlusturToolStripMenuItem.Text = "Stok Oluştur";
            this.parcaStokOlusturToolStripMenuItem.Click += new System.EventHandler(this.parcaStokOlusturToolStripMenuItem_Click);
            // 
            // parcaStokSorgulaToolStripMenuItem
            // 
            this.parcaStokSorgulaToolStripMenuItem.Name = "parcaStokSorgulaToolStripMenuItem";
            this.parcaStokSorgulaToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.parcaStokSorgulaToolStripMenuItem.Text = "Stok Sorgula";
            this.parcaStokSorgulaToolStripMenuItem.Click += new System.EventHandler(this.parcaStokSorgulaToolStripMenuItem_Click);
            // 
            // parcaStokDuzenleToolStripMenuItem
            // 
            this.parcaStokDuzenleToolStripMenuItem.Name = "parcaStokDuzenleToolStripMenuItem";
            this.parcaStokDuzenleToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.parcaStokDuzenleToolStripMenuItem.Text = "Stok Düzenle";
            this.parcaStokDuzenleToolStripMenuItem.Click += new System.EventHandler(this.parcaStokDuzenleToolStripMenuItem_Click);
            // 
            // servisIslemleriToolStripMenuItem
            // 
            this.servisIslemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.servisKaydiOlusturToolStripMenuItem,
            this.servisKayitSorgulaToolStripMenuItem,
            this.servisKayitDuzenleToolStripMenuItem1});
            this.servisIslemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("servisIslemleriToolStripMenuItem.Image")));
            this.servisIslemleriToolStripMenuItem.Name = "servisIslemleriToolStripMenuItem";
            this.servisIslemleriToolStripMenuItem.Size = new System.Drawing.Size(143, 25);
            this.servisIslemleriToolStripMenuItem.Text = "Servis İşlemleri";
            // 
            // servisKaydiOlusturToolStripMenuItem
            // 
            this.servisKaydiOlusturToolStripMenuItem.Name = "servisKaydiOlusturToolStripMenuItem";
            this.servisKaydiOlusturToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.servisKaydiOlusturToolStripMenuItem.Text = "Servis Kaydı Oluştur";
            this.servisKaydiOlusturToolStripMenuItem.Click += new System.EventHandler(this.servisKaydiOlusturToolStripMenuItem_Click);
            // 
            // servisKayitSorgulaToolStripMenuItem
            // 
            this.servisKayitSorgulaToolStripMenuItem.Name = "servisKayitSorgulaToolStripMenuItem";
            this.servisKayitSorgulaToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.servisKayitSorgulaToolStripMenuItem.Text = "Servis Kayıtlarını Sorgula";
            this.servisKayitSorgulaToolStripMenuItem.Click += new System.EventHandler(this.servisKayitSorgulaToolStripMenuItem_Click);
            // 
            // servisKayitDuzenleToolStripMenuItem1
            // 
            this.servisKayitDuzenleToolStripMenuItem1.Name = "servisKayitDuzenleToolStripMenuItem1";
            this.servisKayitDuzenleToolStripMenuItem1.Size = new System.Drawing.Size(255, 26);
            this.servisKayitDuzenleToolStripMenuItem1.Text = "Servis Kayıtlarını Düzenle";
            this.servisKayitDuzenleToolStripMenuItem1.Click += new System.EventHandler(this.servisKayitDuzenleToolStripMenuItem1_Click);
            // 
            // satisIslemleriToolStripMenuItem
            // 
            this.satisIslemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satisYapToolStripMenuItem,
            this.satisKayitSorgulaToolStripMenuItem});
            this.satisIslemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("satisIslemleriToolStripMenuItem.Image")));
            this.satisIslemleriToolStripMenuItem.Name = "satisIslemleriToolStripMenuItem";
            this.satisIslemleriToolStripMenuItem.Size = new System.Drawing.Size(134, 25);
            this.satisIslemleriToolStripMenuItem.Text = "Satış İşlemleri";
            // 
            // satisYapToolStripMenuItem
            // 
            this.satisYapToolStripMenuItem.Name = "satisYapToolStripMenuItem";
            this.satisYapToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.satisYapToolStripMenuItem.Text = "Satış Yap";
            this.satisYapToolStripMenuItem.Click += new System.EventHandler(this.satisYapToolStripMenuItem_Click);
            // 
            // satisKayitSorgulaToolStripMenuItem
            // 
            this.satisKayitSorgulaToolStripMenuItem.Name = "satisKayitSorgulaToolStripMenuItem";
            this.satisKayitSorgulaToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.satisKayitSorgulaToolStripMenuItem.Text = "Satış Kayıtlarını Sorgula";
            this.satisKayitSorgulaToolStripMenuItem.Click += new System.EventHandler(this.satisKayitSorgulaToolStripMenuItem_Click);
            // 
            // musteriIslemleriToolStripMenuItem
            // 
            this.musteriIslemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musteriDuzenleToolStripMenuItem,
            this.musteriSorgulaToolStripMenuItem});
            this.musteriIslemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("musteriIslemleriToolStripMenuItem.Image")));
            this.musteriIslemleriToolStripMenuItem.Name = "musteriIslemleriToolStripMenuItem";
            this.musteriIslemleriToolStripMenuItem.Size = new System.Drawing.Size(154, 25);
            this.musteriIslemleriToolStripMenuItem.Text = "Müşteri İşlemleri";
            // 
            // musteriDuzenleToolStripMenuItem
            // 
            this.musteriDuzenleToolStripMenuItem.Name = "musteriDuzenleToolStripMenuItem";
            this.musteriDuzenleToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.musteriDuzenleToolStripMenuItem.Text = "Müşteri Kayıtlarını Düzenle";
            this.musteriDuzenleToolStripMenuItem.Click += new System.EventHandler(this.musteriDuzenleToolStripMenuItem_Click);
            // 
            // musteriSorgulaToolStripMenuItem
            // 
            this.musteriSorgulaToolStripMenuItem.Name = "musteriSorgulaToolStripMenuItem";
            this.musteriSorgulaToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.musteriSorgulaToolStripMenuItem.Text = "Müşteri Sorgula";
            this.musteriSorgulaToolStripMenuItem.Click += new System.EventHandler(this.musteriSorgulaToolStripMenuItem_Click);
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cikisToolStripMenuItem.Image")));
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(100, 25);
            this.cikisToolStripMenuItem.Text = "Çıkış Yap";
            this.cikisToolStripMenuItem.Click += new System.EventHandler(this.cikisToolStripMenuItem_Click);
            // 
            // CmbModel
            // 
            this.CmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbModel.FormattingEnabled = true;
            this.CmbModel.Location = new System.Drawing.Point(407, 40);
            this.CmbModel.Name = "CmbModel";
            this.CmbModel.Size = new System.Drawing.Size(170, 28);
            this.CmbModel.TabIndex = 2;
            // 
            // CmbMarka
            // 
            this.CmbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMarka.FormattingEnabled = true;
            this.CmbMarka.Location = new System.Drawing.Point(147, 44);
            this.CmbMarka.Name = "CmbMarka";
            this.CmbMarka.Size = new System.Drawing.Size(170, 28);
            this.CmbMarka.TabIndex = 1;
            this.CmbMarka.SelectedIndexChanged += new System.EventHandler(this.CmbMarka_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Marka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Model:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblMarka2);
            this.groupBox1.Controls.Add(this.LblMarka);
            this.groupBox1.Controls.Add(this.BtnTemizle);
            this.groupBox1.Controls.Add(this.BtnAra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CmbMarka);
            this.groupBox1.Controls.Add(this.CmbModel);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1026, 114);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            // 
            // LblMarka2
            // 
            this.LblMarka2.AutoSize = true;
            this.LblMarka2.Location = new System.Drawing.Point(476, 91);
            this.LblMarka2.Name = "LblMarka2";
            this.LblMarka2.Size = new System.Drawing.Size(83, 20);
            this.LblMarka2.TabIndex = 69;
            this.LblMarka2.Text = "LblMarka2";
            this.LblMarka2.Visible = false;
            // 
            // LblMarka
            // 
            this.LblMarka.AutoSize = true;
            this.LblMarka.Location = new System.Drawing.Point(396, 91);
            this.LblMarka.Name = "LblMarka";
            this.LblMarka.Size = new System.Drawing.Size(74, 20);
            this.LblMarka.TabIndex = 68;
            this.LblMarka.Text = "LblMarka";
            this.LblMarka.Visible = false;
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTemizle.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.Image")));
            this.BtnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTemizle.Location = new System.Drawing.Point(829, 32);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(128, 43);
            this.BtnTemizle.TabIndex = 4;
            this.BtnTemizle.Tag = "";
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnAra
            // 
            this.BtnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAra.Image = ((System.Drawing.Image)(resources.GetObject("BtnAra.Image")));
            this.BtnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAra.Location = new System.Drawing.Point(664, 32);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(128, 43);
            this.BtnAra.TabIndex = 3;
            this.BtnAra.Tag = "";
            this.BtnAra.Text = "Ara";
            this.BtnAra.UseVisualStyleBackColor = true;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 339);
            this.dataGridView1.TabIndex = 60;
            // 
            // FrmTelefonSorgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 505);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmTelefonSorgu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefon Sorgulama";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTelefonSorgu_FormClosed);
            this.Load += new System.EventHandler(this.FrmTelefonSorgu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anaEkranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telefonStokIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telefonStokOlusturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telefonStokSorgulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telefonStokDuzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yedekParcaStokIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parcaStokOlusturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parcaStokSorgulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parcaStokDuzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servisIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servisKaydiOlusturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servisKayitSorgulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servisKayitDuzenleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem satisIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satisYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satisKayitSorgulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musteriIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musteriDuzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musteriSorgulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.ComboBox CmbModel;
        private System.Windows.Forms.ComboBox CmbMarka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Label LblMarka2;
        private System.Windows.Forms.Label LblMarka;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
namespace Telefon_Takip_Sistemi
{
    partial class FrmServisKaydiSorgula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServisKaydiSorgula));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblGsm = new System.Windows.Forms.Label();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnAra = new System.Windows.Forms.Button();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblGsm);
            this.groupBox1.Controls.Add(this.MskTelefon);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.BtnSil);
            this.groupBox1.Controls.Add(this.BtnAra);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1026, 93);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            // 
            // LblGsm
            // 
            this.LblGsm.AutoSize = true;
            this.LblGsm.Location = new System.Drawing.Point(6, 70);
            this.LblGsm.Name = "LblGsm";
            this.LblGsm.Size = new System.Drawing.Size(18, 20);
            this.LblGsm.TabIndex = 107;
            this.LblGsm.Text = "0";
            this.LblGsm.Visible = false;
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(346, 33);
            this.MskTelefon.Mask = "(599) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(170, 26);
            this.MskTelefon.TabIndex = 105;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(234, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 20);
            this.label14.TabIndex = 103;
            this.label14.Text = "Müşteri GSM:";
            // 
            // BtnSil
            // 
            this.BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.Image")));
            this.BtnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSil.Location = new System.Drawing.Point(688, 25);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(128, 43);
            this.BtnSil.TabIndex = 66;
            this.BtnSil.Tag = "";
            this.BtnSil.Text = "KutuTemizle";
            this.BtnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnAra
            // 
            this.BtnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAra.Image = ((System.Drawing.Image)(resources.GetObject("BtnAra.Image")));
            this.BtnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAra.Location = new System.Drawing.Point(554, 25);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(128, 43);
            this.BtnAra.TabIndex = 60;
            this.BtnAra.Tag = "";
            this.BtnAra.Text = "Ara";
            this.BtnAra.UseVisualStyleBackColor = true;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
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
            this.menuStrip1.TabIndex = 61;
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
            this.telefonStokSorgulaToolStripMenuItem.Click += new System.EventHandler(this.telefonStokSorgulaToolStripMenuItem_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 354);
            this.dataGridView1.TabIndex = 114;
            // 
            // FrmServisKaydiSorgula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 500);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmServisKaydiSorgula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servis Kaydı Sorgula";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmServisKaydiSorgula_FormClosed);
            this.Load += new System.EventHandler(this.FrmServisKaydiSorgula_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnAra;
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
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LblGsm;
    }
}
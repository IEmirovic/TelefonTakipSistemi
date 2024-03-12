namespace Telefon_Takip_Sistemi
{
    partial class FrmAnaMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnTelefon = new System.Windows.Forms.Button();
            this.BtnServis = new System.Windows.Forms.Button();
            this.BtnMusteri = new System.Windows.Forms.Button();
            this.BtnSatis = new System.Windows.Forms.Button();
            this.BtnYedekParca = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "Telefon Stok \r\nİşlemleri\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(187, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Servis İşlemleri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 48);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yedek Parça ve\r\nStok İşlemleri";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(184, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Müşteri Kayıtları";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(384, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 48);
            this.label5.TabIndex = 9;
            this.label5.Text = "Satış\r\nİşlemleri\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnTelefon
            // 
            this.BtnTelefon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnTelefon.BackgroundImage")));
            this.BtnTelefon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnTelefon.Location = new System.Drawing.Point(33, 36);
            this.BtnTelefon.Name = "BtnTelefon";
            this.BtnTelefon.Size = new System.Drawing.Size(103, 94);
            this.BtnTelefon.TabIndex = 1;
            this.BtnTelefon.UseVisualStyleBackColor = true;
            this.BtnTelefon.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnServis
            // 
            this.BtnServis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnServis.BackgroundImage")));
            this.BtnServis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnServis.Location = new System.Drawing.Point(202, 38);
            this.BtnServis.Name = "BtnServis";
            this.BtnServis.Size = new System.Drawing.Size(103, 94);
            this.BtnServis.TabIndex = 2;
            this.BtnServis.UseVisualStyleBackColor = true;
            this.BtnServis.Click += new System.EventHandler(this.BtnServis_Click);
            // 
            // BtnMusteri
            // 
            this.BtnMusteri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMusteri.BackgroundImage")));
            this.BtnMusteri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnMusteri.Location = new System.Drawing.Point(202, 201);
            this.BtnMusteri.Name = "BtnMusteri";
            this.BtnMusteri.Size = new System.Drawing.Size(103, 94);
            this.BtnMusteri.TabIndex = 5;
            this.BtnMusteri.UseVisualStyleBackColor = true;
            this.BtnMusteri.Click += new System.EventHandler(this.BtnMusteri_Click);
            // 
            // BtnSatis
            // 
            this.BtnSatis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSatis.BackgroundImage")));
            this.BtnSatis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSatis.Location = new System.Drawing.Point(371, 38);
            this.BtnSatis.Name = "BtnSatis";
            this.BtnSatis.Size = new System.Drawing.Size(103, 94);
            this.BtnSatis.TabIndex = 3;
            this.BtnSatis.UseVisualStyleBackColor = true;
            this.BtnSatis.Click += new System.EventHandler(this.BtnSatis_Click);
            // 
            // BtnYedekParca
            // 
            this.BtnYedekParca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnYedekParca.BackgroundImage")));
            this.BtnYedekParca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnYedekParca.Location = new System.Drawing.Point(33, 201);
            this.BtnYedekParca.Name = "BtnYedekParca";
            this.BtnYedekParca.Size = new System.Drawing.Size(103, 94);
            this.BtnYedekParca.TabIndex = 4;
            this.BtnYedekParca.UseVisualStyleBackColor = true;
            this.BtnYedekParca.Click += new System.EventHandler(this.BtnYedekParca_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCikis.BackgroundImage")));
            this.BtnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCikis.Location = new System.Drawing.Point(371, 201);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(103, 94);
            this.BtnCikis.TabIndex = 6;
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(380, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Çıkış Yap";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // FrmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(508, 377);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnYedekParca);
            this.Controls.Add(this.BtnSatis);
            this.Controls.Add(this.BtnServis);
            this.Controls.Add(this.BtnMusteri);
            this.Controls.Add(this.BtnTelefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "FrmAnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefon Takip Sistemi Ana Ekran";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAnaMenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnTelefon;
        private System.Windows.Forms.Button BtnServis;
        private System.Windows.Forms.Button BtnMusteri;
        private System.Windows.Forms.Button BtnSatis;
        private System.Windows.Forms.Button BtnYedekParca;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
    }
}
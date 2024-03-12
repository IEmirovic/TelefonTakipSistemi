namespace Telefon_Takip_Sistemi
{
    partial class FrmMusteriEkle
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtMusteriSoyad = new System.Windows.Forms.TextBox();
            this.TxtMusteriAd = new System.Windows.Forms.TextBox();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtMusteriSoyad);
            this.groupBox2.Controls.Add(this.TxtMusteriAd);
            this.groupBox2.Controls.Add(this.MskTelefon);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 208);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            // 
            // TxtMusteriSoyad
            // 
            this.TxtMusteriSoyad.Location = new System.Drawing.Point(159, 73);
            this.TxtMusteriSoyad.MaxLength = 25;
            this.TxtMusteriSoyad.Name = "TxtMusteriSoyad";
            this.TxtMusteriSoyad.Size = new System.Drawing.Size(170, 26);
            this.TxtMusteriSoyad.TabIndex = 2;
            this.TxtMusteriSoyad.TextChanged += new System.EventHandler(this.TxtMusteriSoyad_TextChanged);
            // 
            // TxtMusteriAd
            // 
            this.TxtMusteriAd.Location = new System.Drawing.Point(159, 40);
            this.TxtMusteriAd.MaxLength = 25;
            this.TxtMusteriAd.Name = "TxtMusteriAd";
            this.TxtMusteriAd.Size = new System.Drawing.Size(170, 26);
            this.TxtMusteriAd.TabIndex = 1;
            this.TxtMusteriAd.TextChanged += new System.EventHandler(this.TxtMusteriAd_TextChanged);
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(159, 107);
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(170, 26);
            this.MskTelefon.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 111;
            this.label3.Text = "Müşteri Soyadı:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(47, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 20);
            this.label14.TabIndex = 112;
            this.label14.Text = "Müşteri GSM:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 110;
            this.label1.Text = "Müşteri Adı:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 232);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmMusteriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Ekle";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMusteriSoyad;
        private System.Windows.Forms.TextBox TxtMusteriAd;
    }
}
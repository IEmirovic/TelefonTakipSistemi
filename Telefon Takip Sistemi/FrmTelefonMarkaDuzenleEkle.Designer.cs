namespace Telefon_Takip_Sistemi
{
    partial class FrmTelefonMarkaDuzenleEkle
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtMarka = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.CmbOS = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblid = new System.Windows.Forms.Label();
            this.TxtMarka2 = new System.Windows.Forms.TextBox();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbOS2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tlfMarkaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlfMarkaAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlfOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonMarkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telefonTakipSistemiDataSet = new Telefon_Takip_Sistemi.TelefonTakipSistemiDataSet();
            this.telefonMarkaTableAdapter = new Telefon_Takip_Sistemi.TelefonTakipSistemiDataSetTableAdapters.TelefonMarkaTableAdapter();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonMarkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonTakipSistemiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtMarka);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.CmbOS);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 174);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Marka Ekle";
            // 
            // TxtMarka
            // 
            this.TxtMarka.Location = new System.Drawing.Point(152, 36);
            this.TxtMarka.MaxLength = 25;
            this.TxtMarka.Name = "TxtMarka";
            this.TxtMarka.Size = new System.Drawing.Size(170, 26);
            this.TxtMarka.TabIndex = 1;
            this.TxtMarka.TextChanged += new System.EventHandler(this.TxtMarka_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 20);
            this.label14.TabIndex = 36;
            this.label14.Text = "İşletim Sistemi:";
            // 
            // CmbOS
            // 
            this.CmbOS.FormattingEnabled = true;
            this.CmbOS.Location = new System.Drawing.Point(152, 71);
            this.CmbOS.Name = "CmbOS";
            this.CmbOS.Size = new System.Drawing.Size(170, 28);
            this.CmbOS.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblid);
            this.groupBox1.Controls.Add(this.TxtMarka2);
            this.groupBox1.Controls.Add(this.BtnGuncelle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CmbOS2);
            this.groupBox1.Location = new System.Drawing.Point(12, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 174);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marka Güncelle";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(6, 151);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(36, 20);
            this.lblid.TabIndex = 49;
            this.lblid.Text = "lblid";
            this.lblid.Visible = false;
            // 
            // TxtMarka2
            // 
            this.TxtMarka2.Location = new System.Drawing.Point(152, 36);
            this.TxtMarka2.MaxLength = 25;
            this.TxtMarka2.Name = "TxtMarka2";
            this.TxtMarka2.Size = new System.Drawing.Size(170, 26);
            this.TxtMarka2.TabIndex = 4;
            this.TxtMarka2.TextChanged += new System.EventHandler(this.TxtMarka2_TextChanged);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(135, 116);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(100, 35);
            this.BtnGuncelle.TabIndex = 6;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "İşletim Sistemi:";
            // 
            // CmbOS2
            // 
            this.CmbOS2.FormattingEnabled = true;
            this.CmbOS2.Location = new System.Drawing.Point(152, 71);
            this.CmbOS2.Name = "CmbOS2";
            this.CmbOS2.Size = new System.Drawing.Size(170, 28);
            this.CmbOS2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tlfMarkaIDDataGridViewTextBoxColumn,
            this.tlfMarkaAdDataGridViewTextBoxColumn,
            this.tlfOSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.telefonMarkaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(390, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(244, 339);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // tlfMarkaIDDataGridViewTextBoxColumn
            // 
            this.tlfMarkaIDDataGridViewTextBoxColumn.DataPropertyName = "TlfMarkaID";
            this.tlfMarkaIDDataGridViewTextBoxColumn.HeaderText = "TlfMarkaID";
            this.tlfMarkaIDDataGridViewTextBoxColumn.Name = "tlfMarkaIDDataGridViewTextBoxColumn";
            this.tlfMarkaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tlfMarkaIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tlfMarkaAdDataGridViewTextBoxColumn
            // 
            this.tlfMarkaAdDataGridViewTextBoxColumn.DataPropertyName = "TlfMarkaAd";
            this.tlfMarkaAdDataGridViewTextBoxColumn.HeaderText = "Marka ";
            this.tlfMarkaAdDataGridViewTextBoxColumn.Name = "tlfMarkaAdDataGridViewTextBoxColumn";
            this.tlfMarkaAdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tlfOSDataGridViewTextBoxColumn
            // 
            this.tlfOSDataGridViewTextBoxColumn.DataPropertyName = "TlfOS";
            this.tlfOSDataGridViewTextBoxColumn.HeaderText = "İşletim Sistemi";
            this.tlfOSDataGridViewTextBoxColumn.Name = "tlfOSDataGridViewTextBoxColumn";
            this.tlfOSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonMarkaBindingSource
            // 
            this.telefonMarkaBindingSource.DataMember = "TelefonMarka";
            this.telefonMarkaBindingSource.DataSource = this.telefonTakipSistemiDataSet;
            // 
            // telefonTakipSistemiDataSet
            // 
            this.telefonTakipSistemiDataSet.DataSetName = "TelefonTakipSistemiDataSet";
            this.telefonTakipSistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // telefonMarkaTableAdapter
            // 
            this.telefonMarkaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmTelefonMarkaDuzenleEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 375);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "FrmTelefonMarkaDuzenleEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefon Markası Ekle";
            this.Load += new System.EventHandler(this.FrmTelefonMarkaEkle_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonMarkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonTakipSistemiDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox CmbOS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtMarka;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtMarka2;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbOS2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TelefonTakipSistemiDataSet telefonTakipSistemiDataSet;
        private System.Windows.Forms.BindingSource telefonMarkaBindingSource;
        private TelefonTakipSistemiDataSetTableAdapters.TelefonMarkaTableAdapter telefonMarkaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlfMarkaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlfMarkaAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlfOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblid;
    }
}
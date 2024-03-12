namespace Telefon_Takip_Sistemi
{
    partial class FrmTelefonModelDuzenleEkle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtHafiza = new System.Windows.Forms.TextBox();
            this.CmbMarka = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtModel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtRam = new System.Windows.Forms.TextBox();
            this.TxtKamera = new System.Windows.Forms.TextBox();
            this.TxtBatarya = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblmarka = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.TxtHafiza2 = new System.Windows.Forms.TextBox();
            this.CmbMarka2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtModel2 = new System.Windows.Forms.TextBox();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.TxtRam2 = new System.Windows.Forms.TextBox();
            this.TxtKamera2 = new System.Windows.Forms.TextBox();
            this.TxtBatarya2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tlfModelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlfMarkaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlfModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlfMPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlfRamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlfBataryaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlfHafizaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonOzelliklerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telefonTakipSistemiDataSet = new Telefon_Takip_Sistemi.TelefonTakipSistemiDataSet();
            this.telefonOzelliklerTableAdapter = new Telefon_Takip_Sistemi.TelefonTakipSistemiDataSetTableAdapters.TelefonOzelliklerTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonOzelliklerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonTakipSistemiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TxtHafiza);
            this.groupBox1.Controls.Add(this.CmbMarka);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtModel);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TxtRam);
            this.groupBox1.Controls.Add(this.TxtKamera);
            this.groupBox1.Controls.Add(this.TxtBatarya);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 299);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model Ekle";
            // 
            // TxtHafiza
            // 
            this.TxtHafiza.Location = new System.Drawing.Point(121, 200);
            this.TxtHafiza.MaxLength = 5;
            this.TxtHafiza.Name = "TxtHafiza";
            this.TxtHafiza.Size = new System.Drawing.Size(170, 26);
            this.TxtHafiza.TabIndex = 6;
            this.TxtHafiza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHafiza_KeyPress);
            // 
            // CmbMarka
            // 
            this.CmbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMarka.FormattingEnabled = true;
            this.CmbMarka.Location = new System.Drawing.Point(121, 34);
            this.CmbMarka.Name = "CmbMarka";
            this.CmbMarka.Size = new System.Drawing.Size(170, 28);
            this.CmbMarka.TabIndex = 1;
            this.CmbMarka.SelectedIndexChanged += new System.EventHandler(this.CmbMarka_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Marka:";
            // 
            // TxtModel
            // 
            this.TxtModel.Location = new System.Drawing.Point(121, 68);
            this.TxtModel.MaxLength = 25;
            this.TxtModel.Name = "TxtModel";
            this.TxtModel.Size = new System.Drawing.Size(170, 26);
            this.TxtModel.TabIndex = 2;
            this.TxtModel.TextChanged += new System.EventHandler(this.TxtModel_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtRam
            // 
            this.TxtRam.Location = new System.Drawing.Point(121, 132);
            this.TxtRam.MaxLength = 5;
            this.TxtRam.Name = "TxtRam";
            this.TxtRam.Size = new System.Drawing.Size(170, 26);
            this.TxtRam.TabIndex = 4;
            this.TxtRam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRam_KeyPress);
            // 
            // TxtKamera
            // 
            this.TxtKamera.Location = new System.Drawing.Point(121, 100);
            this.TxtKamera.MaxLength = 5;
            this.TxtKamera.Name = "TxtKamera";
            this.TxtKamera.Size = new System.Drawing.Size(170, 26);
            this.TxtKamera.TabIndex = 3;
            this.TxtKamera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtKamera_KeyPress);
            // 
            // TxtBatarya
            // 
            this.TxtBatarya.Location = new System.Drawing.Point(121, 164);
            this.TxtBatarya.MaxLength = 10;
            this.TxtBatarya.Name = "TxtBatarya";
            this.TxtBatarya.Size = new System.Drawing.Size(170, 26);
            this.TxtBatarya.TabIndex = 5;
            this.TxtBatarya.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBatarya_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "RAM:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kamera MP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Batarya:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hafıza:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblmarka);
            this.groupBox2.Controls.Add(this.lblid);
            this.groupBox2.Controls.Add(this.TxtHafiza2);
            this.groupBox2.Controls.Add(this.CmbMarka2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TxtModel2);
            this.groupBox2.Controls.Add(this.BtnGuncelle);
            this.groupBox2.Controls.Add(this.TxtRam2);
            this.groupBox2.Controls.Add(this.TxtKamera2);
            this.groupBox2.Controls.Add(this.TxtBatarya2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(12, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 296);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Model Güncelle";
            // 
            // lblmarka
            // 
            this.lblmarka.AutoSize = true;
            this.lblmarka.Location = new System.Drawing.Point(33, 273);
            this.lblmarka.Name = "lblmarka";
            this.lblmarka.Size = new System.Drawing.Size(53, 20);
            this.lblmarka.TabIndex = 58;
            this.lblmarka.Text = "marka";
            this.lblmarka.Visible = false;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(6, 273);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(21, 20);
            this.lblid.TabIndex = 56;
            this.lblid.Text = "id";
            this.lblid.Visible = false;
            // 
            // TxtHafiza2
            // 
            this.TxtHafiza2.Location = new System.Drawing.Point(121, 200);
            this.TxtHafiza2.MaxLength = 5;
            this.TxtHafiza2.Name = "TxtHafiza2";
            this.TxtHafiza2.Size = new System.Drawing.Size(170, 26);
            this.TxtHafiza2.TabIndex = 13;
            this.TxtHafiza2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHafiza2_KeyPress);
            // 
            // CmbMarka2
            // 
            this.CmbMarka2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMarka2.FormattingEnabled = true;
            this.CmbMarka2.Location = new System.Drawing.Point(121, 34);
            this.CmbMarka2.Name = "CmbMarka2";
            this.CmbMarka2.Size = new System.Drawing.Size(170, 28);
            this.CmbMarka2.TabIndex = 8;
            this.CmbMarka2.SelectedIndexChanged += new System.EventHandler(this.CmbMarka2_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 53;
            this.label8.Text = "Marka:";
            // 
            // TxtModel2
            // 
            this.TxtModel2.Location = new System.Drawing.Point(121, 68);
            this.TxtModel2.MaxLength = 25;
            this.TxtModel2.Name = "TxtModel2";
            this.TxtModel2.Size = new System.Drawing.Size(170, 26);
            this.TxtModel2.TabIndex = 9;
            this.TxtModel2.TextChanged += new System.EventHandler(this.TxtModel2_TextChanged);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(121, 238);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(100, 35);
            this.BtnGuncelle.TabIndex = 14;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // TxtRam2
            // 
            this.TxtRam2.Location = new System.Drawing.Point(121, 132);
            this.TxtRam2.MaxLength = 5;
            this.TxtRam2.Name = "TxtRam2";
            this.TxtRam2.Size = new System.Drawing.Size(170, 26);
            this.TxtRam2.TabIndex = 11;
            this.TxtRam2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRam2_KeyPress);
            // 
            // TxtKamera2
            // 
            this.TxtKamera2.Location = new System.Drawing.Point(121, 100);
            this.TxtKamera2.MaxLength = 5;
            this.TxtKamera2.Name = "TxtKamera2";
            this.TxtKamera2.Size = new System.Drawing.Size(170, 26);
            this.TxtKamera2.TabIndex = 10;
            this.TxtKamera2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtKamera2_KeyPress);
            // 
            // TxtBatarya2
            // 
            this.TxtBatarya2.Location = new System.Drawing.Point(121, 164);
            this.TxtBatarya2.MaxLength = 10;
            this.TxtBatarya2.Name = "TxtBatarya2";
            this.TxtBatarya2.Size = new System.Drawing.Size(170, 26);
            this.TxtBatarya2.TabIndex = 12;
            this.TxtBatarya2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBatarya2_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Model:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(66, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "RAM:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "Kamera MP:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(47, 170);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "Batarya:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(56, 203);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "Hafıza:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tlfModelIDDataGridViewTextBoxColumn,
            this.tlfMarkaIDDataGridViewTextBoxColumn,
            this.tlfModelDataGridViewTextBoxColumn,
            this.tlfMPDataGridViewTextBoxColumn,
            this.tlfRamDataGridViewTextBoxColumn,
            this.tlfBataryaDataGridViewTextBoxColumn,
            this.tlfHafizaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.telefonOzelliklerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(342, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 593);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_1);
            // 
            // tlfModelIDDataGridViewTextBoxColumn
            // 
            this.tlfModelIDDataGridViewTextBoxColumn.DataPropertyName = "TlfModelID";
            this.tlfModelIDDataGridViewTextBoxColumn.HeaderText = "Model ID";
            this.tlfModelIDDataGridViewTextBoxColumn.Name = "tlfModelIDDataGridViewTextBoxColumn";
            this.tlfModelIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tlfMarkaIDDataGridViewTextBoxColumn
            // 
            this.tlfMarkaIDDataGridViewTextBoxColumn.DataPropertyName = "TlfMarkaID";
            this.tlfMarkaIDDataGridViewTextBoxColumn.HeaderText = "Marka";
            this.tlfMarkaIDDataGridViewTextBoxColumn.Name = "tlfMarkaIDDataGridViewTextBoxColumn";
            // 
            // tlfModelDataGridViewTextBoxColumn
            // 
            this.tlfModelDataGridViewTextBoxColumn.DataPropertyName = "TlfModel";
            this.tlfModelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.tlfModelDataGridViewTextBoxColumn.Name = "tlfModelDataGridViewTextBoxColumn";
            // 
            // tlfMPDataGridViewTextBoxColumn
            // 
            this.tlfMPDataGridViewTextBoxColumn.DataPropertyName = "TlfMP";
            this.tlfMPDataGridViewTextBoxColumn.HeaderText = "Kamera";
            this.tlfMPDataGridViewTextBoxColumn.Name = "tlfMPDataGridViewTextBoxColumn";
            // 
            // tlfRamDataGridViewTextBoxColumn
            // 
            this.tlfRamDataGridViewTextBoxColumn.DataPropertyName = "TlfRam";
            this.tlfRamDataGridViewTextBoxColumn.HeaderText = "RAM";
            this.tlfRamDataGridViewTextBoxColumn.Name = "tlfRamDataGridViewTextBoxColumn";
            // 
            // tlfBataryaDataGridViewTextBoxColumn
            // 
            this.tlfBataryaDataGridViewTextBoxColumn.DataPropertyName = "TlfBatarya";
            this.tlfBataryaDataGridViewTextBoxColumn.HeaderText = "Batarya";
            this.tlfBataryaDataGridViewTextBoxColumn.Name = "tlfBataryaDataGridViewTextBoxColumn";
            // 
            // tlfHafizaDataGridViewTextBoxColumn
            // 
            this.tlfHafizaDataGridViewTextBoxColumn.DataPropertyName = "TlfHafiza";
            this.tlfHafizaDataGridViewTextBoxColumn.HeaderText = "Hafıza";
            this.tlfHafizaDataGridViewTextBoxColumn.Name = "tlfHafizaDataGridViewTextBoxColumn";
            // 
            // telefonOzelliklerBindingSource
            // 
            this.telefonOzelliklerBindingSource.DataMember = "TelefonOzellikler";
            this.telefonOzelliklerBindingSource.DataSource = this.telefonTakipSistemiDataSet;
            // 
            // telefonTakipSistemiDataSet
            // 
            this.telefonTakipSistemiDataSet.DataSetName = "TelefonTakipSistemiDataSet";
            this.telefonTakipSistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // telefonOzelliklerTableAdapter
            // 
            this.telefonOzelliklerTableAdapter.ClearBeforeFill = true;
            // 
            // FrmTelefonModelDuzenleEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 625);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmTelefonModelDuzenleEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefon Model Ekle";
            this.Load += new System.EventHandler(this.FrmTelefonModelEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonOzelliklerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonTakipSistemiDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtRam;
        private System.Windows.Forms.TextBox TxtKamera;
        private System.Windows.Forms.TextBox TxtBatarya;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtModel;
        private System.Windows.Forms.ComboBox CmbMarka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtHafiza;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtHafiza2;
        private System.Windows.Forms.ComboBox CmbMarka2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtModel2;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.TextBox TxtRam2;
        private System.Windows.Forms.TextBox TxtKamera2;
        private System.Windows.Forms.TextBox TxtBatarya2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TelefonTakipSistemiDataSet telefonTakipSistemiDataSet;
        private System.Windows.Forms.BindingSource telefonOzelliklerBindingSource;
        private TelefonTakipSistemiDataSetTableAdapters.TelefonOzelliklerTableAdapter telefonOzelliklerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlfModelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlfMarkaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlfModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlfMPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlfRamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlfBataryaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlfHafizaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblmarka;
    }
}
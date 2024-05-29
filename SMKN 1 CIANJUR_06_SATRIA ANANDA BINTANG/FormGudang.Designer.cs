namespace SMKN_1_CIANJUR_06_SATRIA_ANANDA_BINTANG
{
    partial class FormGudang
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
            this.BtnTambah = new System.Windows.Forms.Button();
            this.TbSearch = new System.Windows.Forms.TextBox();
            this.TbKode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvBarang = new System.Windows.Forms.DataGridView();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbJumlah = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbNama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TbSatuan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TbHarga = new System.Windows.Forms.TextBox();
            this.DtExpired = new System.Windows.Forms.DateTimePicker();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnHapus = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnTambah
            // 
            this.BtnTambah.Location = new System.Drawing.Point(669, 103);
            this.BtnTambah.Name = "BtnTambah";
            this.BtnTambah.Size = new System.Drawing.Size(88, 39);
            this.BtnTambah.TabIndex = 8;
            this.BtnTambah.Text = "Tambah";
            this.BtnTambah.UseVisualStyleBackColor = true;
            this.BtnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
            // 
            // TbSearch
            // 
            this.TbSearch.Location = new System.Drawing.Point(578, 303);
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.Size = new System.Drawing.Size(210, 20);
            this.TbSearch.TabIndex = 13;
            this.TbSearch.Text = "Search Barang";
            this.TbSearch.TextChanged += new System.EventHandler(this.TbSearch_TextChanged);
            // 
            // TbKode
            // 
            this.TbKode.Location = new System.Drawing.Point(429, 103);
            this.TbKode.Name = "TbKode";
            this.TbKode.Size = new System.Drawing.Size(210, 20);
            this.TbKode.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Kode Barang";
            // 
            // DgvBarang
            // 
            this.DgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBarang.Location = new System.Drawing.Point(340, 329);
            this.DgvBarang.Name = "DgvBarang";
            this.DgvBarang.Size = new System.Drawing.Size(448, 109);
            this.DgvBarang.TabIndex = 14;
            this.DgvBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBarang_CellContentClick);
            // 
            // BtnLogout
            // 
            this.BtnLogout.Location = new System.Drawing.Point(63, 329);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(123, 34);
            this.BtnLogout.TabIndex = 1;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Kelola Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Gudang";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(90, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 40);
            this.label9.TabIndex = 30;
            this.label9.Text = "Kelola\r\nBarang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Jumlah Barang";
            // 
            // TbJumlah
            // 
            this.TbJumlah.Location = new System.Drawing.Point(429, 129);
            this.TbJumlah.Name = "TbJumlah";
            this.TbJumlah.Size = new System.Drawing.Size(210, 20);
            this.TbJumlah.TabIndex = 3;
            this.TbJumlah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbJumlah_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Nama Barang";
            // 
            // TbNama
            // 
            this.TbNama.Location = new System.Drawing.Point(429, 155);
            this.TbNama.Name = "TbNama";
            this.TbNama.Size = new System.Drawing.Size(210, 20);
            this.TbNama.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Satuan";
            // 
            // TbSatuan
            // 
            this.TbSatuan.Location = new System.Drawing.Point(429, 181);
            this.TbSatuan.Name = "TbSatuan";
            this.TbSatuan.Size = new System.Drawing.Size(210, 20);
            this.TbSatuan.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(337, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Expired Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(337, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Harga Satuan";
            // 
            // TbHarga
            // 
            this.TbHarga.Location = new System.Drawing.Point(429, 233);
            this.TbHarga.Name = "TbHarga";
            this.TbHarga.Size = new System.Drawing.Size(210, 20);
            this.TbHarga.TabIndex = 7;
            this.TbHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbHarga_KeyPress);
            // 
            // DtExpired
            // 
            this.DtExpired.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtExpired.Location = new System.Drawing.Point(429, 207);
            this.DtExpired.Name = "DtExpired";
            this.DtExpired.Size = new System.Drawing.Size(210, 20);
            this.DtExpired.TabIndex = 6;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(669, 148);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(88, 39);
            this.BtnEdit.TabIndex = 9;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnHapus
            // 
            this.BtnHapus.Location = new System.Drawing.Point(669, 193);
            this.BtnHapus.Name = "BtnHapus";
            this.BtnHapus.Size = new System.Drawing.Size(88, 39);
            this.BtnHapus.TabIndex = 10;
            this.BtnHapus.Text = "Hapus";
            this.BtnHapus.UseVisualStyleBackColor = true;
            this.BtnHapus.Click += new System.EventHandler(this.BtnHapus_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(669, 126);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(88, 39);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(669, 171);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(88, 39);
            this.BtnCancel.TabIndex = 12;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(337, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Tabel Barang";
            // 
            // FormGudang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DtExpired);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnHapus);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnTambah);
            this.Controls.Add(this.TbSearch);
            this.Controls.Add(this.TbHarga);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TbSatuan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TbNama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TbJumlah);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbKode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DgvBarang);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "FormGudang";
            this.Text = "FormGudang";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGudang_FormClosed);
            this.Load += new System.EventHandler(this.FormGudang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnTambah;
        private System.Windows.Forms.TextBox TbSearch;
        private System.Windows.Forms.TextBox TbKode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvBarang;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbJumlah;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbNama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbSatuan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TbHarga;
        private System.Windows.Forms.DateTimePicker DtExpired;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnHapus;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label10;
    }
}
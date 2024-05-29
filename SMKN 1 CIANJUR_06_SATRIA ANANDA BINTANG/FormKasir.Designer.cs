namespace SMKN_1_CIANJUR_06_SATRIA_ANANDA_BINTANG
{
    partial class FormKasir
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
            this.label8 = new System.Windows.Forms.Label();
            this.TbNama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TbTelepon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbMenu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvKeranjang = new System.Windows.Forms.DataGridView();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TbHarga = new System.Windows.Forms.TextBox();
            this.TbKuantitas = new System.Windows.Forms.TextBox();
            this.TbTotal = new System.Windows.Forms.TextBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnTambah = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LbTotal = new System.Windows.Forms.Label();
            this.LbDisc = new System.Windows.Forms.Label();
            this.TbBayar = new System.Windows.Forms.TextBox();
            this.BtnBayar = new System.Windows.Forms.Button();
            this.LbKembalian = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.id_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_transaksi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kode_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga_satuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvKeranjang)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(515, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Kuantitas";
            // 
            // TbNama
            // 
            this.TbNama.Location = new System.Drawing.Point(340, 223);
            this.TbNama.Name = "TbNama";
            this.TbNama.Size = new System.Drawing.Size(172, 20);
            this.TbNama.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(515, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Total Harga";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(515, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Harga Satuan";
            // 
            // TbTelepon
            // 
            this.TbTelepon.Location = new System.Drawing.Point(340, 169);
            this.TbTelepon.Name = "TbTelepon";
            this.TbTelepon.Size = new System.Drawing.Size(172, 20);
            this.TbTelepon.TabIndex = 3;
            this.TbTelepon.TextChanged += new System.EventHandler(this.TbTelepon_TextChanged);
            this.TbTelepon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTelepon_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Nama Pelanggan";
            // 
            // CbMenu
            // 
            this.CbMenu.FormattingEnabled = true;
            this.CbMenu.Location = new System.Drawing.Point(340, 119);
            this.CbMenu.Name = "CbMenu";
            this.CbMenu.Size = new System.Drawing.Size(172, 21);
            this.CbMenu.TabIndex = 2;
            this.CbMenu.SelectedIndexChanged += new System.EventHandler(this.CbMenu_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Telepon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Pilih Menu";
            // 
            // DgvKeranjang
            // 
            this.DgvKeranjang.AllowUserToAddRows = false;
            this.DgvKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvKeranjang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_barang,
            this.no_transaksi,
            this.kode_barang,
            this.nama_barang,
            this.harga_satuan,
            this.qty,
            this.total_harga});
            this.DgvKeranjang.Location = new System.Drawing.Point(340, 271);
            this.DgvKeranjang.Name = "DgvKeranjang";
            this.DgvKeranjang.Size = new System.Drawing.Size(448, 109);
            this.DgvKeranjang.TabIndex = 10;
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
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Form Transaksi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Kasir";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(75, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 40);
            this.label9.TabIndex = 30;
            this.label9.Text = "Kelola\r\nTransaksi";
            // 
            // TbHarga
            // 
            this.TbHarga.Location = new System.Drawing.Point(518, 120);
            this.TbHarga.Name = "TbHarga";
            this.TbHarga.ReadOnly = true;
            this.TbHarga.Size = new System.Drawing.Size(172, 20);
            this.TbHarga.TabIndex = 5;
            // 
            // TbKuantitas
            // 
            this.TbKuantitas.Location = new System.Drawing.Point(518, 169);
            this.TbKuantitas.Name = "TbKuantitas";
            this.TbKuantitas.Size = new System.Drawing.Size(172, 20);
            this.TbKuantitas.TabIndex = 6;
            this.TbKuantitas.TextChanged += new System.EventHandler(this.TbKuantitas_TextChanged);
            // 
            // TbTotal
            // 
            this.TbTotal.Location = new System.Drawing.Point(518, 223);
            this.TbTotal.Name = "TbTotal";
            this.TbTotal.ReadOnly = true;
            this.TbTotal.Size = new System.Drawing.Size(172, 20);
            this.TbTotal.TabIndex = 7;
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(700, 181);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(88, 39);
            this.BtnReset.TabIndex = 9;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnTambah
            // 
            this.BtnTambah.Location = new System.Drawing.Point(700, 136);
            this.BtnTambah.Name = "BtnTambah";
            this.BtnTambah.Size = new System.Drawing.Size(88, 39);
            this.BtnTambah.TabIndex = 8;
            this.BtnTambah.Text = "Tambah";
            this.BtnTambah.UseVisualStyleBackColor = true;
            this.BtnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(337, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Keranjang";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(597, 383);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Total Harga";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(597, 406);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Disc";
            // 
            // LbTotal
            // 
            this.LbTotal.AutoSize = true;
            this.LbTotal.Location = new System.Drawing.Point(697, 383);
            this.LbTotal.Name = "LbTotal";
            this.LbTotal.Size = new System.Drawing.Size(13, 13);
            this.LbTotal.TabIndex = 39;
            this.LbTotal.Text = "0";
            // 
            // LbDisc
            // 
            this.LbDisc.AutoSize = true;
            this.LbDisc.Location = new System.Drawing.Point(697, 406);
            this.LbDisc.Name = "LbDisc";
            this.LbDisc.Size = new System.Drawing.Size(13, 13);
            this.LbDisc.TabIndex = 39;
            this.LbDisc.Text = "0";
            // 
            // TbBayar
            // 
            this.TbBayar.Location = new System.Drawing.Point(340, 399);
            this.TbBayar.Name = "TbBayar";
            this.TbBayar.Size = new System.Drawing.Size(172, 20);
            this.TbBayar.TabIndex = 11;
            // 
            // BtnBayar
            // 
            this.BtnBayar.Location = new System.Drawing.Point(340, 425);
            this.BtnBayar.Name = "BtnBayar";
            this.BtnBayar.Size = new System.Drawing.Size(172, 23);
            this.BtnBayar.TabIndex = 12;
            this.BtnBayar.Text = "Bayar";
            this.BtnBayar.UseVisualStyleBackColor = true;
            this.BtnBayar.Click += new System.EventHandler(this.BtnBayar_Click);
            // 
            // LbKembalian
            // 
            this.LbKembalian.AutoSize = true;
            this.LbKembalian.Location = new System.Drawing.Point(437, 461);
            this.LbKembalian.Name = "LbKembalian";
            this.LbKembalian.Size = new System.Drawing.Size(13, 13);
            this.LbKembalian.TabIndex = 39;
            this.LbKembalian.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(337, 461);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "Kembalian";
            // 
            // BtnPrint
            // 
            this.BtnPrint.Location = new System.Drawing.Point(583, 442);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(77, 32);
            this.BtnPrint.TabIndex = 14;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.Location = new System.Drawing.Point(666, 442);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(77, 32);
            this.BtnSimpan.TabIndex = 13;
            this.BtnSimpan.Text = "Simpan";
            this.BtnSimpan.UseVisualStyleBackColor = true;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(337, 383);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "Cash";
            // 
            // id_barang
            // 
            this.id_barang.HeaderText = "ID Barang";
            this.id_barang.Name = "id_barang";
            // 
            // no_transaksi
            // 
            this.no_transaksi.HeaderText = "No Transaksi";
            this.no_transaksi.Name = "no_transaksi";
            // 
            // kode_barang
            // 
            this.kode_barang.HeaderText = "Kode Barang";
            this.kode_barang.Name = "kode_barang";
            // 
            // nama_barang
            // 
            this.nama_barang.HeaderText = "Nama Barang";
            this.nama_barang.Name = "nama_barang";
            // 
            // harga_satuan
            // 
            this.harga_satuan.HeaderText = "Harga Satuan";
            this.harga_satuan.Name = "harga_satuan";
            // 
            // qty
            // 
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            // 
            // total_harga
            // 
            this.total_harga.HeaderText = "Total Harga";
            this.total_harga.Name = "total_harga";
            // 
            // FormKasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.BtnBayar);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnSimpan);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.BtnTambah);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TbBayar);
            this.Controls.Add(this.TbNama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TbTotal);
            this.Controls.Add(this.TbKuantitas);
            this.Controls.Add(this.TbHarga);
            this.Controls.Add(this.TbTelepon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbMenu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LbKembalian);
            this.Controls.Add(this.LbDisc);
            this.Controls.Add(this.LbTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DgvKeranjang);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "FormKasir";
            this.Text = "FormKasir";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormKasir_FormClosed);
            this.Load += new System.EventHandler(this.FormKasir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvKeranjang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TbNama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbTelepon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbMenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvKeranjang;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TbHarga;
        private System.Windows.Forms.TextBox TbKuantitas;
        private System.Windows.Forms.TextBox TbTotal;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnTambah;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LbTotal;
        private System.Windows.Forms.Label LbDisc;
        private System.Windows.Forms.TextBox TbBayar;
        private System.Windows.Forms.Button BtnBayar;
        private System.Windows.Forms.Label LbKembalian;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_transaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_satuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_harga;
    }
}
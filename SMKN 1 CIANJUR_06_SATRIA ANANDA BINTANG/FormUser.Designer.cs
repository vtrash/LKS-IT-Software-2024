namespace SMKN_1_CIANJUR_06_SATRIA_ANANDA_BINTANG
{
    partial class FormUser
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
            this.label3 = new System.Windows.Forms.Label();
            this.DgvUser = new System.Windows.Forms.DataGridView();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnActivity = new System.Windows.Forms.Button();
            this.BtnLaporan = new System.Windows.Forms.Button();
            this.BtnUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CbTipe = new System.Windows.Forms.ComboBox();
            this.TbNama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TbTelepon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TbAlamat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TbUsername = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.BtnTambah = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnHapus = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tipe User";
            // 
            // DgvUser
            // 
            this.DgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUser.Location = new System.Drawing.Point(340, 329);
            this.DgvUser.Name = "DgvUser";
            this.DgvUser.Size = new System.Drawing.Size(448, 109);
            this.DgvUser.TabIndex = 17;
            this.DgvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUser_CellContentClick);
            // 
            // BtnLogout
            // 
            this.BtnLogout.Location = new System.Drawing.Point(63, 329);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(123, 34);
            this.BtnLogout.TabIndex = 4;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnActivity
            // 
            this.BtnActivity.Location = new System.Drawing.Point(63, 289);
            this.BtnActivity.Name = "BtnActivity";
            this.BtnActivity.Size = new System.Drawing.Size(123, 34);
            this.BtnActivity.TabIndex = 3;
            this.BtnActivity.Text = "Log Activity";
            this.BtnActivity.UseVisualStyleBackColor = true;
            this.BtnActivity.Click += new System.EventHandler(this.BtnActivity_Click);
            // 
            // BtnLaporan
            // 
            this.BtnLaporan.Location = new System.Drawing.Point(63, 249);
            this.BtnLaporan.Name = "BtnLaporan";
            this.BtnLaporan.Size = new System.Drawing.Size(123, 34);
            this.BtnLaporan.TabIndex = 2;
            this.BtnLaporan.Text = "Kelola Laporan";
            this.BtnLaporan.UseVisualStyleBackColor = true;
            this.BtnLaporan.Click += new System.EventHandler(this.BtnLaporan_Click);
            // 
            // BtnUser
            // 
            this.BtnUser.Location = new System.Drawing.Point(63, 209);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.Size = new System.Drawing.Size(123, 34);
            this.BtnUser.TabIndex = 1;
            this.BtnUser.Text = "Kelola User";
            this.BtnUser.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Log Activity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Admin";
            // 
            // CbTipe
            // 
            this.CbTipe.FormattingEnabled = true;
            this.CbTipe.Items.AddRange(new object[] {
            "admin",
            "gudang",
            "kasir"});
            this.CbTipe.Location = new System.Drawing.Point(340, 119);
            this.CbTipe.Name = "CbTipe";
            this.CbTipe.Size = new System.Drawing.Size(210, 21);
            this.CbTipe.TabIndex = 5;
            // 
            // TbNama
            // 
            this.TbNama.Location = new System.Drawing.Point(340, 169);
            this.TbNama.Name = "TbNama";
            this.TbNama.Size = new System.Drawing.Size(210, 20);
            this.TbNama.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Telepon";
            // 
            // TbTelepon
            // 
            this.TbTelepon.Location = new System.Drawing.Point(340, 223);
            this.TbTelepon.Name = "TbTelepon";
            this.TbTelepon.Size = new System.Drawing.Size(210, 20);
            this.TbTelepon.TabIndex = 7;
            this.TbTelepon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTelepon_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Alamat";
            // 
            // TbAlamat
            // 
            this.TbAlamat.Location = new System.Drawing.Point(340, 279);
            this.TbAlamat.Name = "TbAlamat";
            this.TbAlamat.Size = new System.Drawing.Size(210, 20);
            this.TbAlamat.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(563, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(563, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Password";
            // 
            // TbUsername
            // 
            this.TbUsername.Location = new System.Drawing.Point(566, 119);
            this.TbUsername.Name = "TbUsername";
            this.TbUsername.Size = new System.Drawing.Size(210, 20);
            this.TbUsername.TabIndex = 9;
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(566, 169);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(210, 20);
            this.TbPassword.TabIndex = 10;
            // 
            // BtnTambah
            // 
            this.BtnTambah.Location = new System.Drawing.Point(566, 202);
            this.BtnTambah.Name = "BtnTambah";
            this.BtnTambah.Size = new System.Drawing.Size(66, 41);
            this.BtnTambah.TabIndex = 11;
            this.BtnTambah.Text = "Tambah";
            this.BtnTambah.UseVisualStyleBackColor = true;
            this.BtnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(638, 202);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(66, 41);
            this.BtnEdit.TabIndex = 12;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnHapus
            // 
            this.BtnHapus.Location = new System.Drawing.Point(710, 202);
            this.BtnHapus.Name = "BtnHapus";
            this.BtnHapus.Size = new System.Drawing.Size(66, 41);
            this.BtnHapus.TabIndex = 13;
            this.BtnHapus.Text = "Hapus";
            this.BtnHapus.UseVisualStyleBackColor = true;
            this.BtnHapus.Click += new System.EventHandler(this.BtnHapus_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(600, 202);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(66, 41);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(672, 202);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(66, 41);
            this.BtnCancel.TabIndex = 15;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TbSearch
            // 
            this.TbSearch.Location = new System.Drawing.Point(578, 303);
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.Size = new System.Drawing.Size(210, 20);
            this.TbSearch.TabIndex = 16;
            this.TbSearch.Text = "Search User";
            this.TbSearch.TextChanged += new System.EventHandler(this.TbSearch_TextChanged);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnHapus);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnTambah);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbUsername);
            this.Controls.Add(this.TbSearch);
            this.Controls.Add(this.TbAlamat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TbTelepon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TbNama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbTipe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DgvUser);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.BtnActivity);
            this.Controls.Add(this.BtnLaporan);
            this.Controls.Add(this.BtnUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUser";
            this.Text = "FormUser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUser_FormClosed);
            this.Load += new System.EventHandler(this.FormUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvUser;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnActivity;
        private System.Windows.Forms.Button BtnLaporan;
        private System.Windows.Forms.Button BtnUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbTipe;
        private System.Windows.Forms.TextBox TbNama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbTelepon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbAlamat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TbUsername;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.Button BtnTambah;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnHapus;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TbSearch;
    }
}
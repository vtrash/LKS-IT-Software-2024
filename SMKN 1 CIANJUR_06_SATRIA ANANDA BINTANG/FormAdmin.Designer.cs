namespace SMKN_1_CIANJUR_06_SATRIA_ANANDA_BINTANG
{
    partial class FormAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnUser = new System.Windows.Forms.Button();
            this.DtAwal = new System.Windows.Forms.DateTimePicker();
            this.DgvLog = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.BtnLaporan = new System.Windows.Forms.Button();
            this.BtnActivity = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.DtAkhir = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLog)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin";
            // 
            // BtnUser
            // 
            this.BtnUser.Location = new System.Drawing.Point(63, 209);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.Size = new System.Drawing.Size(123, 34);
            this.BtnUser.TabIndex = 1;
            this.BtnUser.Text = "Kelola User";
            this.BtnUser.UseVisualStyleBackColor = true;
            this.BtnUser.Click += new System.EventHandler(this.BtnUser_Click);
            // 
            // DtAwal
            // 
            this.DtAwal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtAwal.Location = new System.Drawing.Point(340, 119);
            this.DtAwal.Name = "DtAwal";
            this.DtAwal.Size = new System.Drawing.Size(149, 20);
            this.DtAwal.TabIndex = 5;
            // 
            // DgvLog
            // 
            this.DgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLog.Location = new System.Drawing.Point(340, 145);
            this.DgvLog.Name = "DgvLog";
            this.DgvLog.Size = new System.Drawing.Size(448, 293);
            this.DgvLog.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Log Activity";
            // 
            // BtnFilter
            // 
            this.BtnFilter.Location = new System.Drawing.Point(650, 116);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(75, 23);
            this.BtnFilter.TabIndex = 7;
            this.BtnFilter.Text = "FIlter";
            this.BtnFilter.UseVisualStyleBackColor = true;
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
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
            // BtnActivity
            // 
            this.BtnActivity.Location = new System.Drawing.Point(63, 289);
            this.BtnActivity.Name = "BtnActivity";
            this.BtnActivity.Size = new System.Drawing.Size(123, 34);
            this.BtnActivity.TabIndex = 3;
            this.BtnActivity.Text = "Log Activity";
            this.BtnActivity.UseVisualStyleBackColor = true;
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
            // DtAkhir
            // 
            this.DtAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtAkhir.Location = new System.Drawing.Point(495, 119);
            this.DtAkhir.Name = "DtAkhir";
            this.DtAkhir.Size = new System.Drawing.Size(149, 20);
            this.DtAkhir.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tanggal Awal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tanggal Akhir";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DgvLog);
            this.Controls.Add(this.DtAkhir);
            this.Controls.Add(this.DtAwal);
            this.Controls.Add(this.BtnFilter);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.BtnActivity);
            this.Controls.Add(this.BtnLaporan);
            this.Controls.Add(this.BtnUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmin_FormClosed);
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnUser;
        private System.Windows.Forms.DateTimePicker DtAwal;
        private System.Windows.Forms.DataGridView DgvLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.Button BtnLaporan;
        private System.Windows.Forms.Button BtnActivity;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.DateTimePicker DtAkhir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
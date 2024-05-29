using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMKN_1_CIANJUR_06_SATRIA_ANANDA_BINTANG
{
    public partial class FormGudang : Form
    {
        private string idBarang;
        private string statusProcess;

        public FormGudang()
        {
            InitializeComponent();
        }

        private void RefreshTable()
        {
            string query = "SELECT * FROM tbl_barang";
            DgvBarang.DataSource = DBManager.ExecuteQuery(query);
        }

        private bool ValidateInput()
        {
            if (
                string.IsNullOrEmpty(TbKode.Text.ToString()) ||
                string.IsNullOrEmpty(TbJumlah.Text.ToString()) ||
                string.IsNullOrEmpty(TbNama.Text.ToString()) ||
                string.IsNullOrEmpty(TbSatuan.Text.ToString()) ||
                string.IsNullOrEmpty(DtExpired.Text.ToString()) ||
                string.IsNullOrEmpty(TbHarga.Text.ToString())
                )
            {
                FormUtils.Msg("Semua input wajib diisi", "error");
                return false;
            }
            return true;
        }

        private void ToggleFirstState()
        {
            BtnTambah.Visible = true;
            BtnEdit.Visible = true;
            BtnHapus.Visible = true;

            BtnTambah.Enabled = true;
            BtnEdit.Enabled = false;
            BtnHapus.Enabled = false;

            BtnSave.Visible = false;
            BtnCancel.Visible = false;

            TbKode.Enabled = false;
            TbJumlah.Enabled = false;
            TbNama.Enabled = false;
            TbSatuan.Enabled = false;
            DtExpired.Enabled = false;
            TbHarga.Enabled = false;
        }

        private void ToggleInputState()
        {
            BtnTambah.Visible = false;
            BtnEdit.Visible = false;
            BtnHapus.Visible = false;

            BtnSave.Visible = true;
            BtnCancel.Visible = true;

            TbKode.Enabled = true;
            TbJumlah.Enabled = true;
            TbNama.Enabled = true;
            TbSatuan.Enabled = true;
            DtExpired.Enabled = true;
            TbHarga.Enabled = true;
        }

        private void ToggleAllMethodState()
        {
            BtnTambah.Visible = true;
            BtnEdit.Visible = true;
            BtnHapus.Visible = true;

            BtnTambah.Enabled = true;
            BtnEdit.Enabled = true;
            BtnHapus.Enabled = true;

            BtnSave.Visible = false;
            BtnCancel.Visible = false;

            TbKode.Enabled = false;
            TbJumlah.Enabled = false;
            TbNama.Enabled = false;
            TbSatuan.Enabled = false;
            DtExpired.Enabled = false;
            TbHarga.Enabled = false;
        }

        private void InsertMethod()
        {
            string query = "INSERT INTO tbl_barang " +
                "(kode_barang, nama_barang, expired_date, jumlah_barang, satuan, harga_satuan) " +
                "VALUES (@kode_barang, @nama_barang, @expired_date, @jumlah_barang, @satuan, @harga_satuan)";

            SqlParameter[] sp =
            {
                new SqlParameter("@kode_barang", TbKode.Text.ToString()),
                new SqlParameter("@nama_barang", TbNama.Text.ToString()),
                new SqlParameter("@expired_date", DtExpired.Value.ToString("yyyy-MM-dd")),
                new SqlParameter("@jumlah_barang", TbJumlah.Text.ToString()),
                new SqlParameter("@satuan", TbSatuan.Text.ToString()),
                new SqlParameter("@harga_satuan", TbHarga.Text.ToString()),
            };

            DataTable dt = DBManager.ExecuteQuery(query, sp);

            if (dt != null)
            {
                FormUtils.Msg("Berhasil memasukan data", "info");
            }
        }

        private void UpdateMethod()
        {
            string query = "UPDATE tbl_barang " +
                "SET " +
                "kode_barang = @kode_barang, " +
                "nama_barang = @nama_barang, " +
                "expired_date = @expired_date, " +
                "jumlah_barang = @jumlah_barang, " +
                "satuan = @satuan, " +
                "harga_satuan = @harga_satuan " +
                "WHERE id_barang = @id_barang";

            SqlParameter[] sp =
            {
                new SqlParameter("@kode_barang", TbKode.Text.ToString()),
                new SqlParameter("@nama_barang", TbNama.Text.ToString()),
                new SqlParameter("@expired_date", DtExpired.Value.ToString("yyyy-MM-dd")),
                new SqlParameter("@jumlah_barang", TbJumlah.Text.ToString()),
                new SqlParameter("@satuan", TbSatuan.Text.ToString()),
                new SqlParameter("@harga_satuan", TbHarga.Text.ToString()),
                new SqlParameter("@id_barang", idBarang),
            };

            DataTable dt = DBManager.ExecuteQuery(query, sp);

            if (dt != null)
            {
                FormUtils.Msg("Berhasil memasukan data", "info");
            }
        }

        private void FormGudang_Load(object sender, EventArgs e)
        {
            RefreshTable();
            ToggleFirstState();
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            FormUtils.ClearTBs(this);
            statusProcess = "insert";
            ToggleInputState();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            statusProcess = "update";
            ToggleInputState();
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (FormUtils.Msg("Yakin ingin menghapus data?", "confirm") == DialogResult.Yes)
            {
                string query = "DELETE FROM tbl_barang " +
                    "WHERE id_barang = @id_barang";

                SqlParameter[] sp =
                {
                    new SqlParameter("id_barang", idBarang),
                };

                DataTable dt = DBManager.ExecuteQuery(query, sp);

                if (dt != null)
                {
                    FormUtils.Msg("Berhasil menghapus data", "info");
                }
            }

            FormUtils.ClearTBs(this);
            RefreshTable();
            ToggleFirstState();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            if (statusProcess == "insert") InsertMethod();
            else UpdateMethod();

            FormUtils.ClearTBs(this);
            RefreshTable();
            ToggleFirstState();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            FormUtils.ClearTBs(this);
            RefreshTable();
            ToggleFirstState();
        }

        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tbl_barang " +
                "WHERE nama_barang LIKE @nama_barang";

            SqlParameter[] sp =
            {
                new SqlParameter("@nama_barang", '%' + TbSearch.Text.ToString() + '%'),
            };

            DgvBarang.DataSource = DBManager.ExecuteQuery(query, sp);
        }

        private void DgvBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridViewRow row = DgvBarang.Rows[e.RowIndex];

            idBarang = row.Cells[0].Value.ToString();
            TbKode.Text = row.Cells[1].Value.ToString();
            TbNama.Text = row.Cells[2].Value.ToString();
            DtExpired.Text = row.Cells[3].Value.ToString();
            TbJumlah.Text = row.Cells[4].Value.ToString();
            TbSatuan.Text = row.Cells[5].Value.ToString();
            TbHarga.Text = row.Cells[6].Value.ToString();

            ToggleAllMethodState();
        }

        private void TbJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormUtils.NumOnly(e);
        }

        private void TbHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormUtils.NumOnly(e);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            FormUtils.Logout();
            FormUtils.AddLog(FormLogin.idUser, "Logout");
        }

        private void FormGudang_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormUtils.CloseApp();
        }
    }
}

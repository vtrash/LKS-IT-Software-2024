using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMKN_1_CIANJUR_06_SATRIA_ANANDA_BINTANG
{
    public partial class FormUser : Form
    {
        private string idUser;
        private string statusProcess;

        public FormUser()
        {
            InitializeComponent();
        }

        private void RefreshTable()
        {
            string query = "SELECT * FROM tbl_user";
            DgvUser.DataSource = DBManager.ExecuteQuery(query);
        }

        private bool ValidateInput()
        {
            if (
                string.IsNullOrEmpty(CbTipe.Text.ToString()) ||
                string.IsNullOrEmpty(TbNama.Text.ToString()) ||
                string.IsNullOrEmpty(TbTelepon.Text.ToString()) ||
                string.IsNullOrEmpty(TbAlamat.Text.ToString()) ||
                string.IsNullOrEmpty(TbUsername.Text.ToString()) ||
                string.IsNullOrEmpty(TbPassword.Text.ToString())
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

            CbTipe.Enabled = false;
            TbNama.Enabled = false;
            TbTelepon.Enabled = false;
            TbAlamat.Enabled = false;
            TbUsername.Enabled = false;
            TbPassword.Enabled = false;
        }

        private void ToggleInputState()
        {
            BtnTambah.Visible = false;
            BtnEdit.Visible = false;
            BtnHapus.Visible = false;

            BtnSave.Visible = true;
            BtnCancel.Visible = true;

            CbTipe.Enabled = true;
            TbNama.Enabled = true;
            TbTelepon.Enabled = true;
            TbAlamat.Enabled = true;
            TbUsername.Enabled = true;
            TbPassword.Enabled = true;
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

            CbTipe.Enabled = false;
            TbNama.Enabled = false;
            TbTelepon.Enabled = false;
            TbAlamat.Enabled = false;
            TbUsername.Enabled = false;
            TbPassword.Enabled = false;
        }

        private void InsertMethod()
        {
            string query = "INSERT INTO tbl_user " +
                "(tipe_user, nama, telepon, alamat, username, password) " +
                "VALUES (@tipe_user, @nama, @telepon, @alamat, @username, @password)";

            SqlParameter[] sp =
            {
                new SqlParameter("@tipe_user", CbTipe.Text.ToString()),
                new SqlParameter("@nama", TbNama.Text.ToString()),
                new SqlParameter("@telepon", TbTelepon.Text.ToString()),
                new SqlParameter("@alamat", TbAlamat.Text.ToString()),
                new SqlParameter("@username", TbUsername.Text.ToString()),
                new SqlParameter("@password", TbPassword.Text.ToString()),
            };

            DataTable dt = DBManager.ExecuteQuery(query, sp);

            if (dt != null)
            {
                FormUtils.Msg("Berhasil memasukan data", "info");
            }
        }

        private void UpdateMethod()
        {
            string query = "UPDATE tbl_user " +
                "SET " +
                "tipe_user = @tipe_user, " +
                "nama = @nama, " +
                "telepon = @telepon, " +
                "alamat = @alamat, " +
                "username = @username, " +
                "password = @password " +
                "WHERE id_user = @id_user";

            SqlParameter[] sp =
            {
                new SqlParameter("@tipe_user", CbTipe.Text.ToString()),
                new SqlParameter("@nama", TbNama.Text.ToString()),
                new SqlParameter("@telepon", TbTelepon.Text.ToString()),
                new SqlParameter("@alamat", TbAlamat.Text.ToString()),
                new SqlParameter("@username", TbUsername.Text.ToString()),
                new SqlParameter("@password", TbPassword.Text.ToString()),
                new SqlParameter("@id_user", idUser),
            };

            DataTable dt = DBManager.ExecuteQuery(query, sp);

            if (dt != null)
            {
                FormUtils.Msg("Berhasil mengubah data", "info");
            }
        }

        private void FormUser_Load(object sender, EventArgs e)
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
                string query = "DELETE FROM tbl_user " +
                    "WHERE id_user = @id_user";

                SqlParameter[] sp =
                {
                    new SqlParameter("@id_user", idUser),
                };

                DataTable dt = DBManager.ExecuteQuery(query, sp);

                if (dt != null)
                {
                    FormUtils.Msg("Data berhasil dihapus", "info");
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
            string query = "SELECT * FROM tbl_user " +
                "WHERE username LIKE @username";

            SqlParameter[] sp =
            {
                new SqlParameter("@username", '%' + TbSearch.Text.ToString() + '%'),
            };

            DgvUser.DataSource = DBManager.ExecuteQuery(query, sp);
        }

        private void DgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridViewRow row = DgvUser.Rows[e.RowIndex];

            idUser = row.Cells[0].Value.ToString();
            CbTipe.Text = row.Cells[1].Value.ToString();
            TbNama.Text = row.Cells[2].Value.ToString();
            TbTelepon.Text = row.Cells[5].Value.ToString();
            TbAlamat.Text = row.Cells[3].Value.ToString();
            TbUsername.Text = row.Cells[4].Value.ToString();
            TbPassword.Text = row.Cells[6].Value.ToString();

            ToggleAllMethodState();
        }

        private void BtnLaporan_Click(object sender, EventArgs e)
        {
            FormAdmin.formLaporan.Show();
            Hide();
        }

        private void BtnActivity_Click(object sender, EventArgs e)
        {
            FormAdmin.formAdmin.Show();
            Hide();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            FormUtils.Logout();
            FormUtils.AddLog(FormLogin.idUser, "Logout");
        }

        private void TbTelepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormUtils.NumOnly(e);
        }

        private void FormUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormUtils.CloseApp();
        }
    }
}

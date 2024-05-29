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
    public partial class FormLogin : Form
    {
        public static FormLogin formLogin;
        public static string idUser;

        public FormLogin()
        {
            InitializeComponent();
            formLogin = this;
        }

        private bool ValidateInput()
        {
            if (
                string.IsNullOrEmpty(TbEmail.Text.ToString()) ||
                string.IsNullOrEmpty(TbPassword.Text.ToString())
                )
            {
                FormUtils.Msg("Email / Password tidak boleh kosong!", "error");
                return false;
            }

            return true;
        }

        private void Login()
        {
            if (!ValidateInput()) return;

            string query = "SELECT * FROM tbl_user " +
                "WHERE username = @username AND password = @password";

            SqlParameter[] sp =
            {
                new SqlParameter("@username", TbEmail.Text.ToString()),
                new SqlParameter("@password", TbPassword.Text.ToString()),
            };

            DataTable dt = DBManager.ExecuteQuery(query, sp);

            if (dt == null) return;
            if (dt.Rows.Count == 0)
            {
                FormUtils.Msg("Email / Password salah!", "error");
                return;
            }

            FormUtils.Msg("Berhasil login", "info");
            idUser = dt.Rows[0][0].ToString();
            string role = dt.Rows[0][1].ToString();
            string nama = dt.Rows[0][2].ToString();

            if (role == "admin")
            {
                FormAdmin formAdmin = new FormAdmin();
                formAdmin.Show();
            }
            else if (role == "gudang")
            {
                FormGudang formGudang = new FormGudang();
                formGudang.Show();
            }
            else
            {
                FormKasir formKasir = new FormKasir();
                formKasir.Show();
            }

            FormUtils.AddLog(idUser, "Login");
            Hide();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            FormUtils.ClearTBs(this);
        }
    }
}

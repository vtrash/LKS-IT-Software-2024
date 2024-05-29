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
    public partial class FormAdmin : Form
    {
        public static FormAdmin formAdmin;
        public static FormUser formUser = new FormUser();
        public static FormLaporan formLaporan = new FormLaporan();

        public FormAdmin()
        {
            InitializeComponent();
            formAdmin = this;
        }

        private void RefreshTable()
        {
            string query = "SELECT * FROM tbl_log " +
                "WHERE CONVERT(date, waktu) BETWEEN @tglAwal AND @tglAkhir";

            SqlParameter[] sp =
            {
                new SqlParameter("@tglAwal", DtAwal.Value.ToString("yyyy-MM-dd")),
                new SqlParameter("@tglAkhir", DtAkhir.Value.ToString("yyyy-MM-dd")),
            };

            DgvLog.DataSource = DBManager.ExecuteQuery(query, sp);
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            formUser.Show();
            Hide();
        }

        private void BtnLaporan_Click(object sender, EventArgs e)
        {
            formLaporan.Show();
            Hide();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            FormUtils.Logout();
            FormUtils.AddLog(FormLogin.idUser, "Logout");
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormUtils.CloseApp();
        }
    }
}

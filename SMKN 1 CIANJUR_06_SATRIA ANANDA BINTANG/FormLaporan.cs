using Microsoft.SqlServer.Server;
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
    public partial class FormLaporan : Form
    {
        public FormLaporan()
        {
            InitializeComponent();
        }

        private void RefreshTable()
        {
            string query = "SELECT a.no_transaksi, a.tgl_transaksi, a.sum(total_bayar) as total_transaksi, a.nama_kasir, b.nama " +
                "FROM tbl_transaksi a " +
                "LEFT JOIN tbl_pelanggan b on a.id_pelanggan = b.id_pelanggan " +
                "WHERE CONVERT(date, a.tgl_transaksi) BETWEEN @dtAwal AND @dtAkhir " +
                "GROUP BY a.tgl_transaksi";

            SqlParameter[] sp =
            {
                new SqlParameter("@dtAwal", DtAwal.Value.ToString("yyyy-MM-dd")),
                new SqlParameter("@dtAkhir", DtAkhir.Value.ToString("yyyy-MM-dd")),
            };

            DgvTransaksi.DataSource = DBManager.ExecuteQuery(query, sp);
        }

        private void RefreshChart()
        {
            string query = "SELECT tgl_transaksi, sum(total_bayar) as total_transaksi FROM tbl_transaksi " +
                "WHERE CONVERT(date, tgl_transaksi) BETWEEN @dtAwal AND @dtAkhir " +
                "GROUP BY tgl_transaksi";

            SqlParameter[] sp = {
                new SqlParameter("@dtAwal", DtAwal.Value.ToString("yyyy-MM-dd")),
                new SqlParameter("@dtAkhir", DtAkhir.Value.ToString("yyyy-MM-dd")),
            };

            DataTable dt = DBManager.ExecuteQuery(query, sp);

            foreach (DataRow dr in dt.Rows)
            {
                COmset.Series["Omset"].Points.AddXY((DateTime)dr["tgl_transaksi"], dr["total_transaksi"]);
            }
        }

        private void FormLaporan_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            RefreshChart();
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            FormAdmin.formUser.Show();
            Hide();
        }

        private void BtnActivity_Click(object sender, EventArgs e)
        {
            FormAdmin.formAdmin.Show();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            FormUtils.Logout();
        }

        private void FormLaporan_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormUtils.CloseApp();
        }
    }
}

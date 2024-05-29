using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace SMKN_1_CIANJUR_06_SATRIA_ANANDA_BINTANG
{
    public partial class FormKasir : Form
    {
        private string namaKasir;
        private DataTable dtMenu;
        private DataTable dtPelanggan;
        private string idPelanggan = "";
        private int totalHarga = 0;

        public PrintDocument PrintKeranjang { get; private set; }

        public FormKasir()
        {
            InitializeComponent();
        }

        private bool ValidateInput()
        {
            if (
                string.IsNullOrEmpty(CbMenu.Text.ToString()) ||
                string.IsNullOrEmpty(TbTelepon.Text.ToString()) ||
                string.IsNullOrEmpty(TbNama.Text.ToString()) ||
                string.IsNullOrEmpty(TbHarga.Text.ToString()) ||
                string.IsNullOrEmpty(TbKuantitas.Text.ToString()) ||
                string.IsNullOrEmpty(TbTotal.Text.ToString())
                )
            {
                FormUtils.Msg("Semua input wajib diisi", "error");
                return false;
            }

            DataRow menu = dtMenu.Rows[CbMenu.SelectedIndex];

            int barangQty = int.Parse(menu["jumlah_barang"].ToString());
            int keranjangQty = int.Parse(TbKuantitas.Text);

            if (barangQty < keranjangQty)
            {
                FormUtils.Msg($"Jumlah {menu["nama_barang"]} tidak mencukupi", "error");
                return false;
            }

            DateTime expiredBarang = (DateTime)menu["expired_date"];

            if (expiredBarang < DateTime.Now)
            {
                FormUtils.Msg($"{menu["nama_barang"]} sudah expired", "error");
                return false;
            }

            return true;
        }

        private void GetCashierData()
        {
            DataTable dt = DBManager.ExecuteQuery($"SELECT * FROM tbl_user WHERE id_user = {FormLogin.idUser}");
            namaKasir = dt.Rows[0][2].ToString();
        }

        private void GetPelangganData()
        {
            DataTable dt = DBManager.ExecuteQuery($"SELECT * FROM tbl_pelanggan WHERE telepon = {TbTelepon.Text}");
            idPelanggan = dt.Rows[0][0].ToString();
        }

        private void RefreshMenu()
        {

            dtMenu = DBManager.ExecuteQuery("SELECT * FROM tbl_barang");
            dtPelanggan = DBManager.ExecuteQuery("SELECT * FROM tbl_pelanggan");

            foreach (DataRow dr in dtMenu.Rows)
            {
                CbMenu.Items.Add($"{dr["kode_barang"]} - {dr["nama_barang"]}");
            }
        }

        private string LatestTransactionNum()
        {
            string query = "SELECT MAX(no_transaksi) FROM tbl_transaksi";
            DataTable dt = DBManager.ExecuteQuery(query);
            int.TryParse(dt.Rows[0].ToString(), out int prevNum);

            return $"TR{++prevNum:000}";
        }

        private void CbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow dr = dtMenu.Rows[CbMenu.SelectedIndex];
            TbHarga.Text = dr["harga_satuan"].ToString();
        }

        private void TbKuantitas_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(TbKuantitas.Text.ToString(), out int qty);
            int.TryParse(TbHarga.Text.ToString(), out int harga);
            int totalHarga = harga * qty;

            TbTotal.Text = totalHarga.ToString();
        }

        private void ToggleFirstState()
        {
            BtnBayar.Enabled = false;
            BtnPrint.Enabled = false;
            BtnSimpan.Enabled = false;

            TbBayar.Enabled = false;
        }

        private void InsertMethod()
        {
            string[] menu = CbMenu.Text.Split('-');

            string id_barang = dtMenu.Rows[CbMenu.SelectedIndex][0].ToString();
            string no_transaksi = LatestTransactionNum();
            string kode_barang = menu[0];
            string nama_barang = menu[1];
            string harga_satuan = TbHarga.Text.ToString();
            string qty = TbKuantitas.Text.ToString();
            string total_harga = TbTotal.Text.ToString();

            bool found = false;

            foreach (DataGridViewRow row in DgvKeranjang.Rows)
            {
                if (row.Cells["id_barang"].Value != null && row.Cells["id_barang"].Value.ToString() == id_barang)
                {
                    int prevQty = int.Parse(row.Cells["qty"].Value.ToString());
                    int newQty = prevQty + int.Parse(qty);
                    int newPrice = newQty * int.Parse(harga_satuan);

                    row.Cells["qty"].Value = newQty.ToString();
                    row.Cells["total_harga"].Value = newPrice.ToString();

                    found = true;
                }
            }

            if (!found)
            {
                DgvKeranjang.Rows.Add(id_barang, no_transaksi, kode_barang, nama_barang, harga_satuan, qty, total_harga);
            }

            totalHarga += int.Parse(total_harga);
            LbTotal.Text = totalHarga.ToString();

            BtnBayar.Enabled = true;
            TbBayar.Enabled = true;
        }

        private void FormKasir_Load(object sender, EventArgs e)
        {
            RefreshMenu();
            ToggleFirstState();
            LatestTransactionNum();
            GetCashierData();
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            InsertMethod();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ToggleFirstState();
            DgvKeranjang.Rows.Clear();
            LbTotal.Text = LbDisc.Text = LbKembalian.Text = "0";
        }

        private void BtnBayar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TbBayar.Text.ToString()))
            {
                FormUtils.Msg("Uang bayar tidak boleh kosong!", "error");
                return;
            }

            int.TryParse(LbTotal.Text.ToString(), out int totalHarga);
            int bayar = int.Parse(TbBayar.Text.ToString());

            int kembalian = bayar - totalHarga;

            if (kembalian < 0)
            {
                FormUtils.Msg("Uang tidak mencukupi!", "error");
                return;
            }

            FormUtils.Msg("Berhasil dibayar", "info");
            LbKembalian.Text = kembalian.ToString();

            BtnSimpan.Enabled = true;
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            string query;

            if (string.IsNullOrEmpty(idPelanggan))
            {
                query = "INSERT INTO tbl_pelanggan " +
                    "(nama, telepon) " +
                    "VALUES (@nama, @telepon)";

                SqlParameter[] sp =
                {
                    new SqlParameter("@nama", TbNama.Text.ToString()),
                    new SqlParameter("@telepon", TbTelepon.Text.ToString()),
                };

                DBManager.ExecuteQuery(query, sp);
            }

            GetPelangganData();

            query = "INSERT INTO tbl_transaksi " +
                "(no_transaksi, tgl_transaksi, nama_kasir, total_bayar, id_user, id_pelanggan, id_barang) " +
                "VALUES (@no_transaksi, @tgl_transaksi, @nama_kasir, @total_bayar, @id_user, @id_pelanggan, @id_barang)";

            foreach (DataGridViewRow row in DgvKeranjang.Rows)
            {
                SqlParameter[] sp =
                {
                    new SqlParameter("@no_transaksi", row.Cells["no_transaksi"].Value.ToString()),
                    new SqlParameter("@tgl_transaksi", DateTime.Now.ToString("yyyy-MM-dd")),
                    new SqlParameter("@nama_kasir", namaKasir),
                    new SqlParameter("@total_bayar", TbBayar.Text.ToString()),
                    new SqlParameter("@id_user", FormLogin.idUser),
                    new SqlParameter("@id_pelanggan", idPelanggan),
                    new SqlParameter("@id_barang", row.Cells["id_barang"].Value.ToString()),
                };

                DBManager.ExecuteQuery(query, sp);
            }

            BtnPrint.Enabled = true;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
            printDocument.PrintPage += printPage;
        }

        private void printPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Arial", 12);
            int xPos = 50;
            int yPos = 50;

            foreach (DataGridViewRow row in DgvKeranjang.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    //System.Drawing.Graphics.
                }
            }
        }

        private void TbTelepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormUtils.NumOnly(e);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            FormUtils.Logout();
        }

        private void FormKasir_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormUtils.CloseApp();
        }

        private void TbTelepon_TextChanged(object sender, EventArgs e)
        {
            foreach (DataRow dr in dtPelanggan.Rows)
            {
                if (dr["telepon"].ToString() == TbTelepon.Text.ToString())
                {
                    TbNama.Text = dr["nama"].ToString();
                    idPelanggan = dr["id_pelanggan"].ToString();
                    return;
                } else
                {
                    TbNama.Text = "";
                    idPelanggan = "";
                }
            }
        }
    }
}

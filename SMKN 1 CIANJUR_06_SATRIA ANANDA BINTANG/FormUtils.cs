using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMKN_1_CIANJUR_06_SATRIA_ANANDA_BINTANG
{
    internal class FormUtils
    {
        public static DialogResult Msg(string msg, string type)
        {
            if (type == "info")
            {
                MessageBox.Show(msg, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (type == "error")
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                return MessageBox.Show(msg, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            return DialogResult.None;
        }

        public static void Logout()
        {
            if (Msg("Yakin ingin logout?", "confirm") == DialogResult.Yes)
            {
                Form[] openForms = Application.OpenForms.Cast<Form>().ToArray();

                foreach (Form form in openForms)
                {
                    if (form.Name == "FormLogin")
                    {
                        form.Show();
                    }
                    else
                    {
                        form.Hide();
                    }
                }
            }
        }

        public static void CloseApp()
        {
            FormLogin.formLogin.Close();
        }

        public static void ClearTBs(Control control)
        {
            foreach (Control child in control.Controls)
            {
                if (child is TextBox tb)
                {
                    tb.Clear();
                }
                else if (child is ComboBox cb)
                {
                    cb.Text = "";
                }
            }
        }

        public static void NumOnly(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void AddLog(string idUser, string aktivitas)
        {
            string query = "INSERT INTO tbl_log " +
                "(waktu, aktivitas, id_user) " +
                "VALUES (@waktu, @aktivitas, @id_user)";

            SqlParameter[] sp =
            {
                new SqlParameter("@waktu", DateTime.Now.ToString("yyyy-MM-dd HH:mm")),
                new SqlParameter("@aktivitas", aktivitas),
                new SqlParameter("@id_user", idUser),
            };

            DBManager.ExecuteQuery(query, sp);
        }
    }
}

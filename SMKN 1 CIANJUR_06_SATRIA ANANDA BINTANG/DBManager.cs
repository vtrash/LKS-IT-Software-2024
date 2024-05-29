using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMKN_1_CIANJUR_06_SATRIA_ANANDA_BINTANG
{
    internal class DBManager
    {
        private static string connectionString = "Data Source=.;Initial Catalog=lks_mart;Integrated Security=True;TrustServerCertificate=True";

        public static DataTable ExecuteQuery(string query, SqlParameter[] ps = null)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (ps != null)
                        {
                            cmd.Parameters.AddRange(ps);
                        }
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                } catch (Exception ex)
                {
                    FormUtils.Msg("Error mengeksekusi query: " + ex.Message, "error");
                    return null;
                }
            }

            return dt;
        }
    }
}

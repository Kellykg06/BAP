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

namespace UTS_BusinessApplicationProgramming
{
    public partial class frmLaporan : Form
    {
        public frmLaporan()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            this.dgvLaporan.Rows.Clear();
            try
            {
                using (var conn = new Connection().CreateAndOpenConnection())
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = @"SELECT H.IDMenu, H.NamaMenu, H.JenisMenu, H.HargaMenu, M.Jumlah, M.Total, H.Foto FROM Menu H
                        INNER JOIN Pesanan M ON H.IDMenu = M.IDMenu ORDER BY H.IDMenu";
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {

                                    this.dgvLaporan.Rows.Add(new string[] {
                                        reader["IDMenu"].ToString(),
                                        reader["NamaMenu"].ToString(),
                                        reader["JenisMenu"].ToString(),
                                        reader["HargaMenu"].ToString(),
                                        reader["Jumlah"].ToString(),
                                        reader["Total"].ToString()
                                }); ;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLaporan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

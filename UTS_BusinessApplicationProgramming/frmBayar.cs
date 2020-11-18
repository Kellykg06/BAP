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
    public partial class frmBayar : Form
    {
        public frmBayar(string namameja)
        {
            InitializeComponent();
            lblMeja.Text = namameja;
            lblWaktu.Text = DateTime.Now.ToString();
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadData()
        {
            this.dgvDataPesanan.Rows.Clear();
            try
            {
                using (var conn = new Connection().CreateAndOpenConnection())
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = @"Select IDPesanan, IDMenu, IDMeja, NamaMenu, JenisMenu, HargaMenu, Jumlah, Total from Pesanan";
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    if (reader["IDMeja"] + "" == lblMeja.Text)
                                    {
                                        this.dgvDataPesanan.Rows.Add(new string[] {
                                        reader["IDPesanan"].ToString(),
                                        reader["NamaMenu"].ToString(),
                                        reader["HargaMenu"].ToString(),
                                        reader["Jumlah"].ToString(),
                                        reader["Total"].ToString(),
                                    }); ;
                                    }
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

        private void frmBayar_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

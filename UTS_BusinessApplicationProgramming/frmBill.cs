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
    public partial class frmBill : Form
    {
        public frmBill(string namameja)
        {
            InitializeComponent();
            lblMeja.Text = namameja;
            lblWaktu.Text = DateTime.Now.ToString("dd-mmmm-yyyy hh:mm:ss tt");
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
        private void btnTutup_CLick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            string id;
            id = lblMeja.Text; 
            var form = new frmDataMenu(id);
            form.ShowDialog();
            this.Close();
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            if (dgvDataPesanan.Rows.Count != 0)
            {
                this.Hide();
                var form = new frmBayar(lblMeja.Text);
                form.ShowDialog();
                this.Close();
                /*this.Hide();
                var form = new PrintBill();
                form.ShowDialog();*/

            }
            else
            {
                MessageBox.Show("Tidak ada pesanan!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

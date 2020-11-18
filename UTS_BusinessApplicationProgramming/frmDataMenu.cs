using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS_BusinessApplicationProgramming
{
    public partial class frmDataMenu : Form
    {
        public int IDMenu, IDPesanan, IDMeja;

        public frmDataMenu(string id)
        {
            InitializeComponent();
            lblMeja.Text = id;
            this.dgvData.AutoGenerateColumns = false;
            lblWaktu.Text = DateTime.Now.ToString("dd-mmmm-yyyy hh:mm:ss tt");
        }
        private void frmMenuAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
                LoadDataPesanan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LoadData()
        {
            this.dgvData.Rows.Clear();
            try
            {
                using (var conn = new Connection().CreateAndOpenConnection())
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = @"Select IDMenu, NamaMenu, JenisMenu, HargaMenu, Foto from Menu";
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    this.dgvData.Rows.Add(new string[] {
                                        reader["IDMenu"].ToString(),
                                        reader["NamaMenu"].ToString(),
                                        reader["JenisMenu"].ToString(),
                                        reader["HargaMenu"].ToString(),
                                        reader["Foto"].ToString(),
                                    });
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
            finally
            {
                this.dgvData_SelectionChanged(null, null);
            }
        }

        private void LoadDataPesanan()
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
                                    if(reader["IDMeja"] + "" == lblMeja.Text)
                                    {
                                        this.dgvDataPesanan.Rows.Add(new string[] {
                                        reader["IDPesanan"].ToString(),
                                        reader["IDMenu"].ToString(),
                                        reader["IDMeja"].ToString(),
                                        reader["NamaMenu"].ToString(),
                                        reader["JenisMenu"].ToString(),
                                        reader["HargaMenu"].ToString(),
                                        reader["Jumlah"].ToString(),
                                        reader["Total"].ToString(),
                                    }); ;
                                    }
                                    else
                                    {

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
            finally
            {
                this.dgvData_SelectionChanged(null, null);
            }
        }
        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                this.pictBox.Image = null;
                if (this.dgvData.CurrentRow != null)
                {
                    string pictPath = this.dgvData.CurrentRow.Cells[4].Value.ToString();
                    this.pictBox.Load(pictPath);
                }
            }
            catch (Exception)
            {
            }
        }
        private void txtJumlah_Enter_1(object sender, EventArgs e)
        {
            var control = sender as Control;
            control.BackColor = Color.FromKnownColor(KnownColor.LightCyan);
        }
        private void btnPesan_Click(object sender, EventArgs e)
        {
            if (this.txtJumlah.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, jumlah menu tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtJumlah.Focus();
            }
            else
            {
                try
                {
                    using (var conn = new Connection().CreateAndOpenConnection())
                    {
                        using (var cmd = new SqlCommand())
                        {
                            cmd.Connection = conn;
                            int harga;
                            harga = Convert.ToInt32(this.dgvData.CurrentRow.Cells[3].Value);
                            int jumlah;
                            jumlah = Convert.ToInt32(this.txtJumlah.Text);
                            int total = harga * jumlah;
                            //dgvDataPesanan.Rows.Add(this.dgvData.CurrentRow.Cells[0].Value.ToString(), this.dgvData.CurrentRow.Cells[0].Value.ToString(), this.lblMeja.Text, this.dgvData.CurrentRow.Cells[1].Value.ToString(), this.dgvData.CurrentRow.Cells[2].Value.ToString(), this.dgvData.CurrentRow.Cells[3].Value.ToString(), jumlah, total, lblWaktu.Text);
                            cmd.CommandText =
                            @"Insert Into Pesanan Values (@IDMenu, @IDMeja,
                            @NamaMenu, @JenisMenu, @HargaMenu, @Jumlah, @Total)";
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@IDMenu", this.dgvData.CurrentRow.Cells[0].Value.ToString());
                            cmd.Parameters.AddWithValue("@IDMeja", this.lblMeja.Text);
                            cmd.Parameters.AddWithValue("@NamaMenu", this.dgvData.CurrentRow.Cells[1].Value.ToString());
                            cmd.Parameters.AddWithValue("@JenisMenu", this.dgvData.CurrentRow.Cells[2].Value.ToString());
                            cmd.Parameters.AddWithValue("@HargaMenu", this.dgvData.CurrentRow.Cells[3].Value.ToString());
                            cmd.Parameters.AddWithValue("@Jumlah", jumlah);
                            cmd.Parameters.AddWithValue("@Total", total);
                            int recAffeced = cmd.ExecuteNonQuery();
                            if (recAffeced > 0)
                            {
                                this.btnBatal_Click(null, null);
                                LoadDataPesanan();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void txtJumlah_Leave(object sender, EventArgs e)
        {
            var control = sender as Control;
            control.BackColor = Color.FromKnownColor(KnownColor.Window);
        }
        private void txtJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.' || e.KeyChar == '-' || e.KeyChar == ' ' || e.KeyChar == '(' || e.KeyChar == ')') e.Handled = false;
        }
        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.dgvData_SelectionChanged(null, null);
            this.txtJumlah.Clear();
            this.pictBox.Image = null;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (this.dgvDataPesanan.CurrentRow != null)
            {
                if (MessageBox.Show("Hapus Data Ini ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var conn = new Connection().CreateAndOpenConnection())
                    {
                        using (var cmd = new SqlCommand())
                        {
                            cmd.Connection = conn;
                            try { 
                                IDPesanan = Convert.ToInt32(this.dgvDataPesanan.CurrentRow.Cells[0].Value);
                                cmd.CommandText = "DELETE Pesanan where IDPesanan = @IDPesanan";
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@NamaMenu", this.dgvDataPesanan.CurrentRow.Cells[1].Value.ToString());
                                cmd.Parameters.AddWithValue("@JenisMenu", this.dgvDataPesanan.CurrentRow.Cells[2].Value.ToString());
                                cmd.Parameters.AddWithValue("@HargaMenu", this.dgvDataPesanan.CurrentRow.Cells[3].Value.ToString());
                                cmd.Parameters.AddWithValue("@Jumlah", this.dgvDataPesanan.CurrentRow.Cells[4].Value.ToString());
                                cmd.Parameters.AddWithValue("@Total", this.dgvDataPesanan.CurrentRow.Cells[5].Value.ToString());
                                cmd.Parameters.AddWithValue("@Waktu", lblWaktu.Text);
                                cmd.Parameters.AddWithValue("@IDPesanan", this.IDPesanan);
                                int recAffeced = cmd.ExecuteNonQuery();
                                if (recAffeced > 0)
                                {
                                    this.btnBatal_Click(null, null);
                                    LoadDataPesanan();
                                }
                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

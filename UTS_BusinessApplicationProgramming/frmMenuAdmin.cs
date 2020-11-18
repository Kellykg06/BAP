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
   
    public partial class frmMenuAdmin : Form
    {
        bool _editMode = false;
        public int IDMenu;
        public frmMenuAdmin(string IDAdmin, string NamaAdmin)
        {
            InitializeComponent();
            this.IDAdmin.Text = IDAdmin;
            this.NamaAdmin.Text = NamaAdmin;
            this.dgvData.AutoGenerateColumns = false;
        }

        private void txtNama_Enter(object sender, EventArgs e)
        {
            var control = sender as Control;
            control.BackColor = Color.FromKnownColor(KnownColor.LightCyan);
        }

        private void txtNama_Leave(object sender, EventArgs e)
        {
            var control = sender as Control;
            control.BackColor = Color.FromKnownColor(KnownColor.Window);
        }

        private void txtNama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{tab}");
        }
        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.' || e.KeyChar == '-' || e.KeyChar == ' ' || e.KeyChar == '(' || e.KeyChar == ')') e.Handled = false;
        }

        private void txtJenisMenu_Enter(object sender, EventArgs e)
        {
            var control = sender as Control;
            control.BackColor = Color.FromKnownColor(KnownColor.Window);
        }

        private void txtJenisMenu_Leave(object sender, EventArgs e)
        {
            var control = sender as Control;
            control.BackColor = Color.FromKnownColor(KnownColor.Window);
        }
        private void txtJenisMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{tab}");
        }
        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Login();
            form.ShowDialog();
            this.Close();
        }
        private void btnTambahAdmin_Click(object sender, EventArgs e)
        {
            var form = new frmAddAdmin();
            form.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictBox_DoubleClick(object sender, EventArgs e)
        {
            this.loadToolStripMenuItem_Click(null, null);
        }
        private void frmMenuAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
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

        private void btnBatal_Click(object sender, EventArgs e)
        {
            _editMode = false;
            this.dgvData_SelectionChanged(null, null);
            this.txtHarga.Clear();
            this.txtNama.Clear();
            this.txtJenisMenu.Clear();

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (this.txtNama.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, nama menu tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtNama.Focus();
            }
            else if (this.txtJenisMenu.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, jenis menu tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtJenisMenu.Focus();
            }
            else if (this.txtHarga.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, harga menu tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtHarga.Focus();
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
                            if (!_editMode)
                            {
                                cmd.CommandText =
                                   @"Insert Into Menu Values (
                                    @NamaMenu, @JenisMenu, @HargaMenu, @Foto)";
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@NamaMenu", this.txtNama.Text.Trim());
                                cmd.Parameters.AddWithValue("@JenisMenu", this.txtJenisMenu.Text.Trim());
                                cmd.Parameters.AddWithValue("@HargaMenu", this.txtHarga.Text.Trim());
                                cmd.Parameters.AddWithValue("@Foto", this.pictBox.Tag?.ToString() ?? "");
                            }
                            else
                            {
                                cmd.CommandText = "UPDATE Menu SET NamaMenu = @NamaMenu, JenisMenu = @JenisMenu, HargaMenu = @HargaMenu, Foto = @Foto where IDMenu = @IDMenu";
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@NamaMenu", this.txtNama.Text.Trim());
                                cmd.Parameters.AddWithValue("@JenisMenu", this.txtJenisMenu.Text.Trim());
                                cmd.Parameters.AddWithValue("@HargaMenu", this.txtHarga.Text.Trim());
                                cmd.Parameters.AddWithValue("@Foto", this.pictBox.Tag?.ToString() ?? "");
                                cmd.Parameters.AddWithValue("@IDMenu", this.IDMenu);
                            }
                                
                            int recAffeced = cmd.ExecuteNonQuery();
                            if (recAffeced > 0)
                            {
                                this.btnBatal_Click(null, null);
                                LoadData();
                                this.pictBox.Image = null;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvData.CurrentRow != null && MessageBox.Show("Edit Data Ini ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataGridViewRow row = this.dgvData.CurrentRow;
                IDMenu = Convert.ToInt32(row.Cells[0].Value);
                this.txtNama.Text = row.Cells[1].Value.ToString();
                this.txtJenisMenu.Text = row.Cells[2].Value.ToString();
                this.txtHarga.Text = row.Cells[3].Value.ToString();
                if (File.Exists(row.Cells[4].Value?.ToString() ?? ""))
                {
                    this.pictBox.Load(row.Cells[4].Value.ToString());
                    this.pictBox.ImageLocation = row.Cells[4].Value.ToString();
                }
                this.txtNama.Focus();
                _editMode = true;
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ofd = new OpenFileDialog())
                {
                    ofd.Title = "Pilih Foto";
                    ofd.Filter = "JPG File (*.jpg)|*.jpg|PNG File (*.png)|*.png";
                    ofd.FilterIndex = 0;
                    ofd.CheckPathExists = true;
                    ofd.CheckFileExists = true;
                    ofd.Multiselect = false;
                    ofd.FileName = "";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        this.pictBox.Load(ofd.FileName);
                        this.pictBox.Tag = ofd.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (this.dgvData.CurrentRow != null)
            {
                if (MessageBox.Show("Hapus Data Ini ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var conn = new Connection().CreateAndOpenConnection())
                    {
                        using (var cmd = new SqlCommand())
                        {
                            cmd.Connection = conn;
                            try
                            {

                                DataGridViewRow row = this.dgvData.CurrentRow;
                                IDMenu = Convert.ToInt32(row.Cells[0].Value);
                                cmd.CommandText = "DELETE Menu where IDMenu = @IDMenu";
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@NamaMenu", this.txtNama.Text.Trim());
                                cmd.Parameters.AddWithValue("@JenisMenu", this.txtJenisMenu.Text.Trim());
                                cmd.Parameters.AddWithValue("@HargaMenu", this.txtHarga.Text.Trim());
                                cmd.Parameters.AddWithValue("@Foto", this.pictBox.Tag?.ToString() ?? "");
                                cmd.Parameters.AddWithValue("@IDMenu", this.IDMenu);
                                int recAffeced = cmd.ExecuteNonQuery();
                                if (recAffeced > 0)
                                {
                                    this.btnBatal_Click(null, null);
                                    LoadData();
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
        private void editDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvData.CurrentRow != null && MessageBox.Show("Edit Data Ini ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataGridViewRow row = this.dgvData.CurrentRow;
                IDMenu = Convert.ToInt32(row.Cells[0].Value);
                this.txtNama.Text = row.Cells[1].Value.ToString();
                this.txtJenisMenu.Text = row.Cells[2].Value.ToString();
                this.txtHarga.Text = row.Cells[3].Value.ToString();
                if (File.Exists(row.Cells[4].Value?.ToString() ?? ""))
                {
                    this.pictBox.Load(row.Cells[4].Value.ToString());
                    this.pictBox.ImageLocation = row.Cells[4].Value.ToString();
                }
                this.txtNama.Focus();
                _editMode = true;
            } 
        }
        private void hapusDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (this.dgvData.CurrentRow != null)
            {
                if (MessageBox.Show("Hapus Data Ini ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var conn = new Connection().CreateAndOpenConnection())
                    {
                        using (var cmd = new SqlCommand())
                        {
                            cmd.Connection = conn;
                            try
                            {

                                DataGridViewRow row = this.dgvData.CurrentRow;
                                IDMenu = Convert.ToInt32(row.Cells[0].Value);
                                cmd.CommandText = "DELETE Menu where IDMenu = @IDMenu";
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@NamaMenu", this.txtNama.Text.Trim());
                                cmd.Parameters.AddWithValue("@JenisMenu", this.txtJenisMenu.Text.Trim());
                                cmd.Parameters.AddWithValue("@HargaMenu", this.txtHarga.Text.Trim());
                                cmd.Parameters.AddWithValue("@Foto", this.pictBox.Tag?.ToString() ?? "");
                                cmd.Parameters.AddWithValue("@IDMenu", this.IDMenu);
                                int recAffeced = cmd.ExecuteNonQuery();
                                if (recAffeced > 0)
                                {
                                    this.btnBatal_Click(null, null);
                                    LoadData();
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

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            var form = new frmLaporan();
            form.ShowDialog();
            this.Close();
        }

        private void btnCetakBill_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new frmRestaurant();
            form.ShowDialog();
            this.Close();
        }
    }
}

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
    public partial class frmAddAdmin : Form
    {
        public frmAddAdmin()
        {
            InitializeComponent();
            this.dgvData.AutoGenerateColumns = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        cmd.CommandText = @"Select IDAdmin, NamaAdmin from Admin";
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    this.dgvData.Rows.Add(new string[] {
                                     reader["IDAdmin"].ToString(),
                                     reader["NamaAdmin"].ToString(),
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
        }
            private void btnSimpan_Click(object sender, EventArgs e)
            {
            if (this.txtIDAdmin.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, ID Admin tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtIDAdmin.Focus();
            }
            else if (this.txtNamaAdmin.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, Nama Admin tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNamaAdmin.Focus();
            }
            else if (this.txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, Password tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPassword.Focus();
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
                            cmd.CommandText =
                               @"Insert Into Admin Values (
                           @IDAdmin, @NamaAdmin, @Password)";
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@IDAdmin", this.txtIDAdmin.Text.Trim());
                            cmd.Parameters.AddWithValue("@NamaAdmin", this.txtNamaAdmin.Text.Trim());
                            cmd.Parameters.AddWithValue("@Password", Helper.SHA256ComputeHash(this.txtPassword.Text.Trim()));
                            int recAffeced = cmd.ExecuteNonQuery();
                            if (recAffeced > 0)
                            {
                                this.btnBatal_Click(null, null);
                                LoadData();
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

        private void frmAddAdmin_Load(object sender, EventArgs e)
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

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.txtIDAdmin.Clear();
            this.txtNamaAdmin.Clear();
            this.txtPassword.Clear();
        }

        private void lblHapus_Click(object sender, EventArgs e)
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
                                int IDAdmin = Convert.ToInt32(this.dgvData.CurrentRow.Cells[0].Value);
                                cmd.CommandText = "DELETE Admin where IDAdmin = @IDAdmin";
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@NamaAdmin", this.dgvData.CurrentRow.Cells[1].Value.ToString());
                                cmd.Parameters.AddWithValue("@IDAdmin", IDAdmin);
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
    }
}

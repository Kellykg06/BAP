namespace UTS_BusinessApplicationProgramming
{
    partial class frmMenuAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.IDAdmin = new System.Windows.Forms.Label();
            this.NamaAdmin = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.btnCetakBill = new System.Windows.Forms.Button();
            this.btnResto = new System.Windows.Forms.Button();
            this.btnTambahAdmin = new System.Windows.Forms.Button();
            this.grpData = new System.Windows.Forms.GroupBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.btnBatal = new System.Windows.Forms.Button();
            this.grpPict = new System.Windows.Forms.GroupBox();
            this.pictBox = new System.Windows.Forms.PictureBox();
            this.txtJenisMenu = new System.Windows.Forms.TextBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hapusDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grpData.SuspendLayout();
            this.grpPict.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // IDAdmin
            // 
            this.IDAdmin.AutoSize = true;
            this.IDAdmin.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDAdmin.ForeColor = System.Drawing.Color.White;
            this.IDAdmin.Location = new System.Drawing.Point(9, 11);
            this.IDAdmin.Name = "IDAdmin";
            this.IDAdmin.Size = new System.Drawing.Size(0, 21);
            this.IDAdmin.TabIndex = 0;
            // 
            // NamaAdmin
            // 
            this.NamaAdmin.AutoSize = true;
            this.NamaAdmin.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaAdmin.ForeColor = System.Drawing.Color.White;
            this.NamaAdmin.Location = new System.Drawing.Point(9, 12);
            this.NamaAdmin.Name = "NamaAdmin";
            this.NamaAdmin.Size = new System.Drawing.Size(0, 21);
            this.NamaAdmin.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(1167, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 30);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NamaAdmin);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 44);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(569, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "MENU";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.IDAdmin);
            this.panel2.Location = new System.Drawing.Point(0, 609);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1225, 44);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel3.Controls.Add(this.btnLaporan);
            this.panel3.Controls.Add(this.btnCetakBill);
            this.panel3.Controls.Add(this.btnResto);
            this.panel3.Controls.Add(this.btnTambahAdmin);
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(1095, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 567);
            this.panel3.TabIndex = 11;
            // 
            // btnLaporan
            // 
            this.btnLaporan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLaporan.FlatAppearance.BorderSize = 0;
            this.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaporan.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporan.Image = global::UTS_BusinessApplicationProgramming.Properties.Resources.iconfinder_Tilda_Icons_1ed_list_35863621;
            this.btnLaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaporan.Location = new System.Drawing.Point(3, 181);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(124, 38);
            this.btnLaporan.TabIndex = 6;
            this.btnLaporan.Text = "Laporan";
            this.btnLaporan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLaporan.UseVisualStyleBackColor = true;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // btnCetakBill
            // 
            this.btnCetakBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCetakBill.FlatAppearance.BorderSize = 0;
            this.btnCetakBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCetakBill.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCetakBill.Image = global::UTS_BusinessApplicationProgramming.Properties.Resources.iconfinder_buy_bill_money_cash_pay_2205221;
            this.btnCetakBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCetakBill.Location = new System.Drawing.Point(3, 107);
            this.btnCetakBill.Name = "btnCetakBill";
            this.btnCetakBill.Size = new System.Drawing.Size(124, 38);
            this.btnCetakBill.TabIndex = 5;
            this.btnCetakBill.Text = "Cetak Bill";
            this.btnCetakBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCetakBill.UseVisualStyleBackColor = true;
            this.btnCetakBill.Click += new System.EventHandler(this.btnCetakBill_Click);
            // 
            // btnResto
            // 
            this.btnResto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnResto.FlatAppearance.BorderSize = 0;
            this.btnResto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResto.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResto.Image = global::UTS_BusinessApplicationProgramming.Properties.Resources.iconfinder_exit_enter_leave_out_door_2931188;
            this.btnResto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResto.Location = new System.Drawing.Point(3, 511);
            this.btnResto.Name = "btnResto";
            this.btnResto.Size = new System.Drawing.Size(124, 38);
            this.btnResto.TabIndex = 4;
            this.btnResto.Text = "Keluar";
            this.btnResto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResto.UseVisualStyleBackColor = true;
            this.btnResto.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // btnTambahAdmin
            // 
            this.btnTambahAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTambahAdmin.FlatAppearance.BorderSize = 0;
            this.btnTambahAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahAdmin.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahAdmin.Image = global::UTS_BusinessApplicationProgramming.Properties.Resources.iconfinder_user_add_plus_create_admin_3209206;
            this.btnTambahAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTambahAdmin.Location = new System.Drawing.Point(3, 23);
            this.btnTambahAdmin.Name = "btnTambahAdmin";
            this.btnTambahAdmin.Size = new System.Drawing.Size(124, 61);
            this.btnTambahAdmin.TabIndex = 3;
            this.btnTambahAdmin.Text = "Tambah Admin";
            this.btnTambahAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTambahAdmin.UseVisualStyleBackColor = true;
            this.btnTambahAdmin.Click += new System.EventHandler(this.btnTambahAdmin_Click);
            // 
            // grpData
            // 
            this.grpData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpData.Controls.Add(this.txtHarga);
            this.grpData.Controls.Add(this.btnBatal);
            this.grpData.Controls.Add(this.grpPict);
            this.grpData.Controls.Add(this.txtJenisMenu);
            this.grpData.Controls.Add(this.btnHapus);
            this.grpData.Controls.Add(this.label5);
            this.grpData.Controls.Add(this.btnEdit);
            this.grpData.Controls.Add(this.txtNama);
            this.grpData.Controls.Add(this.label7);
            this.grpData.Controls.Add(this.label8);
            this.grpData.Controls.Add(this.btnTambah);
            this.grpData.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpData.Location = new System.Drawing.Point(10, 330);
            this.grpData.Margin = new System.Windows.Forms.Padding(4);
            this.grpData.Name = "grpData";
            this.grpData.Padding = new System.Windows.Forms.Padding(4);
            this.grpData.Size = new System.Drawing.Size(1075, 272);
            this.grpData.TabIndex = 7;
            this.grpData.TabStop = false;
            this.grpData.Text = "Menu";
            // 
            // txtHarga
            // 
            this.txtHarga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHarga.Location = new System.Drawing.Point(133, 132);
            this.txtHarga.Margin = new System.Windows.Forms.Padding(4);
            this.txtHarga.MaxLength = 300;
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(256, 28);
            this.txtHarga.TabIndex = 14;
            this.txtHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHarga_KeyPress);
            // 
            // btnBatal
            // 
            this.btnBatal.FlatAppearance.BorderSize = 0;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.Image = global::UTS_BusinessApplicationProgramming.Properties.Resources.iconfinder_edit_clear_232271;
            this.btnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBatal.Location = new System.Drawing.Point(264, 203);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(4);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(121, 33);
            this.btnBatal.TabIndex = 7;
            this.btnBatal.Text = " Batal";
            this.btnBatal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // grpPict
            // 
            this.grpPict.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPict.Controls.Add(this.pictBox);
            this.grpPict.Location = new System.Drawing.Point(883, 23);
            this.grpPict.Margin = new System.Windows.Forms.Padding(4);
            this.grpPict.Name = "grpPict";
            this.grpPict.Padding = new System.Windows.Forms.Padding(4);
            this.grpPict.Size = new System.Drawing.Size(171, 214);
            this.grpPict.TabIndex = 13;
            this.grpPict.TabStop = false;
            this.grpPict.Text = "Foto";
            // 
            // pictBox
            // 
            this.pictBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictBox.Location = new System.Drawing.Point(8, 23);
            this.pictBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictBox.Name = "pictBox";
            this.pictBox.Size = new System.Drawing.Size(154, 183);
            this.pictBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBox.TabIndex = 0;
            this.pictBox.TabStop = false;
            this.pictBox.DoubleClick += new System.EventHandler(this.pictBox_DoubleClick);
            // 
            // txtJenisMenu
            // 
            this.txtJenisMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJenisMenu.Location = new System.Drawing.Point(133, 83);
            this.txtJenisMenu.Margin = new System.Windows.Forms.Padding(4);
            this.txtJenisMenu.MaxLength = 50;
            this.txtJenisMenu.Name = "txtJenisMenu";
            this.txtJenisMenu.Size = new System.Drawing.Size(702, 28);
            this.txtJenisMenu.TabIndex = 4;
            this.txtJenisMenu.Enter += new System.EventHandler(this.txtJenisMenu_Enter);
            this.txtJenisMenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtJenisMenu_KeyDown);
            this.txtJenisMenu.Leave += new System.EventHandler(this.txtJenisMenu_Leave);
            // 
            // btnHapus
            // 
            this.btnHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.Image = global::UTS_BusinessApplicationProgramming.Properties.Resources.iconfinder_icons_delete_1564502;
            this.btnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHapus.Location = new System.Drawing.Point(519, 203);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(121, 33);
            this.btnHapus.TabIndex = 2;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(31, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Harga";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::UTS_BusinessApplicationProgramming.Properties.Resources.iconfinder_Edit_01_1976055;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(392, 203);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(121, 33);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtNama
            // 
            this.txtNama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNama.Location = new System.Drawing.Point(133, 33);
            this.txtNama.Margin = new System.Windows.Forms.Padding(4);
            this.txtNama.MaxLength = 300;
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(374, 28);
            this.txtNama.TabIndex = 1;
            this.txtNama.Enter += new System.EventHandler(this.txtNama_Enter);
            this.txtNama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNama_KeyDown);
            this.txtNama.Leave += new System.EventHandler(this.txtNama_Leave);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(31, 83);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Jenis Menu";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(31, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nama";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTambah
            // 
            this.btnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Image = global::UTS_BusinessApplicationProgramming.Properties.Resources.iconfinder_document_sans_add_103499__1_;
            this.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTambah.Location = new System.Drawing.Point(136, 203);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(121, 33);
            this.btnTambah.TabIndex = 0;
            this.btnTambah.Text = "Simpan";
            this.btnTambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column7,
            this.Column6,
            this.Column10});
            this.dgvData.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.Location = new System.Drawing.Point(13, 51);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.Size = new System.Drawing.Size(1078, 279);
            this.dgvData.TabIndex = 12;
            this.dgvData.SelectionChanged += new System.EventHandler(this.dgvData_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IDMenu";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nama Menu";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 350;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Jenis Menu";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 500;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Harga Menu";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 175;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Foto";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            this.Column10.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 28);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editDataToolStripMenuItem,
            this.hapusDataToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // editDataToolStripMenuItem
            // 
            this.editDataToolStripMenuItem.Name = "editDataToolStripMenuItem";
            this.editDataToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.editDataToolStripMenuItem.Text = "Edit Data";
            this.editDataToolStripMenuItem.Click += new System.EventHandler(this.editDataToolStripMenuItem_Click);
            // 
            // hapusDataToolStripMenuItem
            // 
            this.hapusDataToolStripMenuItem.Name = "hapusDataToolStripMenuItem";
            this.hapusDataToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.hapusDataToolStripMenuItem.Text = "Hapus Data";
            this.hapusDataToolStripMenuItem.Click += new System.EventHandler(this.hapusDataToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(113, 52);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // frmMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 650);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMenuAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            this.grpPict.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label IDAdmin;
        private System.Windows.Forms.Label NamaAdmin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnTambahAdmin;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnResto;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Button btnCetakBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.GroupBox grpPict;
        private System.Windows.Forms.PictureBox pictBox;
        private System.Windows.Forms.TextBox txtJenisMenu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hapusDataToolStripMenuItem;
    }
}
namespace UTS_BusinessApplicationProgramming
{
    partial class frmBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTutup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NamaAdmin = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvDataPesanan = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMeja = new System.Windows.Forms.Label();
            this.btnPesan = new System.Windows.Forms.Button();
            this.btnBayar = new System.Windows.Forms.Button();
            this.lblWaktu = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPesanan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btnTutup);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NamaAdmin);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 44);
            this.panel1.TabIndex = 11;
            // 
            // btnTutup
            // 
            this.btnTutup.BackColor = System.Drawing.Color.Transparent;
            this.btnTutup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTutup.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTutup.FlatAppearance.BorderSize = 0;
            this.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTutup.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutup.ForeColor = System.Drawing.Color.White;
            this.btnTutup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTutup.Location = new System.Drawing.Point(538, 7);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(38, 30);
            this.btnTutup.TabIndex = 13;
            this.btnTutup.Text = "X";
            this.btnTutup.UseVisualStyleBackColor = false;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_CLick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(200, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rincian Pesanan";
            // 
            // NamaAdmin
            // 
            this.NamaAdmin.AutoSize = true;
            this.NamaAdmin.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaAdmin.ForeColor = System.Drawing.Color.White;
            this.NamaAdmin.Location = new System.Drawing.Point(7, 12);
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
            this.btnClose.Location = new System.Drawing.Point(893, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 30);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // dgvDataPesanan
            // 
            this.dgvDataPesanan.AllowUserToAddRows = false;
            this.dgvDataPesanan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDataPesanan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDataPesanan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDataPesanan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDataPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataPesanan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.Column3,
            this.Column4});
            this.dgvDataPesanan.EnableHeadersVisualStyles = false;
            this.dgvDataPesanan.Location = new System.Drawing.Point(0, 111);
            this.dgvDataPesanan.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDataPesanan.MultiSelect = false;
            this.dgvDataPesanan.Name = "dgvDataPesanan";
            this.dgvDataPesanan.ReadOnly = true;
            this.dgvDataPesanan.RowHeadersWidth = 51;
            this.dgvDataPesanan.Size = new System.Drawing.Size(576, 485);
            this.dgvDataPesanan.TabIndex = 19;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "IDPesanan";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            this.Column8.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nama Menu";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Harga Satuan";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Jumlah";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total Harga";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nomor Meja : ";
            // 
            // lblMeja
            // 
            this.lblMeja.AutoSize = true;
            this.lblMeja.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeja.Location = new System.Drawing.Point(145, 69);
            this.lblMeja.Name = "lblMeja";
            this.lblMeja.Size = new System.Drawing.Size(0, 21);
            this.lblMeja.TabIndex = 22;
            // 
            // btnPesan
            // 
            this.btnPesan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesan.FlatAppearance.BorderSize = 0;
            this.btnPesan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesan.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesan.Image = global::UTS_BusinessApplicationProgramming.Properties.Resources.iconfinder_document_sans_add_103499__1_;
            this.btnPesan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesan.Location = new System.Drawing.Point(468, 603);
            this.btnPesan.Name = "btnPesan";
            this.btnPesan.Size = new System.Drawing.Size(108, 57);
            this.btnPesan.TabIndex = 20;
            this.btnPesan.Text = "Pesan";
            this.btnPesan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesan.UseVisualStyleBackColor = true;
            this.btnPesan.Click += new System.EventHandler(this.btnPesan_Click);
            // 
            // btnBayar
            // 
            this.btnBayar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBayar.FlatAppearance.BorderSize = 0;
            this.btnBayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBayar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBayar.Image = global::UTS_BusinessApplicationProgramming.Properties.Resources.iconfinder_buy_bill_money_cash_pay_2205221;
            this.btnBayar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBayar.Location = new System.Drawing.Point(0, 603);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(94, 57);
            this.btnBayar.TabIndex = 14;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBayar.UseVisualStyleBackColor = true;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // lblWaktu
            // 
            this.lblWaktu.AutoSize = true;
            this.lblWaktu.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaktu.ForeColor = System.Drawing.Color.Black;
            this.lblWaktu.Location = new System.Drawing.Point(200, 621);
            this.lblWaktu.Name = "lblWaktu";
            this.lblWaktu.Size = new System.Drawing.Size(0, 21);
            this.lblWaktu.TabIndex = 27;
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 660);
            this.Controls.Add(this.lblWaktu);
            this.Controls.Add(this.lblMeja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesan);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.dgvDataPesanan);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmBill";
            this.Load += new System.EventHandler(this.frmBill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPesanan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NamaAdmin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvDataPesanan;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.Button btnPesan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMeja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblWaktu;
    }
}
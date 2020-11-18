namespace UTS_BusinessApplicationProgramming
{
    partial class Login
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
            this.lbl = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.txtIDAdmin = new System.Windows.Forms.TextBox();
            this.txtPassAdmin = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblIDAdmin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnTamu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Black;
            this.lbl.Location = new System.Drawing.Point(200, 59);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(188, 27);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "KG\'s Restaurant";
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogIn.Location = new System.Drawing.Point(44, 244);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(500, 35);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "&Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtIDAdmin
            // 
            this.txtIDAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDAdmin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDAdmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIDAdmin.Location = new System.Drawing.Point(44, 116);
            this.txtIDAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDAdmin.Name = "txtIDAdmin";
            this.txtIDAdmin.Size = new System.Drawing.Size(500, 32);
            this.txtIDAdmin.TabIndex = 4;
            // 
            // txtPassAdmin
            // 
            this.txtPassAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassAdmin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassAdmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassAdmin.Location = new System.Drawing.Point(44, 188);
            this.txtPassAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassAdmin.Name = "txtPassAdmin";
            this.txtPassAdmin.PasswordChar = '*';
            this.txtPassAdmin.Size = new System.Drawing.Size(500, 32);
            this.txtPassAdmin.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(527, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblIDAdmin
            // 
            this.lblIDAdmin.AutoSize = true;
            this.lblIDAdmin.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDAdmin.Location = new System.Drawing.Point(44, 92);
            this.lblIDAdmin.Name = "lblIDAdmin";
            this.lblIDAdmin.Size = new System.Drawing.Size(77, 17);
            this.lblIDAdmin.TabIndex = 7;
            this.lblIDAdmin.Text = "&ID Admin : ";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(44, 167);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 17);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "&Password : ";
            // 
            // btnTamu
            // 
            this.btnTamu.Location = new System.Drawing.Point(413, 306);
            this.btnTamu.Name = "btnTamu";
            this.btnTamu.Size = new System.Drawing.Size(131, 35);
            this.btnTamu.TabIndex = 9;
            this.btnTamu.Text = "View Restaurant";
            this.btnTamu.UseVisualStyleBackColor = true;
            this.btnTamu.Click += new System.EventHandler(this.btnTamu_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.btnTamu);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblIDAdmin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtPassAdmin);
            this.Controls.Add(this.txtIDAdmin);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.lbl);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txtIDAdmin;
        private System.Windows.Forms.TextBox txtPassAdmin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblIDAdmin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnTamu;
    }
}
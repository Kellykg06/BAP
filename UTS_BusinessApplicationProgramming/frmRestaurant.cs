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
    public partial class frmRestaurant : Form
    {
        frmBill bill;
        public frmRestaurant()
        {
            InitializeComponent();
            
        }
        private void LoadData()
        {
            using (var conn = new Connection().CreateAndOpenConnection())
            {
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"Select * from Meja";
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            int x=40, y=84, ctr=0;
                            while (reader.Read())
                            {
                                Label meja = new Label();
                                meja.SetBounds(x, y, 160, 90);
                                meja.Cursor = Cursors.Hand;
                                Image img;
                                img = Image.FromFile(@"D:\UPH\Semester 7\(4) Business Application Programming\Foto Menu Makanan\Project\Meja.png");
                                Label namaMeja = new Label();
                                meja.Image = img;
                                namaMeja.SetBounds(55, 40, 50, 15);
                                namaMeja.ForeColor = Color.White;
                                namaMeja.Font = new Font("Tahoma", 9, FontStyle.Bold);
                                namaMeja.BackColor = Color.Black;
                                namaMeja.Text = "Meja " + (ctr + 1);
                                namaMeja.Tag = ctr + 1;
                                meja.Tag = ctr + 1;
                                namaMeja.Name = "     Meja : " + reader["IDMeja"] + "";
                                meja.Name = "     Meja : " + reader["IDMeja"] + "" + " ";
                                this.Controls.Add(meja);
                                meja.Controls.Add(namaMeja);
                                namaMeja.Click += L_Click;
                                meja.Click += L_Click;
                                ctr++;
                                if (ctr % 3 == 0)
                                {
                                    x = 40;
                                    y += 200;
                                }
                                else
                                {
                                    x += 250;
                                }
                            };
                        }
                    }
                }
            }
        }

        private void L_Click(object sender, EventArgs e)
        {
            string idmeja;
            string namameja;
            if(sender is Panel)
            {
                Panel meja = (Panel)sender;
                idmeja = meja.Name;
                namameja = meja.Tag + "";
            }
            else
            {
                Label meja = (Label)sender;
                idmeja = meja.Name;
                namameja = meja.Tag + "";
            }
            if (bill != null)
            {
                bill.Close();
                this.Left += 300;
            }
            bill = new frmBill(namameja);
            bill.Location = new Point(this.Left + this.Width-260, this.Top);
            bill.Show();
            this.Left -= 300;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRestaurant_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Login();
            form.ShowDialog();
            this.Close();
        }
        }
    
}

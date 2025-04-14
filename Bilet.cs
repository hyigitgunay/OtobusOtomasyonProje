using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Xml.Linq;

namespace OtobüsOtomasyonProje
{
    public partial class Bilet : Form
    {
        public Bilet()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int sayac = 0;
        public string tcNo;

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void BosKoltuklar()
        {
            sayac = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(60, 60);
                    btn.BackColor = Color.White;
                    btn.Location = new Point(i * 70, j * 70 + 150);
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    sayac++;
                    if (i == 2)
                    {
                        continue;
                    }
                    this.groupBox1.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }

          
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Name = lblKoltukNO.Text;
        }

        private void YenidenRenklendir()
        {
            foreach (Control item in this.groupBox1.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.White;
                }
            }

          
        }
        private void Bilet_Load(object sender, EventArgs e)
        {
            lblTc.Text = tcNo;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Yolcular where YolcuTc = @p1 " , bgl.baglanti());
            komut.Parameters.AddWithValue("@p1" , lblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAd.Text = dr[1].ToString();
               lblTc.Text = dr[2].ToString();
                lblCnsyt.Text = dr[3].ToString();
                lblTarih.Text = dr[4].ToString();
                lblYer.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();

            BosKoltuklar();
            YenidenRenklendir();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}

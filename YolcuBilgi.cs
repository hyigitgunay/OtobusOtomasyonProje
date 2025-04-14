using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OtobüsOtomasyonProje
{
    public partial class YolcuBilgi : Form
    {
        public YolcuBilgi()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        



        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Insert Into Tbl_Yolcular  (Id ,YolcuAdSoyad , YolcuTC , YolcuCinsiyet , SeferTarihi , SeferSaati , SeferYeri) values (@p1 , @p2 , @p3 ,@p4 ,@p5 , @p6 , @p7)", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", TxtId.Text);
            komut1.Parameters.AddWithValue("@p2", TxtAdSoyad.Text);
            komut1.Parameters.AddWithValue("@p3", TxtTc.Text);
            komut1.Parameters.AddWithValue("@p4", cmbCinsiyet.Text);
            komut1.Parameters.AddWithValue("@p5", CmbSeferTarihi.Text);
            komut1.Parameters.AddWithValue("@p6", CmbSeferSaati.Text);
            komut1.Parameters.AddWithValue("@p7", CmbSeferYeri.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();




            if (String.IsNullOrEmpty(TxtAdSoyad.Text) && String.IsNullOrEmpty(TxtId.Text) && String.IsNullOrEmpty(TxtTc.Text) && String.IsNullOrEmpty(cmbCinsiyet.Text) && String.IsNullOrEmpty(CmbSeferTarihi.Text) && String.IsNullOrEmpty(CmbSeferYeri.Text))
            {
                MessageBox.Show("Boş Alan Bırakmayınız .");
            }
            else
            {
                Bilet frm = new Bilet();
                frm.tcNo = TxtTc.Text;
                frm.ShowDialog();
                this.Close();
            }
        }

        private void TxtAdSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nereye_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("select * from Tbl_Sefer where SeferYeri = @p1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbSeferYeri.Text);
            MessageBox.Show("Uygun Olan Sefer Tarihleri Getiriliyor", "Information" , MessageBoxButtons.OK);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                CmbSeferTarihi.Items.Add(dr[1]);
                CmbSeferSaati.Items.Add(dr[2]);
            }
            bgl.baglanti().Close();



        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void YolcuBilgi_Load(object sender, EventArgs e)
        {
           

        }
    }
}

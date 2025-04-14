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
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using DataTable = System.Data.DataTable;

namespace OtobüsOtomasyonProje
{
    public partial class Araclar : Form
    {
        public Araclar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void Araclar_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Araclar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert Into Tbl_Araclar  (AracModeli , AracYılı , AracPlakası , Id) values (@p1 , @p2 , @p3 ,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.Parameters.AddWithValue("@p3", textBox3.Text);
            komut.Parameters.AddWithValue("@p4", textBox4.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Araç Eklendi !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            SqlCommand komut2 = new SqlCommand("Delete  From Tbl_Araclar where AracPlakası = @p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", textBox3.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Araç Siliniyor", "Information", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("update Tbl_Araclar set AracModeli = @p1 , AracYılı = @p2 , Id= @p4 where AracPlakası = @p3", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", textBox1.Text);
            komut3.Parameters.AddWithValue("@p2", textBox2.Text);
            komut3.Parameters.AddWithValue("@p3", textBox3.Text);
            komut3.Parameters.AddWithValue("@p4", textBox4.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Araç Güncellendi!", "Information", MessageBoxButtons.OK);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Excel uygulaması başlatıyoruz
            Excel.Application excelApp = new Excel.Application
            {
                Visible = true // Excel uygulamasını görünür hale getiriyoruz
            };

            // Yeni bir çalışma kitabı (Workbook) oluşturuyoruz
            Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
            // Yeni bir çalışma sayfası (Worksheet) ekliyoruz
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
            worksheet.Name = "Araçlar";

            // DataGridView'deki verileri Excel sayfasına aktarma
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText; // Başlıkları yazdırma
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value; // Verileri yazdırma
                }
            }
        }
    }
}

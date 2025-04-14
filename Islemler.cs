using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobüsOtomasyonProje
{
    public partial class Islemler : Form
    {
        public Islemler()
        {
            InitializeComponent();
        }

        private void Islemler_Load(object sender, EventArgs e)
        {

        }

        private void BtnBilet_Click(object sender, EventArgs e)
        {
            YolcuBilgi frm = new YolcuBilgi();
            frm.Show();
           
        }

        private void BtnCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOtobus_Click(object sender, EventArgs e)
        {
            Araclar frm = new Araclar();
            frm.Show();
      
        }

        private void BtnSefer_Click(object sender, EventArgs e)
        {
            Seferlercs frm = new Seferlercs();
            frm.Show();
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yolcular frm = new Yolcular();
            frm.Show();
         
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobüsOtomasyonProje
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=hyigitgunay;Initial Catalog=LuksArtvin;Integrated Security=True;Encrypt=False");
            baglan.Open();
            return baglan;
        }
    }
}

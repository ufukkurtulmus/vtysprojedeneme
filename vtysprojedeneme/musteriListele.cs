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

namespace vtysprojedeneme
{
    public partial class musteriListele : Form
    {
        public musteriListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8UM19B5;Initial Catalog=URUN_STOK;Integrated Security=True");
        DataSet geciciKayit = new DataSet();
        private void musteriListele_Load(object sender, EventArgs e)
        {
            kayitListele();
        }

         private void kayitListele()
        {
            baglanti.Open();
            SqlDataAdapter kayitTablosu = new SqlDataAdapter("select *from musteri", baglanti);
            kayitTablosu.Fill(geciciKayit, "musteri");
            //dataGridView1.DataSource = geciciKayit.Tables();
            baglanti.Close();


        }
    }
}

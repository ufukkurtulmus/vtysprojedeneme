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
namespace vtysprojedeneme
{
    public partial class yeniMusteri : Form
    {
        public yeniMusteri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8UM19B5;Initial Catalog=URUN_STOK;Integrated Security=True");
        private void yeniMusteri_Load(object sender, EventArgs e)
        {

                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand ac = new SqlCommand("insert into yeniMusteri(adSoyad,adres,telNo,tcNo) values(@adSoyad,@adres,@telNo,@tc)", baglanti);
            ac.Parameters.AddWithValue("@adSoyad", adSoyad.Text);
            ac.Parameters.AddWithValue("@adres", adres.Text);
            ac.Parameters.AddWithValue("@telNo", telNo.Text);
            ac.Parameters.AddWithValue("@tc", TC.Text);
            ac.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Gerçekleştirildi.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}

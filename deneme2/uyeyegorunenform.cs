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

namespace deneme2
{
    public partial class uyeyegorunenform : Form
    {
        public uyeyegorunenform()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-EIBI7O4;Initial Catalog=kutuphaneOtomasyonu;Integrated Security=True");
        DataSet data = new DataSet();

        private void button1_Click(object sender, EventArgs e)
        {
            Random ranadom = new Random();
            int sayi = ranadom.Next(1, 20);
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select kitapadi from kitap where barkodno=@barkodno", baglanti);
            cmd.Parameters.AddWithValue("@barkodno", sayi);
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                label1.Text = reader["kitapadi"].ToString();
       
            }
            baglanti.Close();
            
        }
        

        private void uyeyegorunenform_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from kitap", baglanti);
            adapter.Fill(data, "kitap");
            dataGridView1.DataSource = data.Tables["kitap"];
            baglanti.Close();
        }
    }
}

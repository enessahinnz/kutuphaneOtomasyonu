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
    public partial class emanetkitaplisteleme : Form
    {
        public emanetkitaplisteleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-EIBI7O4;Initial Catalog=kutuphaneOtomasyonu;Integrated Security=True");
        DataSet data = new DataSet();

        private void emanetkitaplisteleme_Load(object sender, EventArgs e)
        {
            
            emanetKitapListele();
            comboBox1.SelectedIndex = 1;
        }
        
        //verileri datagridview içine listeleme
        private void emanetKitapListele()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from emanetkitapbilgileri", baglanti);
            adapter.Fill(data, "emanetkitapbilgileri");
            dataGridView1.DataSource = data.Tables["emanetkitapbilgileri"];
            baglanti.Close();
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.Tables["emanetkitapbilgileri"].Clear();
            if (comboBox1.SelectedIndex==0)
            {
                emanetKitapListele();
            }else if (comboBox1.SelectedIndex == 2)
            {
                baglanti.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from emanetkitapbilgileri where '"+DateTime.Now.ToShortDateString()+"'<=iadetarihi", baglanti);
                adapter.Fill(data, "emanetkitapbilgileri");
                dataGridView1.DataSource = data.Tables["emanetkitapbilgileri"];
                baglanti.Close();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                baglanti.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from emanetkitapbilgileri where '" + DateTime.Now.ToShortDateString() + "'>iadetarihi", baglanti);
                adapter.Fill(data, "emanetkitapbilgileri");
                dataGridView1.DataSource = data.Tables["emanetkitapbilgileri"];
                baglanti.Close();
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

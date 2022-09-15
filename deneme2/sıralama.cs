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
    public partial class sıralama : Form
    {
        public sıralama()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-EIBI7O4;Initial Catalog=kutuphaneOtomasyonu;Integrated Security=True");
        DataSet data = new DataSet();
        private void sıralama_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from emanetkitapbilgileri", baglanti);
            adapter.Fill(data, "emanetkitapbilgileri");
            dataGridView1.DataSource = data.Tables["emanetkitapbilgileri"];
            baglanti.Close();
        }
    }
}

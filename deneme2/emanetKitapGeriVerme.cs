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
    public partial class emanetKitapGeriVerme : Form
    {
        public emanetKitapGeriVerme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-EIBI7O4;Initial Catalog=kutuphaneOtomasyonu;Integrated Security=True");
        DataSet data = new DataSet();

        //verileri datagridview içine listeleme
        private void emanetKitapListele()
        {
            //data.Tables["emanetkitapbilgileri"].Clear();
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from emanetkitapbilgileri", baglanti);
            adapter.Fill(data, "emanetkitapbilgileri");
            dataGridView1.DataSource = data.Tables["emanetkitapbilgileri"];
            baglanti.Close();
        }
        private void emanetKitapGeriVerme_Load(object sender, EventArgs e)
        {
            emanetKitapListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tcaratxt_TextChanged(object sender, EventArgs e)
        {
            
            data.Tables["emanetkitapbilgileri"].Clear();
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from emanetkitapbilgileri where tc like '%" + tcaratxt.Text + "%'", baglanti);
            adapter.Fill(data, "emanetkitapbilgileri");
            dataGridView1.DataSource = data.Tables["emanetkitapbilgileri"];
            baglanti.Close();
        }

        private void teslimetbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("delete from emanetkitapbilgileri where tc=@tc and barkodno=@barkodno",baglanti);
            cmd.Parameters.AddWithValue("@tc",dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
            cmd.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            cmd.ExecuteNonQuery();
            
            SqlCommand cmd2 = new SqlCommand("update kitap set stoksayisi=stoksayisi+'"+dataGridView1.CurrentRow.Cells["kitapsayisi"].Value.ToString()+"' where barkodno=@barkodno",baglanti);
            cmd2.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            cmd2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap İade edildi");
            data.Tables["emanetkitapbilgileri"].Clear();
            emanetKitapListele();
        }

        private void barkodnoarama_TextChanged(object sender, EventArgs e)
        {
            data.Tables["emanetkitapbilgileri"].Clear();
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from emanetkitapbilgileri where barkodno like '%" + barkodnoarama.Text + "%'", baglanti);
            adapter.Fill(data, "emanetkitapbilgileri");
            dataGridView1.DataSource = data.Tables["emanetkitapbilgileri"];
            baglanti.Close();
        }
    }
}

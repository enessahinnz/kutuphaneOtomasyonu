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
    public partial class KitapListelemeForm : Form
    {
        public KitapListelemeForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-EIBI7O4;Initial Catalog=kutuphaneOtomasyonu;Integrated Security=True");
        DataSet data = new DataSet();

        private void kitapListele()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from kitap", baglanti);
            adapter.Fill(data, "kitap");
            dataGridView1.DataSource = data.Tables["kitap"];
            baglanti.Close();
        }


        private void KitapListelemeForm_Load(object sender, EventArgs e)
        {
            kitapListele();
        }

        private void iptalbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update kitap set kitapadi=@kitapadi,yazaradi=@yazaradi,yayinevi=@yayinevi,sayfasayisi=@sayfasayisi,turu=@turu,stoksayisi=@stoksayisi,rafno=@rafno,aciklama=@aciklama where barkodno=@barkodno", baglanti);
            cmd.Parameters.AddWithValue("@barkodno", barkodNotxt.Text);
            cmd.Parameters.AddWithValue("@kitapadi", kitapAditxt.Text);
            cmd.Parameters.AddWithValue("@yazaradi", yazarAditxt.Text);
            cmd.Parameters.AddWithValue("@yayinevi", yayinEvitxt.Text);
            cmd.Parameters.AddWithValue("@sayfasayisi", sayfaSayisitxt.Text);
            cmd.Parameters.AddWithValue("@turu", turuCombox.Text);
            cmd.Parameters.AddWithValue("@aciklama", aciklamatxt.Text);
            cmd.Parameters.AddWithValue("@stoksayisi", stokSayisitxt.Text);
            cmd.Parameters.AddWithValue("@rafno", rafNotxt.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Gerçekleşti");
            data.Tables["kitap"].Clear();
            kitapListele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }

            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("delete from kitap where barkodno=@barkodno", baglanti);
            cmd.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme İşlemi Başarılı");
            data.Tables["kitap"].Clear();
            kitapListele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }

            }
        }

        private void isimArama_TextChanged(object sender, EventArgs e)
        {
            data.Tables["kitap"].Clear();
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from kitap where kitapadi like '%" + isimArama.Text + "%'", baglanti);
            adapter.Fill(data, "kitap");
            dataGridView1.DataSource = data.Tables["kitap"];
            baglanti.Close();
        }

        private void barkodNotxt_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from kitap where barkodno like '" + barkodNotxt.Text + "'", baglanti);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                kitapAditxt.Text = reader["kitapadi"].ToString();
                yazarAditxt.Text = reader["yazaradi"].ToString();
                yayinEvitxt.Text = reader["yayinevi"].ToString();
                sayfaSayisitxt.Text = reader["sayfasayisi"].ToString();
                turuCombox.Text = reader["turu"].ToString();
                stokSayisitxt.Text = reader["stoksayisi"].ToString();
                rafNotxt.Text = reader["rafno"].ToString();
                aciklamatxt.Text = reader["aciklama"].ToString();


            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
            uyg.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook kitap = uyg.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sayfa = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[1, i + 1];
                myRange.Value2 = dataGridView1.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[j + 2, i + 1];
                    myRange.Value2 = dataGridView1[i, j].Value;
                }
            }
        }
    }
}

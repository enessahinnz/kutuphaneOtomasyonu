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
    public partial class üyelistelemeform : Form
    {
        public üyelistelemeform()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-EIBI7O4;Initial Catalog=kutuphaneOtomasyonu;Integrated Security=True");
        DataSet data = new DataSet();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tcTextbox_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from uye_kayıt where tc like '" + tcTextbox.Text + "'", baglanti);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                adTextBox.Text = reader["ad"].ToString();
                soyadTextBox.Text = reader["soyad"].ToString();
                yasTextBox.Text = reader["yas"].ToString();
                comboBox1.Text = reader["cinsiyet"].ToString();
                telNoTextBox.Text = reader["telefon"].ToString();
                mailTextBox.Text = reader["email"].ToString();
                adresTextBox.Text = reader["adres"].ToString();

            }
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tcTextbox.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
        }
        private void uyeListele()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from uye_kayıt", baglanti);
            adapter.Fill(data, "uye_kayıt");
            dataGridView1.DataSource = data.Tables["uye_kayıt"];
            baglanti.Close();
        }
        private void silmeBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("delete from uye_kayıt where tc=@tc", baglanti);
            cmd.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme İşlemi Başarılı");
            data.Tables["uye_kayıt"].Clear();
            uyeListele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }

            }
        }

        private void üyelistelemeform_Load(object sender, EventArgs e)
        {
            uyeListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update uye_kayıt set ad=@ad,soyad=@soyad,yas=@yas,cinsiyet=@cinsiyet,telefon=@telefon,email=@email,adres=@adres,sifre=@sifre where tc=@tc", baglanti);
            cmd.Parameters.AddWithValue("@tc", tcTextbox.Text);
            cmd.Parameters.AddWithValue("@ad", adTextBox.Text);
            cmd.Parameters.AddWithValue("@soyad", soyadTextBox.Text);
            cmd.Parameters.AddWithValue("@yas", yasTextBox.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", comboBox1.Text);
            cmd.Parameters.AddWithValue("@telefon", telNoTextBox.Text);
            cmd.Parameters.AddWithValue("@email", mailTextBox.Text);
            cmd.Parameters.AddWithValue("@adres", adresTextBox.Text);
            cmd.Parameters.AddWithValue("@sifre", textBox1.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme Yapıldı");
            data.Tables["uye_kayıt"].Clear();
            uyeListele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }

            }
        }

        private void tcArama_TextChanged(object sender, EventArgs e)
        {
            data.Tables["uye_kayıt"].Clear();
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from uye_kayıt where tc like '%" + tcArama.Text + "%'", baglanti);
            adapter.Fill(data, "uye_kayıt");
            dataGridView1.DataSource = data.Tables["uye_kayıt"];
            baglanti.Close();
        }
    }
}

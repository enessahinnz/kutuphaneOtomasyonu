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
    public partial class üyeeklemeform : Form
    {
        public üyeeklemeform()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-EIBI7O4;Initial Catalog=kutuphaneOtomasyonu;Integrated Security=True");


        private void üyeeklemeform_Load(object sender, EventArgs e)
        {

        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("insert into uye_kayıt(tc,ad,soyad,yas,cinsiyet,telefon,email,adres,sifre) values (@tc,@ad,@soyad,@yas,@cinsiyet,@telefon,@email,@adres,@sifre)", baglanti);
                cmd.Parameters.AddWithValue("@tc", textBox1.Text);
                cmd.Parameters.AddWithValue("@ad", textBox2.Text);
                cmd.Parameters.AddWithValue("@soyad", textBox3.Text);
                cmd.Parameters.AddWithValue("@yas", textBox4.Text);
                cmd.Parameters.AddWithValue("@cinsiyet", comboBox1.Text);
                cmd.Parameters.AddWithValue("@telefon", textBox5.Text);
                cmd.Parameters.AddWithValue("@email", textBox7.Text);
                cmd.Parameters.AddWithValue("@adres", textBox6.Text);
                cmd.Parameters.AddWithValue("@sifre", textBox8.Text);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Edildi");

                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }

                }

            }
            else
            {
                MessageBox.Show("Üye Bilgileri Boş geçilemez");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

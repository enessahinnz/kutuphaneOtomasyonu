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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-EIBI7O4;Initial Catalog=kutuphaneOtomasyonu;Integrated Security=True");

        public string tc, sifre,admin,adminsifre;

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void uyeolbtn_Click(object sender, EventArgs e)
        {
            üyeeklemeform uyeEkleme = new üyeeklemeform();
            uyeEkleme.Show();
        }

        private void girisbtn_Click(object sender, EventArgs e)
        {
           
            baglanti.Open();

            SqlCommand cmd2 = new SqlCommand("select tc,sifre from uye_kayıt", baglanti);
            SqlDataReader reader2 = cmd2.ExecuteReader();

            while (reader2.Read())
            {
                tc = reader2["tc"].ToString();
                sifre = reader2["sifre"].ToString();

                
            }
            if (tcgiris.Text == tc.ToString() && sifregiris.Text == sifre.ToString())
            {
                uyeyegorunenform uye = new uyeyegorunenform();
                uye.Show();

            }
            baglanti.Close();

            
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select admin_name,sifre from admin", baglanti);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                admin = reader["admin_name"].ToString();
                adminsifre = reader["sifre"].ToString();

            }

           
            if (tcgiris.Text == admin.ToString() && sifregiris.Text == adminsifre.ToString())
            {
                Form1 form = new Form1();
                form.Show();

            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış");
            }

            baglanti.Close();
        }
    }
}
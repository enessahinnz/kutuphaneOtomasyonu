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
    public partial class KitapeklemeForm : Form
    {
        public KitapeklemeForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-EIBI7O4;Initial Catalog=kutuphaneOtomasyonu;Integrated Security=True");

        private void KitapeklemeForm_Load(object sender, EventArgs e)
        {

        }

        private void iptalbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            if(barkodNotxt.Text!="" && kitapAditxt.Text != "")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("insert into kitap(barkodno,kitapadi,yazaradi,yayinevi,sayfasayisi,turu,stoksayisi,rafno,aciklama,kayittarihi) values (@barkodno,@kitapadi,@yazaradi,@yayinevi,@sayfasayisi,@turu,@stoksayisi,@rafno,@aciklama,@kayittarihi)", baglanti);
                cmd.Parameters.AddWithValue("@barkodno", barkodNotxt.Text);
                cmd.Parameters.AddWithValue("@kitapadi", kitapAditxt.Text);
                cmd.Parameters.AddWithValue("@yazaradi", yazarAditxt.Text);
                cmd.Parameters.AddWithValue("@yayinevi", yayinEvitxt.Text);
                cmd.Parameters.AddWithValue("@sayfasayisi", sayfaSayisitxt.Text);
                cmd.Parameters.AddWithValue("@turu", turuCombox.Text);
                cmd.Parameters.AddWithValue("@stoksayisi", stokSayisitxt.Text);
                cmd.Parameters.AddWithValue("@aciklama", aciklamatxt.Text);
                cmd.Parameters.AddWithValue("@rafno", rafNotxt.Text);
                cmd.Parameters.AddWithValue("@kayittarihi", DateTime.Now.ToShortDateString());
                cmd.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kitap Eklendi");
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
                MessageBox.Show("Kitap Bilgileri Boş Geçilemez");
            }
            
        }
    }
}

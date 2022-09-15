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
    public partial class kitapVermeForm : Form
    {
        public kitapVermeForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-EIBI7O4;Initial Catalog=kutuphaneOtomasyonu;Integrated Security=True");
        DataSet data = new DataSet();
        private void kitapVermeForm_Load(object sender, EventArgs e)
        {
            sepetListele();
            spturunsayisi();
        }
        
        private void iptalbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //sepetteki kayıtların listelenmesi için
        private void sepetListele()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from sepet", baglanti);
            adapter.Fill(data, "sepet");
            dataGridView1.DataSource = data.Tables["sepet"];
            baglanti.Close();

            
        }

        private void sepeteklebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into sepet(barkodno,kitapadi,yazaradi,alimtarihi,iadetarihi,kitapsayisi) values (@barkodno,@kitapadi,@yazaradi,@alimtarihi,@iadetarihi,@kitapsayisi)", baglanti);
            cmd.Parameters.AddWithValue("@barkodno", barkodnotxt.Text);
            cmd.Parameters.AddWithValue("@kitapadi", kitapaditxt.Text);
            cmd.Parameters.AddWithValue("@yazaradi", yazaraditxt.Text);
            cmd.Parameters.AddWithValue("@alimtarihi", alimtarihidate.Text);
            cmd.Parameters.AddWithValue("@iadetarihi", iadetarihidate.Text);
            cmd.Parameters.AddWithValue("@kitapsayisi", int.Parse(kitapadeti.Text));
            cmd.ExecuteNonQuery();
            baglanti.Close();
            data.Tables["sepet"].Clear();
            sepetListele();
            sepet.Text = "";
            spturunsayisi();

            MessageBox.Show("Sepete Eklendi");
            foreach (Control item in kitapbilgileri.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }

            }
        }

        private void tcaratxt_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from uye_kayıt where tc like '" + tcaratxt.Text + "'", baglanti);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tcaratxt.Text = reader["tc"].ToString();
                uyeadıtxt.Text = reader["ad"].ToString();
                soyadıtxt.Text = reader["soyad"].ToString();
                yastxt.Text = reader["yas"].ToString();
                telnotxt.Text = reader["telefon"].ToString();


            }
            baglanti.Close();
            //kayıtlı kitap sayisi
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("select sum(kitapsayisi) from emanetkitapbilgileri", baglanti);
            lblKayitliKitapSayi.Text = cmd2.ExecuteScalar().ToString();
            baglanti.Close();
            if (tcaratxt.Text=="")
            {
                foreach (Control item in uyebilgileri.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                        lblKayitliKitapSayi.Text = "";

                    }

                }
            }
            
        }

        //sepeteki toplam kitap sayisi

        private void spturunsayisi()
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select sum(kitapsayisi) from sepet", baglanti);
            sepet.Text = cmd.ExecuteScalar().ToString();
            baglanti.Close();

        }


        private void barkodnotxt_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from kitap where barkodno like '" + barkodnotxt.Text + "'", baglanti);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                kitapaditxt.Text = reader["kitapadi"].ToString();
                yazaraditxt.Text = reader["yazaradi"].ToString();
                

            }
            baglanti.Close();
            if (barkodnotxt.Text == "")
            {
                foreach (Control item in kitapbilgileri.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }

                }
            }
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("delete from sepet where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme İşlemi Başarılı");
            data.Tables["sepet"].Clear();
            sepetListele();
            sepet.Text = "";
            spturunsayisi();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void teslimetbtn_Click(object sender, EventArgs e)
        {
            
            if (sepet.Text!="")
            {
                if (lblKayitliKitapSayi.Text==""&& int.Parse(sepet.Text)<=3 || lblKayitliKitapSayi.Text!="" && int.Parse(lblKayitliKitapSayi.Text)+int.Parse(sepet.Text)<=3)
                {
                    if (tcaratxt.Text!="" && uyeadıtxt.Text!=""&&soyadıtxt.Text!="" && telnotxt.Text!="" && yastxt.Text!="") 
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            baglanti.Open();
                            SqlCommand cmd = new SqlCommand("insert into emanetkitapbilgileri(tc,ad,soyad,yas,telefon,barkodno,kitapadi,yazaradi,iadetarihi,alimtarihi,kitapsayisi) values(@tc,@ad,@soyad,@yas,@telefon,@barkodno,@kitapadi,@yazaradi,@iadetarihi,@alimtarihi,@kitapsayisi)",baglanti);
                            cmd.Parameters.AddWithValue("@tc", tcaratxt.Text);
                            cmd.Parameters.AddWithValue("@ad", uyeadıtxt.Text);
                            cmd.Parameters.AddWithValue("@soyad", soyadıtxt.Text);
                            cmd.Parameters.AddWithValue("@yas", yastxt.Text);
                            cmd.Parameters.AddWithValue("@telefon", telnotxt.Text);
                            cmd.Parameters.AddWithValue("kitapsayisi", int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()));
                            cmd.Parameters.AddWithValue("barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                            cmd.Parameters.AddWithValue("kitapadi", dataGridView1.Rows[i].Cells["kitapadi"].Value.ToString());
                            cmd.Parameters.AddWithValue("yazaradi", dataGridView1.Rows[i].Cells["yazaradi"].Value.ToString());
                            cmd.Parameters.AddWithValue("iadetarihi", dataGridView1.Rows[i].Cells["iadetarihi"].Value.ToString());
                            cmd.Parameters.AddWithValue("alimtarihi", dataGridView1.Rows[i].Cells["alimtarihi"].Value.ToString());
                            cmd.ExecuteNonQuery();


         
                            SqlCommand cmd2 = new SqlCommand("update uye_kayıt set aldigikitapsayisi=aldigikitapsayisi+'" + int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()) + "'where tc='" + tcaratxt.Text.ToString() + "' ", baglanti) ;
                            cmd2.ExecuteNonQuery();

                            SqlCommand cmd3 = new SqlCommand("update kitap set stoksayisi=stoksayisi-'" + int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()) + "' where barkodno='" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "' ", baglanti);
                            cmd3.ExecuteNonQuery();

                            baglanti.Close();

                        }
                        baglanti.Open();
                        SqlCommand cmd4 = new SqlCommand("delete from sepet",baglanti);
                        cmd4.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Kitaplar Alındı");
                        data.Tables["sepet"].Clear();
                        sepetListele();
                        tcaratxt.Text = "";
                        sepet.Text = "";
                        spturunsayisi();
                        lblKayitliKitapSayi.Text = "";
                        
                    }
                    else
                    {
                        MessageBox.Show("Üye Bilgileri Boş");
                    }
                }
                else
                {
                    MessageBox.Show("En Fazla 3 Kitap Alınabilir");
                }
                
            }
            else
            {
                MessageBox.Show("Sepete Kitap Ekleyiniz");
            }




        }

        private void alimtarihidate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

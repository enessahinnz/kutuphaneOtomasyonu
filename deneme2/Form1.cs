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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-EIBI7O4;Initial Catalog=kutuphaneOtomasyonu;Integrated Security=True");
        DataSet data = new DataSet();

        public String tc, sifre;

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            üyeeklemeform uyeEkleme = new üyeeklemeform();
            uyeEkleme.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            üyelistelemeform uyeListeleme = new üyelistelemeform();

            uyeListeleme.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            KitapeklemeForm kitapekleme = new KitapeklemeForm();
            kitapekleme.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            KitapListelemeForm kitapListeleme = new KitapListelemeForm();
            kitapListeleme.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kitapVermeForm kitapVerme = new kitapVermeForm();
            kitapVerme.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            emanetkitaplisteleme emanetkitaplisteleme = new emanetkitaplisteleme();
            emanetkitaplisteleme.Show();
        }
        

        private void button6_Click(object sender, EventArgs e)
        {
            emanetKitapGeriVerme geriVerme = new emanetKitapGeriVerme();
            geriVerme.Show();
        }
        //-------------------------buton renk degişim---------------------------------------

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.MediumSeaGreen;
        }

        private void button1_MouseLeave_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }
        
       

        private void Button2_MouseEnter_1(object sender, EventArgs e)
        {
            button2.BackColor = Color.MediumSeaGreen;
        }
        
        private void button2_MouseLeave_1(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }

        private void button3_MouseEnter_1(object sender, EventArgs e)
        {
            button3.BackColor = Color.MediumSeaGreen;
        }
        
        private void button3_MouseLeave_1(object sender, EventArgs e)
        {
            button3.BackColor = Color.White;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.MediumSeaGreen;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.MediumSeaGreen;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.White;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.White;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BackColor = Color.MediumSeaGreen;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackColor = Color.MediumSeaGreen;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.White;
        }

        
    }
}


namespace deneme2
{
    partial class KitapListelemeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.isimArama = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.aciklamatxt = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iptalbtn = new System.Windows.Forms.Button();
            this.guncellebtn = new System.Windows.Forms.Button();
            this.turuCombox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rafNotxt = new System.Windows.Forms.TextBox();
            this.stokSayisitxt = new System.Windows.Forms.TextBox();
            this.sayfaSayisitxt = new System.Windows.Forms.TextBox();
            this.yayinEvitxt = new System.Windows.Forms.TextBox();
            this.yazarAditxt = new System.Windows.Forms.TextBox();
            this.kitapAditxt = new System.Windows.Forms.TextBox();
            this.barkodNotxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // isimArama
            // 
            this.isimArama.Location = new System.Drawing.Point(557, 173);
            this.isimArama.Name = "isimArama";
            this.isimArama.Size = new System.Drawing.Size(105, 20);
            this.isimArama.TabIndex = 67;
            this.isimArama.TextChanged += new System.EventHandler(this.isimArama_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(457, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 66;
            this.label10.Text = "K. İsmi ile Arama\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(457, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Açıklama";
            // 
            // aciklamatxt
            // 
            this.aciklamatxt.Location = new System.Drawing.Point(460, 22);
            this.aciklamatxt.Multiline = true;
            this.aciklamatxt.Name = "aciklamatxt";
            this.aciklamatxt.Size = new System.Drawing.Size(202, 129);
            this.aciklamatxt.TabIndex = 64;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(668, 173);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 20);
            this.btnsil.TabIndex = 63;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 284);
            this.dataGridView1.TabIndex = 62;
            // 
            // iptalbtn
            // 
            this.iptalbtn.Location = new System.Drawing.Point(668, 53);
            this.iptalbtn.Name = "iptalbtn";
            this.iptalbtn.Size = new System.Drawing.Size(91, 23);
            this.iptalbtn.TabIndex = 61;
            this.iptalbtn.Text = "İptal";
            this.iptalbtn.UseVisualStyleBackColor = true;
            this.iptalbtn.Click += new System.EventHandler(this.iptalbtn_Click);
            // 
            // guncellebtn
            // 
            this.guncellebtn.Location = new System.Drawing.Point(668, 22);
            this.guncellebtn.Name = "guncellebtn";
            this.guncellebtn.Size = new System.Drawing.Size(91, 23);
            this.guncellebtn.TabIndex = 60;
            this.guncellebtn.Text = "Güncelle";
            this.guncellebtn.UseVisualStyleBackColor = true;
            this.guncellebtn.Click += new System.EventHandler(this.guncellebtn_Click);
            // 
            // turuCombox
            // 
            this.turuCombox.FormattingEnabled = true;
            this.turuCombox.Location = new System.Drawing.Point(325, 50);
            this.turuCombox.Name = "turuCombox";
            this.turuCombox.Size = new System.Drawing.Size(116, 21);
            this.turuCombox.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "Raf No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Stok Sayısı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Türü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Sayfa Sayısı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Yayın Evi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Yazar Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Kitap Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "K. Barkod No";
            // 
            // rafNotxt
            // 
            this.rafNotxt.Location = new System.Drawing.Point(325, 131);
            this.rafNotxt.Name = "rafNotxt";
            this.rafNotxt.Size = new System.Drawing.Size(116, 20);
            this.rafNotxt.TabIndex = 50;
            // 
            // stokSayisitxt
            // 
            this.stokSayisitxt.Location = new System.Drawing.Point(325, 89);
            this.stokSayisitxt.Name = "stokSayisitxt";
            this.stokSayisitxt.Size = new System.Drawing.Size(116, 20);
            this.stokSayisitxt.TabIndex = 49;
            // 
            // sayfaSayisitxt
            // 
            this.sayfaSayisitxt.Location = new System.Drawing.Point(325, 6);
            this.sayfaSayisitxt.Name = "sayfaSayisitxt";
            this.sayfaSayisitxt.Size = new System.Drawing.Size(116, 20);
            this.sayfaSayisitxt.TabIndex = 48;
            // 
            // yayinEvitxt
            // 
            this.yayinEvitxt.Location = new System.Drawing.Point(91, 131);
            this.yayinEvitxt.Name = "yayinEvitxt";
            this.yayinEvitxt.Size = new System.Drawing.Size(116, 20);
            this.yayinEvitxt.TabIndex = 47;
            // 
            // yazarAditxt
            // 
            this.yazarAditxt.Location = new System.Drawing.Point(91, 89);
            this.yazarAditxt.Name = "yazarAditxt";
            this.yazarAditxt.Size = new System.Drawing.Size(116, 20);
            this.yazarAditxt.TabIndex = 46;
            // 
            // kitapAditxt
            // 
            this.kitapAditxt.Location = new System.Drawing.Point(91, 50);
            this.kitapAditxt.Name = "kitapAditxt";
            this.kitapAditxt.Size = new System.Drawing.Size(116, 20);
            this.kitapAditxt.TabIndex = 45;
            // 
            // barkodNotxt
            // 
            this.barkodNotxt.Location = new System.Drawing.Point(91, 6);
            this.barkodNotxt.Name = "barkodNotxt";
            this.barkodNotxt.Size = new System.Drawing.Size(116, 20);
            this.barkodNotxt.TabIndex = 44;
            this.barkodNotxt.TextChanged += new System.EventHandler(this.barkodNotxt_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 68;
            this.button1.Text = "Excel\'e Aktar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KitapListelemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 489);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.isimArama);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.aciklamatxt);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.iptalbtn);
            this.Controls.Add(this.guncellebtn);
            this.Controls.Add(this.turuCombox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rafNotxt);
            this.Controls.Add(this.stokSayisitxt);
            this.Controls.Add(this.sayfaSayisitxt);
            this.Controls.Add(this.yayinEvitxt);
            this.Controls.Add(this.yazarAditxt);
            this.Controls.Add(this.kitapAditxt);
            this.Controls.Add(this.barkodNotxt);
            this.Name = "KitapListelemeForm";
            this.Text = "KitapListelemeForm";
            this.Load += new System.EventHandler(this.KitapListelemeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox isimArama;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox aciklamatxt;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button iptalbtn;
        private System.Windows.Forms.Button guncellebtn;
        private System.Windows.Forms.ComboBox turuCombox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rafNotxt;
        private System.Windows.Forms.TextBox stokSayisitxt;
        private System.Windows.Forms.TextBox sayfaSayisitxt;
        private System.Windows.Forms.TextBox yayinEvitxt;
        private System.Windows.Forms.TextBox yazarAditxt;
        private System.Windows.Forms.TextBox kitapAditxt;
        private System.Windows.Forms.TextBox barkodNotxt;
        private System.Windows.Forms.Button button1;
    }
}
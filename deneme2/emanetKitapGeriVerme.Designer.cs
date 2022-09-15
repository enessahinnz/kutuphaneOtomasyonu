
namespace deneme2
{
    partial class emanetKitapGeriVerme
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
            this.teslimetbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tcaratxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.barkodnoarama = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // teslimetbtn
            // 
            this.teslimetbtn.Location = new System.Drawing.Point(15, 387);
            this.teslimetbtn.Name = "teslimetbtn";
            this.teslimetbtn.Size = new System.Drawing.Size(75, 23);
            this.teslimetbtn.TabIndex = 0;
            this.teslimetbtn.Text = "Teslim Et";
            this.teslimetbtn.UseVisualStyleBackColor = true;
            this.teslimetbtn.Click += new System.EventHandler(this.teslimetbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 332);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tcaratxt
            // 
            this.tcaratxt.Location = new System.Drawing.Point(75, 13);
            this.tcaratxt.Name = "tcaratxt";
            this.tcaratxt.Size = new System.Drawing.Size(106, 20);
            this.tcaratxt.TabIndex = 3;
            this.tcaratxt.TextChanged += new System.EventHandler(this.tcaratxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "T.C İle Ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Barkod No İle Ara";
            // 
            // barkodnoarama
            // 
            this.barkodnoarama.Location = new System.Drawing.Point(336, 12);
            this.barkodnoarama.Name = "barkodnoarama";
            this.barkodnoarama.Size = new System.Drawing.Size(100, 20);
            this.barkodnoarama.TabIndex = 7;
            this.barkodnoarama.TextChanged += new System.EventHandler(this.barkodnoarama_TextChanged);
            // 
            // emanetKitapGeriVerme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 432);
            this.Controls.Add(this.barkodnoarama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tcaratxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.teslimetbtn);
            this.Name = "emanetKitapGeriVerme";
            this.Text = "emanetKitapGeriVerme";
            this.Load += new System.EventHandler(this.emanetKitapGeriVerme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button teslimetbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tcaratxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox barkodnoarama;
    }
}
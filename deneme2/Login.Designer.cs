
namespace deneme2
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.uyeolbtn = new System.Windows.Forms.Button();
            this.girisbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.sifregiris = new System.Windows.Forms.TextBox();
            this.tcgiris = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uyeolbtn
            // 
            this.uyeolbtn.Location = new System.Drawing.Point(177, 128);
            this.uyeolbtn.Name = "uyeolbtn";
            this.uyeolbtn.Size = new System.Drawing.Size(75, 23);
            this.uyeolbtn.TabIndex = 11;
            this.uyeolbtn.Text = "Üye Ol";
            this.uyeolbtn.UseVisualStyleBackColor = true;
            this.uyeolbtn.Click += new System.EventHandler(this.uyeolbtn_Click);
            // 
            // girisbtn
            // 
            this.girisbtn.Location = new System.Drawing.Point(51, 128);
            this.girisbtn.Name = "girisbtn";
            this.girisbtn.Size = new System.Drawing.Size(75, 23);
            this.girisbtn.TabIndex = 10;
            this.girisbtn.Text = "Giriş";
            this.girisbtn.UseVisualStyleBackColor = true;
            this.girisbtn.Click += new System.EventHandler(this.girisbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(73, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.ımageList1;
            this.label1.Location = new System.Drawing.Point(39, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "     T.C./ Kullanıcı Adı";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "user.png");
            // 
            // sifregiris
            // 
            this.sifregiris.Location = new System.Drawing.Point(152, 86);
            this.sifregiris.Name = "sifregiris";
            this.sifregiris.PasswordChar = '*';
            this.sifregiris.Size = new System.Drawing.Size(100, 20);
            this.sifregiris.TabIndex = 7;
            // 
            // tcgiris
            // 
            this.tcgiris.Location = new System.Drawing.Point(152, 43);
            this.tcgiris.Name = "tcgiris";
            this.tcgiris.Size = new System.Drawing.Size(100, 20);
            this.tcgiris.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::deneme2.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(316, 240);
            this.Controls.Add(this.uyeolbtn);
            this.Controls.Add(this.girisbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sifregiris);
            this.Controls.Add(this.tcgiris);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uyeolbtn;
        private System.Windows.Forms.Button girisbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sifregiris;
        private System.Windows.Forms.TextBox tcgiris;
        private System.Windows.Forms.ImageList ımageList1;
    }
}
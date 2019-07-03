namespace WindowsFormsApplication2
{
    partial class girisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisForm));
            this.tcnoGiristextBox = new System.Windows.Forms.TextBox();
            this.sifreGiristextBox = new System.Windows.Forms.TextBox();
            this.yeniUye = new System.Windows.Forms.Button();
            this.sifreUnut = new System.Windows.Forms.Button();
            this.giris = new System.Windows.Forms.Button();
            this.sifre = new System.Windows.Forms.Label();
            this.tcnoGiris = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcnoGiristextBox
            // 
            this.tcnoGiristextBox.Location = new System.Drawing.Point(582, 45);
            this.tcnoGiristextBox.Name = "tcnoGiristextBox";
            this.tcnoGiristextBox.Size = new System.Drawing.Size(100, 20);
            this.tcnoGiristextBox.TabIndex = 6;
            this.tcnoGiristextBox.TextChanged += new System.EventHandler(this.tcnoGiristextBox_TextChanged);
            // 
            // sifreGiristextBox
            // 
            this.sifreGiristextBox.Location = new System.Drawing.Point(582, 85);
            this.sifreGiristextBox.Name = "sifreGiristextBox";
            this.sifreGiristextBox.PasswordChar = '*';
            this.sifreGiristextBox.Size = new System.Drawing.Size(100, 20);
            this.sifreGiristextBox.TabIndex = 7;
            this.sifreGiristextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sifreGiristextBox_KeyDown);
            this.sifreGiristextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sifreGiristextBox_KeyPress);
            // 
            // yeniUye
            // 
            this.yeniUye.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.yeniUye.Image = ((System.Drawing.Image)(resources.GetObject("yeniUye.Image")));
            this.yeniUye.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yeniUye.Location = new System.Drawing.Point(566, 183);
            this.yeniUye.Name = "yeniUye";
            this.yeniUye.Size = new System.Drawing.Size(116, 71);
            this.yeniUye.TabIndex = 3;
            this.yeniUye.Text = "YENİ\r\nÜYE";
            this.yeniUye.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.yeniUye.UseVisualStyleBackColor = true;
            this.yeniUye.Click += new System.EventHandler(this.yeniUye_Click);
            // 
            // sifreUnut
            // 
            this.sifreUnut.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.sifreUnut.Image = ((System.Drawing.Image)(resources.GetObject("sifreUnut.Image")));
            this.sifreUnut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sifreUnut.Location = new System.Drawing.Point(409, 183);
            this.sifreUnut.Name = "sifreUnut";
            this.sifreUnut.Size = new System.Drawing.Size(151, 73);
            this.sifreUnut.TabIndex = 2;
            this.sifreUnut.Text = "ŞİFREMİ\r\nUNUTTUM";
            this.sifreUnut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sifreUnut.UseVisualStyleBackColor = true;
            this.sifreUnut.Click += new System.EventHandler(this.sifreUnut_Click);
            // 
            // giris
            // 
            this.giris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.giris.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.giris.Image = ((System.Drawing.Image)(resources.GetObject("giris.Image")));
            this.giris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.giris.Location = new System.Drawing.Point(285, 183);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(118, 73);
            this.giris.TabIndex = 9;
            this.giris.Text = "GİRİŞ";
            this.giris.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.giris.UseVisualStyleBackColor = true;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.sifre.Location = new System.Drawing.Point(513, 84);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(46, 19);
            this.sifre.TabIndex = 10;
            this.sifre.Text = "Şifre:";
            // 
            // tcnoGiris
            // 
            this.tcnoGiris.AutoSize = true;
            this.tcnoGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tcnoGiris.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.tcnoGiris.Location = new System.Drawing.Point(403, 44);
            this.tcnoGiris.Name = "tcnoGiris";
            this.tcnoGiris.Size = new System.Drawing.Size(156, 19);
            this.tcnoGiris.TabIndex = 11;
            this.tcnoGiris.Text = "T.C Kimlik Numarası:\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 256);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // girisForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(714, 329);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tcnoGiris);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.sifreGiristextBox);
            this.Controls.Add(this.tcnoGiristextBox);
            this.Controls.Add(this.yeniUye);
            this.Controls.Add(this.sifreUnut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "girisForm";
            this.Text = "GİRİŞ";
            this.Load += new System.EventHandler(this.girisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tcnoGiristextBox;
        private System.Windows.Forms.TextBox sifreGiristextBox;
        private System.Windows.Forms.Button yeniUye;
        private System.Windows.Forms.Button sifreUnut;
        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.Label tcnoGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


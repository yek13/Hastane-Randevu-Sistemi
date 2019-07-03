namespace WindowsFormsApplication2
{
    partial class sifreDegisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sifreDegisForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tcnoSifreDegis = new System.Windows.Forms.Label();
            this.şifreDegis = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.yeniŞifre = new System.Windows.Forms.Label();
            this.kaydetSifre = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(252, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // tcnoSifreDegis
            // 
            this.tcnoSifreDegis.AutoSize = true;
            this.tcnoSifreDegis.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcnoSifreDegis.Location = new System.Drawing.Point(59, 212);
            this.tcnoSifreDegis.Name = "tcnoSifreDegis";
            this.tcnoSifreDegis.Size = new System.Drawing.Size(156, 19);
            this.tcnoSifreDegis.TabIndex = 9;
            this.tcnoSifreDegis.Text = "T.C Kimlik Numarası:";
            // 
            // şifreDegis
            // 
            this.şifreDegis.AutoSize = true;
            this.şifreDegis.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.şifreDegis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.şifreDegis.Location = new System.Drawing.Point(232, 57);
            this.şifreDegis.Name = "şifreDegis";
            this.şifreDegis.Size = new System.Drawing.Size(176, 24);
            this.şifreDegis.TabIndex = 8;
            this.şifreDegis.Text = "ŞİFRE DEĞİŞTİR";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(252, 284);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 14;
            // 
            // yeniŞifre
            // 
            this.yeniŞifre.AutoSize = true;
            this.yeniŞifre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.yeniŞifre.Location = new System.Drawing.Point(59, 285);
            this.yeniŞifre.Name = "yeniŞifre";
            this.yeniŞifre.Size = new System.Drawing.Size(78, 19);
            this.yeniŞifre.TabIndex = 13;
            this.yeniŞifre.Text = "Yeni Şifre:";
            // 
            // kaydetSifre
            // 
            this.kaydetSifre.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.kaydetSifre.Image = ((System.Drawing.Image)(resources.GetObject("kaydetSifre.Image")));
            this.kaydetSifre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kaydetSifre.Location = new System.Drawing.Point(62, 360);
            this.kaydetSifre.Name = "kaydetSifre";
            this.kaydetSifre.Size = new System.Drawing.Size(143, 69);
            this.kaydetSifre.TabIndex = 15;
            this.kaydetSifre.Text = "KAYDET";
            this.kaydetSifre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kaydetSifre.UseVisualStyleBackColor = true;
            this.kaydetSifre.Click += new System.EventHandler(this.kaydetSifre_Click);
            // 
            // geri
            // 
            this.geri.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geri.Image = ((System.Drawing.Image)(resources.GetObject("geri.Image")));
            this.geri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.geri.Location = new System.Drawing.Point(252, 360);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(100, 69);
            this.geri.TabIndex = 16;
            this.geri.Text = "GERİ";
            this.geri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 130);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 18;
            // 
            // sifreDegisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(524, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.kaydetSifre);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.yeniŞifre);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tcnoSifreDegis);
            this.Controls.Add(this.şifreDegis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "sifreDegisForm";
            this.Text = "ŞİFRE DEĞİŞTİR";
            this.Load += new System.EventHandler(this.sifreDegisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label tcnoSifreDegis;
        private System.Windows.Forms.Label şifreDegis;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label yeniŞifre;
        private System.Windows.Forms.Button kaydetSifre;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
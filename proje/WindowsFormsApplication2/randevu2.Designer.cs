namespace WindowsFormsApplication2
{
    partial class randevu2Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(randevu2Form));
            this.onbirbucuk = new System.Windows.Forms.Button();
            this.on = new System.Windows.Forms.Button();
            this.randevugoruntule = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.dokuz = new System.Windows.Forms.Button();
            this.sekiz = new System.Windows.Forms.Button();
            this.saat = new System.Windows.Forms.Label();
            this.tarih = new System.Windows.Forms.Label();
            this.kaydetRandevu = new System.Windows.Forms.Button();
            this.onalti = new System.Windows.Forms.Button();
            this.onbes = new System.Windows.Forms.Button();
            this.ondort = new System.Windows.Forms.Button();
            this.onuc = new System.Windows.Forms.Button();
            this.onikibucuk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblsaat = new System.Windows.Forms.Label();
            this.onbir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // onbirbucuk
            // 
            this.onbirbucuk.BackColor = System.Drawing.Color.Green;
            this.onbirbucuk.Location = new System.Drawing.Point(217, 103);
            this.onbirbucuk.Name = "onbirbucuk";
            this.onbirbucuk.Size = new System.Drawing.Size(69, 23);
            this.onbirbucuk.TabIndex = 51;
            this.onbirbucuk.Tag = "rsaati";
            this.onbirbucuk.Text = "11:30";
            this.onbirbucuk.UseVisualStyleBackColor = false;
            this.onbirbucuk.Click += new System.EventHandler(this.onbirbucuk_Click);
            // 
            // on
            // 
            this.on.BackColor = System.Drawing.Color.Green;
            this.on.Location = new System.Drawing.Point(292, 74);
            this.on.Name = "on";
            this.on.Size = new System.Drawing.Size(66, 23);
            this.on.TabIndex = 50;
            this.on.Tag = "rsaati";
            this.on.Text = "10:00";
            this.on.UseVisualStyleBackColor = false;
            this.on.Click += new System.EventHandler(this.on_Click);
            // 
            // randevugoruntule
            // 
            this.randevugoruntule.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.randevugoruntule.Image = ((System.Drawing.Image)(resources.GetObject("randevugoruntule.Image")));
            this.randevugoruntule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.randevugoruntule.Location = new System.Drawing.Point(211, 204);
            this.randevugoruntule.Name = "randevugoruntule";
            this.randevugoruntule.Size = new System.Drawing.Size(180, 83);
            this.randevugoruntule.TabIndex = 49;
            this.randevugoruntule.Text = "RANDEVU\r\nGÖRÜNTÜLE";
            this.randevugoruntule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.randevugoruntule.UseVisualStyleBackColor = true;
            this.randevugoruntule.Click += new System.EventHandler(this.randevugoruntule_Click);
            // 
            // geri
            // 
            this.geri.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.geri.Image = ((System.Drawing.Image)(resources.GetObject("geri.Image")));
            this.geri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.geri.Location = new System.Drawing.Point(400, 204);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(101, 83);
            this.geri.TabIndex = 48;
            this.geri.Text = "GERİ";
            this.geri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // dokuz
            // 
            this.dokuz.BackColor = System.Drawing.Color.Green;
            this.dokuz.Location = new System.Drawing.Point(217, 74);
            this.dokuz.Name = "dokuz";
            this.dokuz.Size = new System.Drawing.Size(69, 23);
            this.dokuz.TabIndex = 47;
            this.dokuz.Tag = "rsaati";
            this.dokuz.Text = "09:00";
            this.dokuz.UseVisualStyleBackColor = false;
            this.dokuz.Click += new System.EventHandler(this.dokuz_Click);
            // 
            // sekiz
            // 
            this.sekiz.BackColor = System.Drawing.Color.Green;
            this.sekiz.Location = new System.Drawing.Point(145, 74);
            this.sekiz.Name = "sekiz";
            this.sekiz.Size = new System.Drawing.Size(66, 23);
            this.sekiz.TabIndex = 46;
            this.sekiz.Tag = "rsaati";
            this.sekiz.Text = "08:00";
            this.sekiz.UseVisualStyleBackColor = false;
            this.sekiz.Click += new System.EventHandler(this.sekiz_Click);
            // 
            // saat
            // 
            this.saat.AutoSize = true;
            this.saat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.saat.Location = new System.Drawing.Point(90, 74);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(44, 19);
            this.saat.TabIndex = 45;
            this.saat.Text = "Saat:";
            // 
            // tarih
            // 
            this.tarih.AutoSize = true;
            this.tarih.Location = new System.Drawing.Point(-34, 22);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(34, 13);
            this.tarih.TabIndex = 43;
            this.tarih.Text = "Tarih:";
            // 
            // kaydetRandevu
            // 
            this.kaydetRandevu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.kaydetRandevu.Image = ((System.Drawing.Image)(resources.GetObject("kaydetRandevu.Image")));
            this.kaydetRandevu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kaydetRandevu.Location = new System.Drawing.Point(72, 204);
            this.kaydetRandevu.Name = "kaydetRandevu";
            this.kaydetRandevu.Size = new System.Drawing.Size(133, 83);
            this.kaydetRandevu.TabIndex = 42;
            this.kaydetRandevu.Text = "KAYDET";
            this.kaydetRandevu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kaydetRandevu.UseVisualStyleBackColor = true;
            this.kaydetRandevu.Click += new System.EventHandler(this.kaydetRandevu_Click);
            // 
            // onalti
            // 
            this.onalti.BackColor = System.Drawing.Color.Green;
            this.onalti.Location = new System.Drawing.Point(145, 161);
            this.onalti.Name = "onalti";
            this.onalti.Size = new System.Drawing.Size(66, 23);
            this.onalti.TabIndex = 41;
            this.onalti.Tag = "rsaati";
            this.onalti.Text = "16:00";
            this.onalti.UseVisualStyleBackColor = false;
            this.onalti.Click += new System.EventHandler(this.onalti_Click);
            // 
            // onbes
            // 
            this.onbes.BackColor = System.Drawing.Color.Green;
            this.onbes.Location = new System.Drawing.Point(292, 132);
            this.onbes.Name = "onbes";
            this.onbes.Size = new System.Drawing.Size(66, 23);
            this.onbes.TabIndex = 40;
            this.onbes.Tag = "rsaati";
            this.onbes.Text = "15:00";
            this.onbes.UseVisualStyleBackColor = false;
            this.onbes.Click += new System.EventHandler(this.onbes_Click);
            // 
            // ondort
            // 
            this.ondort.BackColor = System.Drawing.Color.Green;
            this.ondort.Location = new System.Drawing.Point(217, 132);
            this.ondort.Name = "ondort";
            this.ondort.Size = new System.Drawing.Size(69, 23);
            this.ondort.TabIndex = 39;
            this.ondort.Tag = "rsaati";
            this.ondort.Text = "14:00";
            this.ondort.UseVisualStyleBackColor = false;
            this.ondort.Click += new System.EventHandler(this.ondort_Click);
            // 
            // onuc
            // 
            this.onuc.BackColor = System.Drawing.Color.Green;
            this.onuc.Location = new System.Drawing.Point(145, 132);
            this.onuc.Name = "onuc";
            this.onuc.Size = new System.Drawing.Size(66, 23);
            this.onuc.TabIndex = 38;
            this.onuc.Tag = "rsaati";
            this.onuc.Text = "13:00";
            this.onuc.UseVisualStyleBackColor = false;
            this.onuc.Click += new System.EventHandler(this.onuc_Click);
            // 
            // onikibucuk
            // 
            this.onikibucuk.BackColor = System.Drawing.Color.Green;
            this.onikibucuk.Location = new System.Drawing.Point(292, 103);
            this.onikibucuk.Name = "onikibucuk";
            this.onikibucuk.Size = new System.Drawing.Size(66, 23);
            this.onikibucuk.TabIndex = 37;
            this.onikibucuk.Tag = "rsaati";
            this.onikibucuk.Text = "12:30";
            this.onikibucuk.UseVisualStyleBackColor = false;
            this.onikibucuk.Click += new System.EventHandler(this.onikibucuk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(451, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 52;
            this.label1.Text = "DOKTOR";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 28);
            this.dateTimePicker1.MinDate = new System.DateTime(2016, 10, 12, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 20);
            this.dateTimePicker1.TabIndex = 53;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblsaat
            // 
            this.lblsaat.AutoSize = true;
            this.lblsaat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblsaat.Location = new System.Drawing.Point(452, 84);
            this.lblsaat.Name = "lblsaat";
            this.lblsaat.Size = new System.Drawing.Size(49, 19);
            this.lblsaat.TabIndex = 54;
            this.lblsaat.Text = "SAAT";
            // 
            // onbir
            // 
            this.onbir.BackColor = System.Drawing.Color.Green;
            this.onbir.Location = new System.Drawing.Point(145, 103);
            this.onbir.Name = "onbir";
            this.onbir.Size = new System.Drawing.Size(66, 23);
            this.onbir.TabIndex = 55;
            this.onbir.Tag = "rsaati";
            this.onbir.Text = "11:00";
            this.onbir.UseVisualStyleBackColor = false;
            this.onbir.Click += new System.EventHandler(this.onbir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(90, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 56;
            this.label2.Text = "Tarih:";
            // 
            // randevu2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(631, 326);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.onbir);
            this.Controls.Add(this.lblsaat);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.onbirbucuk);
            this.Controls.Add(this.on);
            this.Controls.Add(this.randevugoruntule);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.dokuz);
            this.Controls.Add(this.sekiz);
            this.Controls.Add(this.saat);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.kaydetRandevu);
            this.Controls.Add(this.onalti);
            this.Controls.Add(this.onbes);
            this.Controls.Add(this.ondort);
            this.Controls.Add(this.onuc);
            this.Controls.Add(this.onikibucuk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "randevu2Form";
            this.Text = "RANDEVU";
            this.Load += new System.EventHandler(this.randevu2Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button onbirbucuk;
        private System.Windows.Forms.Button on;
        private System.Windows.Forms.Button randevugoruntule;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Button dokuz;
        private System.Windows.Forms.Button sekiz;
        private System.Windows.Forms.Label saat;
        private System.Windows.Forms.Label tarih;
        private System.Windows.Forms.Button kaydetRandevu;
        private System.Windows.Forms.Button onalti;
        private System.Windows.Forms.Button onbes;
        private System.Windows.Forms.Button ondort;
        private System.Windows.Forms.Button onuc;
        private System.Windows.Forms.Button onikibucuk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblsaat;
        private System.Windows.Forms.Button onbir;
        private System.Windows.Forms.Label label2;
    }
}
namespace WindowsFormsApplication2
{
    partial class randevuGoruntuleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(randevuGoruntuleForm));
            this.label1 = new System.Windows.Forms.Label();
            this.randevuSil = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.göster = new System.Windows.Forms.Button();
            this.TC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(99, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "RANDEVULAR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // randevuSil
            // 
            this.randevuSil.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.randevuSil.Image = ((System.Drawing.Image)(resources.GetObject("randevuSil.Image")));
            this.randevuSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.randevuSil.Location = new System.Drawing.Point(243, 339);
            this.randevuSil.Name = "randevuSil";
            this.randevuSil.Size = new System.Drawing.Size(160, 56);
            this.randevuSil.TabIndex = 9;
            this.randevuSil.Text = "RANDEVU\r\nSİL";
            this.randevuSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.randevuSil.UseVisualStyleBackColor = true;
            this.randevuSil.Click += new System.EventHandler(this.randevuSil_Click);
            // 
            // geri
            // 
            this.geri.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.geri.Image = ((System.Drawing.Image)(resources.GetObject("geri.Image")));
            this.geri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.geri.Location = new System.Drawing.Point(592, 340);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(101, 56);
            this.geri.TabIndex = 49;
            this.geri.Text = "GERİ";
            this.geri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(663, 235);
            this.dataGridView1.TabIndex = 52;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(603, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 20);
            this.textBox1.TabIndex = 53;
            // 
            // göster
            // 
            this.göster.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.göster.Image = ((System.Drawing.Image)(resources.GetObject("göster.Image")));
            this.göster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.göster.Location = new System.Drawing.Point(699, 98);
            this.göster.Name = "göster";
            this.göster.Size = new System.Drawing.Size(135, 56);
            this.göster.TabIndex = 54;
            this.göster.Text = "GÖSTER";
            this.göster.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.göster.UseVisualStyleBackColor = true;
            this.göster.Click += new System.EventHandler(this.göster_Click);
            // 
            // TC
            // 
            this.TC.AutoSize = true;
            this.TC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.TC.Location = new System.Drawing.Point(560, 71);
            this.TC.Name = "TC";
            this.TC.Size = new System.Drawing.Size(30, 19);
            this.TC.TabIndex = 55;
            this.TC.Text = "TC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(26, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 57);
            this.label2.TabIndex = 56;
            this.label2.Text = "İSTEDİĞİNİZ SAATE\r\nTABLODA TIKLAYARAK\r\nBUTONLA SİLEBİLİRSİNİZ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 65);
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // randevuGoruntuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(887, 426);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TC);
            this.Controls.Add(this.göster);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.randevuSil);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "randevuGoruntuleForm";
            this.Text = "RANDEVU GÖRÜNTÜLE";
            this.Load += new System.EventHandler(this.randevuGoruntuleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button randevuSil;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button göster;
        private System.Windows.Forms.Label TC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
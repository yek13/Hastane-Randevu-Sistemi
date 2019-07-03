namespace WindowsFormsApplication2
{
    partial class randevuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(randevuForm));
            this.doktorcomBox = new System.Windows.Forms.ComboBox();
            this.randevual = new System.Windows.Forms.Button();
            this.doktor = new System.Windows.Forms.Label();
            this.klinik = new System.Windows.Forms.Label();
            this.klinikcombox = new System.Windows.Forms.ComboBox();
            this.geri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doktorcomBox
            // 
            this.doktorcomBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doktorcomBox.FormattingEnabled = true;
            this.doktorcomBox.Location = new System.Drawing.Point(175, 86);
            this.doktorcomBox.Name = "doktorcomBox";
            this.doktorcomBox.Size = new System.Drawing.Size(121, 21);
            this.doktorcomBox.TabIndex = 16;
            this.doktorcomBox.SelectedIndexChanged += new System.EventHandler(this.doktorcomBox_SelectedIndexChanged);
            // 
            // randevual
            // 
            this.randevual.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.randevual.Image = global::WindowsFormsApplication2.Properties.Resources.appointment_book;
            this.randevual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.randevual.Location = new System.Drawing.Point(73, 166);
            this.randevual.Name = "randevual";
            this.randevual.Size = new System.Drawing.Size(151, 68);
            this.randevual.TabIndex = 22;
            this.randevual.Text = "RANDEVU\r\nAL";
            this.randevual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.randevual.UseVisualStyleBackColor = true;
            this.randevual.Click += new System.EventHandler(this.randevual_Click);
            // 
            // doktor
            // 
            this.doktor.AutoSize = true;
            this.doktor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.doktor.Location = new System.Drawing.Point(104, 88);
            this.doktor.Name = "doktor";
            this.doktor.Size = new System.Drawing.Size(57, 19);
            this.doktor.TabIndex = 31;
            this.doktor.Text = "Doktor";
            this.doktor.Click += new System.EventHandler(this.doktor_Click);
            // 
            // klinik
            // 
            this.klinik.AutoSize = true;
            this.klinik.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.klinik.Location = new System.Drawing.Point(104, 45);
            this.klinik.Name = "klinik";
            this.klinik.Size = new System.Drawing.Size(50, 19);
            this.klinik.TabIndex = 33;
            this.klinik.Text = "Klinik";
            // 
            // klinikcombox
            // 
            this.klinikcombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.klinikcombox.FormattingEnabled = true;
            this.klinikcombox.Location = new System.Drawing.Point(175, 43);
            this.klinikcombox.Name = "klinikcombox";
            this.klinikcombox.Size = new System.Drawing.Size(121, 21);
            this.klinikcombox.TabIndex = 34;
            this.klinikcombox.SelectedIndexChanged += new System.EventHandler(this.klnikcombox_SelectedIndexChanged);
            // 
            // geri
            // 
            this.geri.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.geri.Image = ((System.Drawing.Image)(resources.GetObject("geri.Image")));
            this.geri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.geri.Location = new System.Drawing.Point(240, 166);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(101, 68);
            this.geri.TabIndex = 40;
            this.geri.Text = "GERİ";
            this.geri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // randevuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(450, 285);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.klinikcombox);
            this.Controls.Add(this.klinik);
            this.Controls.Add(this.doktor);
            this.Controls.Add(this.randevual);
            this.Controls.Add(this.doktorcomBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "randevuForm";
            this.Text = "RANDEVU";
            this.Load += new System.EventHandler(this.randevuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox doktorcomBox;
        private System.Windows.Forms.Button randevual;
        private System.Windows.Forms.Label doktor;
        private System.Windows.Forms.Label klinik;
        private System.Windows.Forms.ComboBox klinikcombox;
        private System.Windows.Forms.Button geri;
    }
}
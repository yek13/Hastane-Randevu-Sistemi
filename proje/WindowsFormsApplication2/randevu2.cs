using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class randevu2Form : Form
    {
        public randevu2Form()
        {
            InitializeComponent();
        }

        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        private void geri_Click(object sender, EventArgs e)
        {
            randevuForm geri = new randevuForm();
            geri.Show();
            this.Hide();
        }
        DateTime dt;
        private void kaydetRandevu_Click(object sender, EventArgs e)
        {

            

           
           OleDbConnection con1 = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=veritabani.accdb");
           
            con1.Open();
            OleDbCommand komut = new OleDbCommand("Insert into listele(uye_tc,klinik_adi,doktor_adi_soyadi,randevutarih,randevusaat)Values(@tc,@klink,@doktor,@tarih,@saat)", con1);
            komut.Parameters.AddWithValue("@tc", (girisForm.uye_tc.ToString()));
            komut.Parameters.AddWithValue("@klink", randevuForm.klinik_adi);
            komut.Parameters.AddWithValue("@doktor", randevuForm.doktor_adi_soyadi);
            komut.Parameters.AddWithValue("@tarih", dateTimePicker1.Value.ToShortDateString());
            komut.Parameters.AddWithValue("@saat", lblsaat.Text);
            komut.ExecuteNonQuery();
            con1.Close();
            kaydetRandevu.Visible = false;
            randevugoruntule.Visible = true;
        
        }

        private void randevugoruntule_Click(object sender, EventArgs e)
        {
            randevuGoruntuleForm randevugor = new randevuGoruntuleForm();
            randevugor.Show();
            this.Hide();
        }
        public  void RandevuAlAction(Button btnRef)
        {
            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    try
                    {
                        if (item.Tag.ToString() != null && item.Tag.ToString() == "rsaati")
                        {
                            if (btnRef.Text==item.Text)
                            {
                                if (btnRef.BackColor == Color.Red)
                                {
                                    ((Button)btnRef).BackColor = Color.Green;
                                }
                                else if (btnRef.BackColor == Color.Green)
                                {
                                    ((Button)btnRef).BackColor = Color.Red;
                                }
                                lblsaat.Text = btnRef.Text.ToString();

                            }
                            else if (btnRef.Text!=item.Text)
                            {
                                if (item.BackColor != Color.Gray)
                                {
                                    ((Button)item).BackColor = Color.Green;
                                }
                                
                            }
                            
                        }
                    }
                    catch (Exception)
                    {
                        
                    }
                }
            }
        }
      
        public void GuncelRandevular()
        {
            OleDbConnection con1 = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=veritabani.accdb");
            con1.Open();
            OleDbCommand komut = new OleDbCommand("Select*from listele where doktor_adi_soyadi=@doktor and randevutarih=@tarih", con1);
            komut.Parameters.AddWithValue("@doktor", randevuForm.doktor_adi_soyadi);
            komut.Parameters.AddWithValue("@tarih", dateTimePicker1.Value.ToShortDateString());
            OleDbDataReader okuyucu = komut.ExecuteReader();
            
            while (okuyucu.Read())
            {
                string saat=(okuyucu["randevusaat"].ToString());
                foreach (Control item in this.Controls)
                {
                    if (item.Text == saat)
                    {
                        ((Button)item).BackColor = Color.Gray;
                        ((Button)item).Enabled = false;
                    }
                    else continue;
                }
            }
           
            con1.Close();
        }
        private void randevu2Form_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now.AddDays(1);
            dateTimePicker1.Value = dateTimePicker1.MinDate;
            GuncelRandevular();

            label1.Text=(randevuForm.secilenDoktorVerisi.ToString());
            string secilenDoktor = randevuForm.secilenDoktorVerisi.ToString();
            string doktorID = secilenDoktor.Remove(0, secilenDoktor.IndexOf("[")).Replace("[","").Replace("]","");
     
            randevugoruntule.Visible = false;

            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=veritabani.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Randevu where DoktorID=@d;";
            string tarihVerisi = string.Format("{0}", dateTimePicker1.Value.ToShortDateString());

            cmd.Parameters.AddWithValue("@d", int.Parse(doktorID));
            dr = cmd.ExecuteReader();
           
                con.Close();
        }

      

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
             
        }

        private void sekiz_Click(object sender, EventArgs e)
        {
          
            RandevuAlAction(sekiz);

        }

        private void dokuz_Click(object sender, EventArgs e)
        {
            
            RandevuAlAction(dokuz);
        }

        private void on_Click(object sender, EventArgs e)
        {
           
            RandevuAlAction(on);
        }

        private void onbir_Click(object sender, EventArgs e)
        {
        
            RandevuAlAction(onbir);
        }

        private void onbirbucuk_Click(object sender, EventArgs e)
        {
            
            RandevuAlAction(onbirbucuk);
        }

        private void onikibucuk_Click(object sender, EventArgs e)
        {
            RandevuAlAction(onikibucuk);
        }

        private void onuc_Click(object sender, EventArgs e)
        {
            
            RandevuAlAction(onuc);

        }

        private void ondort_Click(object sender, EventArgs e)
        {
            
            RandevuAlAction(ondort);
        }

        private void onbes_Click(object sender, EventArgs e)
        {
            RandevuAlAction(onbes);
        }

        private void onalti_Click(object sender, EventArgs e)
        {
            RandevuAlAction(onalti);
        }

       

    }
}

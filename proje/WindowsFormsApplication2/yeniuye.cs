using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace WindowsFormsApplication2
{
    public partial class yeniUyeForm : Form
    {
        public yeniUyeForm()
        {
            InitializeComponent();
        }

        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
  
        private void yeniuye_Load(object sender, EventArgs e)
        {

        }
        public static string cinsiyett;
        private void kaydetYeniUye_Click(object sender, EventArgs e)
        {
            
            if (erkek.Checked == true)
                cinsiyett = "Erkek";
            else if (bayan.Checked == true)
                cinsiyett = "Bayan";
          

            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=veritabani.accdb");
            cmd = new OleDbCommand();
            con.Open(); 
            cmd.Connection = con;
            cmd.CommandText = "insert into Uyeler (uye_tc,uye_adi,uye_soyadi,uye_cinsiyet,uye_yas,uye_sifre,uye_mail) values ('" + tcnoYeniUyetextBox.Text + "','" + adYeniUyetextBox.Text + "','" + soyadYeniUyetextBox.Text +"','" + cinsiyett + "','" + yasYeniUyetextBox.Text + "','" + parolaYeniUyetextBox.Text + "','"+ mailtext.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Üye Kaydı Yapıldı ");

        }

        private void geri_Click(object sender, EventArgs e)
        {
            girisForm geri = new girisForm();
            geri.Show();
            this.Hide();
        }

    
    }
}

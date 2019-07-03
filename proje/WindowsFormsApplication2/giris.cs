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
    public partial class girisForm : Form
    {
      
        public girisForm()
        {
            InitializeComponent();
        }

        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        private void tcnoGiristextBox_TextChanged(object sender, EventArgs e)
        {

        }
        public static string uye_tc;
        private void giris_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=veritabani.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Uyeler where uye_tc='" + tcnoGiristextBox.Text + "' AND uye_sifre='" + sifreGiristextBox.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                randevuForm randevu = new randevuForm();
                randevu.Show();
                this.Hide();
                uye_tc = tcnoGiristextBox.Text;
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ya da Şifre Yanlış");
            }

            con.Close();


        }

        private void sifreUnut_Click(object sender, EventArgs e)
        {
            sifreDegisForm sifredegis = new sifreDegisForm();
            sifredegis.Show();
            this.Hide();
        }

        private void yeniUye_Click(object sender, EventArgs e)
        {
           
            yeniUyeForm yeniuye = new yeniUyeForm();
            yeniuye.Show();
            this.Hide();
        }

        private void girisForm_Load(object sender, EventArgs e)
        {

        }

        private void sifreGiristextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void sifreGiristextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                giris_Click(sender, new EventArgs { });
            }
        }

    }
}

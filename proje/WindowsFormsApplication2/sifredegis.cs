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
    public partial class sifreDegisForm : Form
    {
        public sifreDegisForm()
        {
            InitializeComponent();
        }
       
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=veritabani.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter dr = new OleDbDataAdapter();

        private void geri_Click(object sender, EventArgs e)
        {
            girisForm geri = new girisForm();
            geri.Show();
            this.Hide();
        }

        private void kaydetSifre_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update Uyeler set uye_sifre='" + textBox3.Text + "' where uye_tc='"+textBox1.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void sifreDegisForm_Load(object sender, EventArgs e)
        {
            
        }

       
         
    }
}

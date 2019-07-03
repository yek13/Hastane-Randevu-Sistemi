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
    public partial class randevuGoruntuleForm : Form
    {
        public randevuGoruntuleForm()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=veritabani.accdb");
        DataTable tablo = new DataTable();
        OleDbCommand cmd= new OleDbCommand();
        OleDbDataAdapter dr = new OleDbDataAdapter();
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
         
        private void randevuGoruntuleForm_Load(object sender, EventArgs e)
        {
          
        } 
        private void randevuSil_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show("Silmek istediğinizden emin misiniz?","Uyarı!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (c == DialogResult.Yes)
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "delete from listele where randevusaat='" + dataGridView1.CurrentRow.Cells[5].Value.ToString() + "'";
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
              
        private void geri_Click_1(object sender, EventArgs e)
        {
            randevu2Form geri = new randevu2Form();
            geri.Show();
            this.Hide();
        }

        private void göster_Click(object sender, EventArgs e)
        {
            tablo.Clear();

            con.Open();
            if (girisForm.uye_tc == textBox1.Text)
            {
                OleDbDataAdapter dr= new OleDbDataAdapter("select * From listele Where uye_tc='" + textBox1.Text + "'", con);
                dr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                dr.Dispose();
            }
            
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      
    }
}

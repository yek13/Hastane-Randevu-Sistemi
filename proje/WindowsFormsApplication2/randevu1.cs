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
    public partial class randevuForm : Form
    {
        public static string secilenDoktorVerisi;
        public randevuForm()
        {
            InitializeComponent();
            secilenDoktorVerisi = null;
        }

        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        
        protected override void OnLoad(EventArgs e)
        {
           
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=veritabani.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select klinik_adi from klinik";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string gelenKlinik = dr["klinik_adi"].ToString();
                if (!klinikcombox.Items.Contains(gelenKlinik))
                {
                    klinikcombox.Items.Add(gelenKlinik);
                }
            }
            con.Close();
        }
        public static string klinik_adi;
        public static string doktor_adi_soyadi;
        private void randevual_Click(object sender, EventArgs e)
        {
            klinik_adi = klinikcombox.Text;
            doktor_adi_soyadi = doktorcomBox.Text;
            randevu2Form randevual = new randevu2Form();
            randevual.Show();
            this.Hide();
        }

    

        private void randevuForm_Load(object sender, EventArgs e)
        {

        }

        private void klnikcombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (klinikcombox.SelectedIndex!=-1)
            {
                doktorcomBox.Items.Clear();
                con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=veritabani.accdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select * from klinik where klinik_adi=@k_adi";
                cmd.Parameters.AddWithValue("@k_adi", klinikcombox.SelectedItem.ToString());
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    
                    string gelenDoktorAdi = string.Format("{0}-[{1}]", dr["doktor_adi_soyadi"].ToString(),dr["doktor_id"].ToString());
                    if (!doktorcomBox.Items.Contains(gelenDoktorAdi))
                    {
                        doktorcomBox.Items.Add(gelenDoktorAdi);
                    }
                }
                con.Close();
            }
        }

        private void geri_Click(object sender, EventArgs e)
        {
           girisForm geri = new girisForm();
            geri.Show();
            this.Hide();
        }

        private void doktorcomBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (doktorcomBox.SelectedIndex!=-1)
            {
                secilenDoktorVerisi = doktorcomBox.SelectedItem.ToString();
            }
        }

        private void doktor_Click(object sender, EventArgs e)
        {

        }
    }
}

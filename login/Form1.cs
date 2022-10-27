using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace login
{
    //Data Source=LAPTOP-KPNR185M\SQLEXPRESS;Initial Catalog=Ornek;Integrated Security=True
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rdr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
           SqlConnection  conn = new SqlConnection("Data Source=LAPTOP-KPNR185M\\SQLEXPRESS;Initial Catalog=Ornek;Integrated Security=True");
            //cmd = new SqlCommand();
            conn.Open();
            //SqlConnection cmd.Connection = conn;
            //cmd.CommandText = ("Select * From Kullanici_Bilgi where kullanici_adi='" + textBox1.Text +
               // "'And sifre='" + textBox2.Text + "'",conn);
               SqlCommand komut =new SqlCommand("Select * From Kullanici_Bilgi where kullanici_adi='" + textBox1.Text + "'And sifre='" + textBox2.Text + "'",conn);
           SqlDataReader rdr = komut.ExecuteReader();
            if(rdr.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı Giriş Yapıldı");
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

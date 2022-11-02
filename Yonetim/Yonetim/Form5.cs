using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Yonetim
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
         SqlConnection baglanti =
           new SqlConnection(@"Data Source=MERT\MERTSERVER;Initial Catalog=apartman;Integrated Security=True");

        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From kisibilgi", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Ad"].ToString();
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Borclar"].ToString());
                

                listView1.Items.Add(ekle);
            }
            baglanti.Close();

        }
            private void Form5_Load(object sender, EventArgs e)
        {
            verilerigoster();
        }
    }
}

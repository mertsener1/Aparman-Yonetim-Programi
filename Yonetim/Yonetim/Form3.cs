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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=MERT\MERTSERVER;Initial Catalog=apartman;Integrated Security=True");

        private void verilerigoster()
        {
            if (baglanti.State != ConnectionState.Open)
            {
                baglanti.Open();
            }

            verileritemizle();
            SqlCommand komut = new SqlCommand("Select * from kisibilgi", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Daire"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Borclar"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox1.Focus();
        }

        private void verileritemizle()
        {
            listView1.Items.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form3_DoubleClick(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kisibilgi(Ad,Soyad,Daire,Telefon,Borclar)values ('" + textBox1.Text.ToString() + "', '" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            verilerigoster();
        }
        int id = 0;
        private void button3_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From kisibilgi where id=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 | textBox2.TextLength == 0 | textBox3.TextLength == 0
                | textBox4.TextLength == 0 | textBox5.TextLength == 0)
            {
                MessageBox.Show("Bilgiler Boş Geçilemez !");

            }

            else
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                SqlCommand komut = new SqlCommand("update kisibilgi set Ad='" + textBox1.Text.ToString() + "',Soyad='" + textBox2.Text.ToString() + "',Daire='" + textBox3.Text.ToString() + "',Telefon='" + textBox4.Text.ToString() + "',Borclar='" + textBox5.Text.ToString() + "'where id  =" + id + "", baglanti);
                komut.ExecuteNonQuery();
            }


            temizle();
            verilerigoster();
            baglanti.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            temizle();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (baglanti.State != ConnectionState.Open)
            {
                baglanti.Open();
            }

            SqlCommand komut = new SqlCommand("Select * from kisibilgi where Ad like '%" + textBox6.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Daire"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Borclar"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick_1(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[5].Text;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
        }
    }
}
//Data Source=MERT\MERTSERVER;Initial Catalog=apartman;Integrated Security=True
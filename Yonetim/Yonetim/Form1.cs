﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Yonetim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtKullaniciAdi.Text == "Yönetici" && TxtSifre.Text == "1234")
            {
                Form2 fr = new Form2();
                fr.Show();
                this.Hide();
                

            }
            else MessageBox.Show("Şifre yanlış");

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlConnection con = new SqlConnection(@"Data Source=MERT\MERTSERVER;Initial Catalog=apartman;Integrated Security=True"); // making connection   
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM kullanicibilgileri WHERE username='" + TxtKullaniciAdi.Text + "' AND password='" + TxtSifre.Text + "'", con);
                /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
                DataTable dt = new DataTable(); //this is creating a virtual table  
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                    this.Hide();
                    new Form2().Show();
                }
                else
                    MessageBox.Show("ŞİFRE YANLIŞ!");

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
//Data Source=MERT\MERTSERVER;Initial Catalog=apartman;Integrated Security=True

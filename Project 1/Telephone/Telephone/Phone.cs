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
using MySql.Data.MySqlClient;


namespace Telephone
{
    public partial class Phone : Form
    {

        public Phone()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Phone_Load(object sender, EventArgs e)
        {
           // this.ActiveControl = textBox2;   this for forcus tab
            //textBox2.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Text = "";
            textBox4.Clear();
            comboBox1.SelectedIndex = 0;
            textBox3.Focus();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBConnection();
        }
        private void DBConnection()
        {
            String ConnectString = "datasource = localhost; port=3306; username = root; password=; databasename=phone";
            MySqlConnection DBConnect = new MySqlConnection(ConnectString);
            try
            {
                DBConnect.Open();
                MessageBox.Show("Ok You Are Connected");

            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}

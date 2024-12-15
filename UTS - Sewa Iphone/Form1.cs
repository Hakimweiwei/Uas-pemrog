using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace UTS___Sewa_Iphone
{
    public partial class Form1Login : Form
    {
        Form2 form2 = new Form2();
        public Form1Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }
        //coba push
        private void ExitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            // Koneksi ke database
            string mySqlConn = "server=127.0.0.1; database=sewa_iphone; user=root; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mySqlConn);

            try
            {
                MessageBox.Show("Koneksi database berhasil");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi as kesalahan: {ex.Message}");
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

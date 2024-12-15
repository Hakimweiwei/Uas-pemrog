using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace UTS___Sewa_Iphone
{
    public partial class Form2 : Form
    {
        Form3 form3 = new Form3();
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSewa16_Click(object sender, EventArgs e)
        {
            this.Hide();
            form3.ShowDialog();
            this.Close();
        }
    }
}

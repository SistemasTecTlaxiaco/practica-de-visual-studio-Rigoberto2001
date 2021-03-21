using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void iniciarsesion_Click(object sender, EventArgs e)
        {
            Form form1 = new Form2();
            form1.Show();
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            Form form2 = new Form3();
            form2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form fac2 = new Form4();
            fac2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form google2 = new Form5();
            google2.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace APP2
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form netflix = new Form9();
            netflix.Show();
        }

        private void personalizada_Click(object sender, EventArgs e)
        {
            Form personalizad1 = new Form23();
            personalizad1.Show();
        }
    }
}

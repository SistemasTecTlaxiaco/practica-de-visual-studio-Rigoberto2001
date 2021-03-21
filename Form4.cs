using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace APP2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void iniciarsesionfacebook_Click(object sender, EventArgs e)
        {
            Form facebook = new Form2();
            facebook.Show();
        }
    }
}

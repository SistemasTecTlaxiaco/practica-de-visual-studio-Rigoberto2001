using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace APP2
{
    public partial class Form41 : Form
    {
        public Form41()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form añadir2 = new Form42();
            añadir2.Show();
        }
    }
}

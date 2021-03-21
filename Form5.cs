using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace APP2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void iniciarsesiogoogle_Click(object sender, EventArgs e)
        {
            Form google = new Form2();
            google.Show();
        }
    }
}

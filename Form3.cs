using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace APP2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        
        private void button7_Click(object sender, EventArgs e)
        {
            Form v2 = new Form6();
            v2.Show();
        }
    }
}

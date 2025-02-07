using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox2.Text == "123")
            {
                MessageBox.Show("Welcome", "Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invallid", "Title", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         
            if (textBox1.Text == "Admin" && textBox2.Text == "123")
            {
                MessageBox.Show("Welcome", "Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invallid", "Title", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }
    }
}


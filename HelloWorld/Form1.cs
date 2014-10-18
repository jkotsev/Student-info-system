using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         button1.BackColor = Color.Red;
         }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 2)
            {
                MessageBox.Show("Здрасти, " + txtName.Text + "!!!\n Това е твоята първа програма на Visual Studio 2012!");
            }

            else
            {
                MessageBox.Show("Името трябва да е повече от два символа!");
            }
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHello_Click(object sender, EventArgs e)
        {

        }
    }
}

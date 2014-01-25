using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Hello Wei!")
            {
                label1.Text = "Hello 481!";
            }
            else
            {
                label1.Text = "Hello Wei!";
            }
            
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                this.BackColor = System.Drawing.Color.White;
                this.label1.ForeColor = System.Drawing.Color.Black;
                this.button1.BackColor = System.Drawing.Color.Black;
                this.button1.ForeColor = System.Drawing.Color.White;
                this.groupBox1.ForeColor = System.Drawing.Color.Black;
            }

            if (radioButton2.Checked)
            {
                this.BackColor = System.Drawing.Color.Black;
                this.label1.ForeColor = System.Drawing.Color.White;
                this.button1.BackColor = System.Drawing.Color.White;
                this.button1.ForeColor = System.Drawing.Color.Black;
                this.groupBox1.ForeColor = System.Drawing.Color.White;
            }
        }

    }
}

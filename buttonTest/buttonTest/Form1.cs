using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttonTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            textBox_input.Text += textBox1.Text.ToString()+"\r\n";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox_copy.Text = textBox1.Text.ToString()+"\r\n";
        }
    }
}

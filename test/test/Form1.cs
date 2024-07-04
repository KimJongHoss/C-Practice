using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // MessageBox.Show("Hello world");

            //textBox1_print.Text = "이것은\r\n멀티라인\r\n입니다";

            //{ 
            //    int a = 10;
            //    textBox1_print.Text = a.ToString();
            //}

            //string s = "abcdef";
            //int c = s.IndexOf("b");
            //textBox1_print.Text = c.ToString();

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int x = 0;
            foreach (int number in numbers)
            {
                x += number;
            }

            textBox1_print.Text = x.ToString();


        }
    }
}

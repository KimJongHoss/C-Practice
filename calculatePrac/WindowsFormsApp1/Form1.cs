using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            //계산기 연습
            int calcul (int x, int y)
            {
                int a = x;
                int b = y;
                int result = a + b;
                return result;
            }



        }
    }
}

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

            calcul(12, "!", 6 );

            void calcul(Double x, String sign, Double y)
            {
                double result = 0;
                switch (sign)
                {
                    case ("+"):
                        result = x + y;
                        textBox1.Text += result.ToString() + "\r\n계산 완료";
                        break;
                    case ("-"):
                        result = x - y;
                        textBox1.Text += result.ToString() + "\r\n계산 완료";
                        break;
                    case ("*"):
                        result = x * y;
                        textBox1.Text += result.ToString()+ "\r\n계산 완료";
                        break;
                    case ("/"):
                        if (y == 0)
                        {
                            textBox1.Text = "0으로 나눌 수는 없습니다.";
                            break ;
                        }
                        result = x / y;
                        textBox1.Text += result.ToString() + "\r\n계산 완료";
                        break;
                    default:
                        MessageBox.Show("잘못된 계산식입니다.");
                        break;
                }
               
            }



        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practiceDataType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //int num = -100;
            //string name = "300";

            ////name = num;

            //name = num.ToString();
            //name = 400.ToString();

            ////num = name;

            //num = int.Parse(name);
            //num = int.Parse("200");
            //num = int.Parse("abc");

            //var name = "Jongho";
            //var num = 1000;
            //var one_char = 'A';
            //float flt = 5654316532133.687f;
            //var db = 6532132141865154165151555d;

            //jongho_box.Text += name.GetType();
            //jongho_box.Text += "\r\n";
            //jongho_box.Text += num.GetType();
            //jongho_box.Text += "\r\n";
            //jongho_box.Text += one_char.GetType();
            //jongho_box.Text += "\r\n";
            //jongho_box.Text += flt.GetType();
            //jongho_box.Text += "\r\n";
            //jongho_box.Text += db.GetType();

            //jongho_box.Text += "\r\n";

            //int ifResult = AddVoid(50,100);

            //jongho_box.Text += ifResult.ToString();

            //AddVoid(1,2);

            //identifyAnimal("Cat");

            //for (int i = 0; i<=10; i++)
            //{
            //    int x = i % 2;
            //    if (i%2 == 1)
            //    {
            //        jongho_box.Text += i.ToString();
            //        jongho_box.Text += "\r\n";
            //    }

            //}

            //int[] number = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //foreach (int num1 in number.Reverse())
            //{

            //    jongho_box.Text += num1.ToString();
            //    jongho_box.Text += "\r\n";

            //}

            //int count = 0;
            //while (true) 
            //{
            //    if (count == 0)
            //    {
            //        count++;
            //        jongho_box.Text += "Loop Start!!\r\n";
            //    }
            //    else if (count < 5)
            //    {
            //        jongho_box.Text += count.ToString();
            //        jongho_box.Text += "\r\n";
            //        count++;
            //    }
            //    else
            //    { 
            //        break;
            //    }
            //}

            //int count;
            //jongho_box.Text += "Loop Start!!\r\n";

            //for (count = 1; count < 5; count++)
            //{
            //    jongho_box.Text += count.ToString();
            //    jongho_box.Text += "\r\n";
            //}

            int count = 1;
            jongho_box.Text += "Loop Start!\r\n";
            while (count < 5)
            {
                jongho_box.Text += count.ToString();
                jongho_box.Text += "\r\n";
                count++;
            }

            jongho_box.Text += "Loop Start!\r\n";
            for (int count2 = 1; count2 < 5; count2++)
            {
                jongho_box.Text += count2.ToString();
                jongho_box.Text += "\r\n";
            }

            //int AddVoid(int x, int y)
            //{
            //    int a = x;
            //    int b = y;
            //    int result = a + b;

            //    if (result <= 0)
            //    {
            //        return -1;
            //    }
            //    else if (result <= 100)
            //    {
            //        return 1;
            //    }
            //    else if (result<=200)
            //    {
            //        return 2; 
            //    }else
            //    {
            //        return 0;
            //    }


            //jongho_box.Text = result.ToString();
        }

        //public void identifyAnimal(String animal)
        //{
        //    switch (animal)
        //    {
        //        case "Dog":
        //            jongho_box.Text = $"This is a {animal}";
        //            break;
        //        case "Bird":
        //            jongho_box.Text = "This is a " + animal;
        //            break;
        //        case "Cat":
        //            jongho_box.Text = "This is a cat";
        //            break;
        //        default:
        //            jongho_box.Text = "Unknown Animal!!!!";
        //            break;
        //    }
        //}
        
       

       

    }
}

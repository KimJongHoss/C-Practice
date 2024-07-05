﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace arrayTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //배열 연습해보기
            int[] array1 = new int[5]; //빈 값으로 초기화
            int[] array2 = { 1, 2, 3, 4, 5, 6 }; //초기화 하면서 할당까지 하기 -> new는 생략되어있음 
            int[,] multiDimensionalArray1 = new int[2, 3];
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[][] jaggedArray = new int[6][];
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };

            //[실습] array2를 for루프써서 돌아가면서 1~6까지 출력
            //for (int i = 0; i<6; i++)
            //{
            //    int a = array2[i];
            //    textBox1.Text += a.ToString();
            //    textBox1.Text += "\r\n";
            //}

            //[실습] array2를 for루프써서 돌아가면서 6~1까지 출력
            //for (int i = 5; i >= 0; i--)
            //{
            //    int a = array2[i];
            //    textBox1.Text += a.ToString();
            //    textBox1.Text += "\r\n";
            //}
            //length 사용하는 것이 좋음

            //2중 for문
            //[실습] multiDimensionalArray2 를 for 루프 써서 돌아가면서 1~6까지 출력
            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    int x = multiDimensionalArray2[i, j];
                    textBox2.Text += x.ToString();
                    textBox2.Text += "\r\n";
                }
            }

            //2차원은 GetLength(0)은 행의 개수, Getlength(1)은 열의 개수를 알 수 있습니다.
            //GetLength(0)은 0차원을 의미한다 GetLength(1)은 1차원을 의미한다
            for (int i = 0; i < multiDimensionalArray2.GetLength(0); i++)
            {

                for (int j = 0; j < multiDimensionalArray2.GetLength(1); j++)
                {
                    int x = multiDimensionalArray2[i, j];
                    textBox2.Text += x.ToString();
                    textBox2.Text += "\r\n";
                }
            }

        }

       
    }
}
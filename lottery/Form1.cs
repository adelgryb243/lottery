using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lottery
{
    public partial class Form1 : Form
    {
        int num1;
        int num2;
        int num3;
        int num4;
        int num5;
        int num6;
        public const int MAX = 60;//max value that can be on ticket
        Random numberMaker = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void lotteryButton_Click(object sender, EventArgs e)
        {
            num1 = numberMaker.Next(1, MAX);
            num2 = numberMaker.Next(1, MAX);
            while (num2 == num1)
            {
                num2 = numberMaker.Next(1, MAX);
            }
            while (num3 == num2)//
            {
                num3 = numberMaker.Next(1, MAX);
            }
            while (num4 == num3)
            {
                num4 = numberMaker.Next(1, MAX);
            }
            while (num5 == num4)//
            {
                num5 = numberMaker.Next(1, MAX);
            }
            while (num6 == num5)
            {
                num6 = numberMaker.Next(1, MAX);
            }
            outputLabel.Text = "your numbers are: " + num1 +" "+ num2 + " " + num3 + " " + num4 + " " + num5 + " " + num6;
        }
    }
}

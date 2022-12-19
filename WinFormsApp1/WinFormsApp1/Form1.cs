using System.Collections.Specialized;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string number1 = "";
        string number2 = "";
        string sum = "";
        int count = 1;
        int op = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case 0:
                    label1.Text = (int.Parse(number1) + int.Parse(number2)).ToString();
                    sum = (int.Parse(number1) + int.Parse(number2)).ToString();
                    count = 3;
                    break;
                case 1:
                    label1.Text = (int.Parse(number1) - int.Parse(number2)).ToString();
                    sum = (int.Parse(number1) + int.Parse(number2)).ToString();
                    count = 3;
                    break;
                case 2:
                    label1.Text = (int.Parse(number1) * int.Parse(number2)).ToString();
                    sum = (int.Parse(number1) + int.Parse(number2)).ToString();
                    count = 3;
                    break;
                case 3:
                    label1.Text = (int.Parse(number1) / int.Parse(number2)).ToString();
                    sum = (int.Parse(number1) + int.Parse(number2)).ToString();
                    count = 3;
                    break;
            }
        }
        private void excute(Button btn)
        {
            if (count == 3)
            {
                count = 1;
                label1.Text = "";
                number1 = "";
                number2 = "";
                if (count == 1)
                {
                    number1 += btn.Text;
                    label1.Text += btn.Text;
                }
                else if (count == 2)
                {
                    number2 += btn.Text;
                    label1.Text += btn.Text;
                }
            }
            else
            {
                if (count == 1)
                {
                    number1 += btn.Text;
                    label1.Text += btn.Text;
                }
                else if (count == 2)
                {
                    number2 += btn.Text;
                    label1.Text += btn.Text;
                }
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            excute(btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            excute(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            excute(btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            excute(btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            excute(btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            excute(btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            excute(btn7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            excute(btn8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            excute(btn9);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            excute(btn0);
        }

        private void add_Click(object sender, EventArgs e)
        {
            op = 0;
            count = 2;
            label1.Text += "+";
        }

        private void rem_Click(object sender, EventArgs e)
        {
            op = 1;
            count = 2;
            label1.Text += "-";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            op = 2;
            count = 2;
            label1.Text += "x";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            op = 3;
            count = 2;
            label1.Text += "/";
        }
    }
}
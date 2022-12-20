namespace Calculator
{
    public partial class Calculator : Form
    {
        string numbercache = "";
        List<string> numbers = new List<string>();
        List<string> operators = new List<string>();
        public Calculator()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Addnumbercache(btn1);
            UpdateDisplay1(numbercache);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Addnumbercache(btn2);
            UpdateDisplay1(numbercache);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Addnumbercache(btn3);
            UpdateDisplay1(numbercache);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Addnumbercache(btn4);
            UpdateDisplay1(numbercache);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Addnumbercache(btn5);
            UpdateDisplay1(numbercache);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Addnumbercache(btn6);
            UpdateDisplay1(numbercache);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Addnumbercache(btn7);
            UpdateDisplay1(numbercache);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Addnumbercache(btn8);
            UpdateDisplay1(numbercache);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Addnumbercache(btn9);
            UpdateDisplay1(numbercache);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Addnumbercache(btn0);
            UpdateDisplay1(numbercache);
        }
        
        private void add_Click(object sender, EventArgs e)
        {
            operators.Add("+");
            numbers.Add(numbercache);
            Display2.Text += string.Format("{0}{1}", numbercache, "+");
            Clearnumbercache();
        }

        private void rem_Click(object sender, EventArgs e)
        {
            operators.Add("-");
            numbers.Add(numbercache);
            Display2.Text += string.Format("{0}{1}", numbercache, "-");
            Clearnumbercache();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            operators.Add("*");
            numbers.Add(numbercache);
            Display2.Text += string.Format("{0}{1}", numbercache, "*");
            Clearnumbercache();
        }

        private void devide_Click(object sender, EventArgs e)
        {
            operators.Add("/");
            numbers.Add(numbercache);
            Display2.Text += string.Format("{0}{1}", numbercache, "/");
            Clearnumbercache();
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            Addnumbercache(btndot);
            UpdateDisplay1(numbercache);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            numbers.Add(numbercache);
            double sum = 0;
            foreach(string value in numbers)
            {
                foreach(string op in operators)
                {
                    switch(op)
                    {
                        case "+":
                            sum = sum + Convert.ToDouble(value);
                            break;
                    }
                }
            }
            Display1.Text = sum.ToString();
        }

        private void Addnumbercache(Button btn)
        {
            numbercache += btn.Text;
        }
        private void Clearnumbercache()
        {
            numbercache = "";
        }
        private void UpdateDisplay1(string value)
        {
            Display1.Text = value;
        }
    }
}
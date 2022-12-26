using System.Configuration;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private TextBox Display() => this.Display1;
        private const string DisplayText = "0";
        private bool CheckStage = false;
        private double sum = 0;
        private string Op = "+";
        public Calculator()
        {
            InitializeComponent();
            Display().Text = DisplayText;
        }

        private void btnNumberController(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == ".")
            {
                Dot();
            }
            else
            {
                Number(((Button)sender).Text);
            }
        }

        public void Dot()
        {
            if (CheckStage)
            {
                CheckStage = false;
                Display().Text = DisplayText;
            }
            if (Display().Text.Contains("."))
            {
                return;
            }
            else
            {
                Display().AppendText(".");
            }
        }

        public void Number(string num)
        {
            if (CheckStage)
            {
                CheckStage = false;
                Display().Text = DisplayText;
            }
            Display().AppendText(num);
            if (Display().Text.Contains("."))
            {
                return;
            }
            else
            {
                Display().Text = Double.Parse(Display().Text).ToString("#,##0");
            }
        }

        public void Calculate(string op)
        {
            Display().Text.TrimEnd('.');
            Display2.AppendText($" {Display().Text} {op}");
            double operand = Double.Parse(Display().Text);
            CheckStage = true;
            if (Op == "/" && Display().Text == "0")
            {
                Display().Text = double.Parse(DisplayText).ToString("#,##0");
                return;
            }
            switch (Op)
            {
                case "+":
                    sum += operand;
                    break;
                case "-":
                    sum -= operand;
                    break;
                case "*":
                    sum *= operand;
                    break;
                case "/":
                    sum /= operand;
                    break;
                default:
                    break;
            }
            Op = op;
            Display().Text = sum.ToString("#,##0");
        }

        public void Clear()
        {
            sum = 0;
            Display2.Clear();
            Display().Text = DisplayText;
            CheckStage = false;
        }

        public void ClearCE()
        {
            Display().Text = double.Parse(DisplayText).ToString("#,##0");
            CheckStage = false;
        }
        private void ClearCE(object sender, EventArgs e)
        {
            ClearCE();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void OperationContoller(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case "+":
                    Calculate("+");
                    break;
                case "-":
                    Calculate("-");
                    break;
                case "*":
                    Calculate("*");
                    break;
                case "/":
                    Calculate("/");
                    break;
                case "=":
                    Calculate("+");
                    string result = Display().Text;
                    Clear();
                    CheckStage = true;
                    Display().Text = double.Parse(result).ToString("#,##0");
                    break;
                default:
                    break;
            }
        }
    }
}
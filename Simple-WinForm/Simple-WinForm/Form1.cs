namespace Simple_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // get value from textbox store in variable
            string value1 = textBox1.Text;
            string value2 = textBox2.Text;

            // show message box with value

            MessageBox.Show(value1 + " " + value2);
        }
    }
}
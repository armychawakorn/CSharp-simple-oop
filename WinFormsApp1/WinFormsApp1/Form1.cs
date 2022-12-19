namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = string.Format("คำตอบคือ: {0}", int.Parse(textBox1.Text) + int.Parse(textBox2.Text));
        }
    }
}
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string username = "Chawakorn";
        private string password = "1234";
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == username && textBox2.Text == password)
            {
                MessageBox.Show("Login Success", caption: "Login", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Login Failed", caption: "Login", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }
    }
}
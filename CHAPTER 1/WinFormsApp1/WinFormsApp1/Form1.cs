namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string fNameValue = firstname.Text;
            string lNameValue = lastname.Text;
            MessageBox.Show($" Hello World! {fNameValue} {lNameValue}", "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
    }
}

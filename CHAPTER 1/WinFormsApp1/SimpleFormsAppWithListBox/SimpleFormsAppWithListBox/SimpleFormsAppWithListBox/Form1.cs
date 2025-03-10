using System.Windows.Forms;

namespace SimpleFormsAppWithListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbox.Text) && !lstbox.Items.Contains(txtbox.Text))
            {

                lstbox.Items.Add(txtbox.Text);
            }
        }

        private void removebtn_Click(object sender, EventArgs e)
        {

        }

        private void removebtn_Click_1(object sender, EventArgs e)
        {
            lstbox.Items.Remove(lstbox.Text);
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            lstbox.Items.Clear();
        }
    }
}

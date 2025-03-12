using System.Windows.Forms;

namespace SimpleFormsAppWithCheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] movies = { "Breaking Bad", "Game of Thrones", "Stranger Things" ,"Batang Quiapo",};
            chcklistbox.Items.AddRange(movies);
            chcklistbox.CheckOnClick = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void add_Click(object sender, EventArgs e)
        {
            foreach (var item in chcklistbox.Items)
            {
                bool isSelected = chcklistbox.GetItemChecked(chcklistbox.Items.IndexOf(item));
                if (isSelected && !lstbox.Items.Contains(item))
                {
                    lstbox.Items.Add(item);
                }
            }
        }

        private void chcklistbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            if (lstbox.Items.Count >= 0)
            {
                lstbox.Items.Remove(lstbox.SelectedItem);
            }
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            if (lstbox.Items.Count == 0)
            {
                MessageBox.Show("The list is already empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lstbox.Items.Clear();
            }
        }
    }
}

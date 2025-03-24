namespace SimpleFavoriteCartoonFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            charcombobox.Items.Add("Spongebob");
            charcombobox.Items.Add("Patrick");
            charcombobox.Items.Add("Mr. Krabs");
            charcombobox.Items.Add("Sandy");
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            if (charcombobox.SelectedItem == null)
            {
                MessageBox.Show("Please select a character!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedCharacter = charcombobox.SelectedItem?.ToString() ?? "";
            Image? characterImage = null;


            using (MemoryStream ms = new MemoryStream())
            {
                switch (selectedCharacter)
                {
                    case "Spongebob":
                        ms.Write(Properties.Resources.spongebob, 0, Properties.Resources.spongebob.Length);
                        characterImage = Image.FromStream(ms);
                        break;
                    case "Patrick":
                        ms.Write(Properties.Resources.patrick, 0, Properties.Resources.patrick.Length);
                        characterImage = Image.FromStream(ms);
                        break;
                    case "Mr. Krabs":
                        ms.Write(Properties.Resources.mrkrabs, 0, Properties.Resources.mrkrabs.Length);
                        characterImage = Image.FromStream(ms);
                        break;
                    case "Sandy":
                        ms.Write(Properties.Resources.sandy, 0, Properties.Resources.sandy.Length);
                        characterImage = Image.FromStream(ms);
                        break;
                }
            }

            imgpicturebox.Image = characterImage;
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            imgpicturebox.Image = null;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}


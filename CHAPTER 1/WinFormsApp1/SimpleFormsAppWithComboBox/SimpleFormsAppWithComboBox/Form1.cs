using System.Windows.Forms;

namespace SimpleFormsAppWithComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            {
                string[] cuisineGenre = { "Filipino", "Chinese", "American", "Mexican" };
                cuisinecombobox.Items.AddRange(cuisineGenre);

                cuisinecombobox.DropDownStyle = ComboBoxStyle.DropDownList;
                cuisinecombobox.SelectedIndex = 0;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void selectbtn_Click(object sender, EventArgs e)
        {
            string[] filipinoCuisineList = { "Adobo", "Sinigang", "Lechon", "Pancit"};
            string[] chineseCuisinelist = { "Huaiyang", "Shandong", "Sichuan", "Cantonese" };
            string[] americanCuisineList = { " Fried Chicken", "Grilled Cheese", "Cheeseburger" , "Steak And Fries" };
            string[] mexicanCuisineList = { "tacos", "chimichangas", "pozole", "ceviche" };

            foodlstchckbox.Items.Clear();

            if (cuisinecombobox.SelectedItem != null && cuisinecombobox.SelectedItem.ToString()!.Contains("Filipino"))
            {
                foodlstchckbox.Items.AddRange(filipinoCuisineList);

            }
            else if (cuisinecombobox.SelectedItem != null && cuisinecombobox.SelectedItem.ToString()!.Contains("Chinese"))
            {
                foodlstchckbox.Items.AddRange(chineseCuisinelist);
            }
            else if (cuisinecombobox.SelectedItem != null && cuisinecombobox.SelectedItem.ToString()!.Contains("American"))
            {
                foodlstchckbox.Items.AddRange(americanCuisineList);

            }
            else if (cuisinecombobox.SelectedItem != null && cuisinecombobox.SelectedItem.ToString()!.Contains("Mexican"))
            {
                foodlstchckbox.Items.AddRange(mexicanCuisineList);
            }
        }




        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            if (foodlstbox.Items.Count >= 1 && foodlstbox.SelectedItem!=null)
            {
                foodlstbox.Items.Remove(foodlstbox.SelectedItem);
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            foreach (var item in foodlstchckbox.Items)
            {
                bool isSelected = foodlstchckbox.GetItemChecked(foodlstchckbox.Items.IndexOf(item));
                if (isSelected && !foodlstbox.Items.Contains(item))
                {
                    foodlstbox.Items.Add(item);
                }
            }
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            foodlstbox.Items.Clear();
        }

        private void cuisinecombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}

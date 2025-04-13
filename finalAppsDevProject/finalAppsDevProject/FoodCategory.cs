using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace finalAppsDevProject
{
    public partial class FoodCategory : Form
    {
        public string myProductName => product_nametxtbox.Text;
        public string UtilitiesCost => Uc_result.Text;
        public string TotalLaborCost => Tlc_txtbox.Text;
        public string LaborCostPerUnit => laborCostPerUnitTxt.Text;
        public string TotalRawMaterialCost => Totalrmc_txtbox.Text;
       

        public FoodCategory()
        {
            InitializeComponent();
        }

        private void back_picbox_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
      "Are you sure you want to go back? All inputs or progress will be lost.",
      "Confirm",
      MessageBoxButtons.YesNo,
      MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {

                Category categoryForm = new Category();
                categoryForm.Show();
                this.Close();
            }
        }
        private void InitializeDataGridView()
        {
            Rmc_Datagridview.ColumnCount = 4;
            Rmc_Datagridview.Columns[0].Name = "Ingredient Name";
            Rmc_Datagridview.Columns[1].Name = "Quantity Used";
            Rmc_Datagridview.Columns[2].Name = "Cost Per Unit";
            Rmc_Datagridview.Columns[3].Name = "Subtotal";

            Rmc_Datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        
        private void FoodCategory_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            string ingredient = Ing_txtbox.Text.Trim();
            string quantityText = Quantity_txtbox.Text.Trim();
            string costText = Cost_txtbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(ingredient) ||
                string.IsNullOrWhiteSpace(quantityText) ||
                string.IsNullOrWhiteSpace(costText))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Extract numeric part from quantity (e.g., "1.5kg" -> 1.5)
            string numericPart = new string(quantityText.TakeWhile(c => char.IsDigit(c) || c == '.' || c == ',').ToArray());

            if (!decimal.TryParse(numericPart, out decimal quantity) ||
                !decimal.TryParse(costText, out decimal cost))
            {
                MessageBox.Show("Please enter a valid quantity (e.g., '1kg') and numeric cost.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal subtotal = quantity * cost;


            string[] row = new string[]
            {
             ingredient,
             quantityText,
             cost.ToString("0.##"),
             subtotal.ToString("0.##")
            };

            Rmc_Datagridview.Rows.Add(row);

            Ing_txtbox.Clear();
            Quantity_txtbox.Clear();
            Cost_txtbox.Clear();
        }

        private void Quantity_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Totalrmc_btn_Click(object sender, EventArgs e)
        {
            decimal totalRMC = 0;

            foreach (DataGridViewRow row in Rmc_Datagridview.Rows)
            {
                if (row.IsNewRow) continue;

                decimal quantity = 0;
                decimal cost = 0;

                // Get values by column index
                decimal.TryParse(Convert.ToString(row.Cells[1].Value), out quantity); // Quantity column
                decimal.TryParse(Convert.ToString(row.Cells[2].Value), out cost);     // Cost column

                decimal subtotal = quantity * cost;
                row.Cells[3].Value = subtotal.ToString("0.##"); // Subtotal column

                totalRMC += subtotal;
            }

            Totalrmc_txtbox.Text = totalRMC.ToString("0.##");
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Util_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Util_Click(object sender, EventArgs e)
        {
            string expenseType = Expenses_txt.Text.Trim();
            string billText = Month_txt.Text.Trim();
            string percentText = Production_txt.Text.Trim();
            string unitsText = Pu_txt.Text.Trim();

            if (string.IsNullOrWhiteSpace(expenseType) ||
                string.IsNullOrWhiteSpace(billText) ||
                string.IsNullOrWhiteSpace(percentText) ||
                string.IsNullOrWhiteSpace(unitsText))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            percentText = percentText.Replace("%", "").Trim();

            if (!decimal.TryParse(billText, out decimal bill) ||
                !decimal.TryParse(percentText, out decimal percentUsed) ||
                !decimal.TryParse(unitsText, out decimal unitsProduced))
            {
                MessageBox.Show("Please enter valid numbers. For Production %, you can enter values like '25%'.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (unitsProduced == 0)
            {
                MessageBox.Show("Estimated Units Produced cannot be zero.", "Math Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal percentDecimal = percentUsed / 100;

            decimal UC = (bill * percentDecimal) / unitsProduced;

            string[] row = new string[]
            {
           expenseType,
           bill.ToString("0.##"),
           percentUsed.ToString("0.##") + "%",
           unitsProduced.ToString("0.##"),
           UC.ToString("0.####")
            };

            Util_DataGridView.Rows.Add(row);


            Expenses_txt.Clear();
            Month_txt.Clear();
            Production_txt.Clear();
            Pu_txt.Clear();
        }

        private void TotalUc_btn_Click(object sender, EventArgs e)
        {
            decimal totalUC = 0;

            foreach (DataGridViewRow row in Util_DataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                decimal uc = 0;
                decimal.TryParse(Convert.ToString(row.Cells[4].Value), out uc);
                totalUC += uc;
            }

            Uc_result.Text = totalUC.ToString("0.##");
        }

        private void label17_Click(object sender, EventArgs e)
        {
            FoodCategory2cs foodCategory2Form = new FoodCategory2cs(this);
            foodCategory2Form.Show();
            this.Hide();
        }

        private void Laborhrrate_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbr_addbtn_Click(object sender, EventArgs e)
        {
            string name = lbrname_txtbox.Text.Trim();
            if (!decimal.TryParse(Hrwork_txtbox.Text.Trim(), out decimal hoursWorked) ||
                !decimal.TryParse(Laborhrrate_txtbox.Text.Trim(), out decimal hourlyRate))
            {
                MessageBox.Show("Please enter valid numbers for hours worked and hourly rate.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter the laborer's name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal subtotal = hoursWorked * hourlyRate;

            lbr_datagridview.Rows.Add(name, hoursWorked, hourlyRate, subtotal.ToString("0.##"));

            lbrname_txtbox.Clear();
            Hrwork_txtbox.Clear();
            Laborhrrate_txtbox.Clear();
        }

        private void Uc_result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
